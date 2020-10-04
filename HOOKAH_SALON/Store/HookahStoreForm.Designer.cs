namespace HOOKAH_SALON.Store
{
	partial class HookahStoreForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HookahStoreForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.titelPanel = new Mbb.Windows.Forms.Panel();
			this.hookahStoreTitleLabel = new Mbb.Windows.Forms.Label();
			this.minimizButton = new Mbb.Windows.Forms.Button();
			this.RegisterLogoPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.searchPanel = new Mbb.Windows.Forms.Panel();
			this.allClearButton = new Mbb.Windows.Forms.Button();
			this.deleteRecordButton = new Mbb.Windows.Forms.Button();
			this.hookahSearchTextBox = new Mbb.Windows.Forms.TextBox();
			this.hookahSearchPanel = new Mbb.Windows.Forms.Panel();
			this.hookahStorePanel = new Mbb.Windows.Forms.Panel();
			this.hookahBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.registerTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.updateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hookahImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.hookahDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hookahPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hookahNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hookahStoreDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.titelPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RegisterLogoPicturBox)).BeginInit();
			this.searchPanel.SuspendLayout();
			this.hookahStorePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.hookahBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hookahStoreDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// titelPanel
			// 
			this.titelPanel.Controls.Add(this.hookahStoreTitleLabel);
			this.titelPanel.Controls.Add(this.minimizButton);
			this.titelPanel.Controls.Add(this.RegisterLogoPicturBox);
			this.titelPanel.Controls.Add(this.closeButton);
			this.titelPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titelPanel.Location = new System.Drawing.Point(0, 0);
			this.titelPanel.Name = "titelPanel";
			this.titelPanel.Size = new System.Drawing.Size(980, 30);
			this.titelPanel.TabIndex = 0;
			// 
			// hookahStoreTitleLabel
			// 
			this.hookahStoreTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.hookahStoreTitleLabel.AutoSize = true;
			this.hookahStoreTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.hookahStoreTitleLabel.ForeColor = System.Drawing.Color.White;
			this.hookahStoreTitleLabel.Location = new System.Drawing.Point(873, 7);
			this.hookahStoreTitleLabel.Name = "hookahStoreTitleLabel";
			this.hookahStoreTitleLabel.Size = new System.Drawing.Size(71, 17);
			this.hookahStoreTitleLabel.TabIndex = 15;
			this.hookahStoreTitleLabel.Text = "موجودی قلیان";
			// 
			// minimizButton
			// 
			this.minimizButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizButton.BackgroundImage")));
			this.minimizButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.minimizButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.minimizButton.FlatAppearance.BorderSize = 0;
			this.minimizButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.minimizButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.minimizButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.minimizButton.Location = new System.Drawing.Point(50, 0);
			this.minimizButton.Name = "minimizButton";
			this.minimizButton.Size = new System.Drawing.Size(50, 30);
			this.minimizButton.TabIndex = 13;
			this.minimizButton.UseVisualStyleBackColor = true;
			this.minimizButton.Click += new System.EventHandler(this.MinimizButton_Click);
			// 
			// RegisterLogoPicturBox
			// 
			this.RegisterLogoPicturBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.RegisterLogoPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("RegisterLogoPicturBox.Image")));
			this.RegisterLogoPicturBox.Location = new System.Drawing.Point(950, 0);
			this.RegisterLogoPicturBox.Name = "RegisterLogoPicturBox";
			this.RegisterLogoPicturBox.Size = new System.Drawing.Size(30, 30);
			this.RegisterLogoPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.RegisterLogoPicturBox.TabIndex = 14;
			this.RegisterLogoPicturBox.TabStop = false;
			// 
			// closeButton
			// 
			this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
			this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.closeButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
			this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.closeButton.Location = new System.Drawing.Point(0, 0);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(50, 30);
			this.closeButton.TabIndex = 12;
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// searchPanel
			// 
			this.searchPanel.Controls.Add(this.allClearButton);
			this.searchPanel.Controls.Add(this.deleteRecordButton);
			this.searchPanel.Controls.Add(this.hookahSearchTextBox);
			this.searchPanel.Controls.Add(this.hookahSearchPanel);
			this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.searchPanel.Location = new System.Drawing.Point(0, 30);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(980, 45);
			this.searchPanel.TabIndex = 1;
			// 
			// allClearButton
			// 
			this.allClearButton.BackColor = System.Drawing.Color.LightSlateGray;
			this.allClearButton.FlatAppearance.BorderSize = 0;
			this.allClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.allClearButton.Location = new System.Drawing.Point(108, 16);
			this.allClearButton.Name = "allClearButton";
			this.allClearButton.Size = new System.Drawing.Size(90, 23);
			this.allClearButton.TabIndex = 2;
			this.allClearButton.Text = "حذف &کامل";
			this.allClearButton.UseCompatibleTextRendering = true;
			this.allClearButton.UseVisualStyleBackColor = false;
			this.allClearButton.Click += new System.EventHandler(this.AllClearButton_Click);
			// 
			// deleteRecordButton
			// 
			this.deleteRecordButton.BackColor = System.Drawing.Color.LightSlateGray;
			this.deleteRecordButton.FlatAppearance.BorderSize = 0;
			this.deleteRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteRecordButton.Location = new System.Drawing.Point(12, 16);
			this.deleteRecordButton.Name = "deleteRecordButton";
			this.deleteRecordButton.Size = new System.Drawing.Size(90, 23);
			this.deleteRecordButton.TabIndex = 1;
			this.deleteRecordButton.Text = "حذف &رکورد";
			this.deleteRecordButton.UseCompatibleTextRendering = true;
			this.deleteRecordButton.UseVisualStyleBackColor = false;
			this.deleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
			// 
			// hookahSearchTextBox
			// 
			this.hookahSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.hookahSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
			this.hookahSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hookahSearchTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.hookahSearchTextBox.Location = new System.Drawing.Point(618, 10);
			this.hookahSearchTextBox.MaxLength = 30;
			this.hookahSearchTextBox.Name = "hookahSearchTextBox";
			this.hookahSearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.hookahSearchTextBox.Size = new System.Drawing.Size(350, 17);
			this.hookahSearchTextBox.TabIndex = 0;
			this.hookahSearchTextBox.Text = "جستجوی کالا...";
			this.hookahSearchTextBox.TextChanged += new System.EventHandler(this.HookahSearchTextBox_TextChanged);
			this.hookahSearchTextBox.Enter += new System.EventHandler(this.HookahSearchTextBox_Enter);
			this.hookahSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HookahSearchTextBox_KeyPress);
			this.hookahSearchTextBox.Leave += new System.EventHandler(this.HookahSearchTextBox_Leave);
			// 
			// hookahSearchPanel
			// 
			this.hookahSearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.hookahSearchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hookahSearchPanel.Location = new System.Drawing.Point(618, 33);
			this.hookahSearchPanel.Name = "hookahSearchPanel";
			this.hookahSearchPanel.Size = new System.Drawing.Size(350, 2);
			this.hookahSearchPanel.TabIndex = 0;
			// 
			// hookahStorePanel
			// 
			this.hookahStorePanel.Controls.Add(this.hookahStoreDataGridView);
			this.hookahStorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hookahStorePanel.Location = new System.Drawing.Point(0, 75);
			this.hookahStorePanel.Name = "hookahStorePanel";
			this.hookahStorePanel.Size = new System.Drawing.Size(980, 325);
			this.hookahStorePanel.TabIndex = 2;
			// 
			// hookahBindingSource
			// 
			this.hookahBindingSource.DataSource = typeof(Models.Hookah);
			// 
			// registerTimeDataGridViewTextBoxColumn
			// 
			this.registerTimeDataGridViewTextBoxColumn.DataPropertyName = "RegisterTime";
			this.registerTimeDataGridViewTextBoxColumn.HeaderText = "زمان ثبت";
			this.registerTimeDataGridViewTextBoxColumn.Name = "registerTimeDataGridViewTextBoxColumn";
			this.registerTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// numberUpdateDataGridViewTextBoxColumn
			// 
			this.numberUpdateDataGridViewTextBoxColumn.DataPropertyName = "NumberUpdate";
			this.numberUpdateDataGridViewTextBoxColumn.HeaderText = "تعداد به روز رسانی";
			this.numberUpdateDataGridViewTextBoxColumn.Name = "numberUpdateDataGridViewTextBoxColumn";
			this.numberUpdateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// updateTimeDataGridViewTextBoxColumn
			// 
			this.updateTimeDataGridViewTextBoxColumn.DataPropertyName = "UpdateTime";
			this.updateTimeDataGridViewTextBoxColumn.HeaderText = "اخرین به روز رسانی";
			this.updateTimeDataGridViewTextBoxColumn.Name = "updateTimeDataGridViewTextBoxColumn";
			this.updateTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hookahImageDataGridViewImageColumn
			// 
			this.hookahImageDataGridViewImageColumn.DataPropertyName = "HookahImage";
			this.hookahImageDataGridViewImageColumn.HeaderText = "تصویر قلیان";
			this.hookahImageDataGridViewImageColumn.Name = "hookahImageDataGridViewImageColumn";
			this.hookahImageDataGridViewImageColumn.ReadOnly = true;
			// 
			// hookahDescriptionDataGridViewTextBoxColumn
			// 
			this.hookahDescriptionDataGridViewTextBoxColumn.DataPropertyName = "HookahDescription";
			this.hookahDescriptionDataGridViewTextBoxColumn.HeaderText = "توضیحات";
			this.hookahDescriptionDataGridViewTextBoxColumn.Name = "hookahDescriptionDataGridViewTextBoxColumn";
			this.hookahDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hookahPriceDataGridViewTextBoxColumn
			// 
			this.hookahPriceDataGridViewTextBoxColumn.DataPropertyName = "HookahPrice";
			this.hookahPriceDataGridViewTextBoxColumn.HeaderText = "مبلغ قلیان";
			this.hookahPriceDataGridViewTextBoxColumn.Name = "hookahPriceDataGridViewTextBoxColumn";
			this.hookahPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hookahNameDataGridViewTextBoxColumn
			// 
			this.hookahNameDataGridViewTextBoxColumn.DataPropertyName = "HookahName";
			this.hookahNameDataGridViewTextBoxColumn.HeaderText = "نام قلیان";
			this.hookahNameDataGridViewTextBoxColumn.Name = "hookahNameDataGridViewTextBoxColumn";
			this.hookahNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hookahStoreDataGridView
			// 
			this.hookahStoreDataGridView.AllowUserToAddRows = false;
			this.hookahStoreDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.hookahStoreDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.hookahStoreDataGridView.AutoGenerateColumns = false;
			this.hookahStoreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.hookahStoreDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
			this.hookahStoreDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hookahStoreDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.hookahStoreDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.hookahStoreDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.hookahStoreDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.hookahStoreDataGridView.ColumnHeadersHeight = 30;
			this.hookahStoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.hookahStoreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hookahNameDataGridViewTextBoxColumn,
            this.hookahPriceDataGridViewTextBoxColumn,
            this.hookahDescriptionDataGridViewTextBoxColumn,
            this.hookahImageDataGridViewImageColumn,
            this.updateTimeDataGridViewTextBoxColumn,
            this.numberUpdateDataGridViewTextBoxColumn,
            this.registerTimeDataGridViewTextBoxColumn});
			this.hookahStoreDataGridView.DataSource = this.hookahBindingSource;
			this.hookahStoreDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.hookahStoreDataGridView.EnableHeadersVisualStyles = false;
			this.hookahStoreDataGridView.Location = new System.Drawing.Point(0, 6);
			this.hookahStoreDataGridView.MultiSelect = false;
			this.hookahStoreDataGridView.Name = "hookahStoreDataGridView";
			this.hookahStoreDataGridView.ReadOnly = true;
			this.hookahStoreDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.hookahStoreDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Purple;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.hookahStoreDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.hookahStoreDataGridView.RowHeadersVisible = false;
			this.hookahStoreDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.BlueViolet;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			this.hookahStoreDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.hookahStoreDataGridView.RowTemplate.ReadOnly = true;
			this.hookahStoreDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.hookahStoreDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.hookahStoreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.hookahStoreDataGridView.Size = new System.Drawing.Size(980, 319);
			this.hookahStoreDataGridView.TabIndex = 0;
			this.hookahStoreDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HookahStoreDataGridView_CellDoubleClick);
			// 
			// HookahStoreForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
			this.ClientSize = new System.Drawing.Size(980, 400);
			this.Controls.Add(this.hookahStorePanel);
			this.Controls.Add(this.searchPanel);
			this.Controls.Add(this.titelPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(980, 400);
			this.MinimumSize = new System.Drawing.Size(980, 400);
			this.Name = "HookahStoreForm";
			this.Text = "HookahStoreForm";
			this.Load += new System.EventHandler(this.HookahStoreForm_Load);
			this.titelPanel.ResumeLayout(false);
			this.titelPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RegisterLogoPicturBox)).EndInit();
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
			this.hookahStorePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.hookahBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hookahStoreDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel titelPanel;
		private Mbb.Windows.Forms.Button minimizButton;
		private Mbb.Windows.Forms.PicturBox RegisterLogoPicturBox;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Label hookahStoreTitleLabel;
		private Mbb.Windows.Forms.Panel searchPanel;
		private Mbb.Windows.Forms.TextBox hookahSearchTextBox;
		private Mbb.Windows.Forms.Panel hookahSearchPanel;
		private Mbb.Windows.Forms.Panel hookahStorePanel;
		private System.Windows.Forms.BindingSource hookahBindingSource;
		private Mbb.Windows.Forms.Button deleteRecordButton;
		private Mbb.Windows.Forms.Button allClearButton;
		private Mbb.Windows.Forms.DataGridView hookahStoreDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn hookahNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hookahPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hookahDescriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn hookahImageDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberUpdateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registerTimeDataGridViewTextBoxColumn;
	}
}