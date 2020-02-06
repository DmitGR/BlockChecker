using BlockChecker.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using URLchecker.Logic;

namespace BlockChecker
{
	public partial class MainForm : Form
	{
		string filePath, traceRouteDomain, providerName;
		int timeOut, totalLines, AvrgTime;
		bool canceled;

		public MainForm()
		{
			InitializeComponent();

			Logger.ShowLog += ConsoleWriteLine;
			Output.ShowResult += PrintResult;

			LoadFilters();
			timeOutInput.Value = 3;
			AvrgTime = 0;
			domainPingBox.Text = "ya.ru";
			providerName = ProviderNameBox.Text;
			canceled = false;

			SessionCotroller.Session = DateTime.Now.ToString("yyyyMMddHHmmss");
			SessionCotroller.newPath();
		}

		void Work()
		{
			Stopwatch sw_total = new Stopwatch();
			sw_total.Start();


			//	Parallel.For(0, reader.records.Count, i =>
			//	{
			//		if (!canceled)
			//		{
			//			reader.records[i].Status = Requester.Send(reader.records[i].GetURL(), timeOut);
			//
			//			Logger.Log(string.Format("HOST {0} is {1}", reader.records[i].GetURL(), reader.records[i].Status));
			//			Logger.Log(string.Format("[{0} of {1}] at [{2}] s", completed, reader.records.Count, sw_total.ElapsedMilliseconds / 1000));
			//
			//			completed++;
			//			ProgressBarChanged(reader.records.Count);
			//		}
			//
			//	});


			int completed = 0;
			int counter = 0;
			try
			{
				Logger.Log("\n******Begin Reading********\n");
				totalLines = File.ReadAllLines(filePath).Length;

				Logger.Log(string.Format("File: " + filePath));
				Logger.Log(string.Format("Total Lines: " + totalLines));
				//	SessionCotroller.Write(filePath));
				//	SessionCotroller.Write("Total Lines: " + totalLines);
				//	SessionCotroller.Write(new string('-',50));


				ProgressBarMax(totalLines);
				Record record;

				Output.Write(string.Format("MachineName: {0} ProviderName: {1} Total {2} URL's\n",
					Environment.MachineName, providerName, totalLines));
				Output.Write(new string('=', 100));

				using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.Default))
				{
					string line;
					string[] temp;



					for (completed = SessionCotroller.LastRecord; completed < totalLines; completed++)
					{
						line = sr.ReadLine();

						if (canceled)
							break;

						//if (completed > SessionCotroller.LastRecord)
						//{ 
						temp = line.Split('\t');

						record = new Record(long.Parse(temp[0]), temp[1], temp[2], temp[3], temp[4]);

						//records.Add(new Record(temp[0], temp[1], temp[2]));
						//records.Add(new Record(long.Parse(temp[0]), temp[1], temp[2], temp[3], temp[4]));
						Logger.Log(string.Format("#{0} URL: {1} DOMAIN: {2} IP: {3}", temp[0], temp[4], temp[3], temp[2]));
						record.Status = Requester.Send(record.GetURL(), timeOut);

						Logger.Log(string.Format("HOST {0} is {1}", record.GetURL(), record.Status));



						if (record.Status == Status.Available)
						{
							Output.Write(record.ToString());
							counter++;
						}

						completed++;
						SessionCotroller.Write(completed.ToString(), filePath);
						Logger.Log(string.Format("[{0} of {1}] at [{2}] s", completed, totalLines, sw_total.Elapsed.Seconds));
						ProgressBarChanged(completed);
						double calc = sw_total.Elapsed.TotalSeconds / completed * totalLines;
						UpdateTimer(calc - sw_total.Elapsed.TotalSeconds);
					}

					//}

					Output.Write((string.Format("[{0} of {1}] Avaible", counter, totalLines)));
					Output.Write(new string('=', 100));

					if(completed == totalLines)
						SessionCotroller.Write(new string('-', 100), filePath, true);


				}
			}
			catch (Exception ex)
			{
				Logger.Log(ex.Message);
			}
			//-------------вывод результата таймера----------------------------------------------------------------------//
			sw_total.Stop();
			Logger.Log(string.Format("Checked [{0}] URL's at [{1}] ms", completed, sw_total.ElapsedMilliseconds));



			//sw_total.Stop();

			Console.WriteLine("Total Time: [{0} s]", sw_total.ElapsedMilliseconds / 1000);
			Logger.Log(string.Format("Total Time: [{0} s]", sw_total.ElapsedMilliseconds / 1000));

			//foreach (var item in reader.records)
			//{
			//	Logger.Log(item.ToString());
			//}


		//	Output.InTXT(reader.records, providerName);
		//	PrintResult(reader.records);

