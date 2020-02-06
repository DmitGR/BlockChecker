using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLchecker.Logic
{
	class RecordsReader
	{
		public List<Record> records;
		string file;

		public RecordsReader(string file)
		{
			this.file = file;
			records = new List<Record>();
			Read();
		}

		private void Read()
		{
			//-------------запуск таймера------------------------------------------------------------------------------------//
			Stopwatch sw_total = new Stopwatch();
			sw_total.Start();

			//------------чтение таблицы -----------------------------------------------------------------------------//
			int counter = 1;
			try
			{
				Logger.Log("\n******Begin Reading********\n");
				Logger.Log(string.Format("File: " + file));

				using (StreamReader sr = new StreamReader(file, System.Text.Encoding.Default))
				{
					string line;
					string[] temp;
					while ((line = sr.ReadLine()) != null)
					{
						temp = line.Split('\t');
						//records.Add(new Record(temp[0], temp[1], temp[2]));
						records.Add(new Record(long.Parse(temp[0]), temp[1], temp[2], temp[3], temp[4]));
						Logger.Log(string.Format("#{0} URL: {1} DOMAIN: {2} IP: {3}",counter, temp[4], temp[3], temp[2]));

						counter++;
					}
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex);
			}
				//-------------вывод результата таймера----------------------------------------------------------------------//
			sw_total.Stop();
			Logger.Log(string.Format("Loaded [{0}] URL's at [{1}] ms",counter, sw_total.ElapsedMilliseconds));

		}
	}
}