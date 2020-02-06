using System;
namespace URLchecker.Logic
{
	public class Record
	{
		string url, ip, domain, type;
		long number;
		Status status;
		private const string http = "http://";

		public Record(long number, string type, string ip, string domain, string url)
		{
			Url = url;
			Ip = ip;
			Domain = domain;
			Number = number;
			Type = type;
		}

		public string Url { get => url; set => url = value; }
		public string Ip { get => ip; set => ip = value; }
		public string Domain { get => domain; set => domain = value; }
		public long Number { get => number; set => number = value; }
		public string Type { get => type; set => type = value; }
		internal Status Status { get => status; set => status = value; }


		public string GetURL()
		{
			if (url == "")
			{
				if (domain == "")
					return http + ip;
				else
					return http + domain;
			}
			else
				return url;
		}

		public override string ToString()
		{
			return url + " " + domain + " " + ip + " " + Status;
		}
	}
}