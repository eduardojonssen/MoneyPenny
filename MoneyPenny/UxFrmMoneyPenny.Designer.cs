namespace MoneyPenny
{
	partial class UxFrmMoneyPenny
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UxFrmMoneyPenny));
			this.UxTxtProductAmount = new System.Windows.Forms.TextBox();
			this.UxTxtPaidAmount = new System.Windows.Forms.TextBox();
			this.UxBtnCalculateChange = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.UxLblChange = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.UxLtbResult = new System.Windows.Forms.ListBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.UxBtnFechar = new System.Windows.Forms.Button();
			this.UxMenu = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UxPnlTitle = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.UxMenu.SuspendLayout();
			this.UxPnlTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// UxTxtProductAmount
			// 
			this.UxTxtProductAmount.Location = new System.Drawing.Point(159, 28);
			this.UxTxtProductAmount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.UxTxtProductAmount.Name = "UxTxtProductAmount";
			this.UxTxtProductAmount.Size = new System.Drawing.Size(163, 26);
			this.UxTxtProductAmount.TabIndex = 0;
			// 
			// UxTxtPaidAmount
			// 
			this.UxTxtPaidAmount.Location = new System.Drawing.Point(159, 72);
			this.UxTxtPaidAmount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.UxTxtPaidAmount.Name = "UxTxtPaidAmount";
			this.UxTxtPaidAmount.Size = new System.Drawing.Size(163, 26);
			this.UxTxtPaidAmount.TabIndex = 1;
			// 
			// UxBtnCalculateChange
			// 
			this.UxBtnCalculateChange.Location = new System.Drawing.Point(159, 120);
			this.UxBtnCalculateChange.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.UxBtnCalculateChange.Name = "UxBtnCalculateChange";
			this.UxBtnCalculateChange.Size = new System.Drawing.Size(164, 38);
			this.UxBtnCalculateChange.TabIndex = 2;
			this.UxBtnCalculateChange.Text = "Calcular";
			this.UxBtnCalculateChange.UseVisualStyleBackColor = true;
			this.UxBtnCalculateChange.Click += new System.EventHandler(this.UxBtnCalculateChange_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Valor do produto";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Valor pago";
			// 
			// UxLblChange
			// 
			this.UxLblChange.AutoSize = true;
			this.UxLblChange.Location = new System.Drawing.Point(342, 128);
			this.UxLblChange.Name = "UxLblChange";
			this.UxLblChange.Size = new System.Drawing.Size(53, 20);
			this.UxLblChange.TabIndex = 5;
			this.UxLblChange.Text = "Troco:";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.UxLblChange);
			this.panel1.Controls.Add(this.UxTxtProductAmount);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.UxTxtPaidAmount);
			this.panel1.Controls.Add(this.UxBtnCalculateChange);
			this.panel1.Location = new System.Drawing.Point(13, 159);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(610, 177);
			this.panel1.TabIndex = 6;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// UxLtbResult
			// 
			this.UxLtbResult.FormattingEnabled = true;
			this.UxLtbResult.ItemHeight = 20;
			this.UxLtbResult.Location = new System.Drawing.Point(13, 351);
			this.UxLtbResult.Name = "UxLtbResult";
			this.UxLtbResult.Size = new System.Drawing.Size(610, 184);
			this.UxLtbResult.TabIndex = 7;
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.statusStrip1.Location = new System.Drawing.Point(11, 593);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
			this.statusStrip1.Size = new System.Drawing.Size(611, 22);
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// UxBtnFechar
			// 
			this.UxBtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.UxBtnFechar.Location = new System.Drawing.Point(446, 543);
			this.UxBtnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.UxBtnFechar.Name = "UxBtnFechar";
			this.UxBtnFechar.Size = new System.Drawing.Size(177, 35);
			this.UxBtnFechar.TabIndex = 6;
			this.UxBtnFechar.Text = "Fechar";
			this.UxBtnFechar.UseVisualStyleBackColor = true;
			this.UxBtnFechar.Click += new System.EventHandler(this.UxBtnFechar_Click);
			// 
			// UxMenu
			// 
			this.UxMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.UxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
			this.UxMenu.Location = new System.Drawing.Point(11, 11);
			this.UxMenu.Name = "UxMenu";
			this.UxMenu.Size = new System.Drawing.Size(611, 33);
			this.UxMenu.TabIndex = 9;
			this.UxMenu.Text = "menuStrip1";
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
			this.arquivoToolStripMenuItem.Text = "Arquivo";
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(126, 30);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
			// 
			// ajudaToolStripMenuItem
			// 
			this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
			this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
			this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
			this.ajudaToolStripMenuItem.Text = "Ajuda";
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
			this.sobreToolStripMenuItem.Text = "Sobre";
			this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
			// 
			// UxPnlTitle
			// 
			this.UxPnlTitle.BackColor = System.Drawing.Color.White;
			this.UxPnlTitle.Controls.Add(this.pictureBox1);
			this.UxPnlTitle.Controls.Add(this.label3);
			this.UxPnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.UxPnlTitle.Location = new System.Drawing.Point(11, 44);
			this.UxPnlTitle.Name = "UxPnlTitle";
			this.UxPnlTitle.Size = new System.Drawing.Size(611, 98);
			this.UxPnlTitle.TabIndex = 10;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::MoneyPenny.Properties.Resources._1459966427_coins;
			this.pictureBox1.Location = new System.Drawing.Point(12, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(115, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(231, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 29);
			this.label3.TabIndex = 0;
			this.label3.Text = "Money Penny";
			// 
			// UxFrmMoneyPenny
			// 
			this.AcceptButton = this.UxBtnCalculateChange;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.UxBtnFechar;
			this.ClientSize = new System.Drawing.Size(633, 626);
			this.Controls.Add(this.UxPnlTitle);
			this.Controls.Add(this.UxBtnFechar);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.UxMenu);
			this.Controls.Add(this.UxLtbResult);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.UxMenu;
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.MaximizeBox = false;
			this.Name = "UxFrmMoneyPenny";
			this.Padding = new System.Windows.Forms.Padding(11);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MoneyPenny";
			this.Load += new System.EventHandler(this.UxFrmMoneyPenny_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.UxMenu.ResumeLayout(false);
			this.UxMenu.PerformLayout();
			this.UxPnlTitle.ResumeLayout(false);
			this.UxPnlTitle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox UxTxtProductAmount;
		private System.Windows.Forms.TextBox UxTxtPaidAmount;
		private System.Windows.Forms.Button UxBtnCalculateChange;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label UxLblChange;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox UxLtbResult;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Button UxBtnFechar;
		private System.Windows.Forms.MenuStrip UxMenu;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.Panel UxPnlTitle;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
	}
}

