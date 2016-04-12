using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core.Processors
{
	public class BankNoteProcessor : AbstractChangeProcessor
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

		public override Dictionary<long, int> CalculateChange(long currentChangeAmount)
		{
			Dictionary<long, int> resultNotes = new Dictionary<long, int>();
			foreach (int note in ChangeValues.OrderByDescending(n => n))
			{
				long resultDiv = currentChangeAmount / note;

				if (resultDiv == 0)
					continue;

				currentChangeAmount -= (note * resultDiv);
				resultNotes.Add(note, Convert.ToInt32(resultDiv));

				if (currentChangeAmount < 200)
					break;
			}
			return resultNotes;
		}
	}
}
