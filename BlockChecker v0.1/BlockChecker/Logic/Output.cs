using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace URLchecker.Logic
{
	static class Output
	{
		public static void InTXT(List<Record> res)
		{
			string Path = string.Format("Results\\result-{0}.txt", DateTime.Now.ToString("dd/MM/yyyy"));
			try
			{
				using (StreamWriter sw = new StreamWriter(Path, true, System.Text.Encoding.Default))
				{
					sw.WriteLine("MachineName: {0} HostName: {1}", Environment.MachineName, Dns.GetHostName());
					sw.WriteLine(new string('=', 100));
					foreach (var item in res)
					{
						if(item.Status == Status.Available)
							sw.WriteLine(item.ToString());
					}
					sw.WriteLine(new string('=', 100));
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
