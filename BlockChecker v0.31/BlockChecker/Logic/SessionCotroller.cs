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
		public static Session Session { get; set; }

		public static List<Session> List { get; set; }

		public static void Initialize()
		{
			Session = new Session();
			List = new List<Session>();
			Scan();

		}

		public static void CreateNew()
		{
			Session.SessionNum = DateTime.Now.ToString("yyyyMMddHHmmss");
			Session.LastRecord = 0;
			newPath();
		}

		public static void newPath()
		{
			Session.Path = string.Format("Sessions\\session-{0}-{1}.txt", Session.SessionNum, 'U');
		}

		public static void ReadToLast()
		{
			string[] temp = new string[2];
			try
			{
				using (StreamReader sr = new StreamReader(Session.Path, System.Text.Encoding.Default))
				{
					for (int i = 0; i < temp.Length; i++)
					{
						temp[i] = sr.ReadLine();
					}
				}
				Session.LastRecord = int.Parse(temp[temp.Length - 1]);

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
				using (StreamWriter sw = new StreamWriter(Session.Path, false, System.Text.Encoding.Default))
				{
					sw.WriteLine("File: "+file);
					sw.WriteLine(text);

				}
				if (completed)
					System.IO.File.Move(Session.Path, Session.Path.Substring(0, Session.Path.Length-5)+"C.txt");
			}
			catch (Exception e)
			{
				Logger.Log("Session Warning [" + e.Message + "]");
			}
		}
		public static void Scan()
		{
			string[] files;
			List = new List<Session>();
			if(Directory.Exists("Sessions"))
			{
				files = Directory.GetFiles("Sessions");
				foreach (var file in files)
				{
					if (file.Contains("U"))
					{
						Session temp = new Session();

						temp.Path = file;
						temp.SessionNum = file.Substring(17, 14);
						 ReadLastRecord(temp);
						List.Add(temp);
					}
				}
			}

		}

		public static void ReadLastRecord(Session session)
		{
			string[] temp = new string[2];
			try
			{
				using (StreamReader sr = new StreamReader(session.Path, System.Text.Encoding.Default))
				{
					for (int i = 0; i < temp.Length; i++)
					{
						temp[i] = sr.ReadLine();
					}
				}
				session.LastRecord =  int.Parse(temp[temp.Length - 1]);
				session.FilePath = temp[0].Substring(6);

			}
			catch (Exception e)
			{
				Logger.Log("Session Read Warning [" + e.Message + "[");
			}
		}
	}
}
