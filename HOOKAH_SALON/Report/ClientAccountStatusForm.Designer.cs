namespace HOOKAH_SALON.Report
{
	partial class ClientAccountStatusForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientAccountStatusForm));
			this.searchIDGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.searchPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.searchIDPanel = new Mbb.Windows.Forms.Panel();
			this.searchClientIDTextBox = new Mbb.Windows.Forms.TextBox();
			this.clientNameTextBox = new Mbb.Windows.Forms.Label();
			this.clientIDPanel = new Mbb.Windows.Forms.Panel();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.amountTextBox = new Mbb.Windows.Forms.Label();
			this.statusAccountGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.settlementStatusRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.creditorStatusRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.debtorStatusRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.paymentTypeProupBox = new Mbb.Windows.Forms.GroupBox();
			this.cardRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.chashAndCardRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.cashRradioButton = new Mbb.Windows.Forms.RadioButton();
			this.paymentAmountButton = new Mbb.Windows.Forms.Button();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.paymentAmountTextBox = new Mbb.Windows.Forms.TextBox();
			this.clientAccountStatusFormBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.searchIDGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchPicturBox)).BeginInit();
			this.statusAccountGroupBox.SuspendLayout();
			this.paymentTypeProupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchIDGroupBox
			// 
			this.searchIDGroupBox.Controls.Add(this.searchPicturBox);
			this.searchIDGroupBox.Controls.Add(this.searchIDPanel);
			this.searchIDGroupBox.Controls.Add(this.searchClientIDTextBox);
			this.searchIDGroupBox.ForeColor = System.Drawing.Color.White;
			this.searchIDGroupBox.Location = new System.Drawing.Point(297, 80);
			this.searchIDGroupBox.Name = "searchIDGroupBox";
			this.searchIDGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.searchIDGroupBox.Size = new System.Drawing.Size(317, 100);
			this.searchIDGroupBox.TabIndex = 0;
			this.searchIDGroupBox.TabStop = false;
			this.searchIDGroupBox.Text = "کد شناسایی را وارد کنید";
			// 
			// searchPicturBox
			// 
			this.searchPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("searchPicturBox.Image")));
			this.searchPicturBox.Location = new System.Drawing.Point(249, 35);
			this.searchPicturBox.Name = "searchPicturBox";
			this.searchPicturBox.Size = new System.Drawing.Size(25, 25);
			this.searchPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.searchPicturBox.TabIndex = 5;
			this.searchPicturBox.TabStop = false;
			// 
			// searchIDPanel
			// 
			this.searchIDPanel.BackColor = System.Drawing.Color.White;
			this.searchIDPanel.Location = new System.Drawing.Point(43, 65);
			this.searchIDPanel.Name = "searchIDPanel";
			this.searchIDPanel.Size = new System.Drawing.Size(231, 1);
			this.searchIDPanel.TabIndex = 4;
			// 
			// searchClientIDTextBox
			// 
			this.searchClientIDTextBox.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.searchClientIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchClientIDTextBox.Font = new System.Drawing.Font("IRANSansFaNum", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.searchClientIDTextBox.ForeColor = System.Drawing.Color.White;
			this.searchClientIDTextBox.Location = new System.Drawing.Point(43, 39);
			this.searchClientIDTextBox.MaxLength = 12;
			this.searchClientIDTextBox.Name = "searchClientIDTextBox";
			this.searchClientIDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.searchClientIDTextBox.Size = new System.Drawing.Size(200, 19);
			this.searchClientIDTextBox.TabIndex = 1;
			this.searchClientIDTextBox.Text = "کد شناسه...";
			this.searchClientIDTextBox.TextChanged += new System.EventHandler(this.SearchClientIDTextBox_TextChanged);
			this.searchClientIDTextBox.Enter += new System.EventHandler(this.SearchClientIDTextBox_Enter);
			this.searchClientIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchClientIDTextBox_KeyPress);
			this.searchClientIDTextBox.Leave += new System.EventHandler(this.SearchClientIDTextBox_Leave);
			// 
			// clientNameTextBox
			// 
			this.clientNameTextBox.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientNameTextBox.ForeColor = System.Drawing.Color.White;
			this.clientNameTextBox.Location = new System.Drawing.Point(449, 246);
			this.clientNameTextBox.Name = "clientNameTextBox";
			this.clientNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.clientNameTextBox.Size = new System.Drawing.Size(250, 35);
			this.clientNameTextBox.TabIndex = 4;
			this.clientNameTextBox.Text = "نام مشتری";
			this.clientNameTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clientNameTextBox.UseCompatibleTextRendering = true;
			// 
			// clientIDPanel
			// 
			this.clientIDPanel.BackColor = System.Drawing.Color.White;
			this.clientIDPanel.Location = new System.Drawing.Point(449, 284);
			this.clientIDPanel.Name = "clientIDPanel";
			this.clientIDPanel.Size = new System.Drawing.Size(250, 1);
			this.clientIDPanel.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(449, 345);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 1);
			this.panel2.TabIndex = 7;
			// 
			// amountTextBox
			// 
			this.amountTextBox.Font = new System.Drawing.Font("IRANSansFaNum", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.amountTextBox.ForeColor = System.Drawing.Color.White;
			this.amountTextBox.Location = new System.Drawing.Point(449, 307);
			this.amountTextBox.Name = "amountTextBox";
			this.amountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.amountTextBox.Size = new System.Drawing.Size(250, 35);
			this.amountTextBox.TabIndex = 6;
			this.amountTextBox.Text = "مبلغ";
			this.amountTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.amountTextBox.UseCompatibleTextRendering = true;
			this.amountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged);
			// 
			// statusAccountGroupBox
			// 
			this.statusAccountGroupBox.Controls.Add(this.settlementStatusRadioButton);
			this.statusAccountGroupBox.Controls.Add(this.creditorStatusRadioButton);
			this.statusAccountGroupBox.Controls.Add(this.debtorStatusRadioButton);
			this.statusAccountGroupBox.ForeColor = System.Drawing.Color.White;
			this.statusAccountGroupBox.Location = new System.Drawing.Point(85, 215);
			this.statusAccountGroupBox.Name = "statusAccountGroupBox";
			this.statusAccountGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusAccountGroupBox.Size = new System.Drawing.Size(307, 78);
			this.statusAccountGroupBox.TabIndex = 8;
			this.statusAccountGroupBox.TabStop = false;
			this.statusAccountGroupBox.Text = "وضعیت حساب";
			// 
			// settlementStatusRadioButton
			// 
			this.settlementStatusRadioButton.AutoCheck = false;
			this.settlementStatusRadioButton.AutoSize = true;
			this.settlementStatusRadioButton.Location = new System.Drawing.Point(109, 33);
			this.settlementStatusRadioButton.Name = "settlementStatusRadioButton";
			this.settlementStatusRadioButton.Size = new System.Drawing.Size(86, 21);
			this.settlementStatusRadioButton.TabIndex = 2;
			this.settlementStatusRadioButton.TabStop = true;
			this.settlementStatusRadioButton.Text = "تسویه حساب";
			this.settlementStatusRadioButton.UseVisualStyleBackColor = true;
			// 
			// creditorStatusRadioButton
			// 
			this.creditorStatusRadioButton.AutoCheck = false;
			this.creditorStatusRadioButton.AutoSize = true;
			this.creditorStatusRadioButton.Location = new System.Drawing.Point(50, 33);
			this.creditorStatusRadioButton.Name = "creditorStatusRadioButton";
			this.creditorStatusRadioButton.Size = new System.Drawing.Size(53, 21);
			this.creditorStatusRadioButton.TabIndex = 1;
			this.creditorStatusRadioButton.TabStop = true;
			this.creditorStatusRadioButton.Text = "طلبکار";
			this.creditorStatusRadioButton.UseVisualStyleBackColor = true;
			// 
			// debtorStatusRadioButton
			// 
			this.debtorStatusRadioButton.AutoCheck = false;
			this.debtorStatusRadioButton.AutoSize = true;
			this.debtorStatusRadioButton.Location = new System.Drawing.Point(201, 33);
			this.debtorStatusRadioButton.Name = "debtorStatusRadioButton";
			this.debtorStatusRadioButton.Size = new System.Drawing.Size(55, 21);
			this.debtorStatusRadioButton.TabIndex = 0;
			this.debtorStatusRadioButton.TabStop = true;
			this.debtorStatusRadioButton.Text = "بدهکار";
			this.debtorStatusRadioButton.UseVisualStyleBackColor = true;
			// 
			// paymentTypeProupBox
			// 
			this.paymentTypeProupBox.Controls.Add(this.cardRadioButton);
			this.paymentTypeProupBox.Controls.Add(this.chashAndCardRadioButton);
			this.paymentTypeProupBox.Controls.Add(this.cashRradioButton);
			this.paymentTypeProupBox.ForeColor = System.Drawing.Color.White;
			this.paymentTypeProupBox.Location = new System.Drawing.Point(85, 299);
			this.paymentTypeProupBox.Name = "paymentTypeProupBox";
			this.paymentTypeProupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.paymentTypeProupBox.Size = new System.Drawing.Size(307, 78);
			this.paymentTypeProupBox.TabIndex = 9;
			this.paymentTypeProupBox.TabStop = false;
			this.paymentTypeProupBox.Text = "نوع پرداخت";
			// 
			// cardRadioButton
			// 
			this.cardRadioButton.AutoSize = true;
			this.cardRadioButton.Location = new System.Drawing.Point(141, 32);
			this.cardRadioButton.Name = "cardRadioButton";
			this.cardRadioButton.Size = new System.Drawing.Size(48, 21);
			this.cardRadioButton.TabIndex = 4;
			this.cardRadioButton.Text = "کارت";
			this.cardRadioButton.UseVisualStyleBackColor = true;
			this.cardRadioButton.CheckedChanged += new System.EventHandler(this.CardRadioButton_CheckedChanged);
			// 
			// chashAndCardRadioButton
			// 
			this.chashAndCardRadioButton.AutoSize = true;
			this.chashAndCardRadioButton.Location = new System.Drawing.Point(62, 32);
			this.chashAndCardRadioButton.Name = "chashAndCardRadioButton";
			this.chashAndCardRadioButton.Size = new System.Drawing.Size(73, 21);
			this.chashAndCardRadioButton.TabIndex = 5;
			this.chashAndCardRadioButton.Text = "نقد و کارت";
			this.chashAndCardRadioButton.UseVisualStyleBackColor = true;
			this.chashAndCardRadioButton.CheckedChanged += new System.EventHandler(this.ChashAndCardRadioButton_CheckedChanged);
			// 
			// cashRradioButton
			// 
			this.cashRradioButton.AutoSize = true;
			this.cashRradioButton.Location = new System.Drawing.Point(195, 32);
			this.cashRradioButton.Name = "cashRradioButton";
			this.cashRradioButton.Size = new System.Drawing.Size(49, 21);
			this.cashRradioButton.TabIndex = 3;
			this.cashRradioButton.Text = "نقدی";
			this.cashRradioButton.UseVisualStyleBackColor = true;
			this.cashRradioButton.CheckedChanged += new System.EventHandler(this.CashRradioButton_CheckedChanged);
			// 
			// paymentAmountButton
			// 
			this.paymentAmountButton.BackColor = System.Drawing.Color.MediumPurple;
			this.paymentAmountButton.FlatAppearance.BorderSize = 0;
			this.paymentAmountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.paymentAmountButton.Location = new System.Drawing.Point(348, 476);
			this.paymentAmountButton.Name = "paymentAmountButton";
			this.paymentAmountButton.Size = new System.Drawing.Size(215, 35);
			this.paymentAmountButton.TabIndex = 10;
			this.paymentAmountButton.Text = "پرداخت حساب";
			this.paymentAmountButton.UseVisualStyleBackColor = false;
			this.paymentAmountButton.Click += new System.EventHandler(this.PaymentAmountButton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(305, 440);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 1);
			this.panel1.TabIndex = 12;
			// 
			// paymentAmountTextBox
			// 
			this.paymentAmountTextBox.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.paymentAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.paymentAmountTextBox.Font = new System.Drawing.Font("IRANSansFaNum", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.paymentAmountTextBox.ForeColor = System.Drawing.Color.White;
			this.paymentAmountTextBox.Location = new System.Drawing.Point(305, 402);
			this.paymentAmountTextBox.MaxLength = 12;
			this.paymentAmountTextBox.Name = "paymentAmountTextBox";
			this.paymentAmountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.paymentAmountTextBox.Size = new System.Drawing.Size(300, 32);
			this.paymentAmountTextBox.TabIndex = 2;
			this.paymentAmountTextBox.Text = "پرداخت مبلغ";
			this.paymentAmountTextBox.TextChanged += new System.EventHandler(this.PaymentAmountTextBox_TextChanged);
			this.paymentAmountTextBox.Enter += new System.EventHandler(this.PaymentAmountTextBox_Enter);
			this.paymentAmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaymentAmountTextBox_KeyPress);
			this.paymentAmountTextBox.Leave += new System.EventHandler(this.PaymentAmountTextBox_Leave);
			// 
			// clientAccountStatusFormBunifuElipse
			// 
			this.clientAccountStatusFormBunifuElipse.ElipseRadius = 25;
			this.clientAccountStatusFormBunifuElipse.TargetControl = this;
			// 
			// ClientAccountStatusForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.ClientSize = new System.Drawing.Size(910, 590);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.paymentAmountTextBox);
			this.Controls.Add(this.paymentAmountButton);
			this.Controls.Add(this.paymentTypeProupBox);
			this.Controls.Add(this.statusAccountGroupBox);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.amountTextBox);
			this.Controls.Add(this.clientIDPanel);
			this.Controls.Add(this.clientNameTextBox);
			this.Controls.Add(this.searchIDGroupBox);
			this.Name = "ClientAccountStatusForm";
			this.Text = "";
			this.Load += new System.EventHandler(this.ClientAccountStatusForm_Load);
			this.searchIDGroupBox.ResumeLayout(false);
			this.searchIDGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchPicturBox)).EndInit();
			this.statusAccountGroupBox.ResumeLayout(false);
			this.statusAccountGroupBox.PerformLayout();
			this.paymentTypeProupBox.ResumeLayout(false);
			this.paymentTypeProupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.GroupBox searchIDGroupBox;
		private Mbb.Windows.Forms.PicturBox searchPicturBox;
		private Mbb.Windows.Forms.Panel searchIDPanel;
		private Mbb.Windows.Forms.TextBox searchClientIDTextBox;
		private Mbb.Windows.Forms.Label clientNameTextBox;
		private Mbb.Windows.Forms.Panel clientIDPanel;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.Label amountTextBox;
		private Mbb.Windows.Forms.GroupBox statusAccountGroupBox;
		private Mbb.Windows.Forms.RadioButton settlementStatusRadioButton;
		private Mbb.Windows.Forms.RadioButton creditorStatusRadioButton;
		private Mbb.Windows.Forms.RadioButton debtorStatusRadioButton;
		private Mbb.Windows.Forms.GroupBox paymentTypeProupBox;
		private Mbb.Windows.Forms.RadioButton cardRadioButton;
		private Mbb.Windows.Forms.RadioButton chashAndCardRadioButton;
		private Mbb.Windows.Forms.RadioButton cashRradioButton;
		private Mbb.Windows.Forms.Button paymentAmountButton;
		private Mbb.Windows.Forms.Panel panel1;
		private Mbb.Windows.Forms.TextBox paymentAmountTextBox;
		private Bunifu.Framework.UI.BunifuElipse clientAccountStatusFormBunifuElipse;
	}
}