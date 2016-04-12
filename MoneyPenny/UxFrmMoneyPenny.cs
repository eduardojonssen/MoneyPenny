using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyPenny.Core;
namespace MoneyPenny
{
	public partial class UxFrmMoneyPenny : Form
	{
		MoneyPennyManager MoneyPennyManager;
		public UxFrmMoneyPenny()
		{
			InitializeComponent();
		}

		private void UxBtnCalculateChange_Click(object sender, EventArgs e)
		{
			if (UxTxtPaidAmount.Text == "" || UxTxtProductAmount.Text == "")
				return;

			ReturnAmountRequest request = new ReturnAmountRequest();

			request.PaidAmount = Convert.ToInt64(UxTxtPaidAmount.Text);
			request.ProductAmount = Convert.ToInt64(UxTxtProductAmount.Text);

			ReturnAmountResponse returnAmountResponse = MoneyPennyManager.ReturnAmount(request);

			if (returnAmountResponse.Success == false)
			{
				string message = string.Empty;
				foreach (Report report in returnAmountResponse.OperationReport)
				{
					message += string.Format("{0}: {1}\r\n", report.Field, report.Message);
				}
				MessageBox.Show(message,
					"Money Penny",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (returnAmountResponse.TotalAmount > 0)
			{
				UxLblChange.Text = String.Format("Troco: {0}", returnAmountResponse.TotalAmount);
				UxLtbResult.Items.Clear();
				foreach (KeyValuePair<long, int> item in returnAmountResponse.ResultNotes)
				{
					UxLtbResult.Items.Add(string.Format("Notas de {0} reais : {1}", item.Key/100, item.Value));
				}
				foreach (KeyValuePair<long, int> item in returnAmountResponse.ResultCoins)
				{
					UxLtbResult.Items.Add(string.Format("Moeda de {0} centavos : {1}", item.Key, item.Value));
				}
			}
		}

		private void UxFrmMoneyPenny_Load(object sender, EventArgs e)
		{
			MoneyPennyManager = new MoneyPennyManager();
		}

		private void UxBtnFechar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UxFrmAboutBox uxFrmAboutBox = new UxFrmAboutBox();
			uxFrmAboutBox.ShowDialog();
		}	
	}
}
