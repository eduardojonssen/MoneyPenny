using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core.Processors
{
	public abstract class AbstractProcessor
	{
		public abstract long[] ChangeValues { get; }

		public virtual string GetName()
		{
			return this.GetType().Name;
		}

		public virtual Dictionary<long, int> CalculateChange(long currentChangeAmount) {

			Dictionary<long, int> resultNotes = new Dictionary<long, int>();
			foreach (int note in ChangeValues.OrderByDescending(n => n))
			{
				long resultDiv = currentChangeAmount / note;

				if (resultDiv == 0)
					continue;

				currentChangeAmount -= (note * resultDiv);
				resultNotes.Add(note, Convert.ToInt32(resultDiv));

				if (currentChangeAmount < ChangeValues.Min())
					break;
			}
			return resultNotes;
		}
	}
}
