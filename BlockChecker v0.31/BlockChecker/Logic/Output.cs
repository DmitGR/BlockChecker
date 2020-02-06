using System;
using System.Collections.Generic;
using System.IO;
using BlockChecker.Logic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace URLchecker.Logic
{
	static class Output
	{
		public static event Action<string> ShowResult;

		public static void InTXT(List<Record> res, string provider)
		{
			string Path = string.Format("Results\\result-{0}.txt", DateTime.Now.ToString("dd/MM/yyyy"));
			try
			{
				using (StreamWriter sw = new StreamWriter(Path, true, System.Text.Encoding.Default))
				{
					int counter = 0;
					sw.WriteLine("MachineName: {0} ProviderName: {1} Total {2} URL's\n",
						Environment.MachineName, provider, res.Count);
					sw.WriteLine(new string('=', 100));
					foreach (var item in res)
					{
						if (item.Status == Status.Available)
						{
							sw.WriteLine(item.ToString());
							counter++;
						}
					}

					sw.WriteLine("\n{0} URL's are available \n", counter);
					sw.WriteLine(new string('=', 100));
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		public static void InTXT(Record res, string provider, int count, string[] tracert = null)
		{
			string Path = string.Format("Results\\result-{0}.txt", SessionCotroller.Session.SessionNum);
			try
			{
				using (StreamWriter sw = new StreamWriter(Path, true, System.Text.Encoding.Default))
				{
					int counter = 0;
					if (res == null)
					{


						sw.WriteLine("MachineName: {0} ProviderName: {1} Total {2} URL's\n",
							Environment.MachineName, provider, count);
						sw.WriteLine(new string('=', 100));

						if(tracert != null)
						{
							foreach (var item in tracert)
							{
								sw.WriteLine(item);
							}
						}
					}
					else
					{

						if (res.Status == Status.Available)
						{
						sw.WriteLine(res.ToString());
						counter++;
						sw.WriteLine("\n{0} URL's are available \n", counter);
						sw.WriteLine(new string('=', 100));
						}


					}
				}
			}
			catch (Exception e)
			{
				Logger.Log("Output in txt Error ["+e.Message+"]");
			}
		}

		public static void Write(string text)
		{
			ShowResult(text);

			string Path = string.Format("Results\\result-{0}.txt", SessionCotroller.Session.SessionNum);
			try
			{
				using (StreamWriter sw = new StreamWriter(Path, true, System.Text.Encoding.Default))
				{
					
					sw.WriteLine(text);
				}
			}
			catch (Exception e)
			{
				Logger.Log("Output Warning [" + e.Message + "]");
			}
		}
	}
}
