using MoneyPenny.Core.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core
{
	public class MoneyPennyManager
	{
		public ReturnAmountResponse ReturnAmount(ReturnAmountRequest returnCoinsRequest)
		{
			ReturnAmountResponse returnAmountResponse = new ReturnAmountResponse();

			try
			{
				// Verifica se os ados recebidos são válidos.
				if (returnCoinsRequest.IsValid == false)
				{
					returnAmountResponse.OperationReport = returnCoinsRequest.ValidationReport;
					return returnAmountResponse;
				}
				
				long changeAmount = returnCoinsRequest.PaidAmount - returnCoinsRequest.ProductAmount;
				long currentChangeAmount = changeAmount;

				BankNoteProcessor bankNoteProcessor = new BankNoteProcessor();
				CoinProcessor coinProcessor = new CoinProcessor();

				Dictionary<long, int> resultNotes = bankNoteProcessor.CalculateChange(currentChangeAmount);
				currentChangeAmount -= resultNotes.Sum(c => c.Key * c.Value);
				Dictionary<long, int> resultCoins = coinProcessor.CalculateChange(currentChangeAmount);

				returnAmountResponse.TotalAmount = changeAmount;
				returnAmountResponse.ResultCoins = resultCoins;
				returnAmountResponse.ResultNotes = resultNotes;
				returnAmountResponse.Success = true;
			}
			catch (Exception ex)
			{
				returnAmountResponse.OperationReport.Add(new Report(null, "Ocorreu um erro interno."));
			}

			return returnAmountResponse;
		}
	}
}
