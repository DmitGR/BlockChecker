using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URLchecker.Logic;

namespace BlockChecker.Logic
{
	class FilterIO
	{
		public static List<string> Read(string path)
		{
			List<string> buffer = new List<string>();
			//-------------запуск таймера------------------------------------------------------------------------------------//
			Stopwatch sw_total = new Stopwatch();
			sw_total.Start();

			//------------чтение таблицы -----------------------------------------------------------------------------//
			try
			{
				Logger.Log("\n******Begin Reading********");
				Logger.Log(string.Format("From File: " + path));

				using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
				{
					string line;
					while ((line = sr.ReadLine()) != null)
					{
						buffer.Add(line);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
			//-------------вывод результата----------------------------------------------------------------------//
			sw_total.Stop();
			Logger.Log(string.Format("Loaded [{0}] Lines at [{1}] ms from [{2}]", buffer.Count, sw_total.ElapsedMilliseconds,path));

			return buffer;
		}

		public static void Write(string[] list, string path)
		{
			//-------------запуск таймера------------------------------------------------------------------------------------//
			Stopwatch sw_total = new Stopwatch();
			sw_total.Start();
			try
			{
				Logger.Log("\n******Begin Writing********");
				Logger.Log(string.Format("Into File: " + path));
				using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
				{
					foreach (var item in list)
					{
						if (item != "")
							sw.WriteLine(item);
					}
				}
			}
			catch (Exception e)
			{
				Logger.Log(e.Message);
			}
			sw_total.Stop();
			Logger.Log(string.Format("Writed [{0}] Lines at [{1}] ms to [{2}]", list.Length, sw_total.ElapsedMilliseconds, path));
		}
	}
}