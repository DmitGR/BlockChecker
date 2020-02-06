using BlockChecker.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLchecker.Logic
{
	class Logger
	{
		static List<string> logs = new List<string>();

		public static event Action<string> ShowLog;

		public static string Provider { get; set; }

		public static void Log(string text)
		{
			var logText = "[" + DateTime.Now.ToString("HH:mm:ss") + "] " + text;
			logs.Add(logText);
			Write(logText);
			ShowLog(logText);
		}
		
		public static void WriteLogs()
		{
			//	string Path = string.Format("Logs\\log-{0}.txt",DateTime.Now.ToString("dd/MM/yyyy-HHmmss!"));
			string Path = string.Format("Logs\\log-{0}.txt", SessionCotroller.Session.SessionNum);
			try
			{
				using (StreamWriter sw = new StreamWriter(Path, true, System.Text.Encoding.Default))
				{
					sw.WriteLine("MachineName: {0}", Environment.MachineName);
					sw.WriteLine(new string('=', 100));
					foreach (var item in logs)
					{
						sw.WriteLine(item);
					}
					sw.WriteLine(new string('=', 100));
				}
			}
			catch (Exception e)
			{
				Log("Log Warning ["+e.Message+"]");
			}
		}

		public static void Write(string text)
		{
			string Path = string.Format("Logs\\log-{0}.txt", SessionCotroller.Session.SessionNum);
			try
			{
				using (StreamWriter sw = new StreamWriter(Path, true, System.Text.Encoding.Default))
				{
;
					sw.WriteLine(text);
				}
			}
			catch (Exception e)
			{
				Log("Log Warning [" + e.Message + "]");
			}
		}
	}
}
