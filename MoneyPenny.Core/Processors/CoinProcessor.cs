using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core.Processors
{
	public class CoinProcessor : AbstractChangeProcessor
	{
		public override long[] ChangeValues
		{
			get
			{
				return new long[] { 1, 5, 10, 25, 50, 100 };
			}

		}

		public override Dictionary<long, int> CalculateChange(long currentChangeAmount)
		{
			Dictionary<long, int> resultCoins= new Dictionary<long, int>();
			foreach (int coin in ChangeValues.OrderByDescending(n => n))
			{
				long resultDiv = currentChangeAmount / coin;

				if (resultDiv == 0)
					continue;

				currentChangeAmount -= (coin * resultDiv);
				resultCoins.Add(coin, Convert.ToInt32(resultDiv));

				if (currentChangeAmount <= 0)
					break;
			}
			return resultCoins;
		}
	}
}
