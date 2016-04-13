using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core.Processors
{
	public class BankNoteProcessor : AbstractProcessor
	{
		public BankNoteProcessor()
		{

		}

		public override long[] ChangeValues
		{
			get
			{
				return new long[] { 200, 500, 1000, 2000, 5000, 10000 };
			}
		}

		public override string GetName()
		{
			return "BankNote";
		}
	}
}
