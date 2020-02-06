using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLchecker.Logic
{
	enum Status
	{
		Available,
		Unavailable,
		Blocked,
		AvailableByDomain,
		AvailableByIp
	}
}
