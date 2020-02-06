using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChecker.Logic
{
	class Session
	{
		public Session()
		{
		}

		public Session(string sessionNum, string path, int lastRecord)
		{
			SessionNum = sessionNum;
			Path = path;
			LastRecord = lastRecord;
		}

		public string SessionNum { get; set; }
		public string Path { get; set; }
		public int LastRecord { get; set; }
		public string FilePath { get; set; }

		public override string ToString()
		{
			return SessionNum;
		}
	}
}
