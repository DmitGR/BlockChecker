using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace URLchecker.Logic
{
	static class Requester
	{
		public static readonly string StabsFile = "Settings\\stubs.txt";
		public static readonly string DomainsFile = "Settings\\domains.txt";


		static List<string> stubFilter;
		static List<string> domainFilter;

		public static Status Send(string url, int timeOut)
		{
			Stopwatch sw_total = new Stopwatch();
			sw_total.Start();
			try
			{
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.Timeout = timeOut;
			//request.Method = "POST";
			request.AllowAutoRedirect = false;

			string html = "";
			string location;

			HttpWebResponse response;


				response = (HttpWebResponse)request.GetResponse();
				location = response.GetResponseHeader("Location");



				if (location != "")
				{
					Logger.Log(string.Format("Url [{0}] Redirected to [{1}]", url, location));

					if (DomainFilter(location))
					{
						Logger.Log(string.Format("Url [{0}] Blocked", url, location));
						return Status.Blocked;
					}
					response = (HttpWebResponse)((HttpWebRequest)(WebRequest.Create(location))).GetResponse();


				}

				using (response)
				{
					using (Stream stream = response.GetResponseStream())
					{
						using (StreamReader reader = new StreamReader(stream))
						{
							Logger.Log(string.Format("Response {0} at {1} ms", url, sw_total.ElapsedMilliseconds));
							
							html = reader.ReadToEnd();
						}
					}
				}
				return StubFilter(html);

			}
			catch (Exception ex)
			{
				Logger.Log(string.Format("HOST {0} Warning: [{1}] delay {2} ms", url,ex.Message, sw_total.ElapsedMilliseconds));

				return Status.Unavailable;
			}
		}

		private static Status StubFilter(string html)
		{
		//	html.ToLower();
			foreach (var item in stubFilter)
			{
				if (html.Contains(item))
					return Status.Blocked;
			}

			return Status.Available;
		}

		private static bool DomainFilter(string url)
		{
			foreach (var item in domainFilter)
			{
				if (url.Contains(item))
					return true;
			}

			return false;
		}

		public static void LoadStubs()
		{
			stubFilter = new List<string>();
			try
			{
				Logger.Log(string.Format("Loading Stubs from " + StabsFile));
				Logger.Log(new string('*', 50));
				using (StreamReader sr = new StreamReader(StabsFile, System.Text.Encoding.Default))
				{
					string line;
					while ((line = sr.ReadLine()) != null)
					{
						stubFilter.Add(line);
						Logger.Log(line);
					}
				}
				Logger.Log(new string('*', 50));

			}
			catch (Exception ex)
			{
				Logger.Log(ex.ToString());
			}
		}
		
		public static void LoadDomains()
		{
			domainFilter = new List<string>();
			try
			{
				Logger.Log(string.Format("Loading Domains from " + DomainsFile));
				Logger.Log(new string('*', 50));
				using (StreamReader sr = new StreamReader(DomainsFile, System.Text.Encoding.Default))
				{
					string line;
					while ((line = sr.ReadLine()) != null)
					{
						domainFilter.Add(line);
						Logger.Log(line);
					}
				}
				Logger.Log(new string('*', 50));

			}
			catch (Exception ex)
			{
				Logger.Log(ex.ToString());
			}
		}
	}
}