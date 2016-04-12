using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core.Processors
{
	public abstract class AbstractChangeProcessor
	{

		public abstract long[] ChangeValues { get; }

		public virtual string GetName()
		{
			return this.GetType().Name;
		}

		public abstract Dictionary<long, int> CalculateChange(long currentChangeAmount);
	}
}
