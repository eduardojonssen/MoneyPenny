using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core
{	public class Report
	{
		public string Field { get; private set; }
		public string Message { get; private set; }
		public Report(string field, string message)
		{
			this.Field = field;
			this.Message = message;
		}
	}
}
