using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core
{
	public class ChangeData
	{
		public long TotalAmount { get;internal set; }
		public string Type { get;internal set; }
		public Dictionary<long, int> Changes = new Dictionary<long, int>();
	}
}
