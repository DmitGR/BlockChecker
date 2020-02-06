using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URLchecker.Logic;

namespace BlockChecker.Logic
{
	class SessionCotroller
	{
		public static string Session { get; set; }
		public static string Path{ get; set; }
		public static int LastRecord { get; set; }

		public static void newPath()
		{
			Path = string.Format("Sessions\\session-{0}-{1}.txt", Session, 'U');
		}

		public static void ReadToLast()
		{
			string[] temp = new string[2];
			try
			{
				using (StreamReader sr = new StreamReader(Path, System.Text.Encoding.Default))
				{
					for (int i = 0; i < temp.Length; i++)
					{
						temp[i] = sr.ReadLine();
					}
				}
				LastRecord = int.Parse(temp[temp.Length - 1]);

			}
			catch (Exception e)
			{
				Logger.Log("Session Read Warning [" + e.Message + "[");
			}
		}

		public static void Write(string text, string file, bool completed = false)
		{
			try
			{
				using (StreamWriter sw = new StreamWriter(Path, false, System.Text.Encoding.Default))
				{
					sw.WriteLine("File: "+file);
					sw.WriteLine(text);

				}
				if (completed)
					System.IO.File.Move(Path, Path.Substring(0,Path.Length-5)+"C.txt");
			}
			catch (Exception e)
			{
				Logger.Log("Session Warning [" + e.Message + "]");
			}
		}
	}
}
