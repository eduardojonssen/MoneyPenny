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
		public ReturnAmountResponse() {
			this.Result = new List<ChangeData>();
		}

		public List<ChangeData> Result { get; set; }

		public Nullable<long> TotalAmount { get; internal set; }
	}
}
