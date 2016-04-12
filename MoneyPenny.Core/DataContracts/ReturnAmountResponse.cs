using MoneyPenny.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core
{
	public class ReturnAmountResponse : AbstractResponse
	{
		public ReturnAmountResponse() { }

		public Dictionary<long, int> ResultNotes { get; internal set; }

		public Dictionary<long, int> ResultCoins { get; internal set; }

		public Nullable<long> TotalAmount { get; internal set; }
	}
}
