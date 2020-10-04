namespace HOOKAH_SALON.Store
{
	partial class FoodStoreFrom
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodStoreFrom));
			this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.foodStoreDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.registerTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.updateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.foodStorePanel = new Mbb.Windows.Forms.Panel();
			this.foodSearchPanel = new Mbb.Windows.Forms.Panel();
			this.foodSearchTextBox = new Mbb.Windows.Forms.TextBox();
			this.deleteRecordButton = new Mbb.Windows.Forms.Button();
			this.searchPanel = new Mbb.Windows.Forms.Panel();
			this.titelPanel = new Mbb.Windows.Forms.Panel();
			this.foodStoreTitleLabel = new Mbb.Windows.Forms.Label();
			this.minimizButton = new Mbb.Windows.Forms.Button();
			this.foodLogoPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.allClearButton = new Mbb.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foodStoreDataGridView)).BeginInit();
			this.foodStorePanel.SuspendLayout();
			this.searchPanel.SuspendLayout();
			this.titelPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.foodLogoPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// foodBindingSource
			// 
			this.foodBindingSource.DataSource = typeof(Models.Food);
			// 
			// foodStoreDataGridView
			// 
			this.foodStoreDataGridView.AllowUserToAddRows = false;
			this.foodStoreDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.foodStoreDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.foodStoreDataGridView.AutoGenerateColumns = false;
			this.foodStoreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.foodStoreDataGridView.BackgroundColor = System.Drawing.Color.SeaGreen;
			this.foodStoreDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.foodStoreDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.foodStoreDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.foodStoreDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.foodStoreDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.foodStoreDataGridView.ColumnHeadersHeight = 30;
			this.foodStoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.foodStoreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodNameDataGridViewTextBoxColumn,
            this.foodPriceDataGridViewTextBoxColumn,
            this.foodDescriptionDataGridViewTextBoxColumn,
            this.updateTimeDataGridViewTextBoxColumn,
            this.numberUpdateDataGridViewTextBoxColumn,
            this.registerTimeDataGridViewTextBoxColumn});
			this.foodStoreDataGridView.DataSource = this.foodBindingSource;
			this.foodStoreDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.foodStoreDataGridView.EnableHeadersVisualStyles = false;
			this.foodStoreDataGridView.Location = new System.Drawing.Point(0, 6);
			this.foodStoreDataGridView.MultiSelect = false;
			this.foodStoreDataGridView.Name = "foodStoreDataGridView";
			this.foodStoreDataGridView.ReadOnly = true;
			this.foodStoreDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.foodStoreDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.foodStoreDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.foodStoreDataGridView.RowHeadersVisible = false;
			this.foodStoreDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Green;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
			this.foodStoreDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.foodStoreDataGridView.RowTemplate.ReadOnly = true;
			this.foodStoreDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.foodStoreDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.foodStoreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.foodStoreDataGridView.Size = new System.Drawing.Size(980, 319);
			this.foodStoreDataGridView.TabIndex = 0;
			this.foodStoreDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodStoreDataGridView_CellDoubleClick);
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
			// foodDescriptionDataGridViewTextBoxColumn
			// 
			this.foodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FoodDescription";
			this.foodDescriptionDataGridViewTextBoxColumn.HeaderText = "توضیحات";
			this.foodDescriptionDataGridViewTextBoxColumn.Name = "foodDescriptionDataGridViewTextBoxColumn";
			this.foodDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// foodPriceDataGridViewTextBoxColumn
			// 
			this.foodPriceDataGridViewTextBoxColumn.DataPropertyName = "FoodPrice";
			this.foodPriceDataGridViewTextBoxColumn.HeaderText = "مبلغ غذا";
			this.foodPriceDataGridViewTextBoxColumn.Name = "foodPriceDataGridViewTextBoxColumn";
			this.foodPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// foodNameDataGridViewTextBoxColumn
			// 
			this.foodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName";
			this.foodNameDataGridViewTextBoxColumn.HeaderText = "نام غذا";
			this.foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
			this.foodNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// foodStorePanel
			// 
			this.foodStorePanel.Controls.Add(this.foodStoreDataGridView);
			this.foodStorePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.foodStorePanel.Location = new System.Drawing.Point(0, 75);
			this.foodStorePanel.Name = "foodStorePanel";
			this.foodStorePanel.Size = new System.Drawing.Size(980, 325);
			this.foodStorePanel.TabIndex = 8;
			// 
			// foodSearchPanel
			// 
			this.foodSearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.foodSearchPanel.BackColor = System.Drawing.Color.Black;
			this.foodSearchPanel.Location = new System.Drawing.Point(618, 37);
			this.foodSearchPanel.Name = "foodSearchPanel";
			this.foodSearchPanel.Size = new System.Drawing.Size(350, 2);
			this.foodSearchPanel.TabIndex = 0;
			// 
			// foodSearchTextBox
			// 
			this.foodSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.foodSearchTextBox.BackColor = System.Drawing.Color.SeaGreen;
			this.foodSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.foodSearchTextBox.ForeColor = System.Drawing.Color.Black;
			this.foodSearchTextBox.Location = new System.Drawing.Point(618, 14);
			this.foodSearchTextBox.MaxLength = 30;
			this.foodSearchTextBox.Name = "foodSearchTextBox";
			this.foodSearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.foodSearchTextBox.Size = new System.Drawing.Size(350, 17);
			this.foodSearchTextBox.TabIndex = 0;
			this.foodSearchTextBox.Text = "جستجوی کالا...";
			this.foodSearchTextBox.TextChanged += new System.EventHandler(this.FoodSearchTextBox_TextChanged);
			this.foodSearchTextBox.Enter += new System.EventHandler(this.FoodSearchTextBox_Enter);
			this.foodSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodSearchTextBox_KeyPress);
			this.foodSearchTextBox.Leave += new System.EventHandler(this.FoodSearchTextBox_Leave);
			// 
			// deleteRecordButton
			// 
			this.deleteRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.deleteRecordButton.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.deleteRecordButton.FlatAppearance.BorderSize = 0;
			this.deleteRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteRecordButton.Location = new System.Drawing.Point(12, 16);
			this.deleteRecordButton.Name = "deleteRecordButton";
			this.deleteRecordButton.Size = new System.Drawing.Size(90, 23);
			this.deleteRecordButton.TabIndex = 1;
			this.deleteRecordButton.Text = "حذف &رکورد";
			this.deleteRecordButton.UseVisualStyleBackColor = false;
			this.deleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
			// 
			// searchPanel
			// 
			this.searchPanel.Controls.Add(this.allClearButton);
			this.searchPanel.Controls.Add(this.deleteRecordButton);
			this.searchPanel.Controls.Add(this.foodSearchTextBox);
			this.searchPanel.Controls.Add(this.foodSearchPanel);
			this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchPanel.ForeColor = System.Drawing.Color.White;
			this.searchPanel.Location = new System.Drawing.Point(0, 30);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(980, 45);
			this.searchPanel.TabIndex = 9;
			// 
			// titelPanel
			// 
			this.titelPanel.Controls.Add(this.foodStoreTitleLabel);
			this.titelPanel.Controls.Add(this.minimizButton);
			this.titelPanel.Controls.Add(this.foodLogoPicturBox);
			this.titelPanel.Controls.Add(this.closeButton);
			this.titelPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titelPanel.Location = new System.Drawing.Point(0, 0);
			this.titelPanel.Name = "titelPanel";
			this.titelPanel.Size = new System.Drawing.Size(980, 30);
			this.titelPanel.TabIndex = 10;
			// 
			// foodStoreTitleLabel
			// 
			this.foodStoreTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.foodStoreTitleLabel.AutoSize = true;
			this.foodStoreTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.foodStoreTitleLabel.ForeColor = System.Drawing.Color.White;
			this.foodStoreTitleLabel.Location = new System.Drawing.Point(881, 7);
			this.foodStoreTitleLabel.Name = "foodStoreTitleLabel";
			this.foodStoreTitleLabel.Size = new System.Drawing.Size(63, 17);
			this.foodStoreTitleLabel.TabIndex = 15;
			this.foodStoreTitleLabel.Text = "موجودی غذا";
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
			// 
			// foodLogoPicturBox
			// 
			this.foodLogoPicturBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.foodLogoPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("foodLogoPicturBox.Image")));
			this.foodLogoPicturBox.Location = new System.Drawing.Point(950, 0);
			this.foodLogoPicturBox.Name = "foodLogoPicturBox";
			this.foodLogoPicturBox.Size = new System.Drawing.Size(30, 30);
			this.foodLogoPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.foodLogoPicturBox.TabIndex = 14;
			this.foodLogoPicturBox.TabStop = false;
			// 
			// closeButton
			// 
			this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
			this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
			// 
			// allClearButton
			// 
			this.allClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.allClearButton.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.allClearButton.FlatAppearance.BorderSize = 0;
			this.allClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.allClearButton.Location = new System.Drawing.Point(108, 16);
			this.allClearButton.Name = "allClearButton";
			this.allClearButton.Size = new System.Drawing.Size(90, 23);
			this.allClearButton.TabIndex = 2;
			this.allClearButton.Text = "حذف &رکورد";
			this.allClearButton.UseVisualStyleBackColor = false;
			this.allClearButton.Click += new System.EventHandler(this.AllClearButton_Click);
			// 
			// FoodStoreFrom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaGreen;
			this.ClientSize = new System.Drawing.Size(980, 400);
			this.Controls.Add(this.searchPanel);
			this.Controls.Add(this.titelPanel);
			this.Controls.Add(this.foodStorePanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(980, 400);
			this.MinimumSize = new System.Drawing.Size(980, 400);
			this.Name = "FoodStoreFrom";
			this.Text = "FoodStoreFrom";
			this.Load += new System.EventHandler(this.FoodStoreFrom_Load);
			((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foodStoreDataGridView)).EndInit();
			this.foodStorePanel.ResumeLayout(false);
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
			this.titelPanel.ResumeLayout(false);
			this.titelPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.foodLogoPicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource foodBindingSource;
		private Mbb.Windows.Forms.DataGridView foodStoreDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn foodPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn foodDescriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberUpdateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registerTimeDataGridViewTextBoxColumn;
		private Mbb.Windows.Forms.Panel foodStorePanel;
		private Mbb.Windows.Forms.Panel foodSearchPanel;
		private Mbb.Windows.Forms.TextBox foodSearchTextBox;
		private Mbb.Windows.Forms.Button deleteRecordButton;
		private Mbb.Windows.Forms.Panel searchPanel;
		private Mbb.Windows.Forms.Button allClearButton;
		private Mbb.Windows.Forms.Panel titelPanel;
		private Mbb.Windows.Forms.Label foodStoreTitleLabel;
		private Mbb.Windows.Forms.Button minimizButton;
		private Mbb.Windows.Forms.PicturBox foodLogoPicturBox;
		private Mbb.Windows.Forms.Button closeButton;
	}
}