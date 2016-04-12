using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPenny.Core.DataContracts
{
	public abstract class AbstractRequest
	{
		public AbstractRequest()
		{
			this._validationReport = new List<Report>();
		}

		private List<Report> _validationReport;
		internal List<Report> ValidationReport {
			get { return this._validationReport.ToList(); }
		}

		internal bool IsValid
		{
			get
			{
				this._validationReport.Clear();
				this.Validate();
				return (this._validationReport.Any() == false);
			}
		}

		protected abstract void Validate();

		protected void AddError(string field, string message)
		{
			string typeName = this.GetType().Name;

			this._validationReport.Add(new Report(typeName + "." + field, message));
		}
	}
}
