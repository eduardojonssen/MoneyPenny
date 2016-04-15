using MoneyPenny.Core.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyPenny.Core.Log;

namespace MoneyPenny.Core
{
	public class MoneyPennyManager
	{
		public ReturnAmountResponse ReturnAmount(ReturnAmountRequest returnCoinsRequest)
		{
			LogService.Save("Request", returnCoinsRequest);
			
			ReturnAmountResponse returnAmountResponse = new ReturnAmountResponse();

			try
			{
				// Verifica se os dados recebidos são válidos.
				if (returnCoinsRequest.IsValid == false)
				{
					returnAmountResponse.OperationReport = returnCoinsRequest.ValidationReport;
					return returnAmountResponse;
				}

				long changeAmount = returnCoinsRequest.PaidAmount - returnCoinsRequest.ProductAmount;
				long currentChangeAmount = changeAmount;

				List<ChangeData> chData = new List<ChangeData>();
				while (currentChangeAmount > 0)
				{
					AbstractProcessor processor = ProcessorFactory.Create(currentChangeAmount);
					if (processor == null)
					{
						returnAmountResponse.OperationReport.Add(new Report(null, "Não foi possivel processar seu troco."));
						return returnAmountResponse;
					}

					Dictionary<long, int> result = processor.CalculateChange(currentChangeAmount);
					long resultTotalAmount = result.Sum(t => t.Key * t.Value);
					chData.Add(new ChangeData()
					{
						Type = processor.GetName(),
						TotalAmount = resultTotalAmount,
						Changes = result
					});
					currentChangeAmount -= resultTotalAmount;
				}
				returnAmountResponse.TotalAmount = changeAmount;
				returnAmountResponse.Result = chData;
				returnAmountResponse.Success = true;
			}
			catch (Exception ex)
			{
				returnAmountResponse.OperationReport.Add(new Report(null, "Ocorreu um erro interno."));

				LogService.Save("Exception", ex.Message);
			}

			LogService.Save("Response", returnAmountResponse);

			return returnAmountResponse;
		}
	}
}
