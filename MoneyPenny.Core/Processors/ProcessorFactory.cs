using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core.Processors
{
	public static class ProcessorFactory
	{
		static List<AbstractProcessor> listProcessor = new List<AbstractProcessor>();

		static ProcessorFactory()
		{
			listProcessor.Add(new CoinProcessor());
			listProcessor.Add(new BankNoteProcessor());
			listProcessor.Add(new SilverProcessor());
			listProcessor.Add(new CandyProcessor());
		}

		public static AbstractProcessor Create(long currentChangeAmount)
		{
			foreach (AbstractProcessor processor in listProcessor.OrderByDescending(l => l.ChangeValues.Max()))
			{
				if (currentChangeAmount >= processor.ChangeValues.Min())
				{
					return processor;
				}
			}
			return null;
		}
	}
}
