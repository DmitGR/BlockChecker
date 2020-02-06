using BlockChecker.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
		string filePath, traceRouteDomain;
		int timeOut;
		bool canceled;

		public MainForm()
		{
			InitializeComponent();

			Logger.ShowLog += ConsoleWriteLine;

			LoadFilters();
			timeOutInput.Value = 3;
			domainPingBox.Text = "ya.ru";

			canceled = false;
		}

		void Work()
		{

			List<string> OUT = new List<string>();

			RecordsReader reader = new RecordsReader(filePath);

			Stopwatch sw_total = new Stopwatch();
			sw_total.Start();

			int completed = 1;

			Parallel.For(0, reader.records.Count, i =>
			{
				if (!canceled)
				{
					reader.records[i].Status = Requester.Send(reader.records[i].GetURL(), timeOut);

					Logger.Log(string.Format("HOST {0} is {1}", reader.records[i].GetURL(), reader.records[i].Status));
					Logger.Log(string.Format("[{0} of {1}] at [{2}] s", completed, reader.records.Count, sw_total.ElapsedMilliseconds / 1000));

					completed++;
					ProgressBarChanged(reader.records.Count);
				}

			});


			sw_total.Stop();

			Console.WriteLine("Total Time: [{0} s]", sw_total.ElapsedMilliseconds / 1000);
			Logger.Log(string.Format("Total Time: [{0} s]", sw_total.ElapsedMilliseconds / 1000));

			//foreach (var item in reader.records)
			//{
			//	Logger.Log(item.ToString());
			//}


			Output.InTXT(reader.records);
			PrintResult(reader.records);

			Logger.WriteLogs();
		}

		private void PrintResult(List<Record> res)
		{
			Action action = () =>
			{
				resultBox.Clear();
				resultBox.AppendText(string.Format("MachineName: {0} HostName: {1} Total {2} URL's\n",
					Environment.MachineName, System.Net.Dns.GetHostName(),res.Count));
				resultBox.AppendText(new string('=', 100));
				resultBox.AppendText("\n");
				int counter = 0;
				foreach (var item in res)
				{
					if (item.Status == Status.Available)
					{
						resultBox.AppendText(item.ToString() + "\n");
						counter++;
					}
				}
				resultBox.AppendText(string.Format("\n{0} URL's are available \n",counter));
				resultBox.AppendText(new string('=', 100));

				tabControl.SelectedIndex = tabControl.TabPages.IndexOf(resultPage);

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

		private void ProgressBarChanged(int total)
		{

			Action action = () =>
			{
				progressBar.Maximum = total;
				progressBar.Value++;
			};
			if (InvokeRequired)
				Invoke(action);
			else
				action();
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
		private void buttonChooseFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				filePath = ofd.FileName;
			}
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

		private void timeOutInput_ValueChanged(object sender, EventArgs e)
		{
			timeOut = (int)timeOutInput.Value*100;
		}

		private void richTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}

		private void addStubButton_Click(object sender, EventArgs e)
		{
			string result = Microsoft.VisualBasic.Interaction.InputBox("Введите текст:");
			stubsBox.AppendText(result);
		}

		private void domainPingBox_TextChanged(object sender, EventArgs e)
		{
			traceRouteDomain = domainPingBox.Text;
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			Action action = () =>
			{
				canceled = !canceled;
				Logger.Log(new string('-', 100));
				Logger.Log("Forced Stop");
				Logger.Log(new string('-', 100));
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

			var temp = TraceRoute.GetTraceRoute(traceRouteDomain);
			//foreach (var item in temp.ToArray())
			//{
			//	Logger.Log(item.ToString());
			//}
			Logger.Log(new string('-', 100));
		}
	}
}