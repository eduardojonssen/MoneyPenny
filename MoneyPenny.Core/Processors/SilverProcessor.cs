using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core.Processors
{
	public class SilverProcessor : AbstractProcessor
	{


		public override long[] ChangeValues
		{
			get
			{
				return new long[] { 50000, 100000 };
			}

		}

		public override string GetName()
		{
			return "SilverBar";
		}
	}
}
