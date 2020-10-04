namespace HOOKAH_SALON.Setting.Client
{
	partial class PermanentClientListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermanentClientListForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.topPanel = new Mbb.Windows.Forms.Panel();
			this.deletePermancentClientButton = new Mbb.Windows.Forms.Button();
			this.searchClientIDRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.seachClientNameRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.searchPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.searchClientPanel = new Mbb.Windows.Forms.Panel();
			this.searchClientTextBox = new Mbb.Windows.Forms.TextBox();
			this.clientAddButton = new Mbb.Windows.Forms.Button();
			this.permanentClientDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.permanentClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registerDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.permanentClientDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.permanentClientBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.deletePermancentClientButton);
			this.topPanel.Controls.Add(this.searchClientIDRadioButton);
			this.topPanel.Controls.Add(this.seachClientNameRadioButton);
			this.topPanel.Controls.Add(this.searchPicturBox);
			this.topPanel.Controls.Add(this.searchClientPanel);
			this.topPanel.Controls.Add(this.searchClientTextBox);
			this.topPanel.Controls.Add(this.clientAddButton);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(985, 60);
			this.topPanel.TabIndex = 11;
			// 
			// deletePermancentClientButton
			// 
			this.deletePermancentClientButton.BackColor = System.Drawing.Color.Gray;
			this.deletePermancentClientButton.FlatAppearance.BorderSize = 0;
			this.deletePermancentClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deletePermancentClientButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.deletePermancentClientButton.ForeColor = System.Drawing.Color.White;
			this.deletePermancentClientButton.Image = ((System.Drawing.Image)(resources.GetObject("deletePermancentClientButton.Image")));
			this.deletePermancentClientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.deletePermancentClientButton.Location = new System.Drawing.Point(157, 10);
			this.deletePermancentClientButton.Name = "deletePermancentClientButton";
			this.deletePermancentClientButton.Size = new System.Drawing.Size(139, 40);
			this.deletePermancentClientButton.TabIndex = 17;
			this.deletePermancentClientButton.Text = "حذف مشتری دائمی";
			this.deletePermancentClientButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.deletePermancentClientButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.deletePermancentClientButton.UseVisualStyleBackColor = false;
			this.deletePermancentClientButton.Click += new System.EventHandler(this.DeletePermancentClientButton_Click);
			// 
			// searchClientIDRadioButton
			// 
			this.searchClientIDRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchClientIDRadioButton.AutoSize = true;
			this.searchClientIDRadioButton.ForeColor = System.Drawing.Color.White;
			this.searchClientIDRadioButton.Location = new System.Drawing.Point(860, 3);
			this.searchClientIDRadioButton.Name = "searchClientIDRadioButton";
			this.searchClientIDRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.searchClientIDRadioButton.Size = new System.Drawing.Size(113, 21);
			this.searchClientIDRadioButton.TabIndex = 0;
			this.searchClientIDRadioButton.TabStop = true;
			this.searchClientIDRadioButton.Text = "جستجوی کد شناسه";
			this.searchClientIDRadioButton.UseVisualStyleBackColor = true;
			// 
			// seachClientNameRadioButton
			// 
			this.seachClientNameRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.seachClientNameRadioButton.AutoSize = true;
			this.seachClientNameRadioButton.ForeColor = System.Drawing.Color.White;
			this.seachClientNameRadioButton.Location = new System.Drawing.Point(735, 3);
			this.seachClientNameRadioButton.Name = "seachClientNameRadioButton";
			this.seachClientNameRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.seachClientNameRadioButton.Size = new System.Drawing.Size(119, 21);
			this.seachClientNameRadioButton.TabIndex = 1;
			this.seachClientNameRadioButton.TabStop = true;
			this.seachClientNameRadioButton.Text = "جستجوی نام مشتری";
			this.seachClientNameRadioButton.UseVisualStyleBackColor = true;
			// 
			// searchPicturBox
			// 
			this.searchPicturBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("searchPicturBox.Image")));
			this.searchPicturBox.Location = new System.Drawing.Point(953, 26);
			this.searchPicturBox.Name = "searchPicturBox";
			this.searchPicturBox.Size = new System.Drawing.Size(20, 20);
			this.searchPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.searchPicturBox.TabIndex = 16;
			this.searchPicturBox.TabStop = false;
			// 
			// searchClientPanel
			// 
			this.searchClientPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchClientPanel.BackColor = System.Drawing.Color.Gray;
			this.searchClientPanel.Location = new System.Drawing.Point(735, 52);
			this.searchClientPanel.Name = "searchClientPanel";
			this.searchClientPanel.Size = new System.Drawing.Size(238, 2);
			this.searchClientPanel.TabIndex = 15;
			// 
			// searchClientTextBox
			// 
			this.searchClientTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchClientTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.searchClientTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchClientTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.searchClientTextBox.ForeColor = System.Drawing.Color.Gray;
			this.searchClientTextBox.Location = new System.Drawing.Point(735, 26);
			this.searchClientTextBox.Name = "searchClientTextBox";
			this.searchClientTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.searchClientTextBox.Size = new System.Drawing.Size(212, 21);
			this.searchClientTextBox.TabIndex = 2;
			this.searchClientTextBox.Text = "جستجو...";
			// 
			// clientAddButton
			// 
			this.clientAddButton.BackColor = System.Drawing.Color.Gray;
			this.clientAddButton.FlatAppearance.BorderSize = 0;
			this.clientAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clientAddButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientAddButton.ForeColor = System.Drawing.Color.White;
			this.clientAddButton.Image = ((System.Drawing.Image)(resources.GetObject("clientAddButton.Image")));
			this.clientAddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.clientAddButton.Location = new System.Drawing.Point(12, 10);
			this.clientAddButton.Name = "clientAddButton";
			this.clientAddButton.Size = new System.Drawing.Size(139, 40);
			this.clientAddButton.TabIndex = 3;
			this.clientAddButton.Text = "افزودن مشتری دائمی";
			this.clientAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.clientAddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.clientAddButton.UseVisualStyleBackColor = false;
			this.clientAddButton.Click += new System.EventHandler(this.ClientAddButton_Click);
			// 
			// permanentClientDataGridView
			// 
			this.permanentClientDataGridView.AllowUserToAddRows = false;
			this.permanentClientDataGridView.AllowUserToDeleteRows = false;
			this.permanentClientDataGridView.AutoGenerateColumns = false;
			this.permanentClientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.permanentClientDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.permanentClientDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.permanentClientDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.permanentClientDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.permanentClientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.permanentClientDataGridView.ColumnHeadersHeight = 25;
			this.permanentClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.permanentClientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.numberOrderDataGridViewTextBoxColumn,
            this.lastOrderDataGridViewTextBoxColumn,
            this.registerDateDataGridViewTextBoxColumn,
            this.editDateDataGridViewTextBoxColumn});
			this.permanentClientDataGridView.DataSource = this.permanentClientBindingSource;
			this.permanentClientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.permanentClientDataGridView.EnableHeadersVisualStyles = false;
			this.permanentClientDataGridView.Location = new System.Drawing.Point(0, 60);
			this.permanentClientDataGridView.MultiSelect = false;
			this.permanentClientDataGridView.Name = "permanentClientDataGridView";
			this.permanentClientDataGridView.ReadOnly = true;
			this.permanentClientDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.permanentClientDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.permanentClientDataGridView.RowHeadersVisible = false;
			this.permanentClientDataGridView.RowHeadersWidth = 25;
			this.permanentClientDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			this.permanentClientDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.permanentClientDataGridView.RowTemplate.Height = 25;
			this.permanentClientDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.permanentClientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.permanentClientDataGridView.Size = new System.Drawing.Size(985, 260);
			this.permanentClientDataGridView.TabIndex = 12;
			this.permanentClientDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PermanentClientDataGridView_CellDoubleClick);
			// 
			// permanentClientBindingSource
			// 
			this.permanentClientBindingSource.DataSource = typeof(Models.PermanentClient);
			// 
			// clientIDDataGridViewTextBoxColumn
			// 
			this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
			this.clientIDDataGridViewTextBoxColumn.HeaderText = "شناسه مشتری";
			this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
			this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// numberOrderDataGridViewTextBoxColumn
			// 
			this.numberOrderDataGridViewTextBoxColumn.DataPropertyName = "Number_Order";
			this.numberOrderDataGridViewTextBoxColumn.HeaderText = "تعداد سفارش";
			this.numberOrderDataGridViewTextBoxColumn.Name = "numberOrderDataGridViewTextBoxColumn";
			this.numberOrderDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lastOrderDataGridViewTextBoxColumn
			// 
			this.lastOrderDataGridViewTextBoxColumn.DataPropertyName = "Last_Order";
			this.lastOrderDataGridViewTextBoxColumn.HeaderText = "اخرین آخرین سفارش";
			this.lastOrderDataGridViewTextBoxColumn.Name = "lastOrderDataGridViewTextBoxColumn";
			this.lastOrderDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// registerDateDataGridViewTextBoxColumn
			// 
			this.registerDateDataGridViewTextBoxColumn.DataPropertyName = "Register_Date";
			this.registerDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
			this.registerDateDataGridViewTextBoxColumn.Name = "registerDateDataGridViewTextBoxColumn";
			this.registerDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// editDateDataGridViewTextBoxColumn
			// 
			this.editDateDataGridViewTextBoxColumn.DataPropertyName = "Edit_Date";
			this.editDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ویرایش";
			this.editDateDataGridViewTextBoxColumn.Name = "editDateDataGridViewTextBoxColumn";
			this.editDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// PermanentClientListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(985, 320);
			this.Controls.Add(this.permanentClientDataGridView);
			this.Controls.Add(this.topPanel);
			this.Name = "PermanentClientListForm";
			this.Text = "RegularClientListForm";
			this.Load += new System.EventHandler(this.PermanentClientListForm_Load);
			this.topPanel.ResumeLayout(false);
			this.topPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.permanentClientDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.permanentClientBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Mbb.Windows.Forms.Panel topPanel;
		private Mbb.Windows.Forms.RadioButton searchClientIDRadioButton;
		private Mbb.Windows.Forms.RadioButton seachClientNameRadioButton;
		private Mbb.Windows.Forms.PicturBox searchPicturBox;
		private Mbb.Windows.Forms.Panel searchClientPanel;
		private Mbb.Windows.Forms.TextBox searchClientTextBox;
		private Mbb.Windows.Forms.Button clientAddButton;
		private Mbb.Windows.Forms.DataGridView permanentClientDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberVisitsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastVisitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registerTimeDataGridViewTextBoxColumn;
		private Mbb.Windows.Forms.Button deletePermancentClientButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberOrderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastOrderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registerDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn editDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource permanentClientBindingSource;
	}
}