			//Logger.WriteLogs();
		}



		private void buttonStart_Click(object sender, EventArgs e)
		{
			if (filePath == "" || filePath == null)
			{
				richTextBox.AppendText(new string('-', 50));
				richTextBox.AppendText("\nФайл не выбран\n");
				richTextBox.AppendText(new string('-', 50));

			}
			else
			{

				progressBar.Value = progressBar.Minimum;
				resultBox.Clear();
				canceled = false;

				Output.Write("File: " + filePath);				

				ThreadPool.QueueUserWorkItem(_ =>
				{
					DoTraceRoute();
					Requester.LoadDomains();
					Requester.LoadStubs();

					ThreadPool.QueueUserWorkItem(__ =>
					{
						Work();
					});
				});
			}

		}



		private void buttonStop_Click(object sender, EventArgs e)
		{

			canceled = true;
			Logger.Log(new string('-', 100));
			Logger.Log("Forced Stop");
			Logger.Log(new string('-', 100));

		}

		private void UpdateTimer(double time)
		{
			var s = time / 3600;
			var h = Math.Truncate(s);
			s -= h;
			s *= 60;
			var m = Math.Truncate(s);
			s -= m;
			s *= 60;
			s = Math.Truncate(s);
			Action action = () =>
			{
				//AvrgTime = time;
				//	timer.Text = string.Format("{0}:{1}:{2} ",Math.Round(time/360000), Math.Round(time / 60000), Math.Round(time / 1000));
				timer.Text = string.Format("{0}:{1}:{2}",h,m,s);

			};

			if (InvokeRequired)
				Invoke(action);
			else
				action();
		}


		private void DoTraceRoute()
		{
			Logger.Log(new string('-', 100));
			Logger.Log("TraceRoute to " + traceRouteDomain);
			Logger.Log(new string('-', 100));

			Output.Write(new string('-', 100));
			Output.Write("TraceRoute to " + traceRouteDomain);
			Output.Write(new string('-', 100));



			var temp = TraceRoute.GetTraceRoute(traceRouteDomain);
			foreach (var item in temp.ToArray())
			{
				Logger.Log(item.ToString());
				Output.Write(item.ToString());
			}
			Logger.Log(new string('-', 100));
			Output.Write(new string('-', 100));
		}


		private void LoadFilters()
		{

			var temp = FilterIO.Read(Requester.DomainsFile);
			domainsBox.Clear();
			stubsBox.Clear();
			foreach (var item in temp)
			{
				if (temp.IndexOf(item) != temp.Count - 1)
					domainsBox.AppendText(item + "\n");
				else
					domainsBox.AppendText(item);
			}

			temp = FilterIO.Read(Requester.StabsFile);
			foreach (var item in temp)
			{
				if (temp.IndexOf(item) != temp.Count - 1)
					stubsBox.AppendText(item + "\n");
				else
					stubsBox.AppendText(item);
			}
		}
		private void ProgressBarChanged(int value)
		{

			Action action = () =>
			{
				progressBar.Value++;
				progressBar.Value = value;
			};
			if (InvokeRequired)
				Invoke(action);
			else
				action();
		}
		private void ProgressBarMax(int value)
		{

			Action action = () =>
			{
				progressBar.Maximum = value;
			};
			if (InvokeRequired)
				Invoke(action);
			else
				action();
		}

		private void PrintResult(string text)
		{
			Action action = () =>
			{
				resultBox.AppendText(text + "\n");
			};

			if (InvokeRequired)

				Invoke(action);
			else
				action();

		}

		private void ConsoleWriteLine(string text)
		{
			Action action = () =>
			{
				richTextBox.AppendText(text + "\n");
			};

			if (InvokeRequired)
				Invoke(action);
			else
				action();
		}

		private void buttonChooseFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				filePath = ofd.FileName;
				filePathLabel.Text = filePath;
			}
		}
		private void richTextBox_TextChanged(object sender, EventArgs e)
		{
			if (AutoScrollBox.Checked)
			{
				// set the current caret position to the end
				richTextBox.SelectionStart = richTextBox.Text.Length;
				// scroll it automatically
				richTextBox.ScrollToCaret();
			}
		}
		private void ProviderNameBox_TextChanged(object sender, EventArgs e)
		{
			providerName = ProviderNameBox.Text;
		}
		private void domainPingBox_TextChanged(object sender, EventArgs e)
		{
			traceRouteDomain = domainPingBox.Text;
		}
		private void richTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}
		private void timeOutInput_ValueChanged(object sender, EventArgs e)
		{
			timeOut = (int)timeOutInput.Value * 100;
		}

		private void sessionCheck_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				SessionCotroller.Path = ofd.FileName;
				SessionCotroller.ReadToLast();
				sessionLabel.Text = SessionCotroller.Session+" "+SessionCotroller.LastRecord;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

		}

		private void domainsFilterSave_Click(object sender, EventArgs e)
		{
			FilterIO.Write(domainsBox.Lines, Requester.DomainsFile);

			LoadFilters();
		}
		private void stubsFilterSave_Click(object sender, EventArgs e)
		{
			FilterIO.Write(stubsBox.Lines, Requester.StabsFile);

			LoadFilters();

		}
		private void addStubButton_Click(object sender, EventArgs e)
		{
			string result = Microsoft.VisualBasic.Interaction.InputBox("Введите текст:");
			stubsBox.AppendText(result);
		}

	}
}