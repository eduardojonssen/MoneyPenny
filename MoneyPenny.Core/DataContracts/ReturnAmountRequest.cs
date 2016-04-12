using MoneyPenny.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core
{
	public class ReturnAmountRequest : AbstractRequest
	{
		public long ProductAmount { get; set; }
		public long PaidAmount { get; set; }

		protected override void Validate()
		{
			if (this.ProductAmount < 0)
			{
				this.AddError("ProductAmount", "Product amount should be higher than 0");
			}
			if (this.PaidAmount < 0)
			{
				this.AddError("PaidAmount", "Paid amount should be higher than 0");
			}
			if (this.PaidAmount < this.ProductAmount)
			{
				this.AddError("PaidAmount", "Paid amount should be higher than product amount!");
			}
		}
	}
}
