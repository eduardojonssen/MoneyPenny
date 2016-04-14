using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core.Processors
{
	public class CandyProcessor : AbstractProcessor
	{
		public override long[] ChangeValues
		{
			get
			{
				return new long[] { 1, 3 };
			}
		}

		public override string GetName()
		{
			return "Candy";
		}
	}
}
