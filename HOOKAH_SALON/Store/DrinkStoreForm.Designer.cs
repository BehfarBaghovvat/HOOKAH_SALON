namespace HOOKAH_SALON.Store
{
	partial class DrinkStoreForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkStoreForm));
			this.drinkStoreDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.drinkNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.drinkPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.drinkDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.updateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registerTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.drinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.drinkStorePanel = new Mbb.Windows.Forms.Panel();
			this.drinkStoreTitleLabel = new Mbb.Windows.Forms.Label();
			this.titelPanel = new Mbb.Windows.Forms.Panel();
			this.minimizButton = new Mbb.Windows.Forms.Button();
			this.drinkLogoPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.searchPanel = new Mbb.Windows.Forms.Panel();
			this.allClearButton = new Mbb.Windows.Forms.Button();
			this.deleteRecordButton = new Mbb.Windows.Forms.Button();
			this.drinkSearchTextBox = new Mbb.Windows.Forms.TextBox();
			this.drinkSearchPanel = new Mbb.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.drinkStoreDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.drinkBindingSource)).BeginInit();
			this.drinkStorePanel.SuspendLayout();
			this.titelPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.drinkLogoPicturBox)).BeginInit();
			this.searchPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// drinkStoreDataGridView
			// 
			this.drinkStoreDataGridView.AllowUserToAddRows = false;
			this.drinkStoreDataGridView.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.drinkStoreDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.drinkStoreDataGridView.AutoGenerateColumns = false;
			this.drinkStoreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.drinkStoreDataGridView.BackgroundColor = System.Drawing.Color.LightCoral;
			this.drinkStoreDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.drinkStoreDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.drinkStoreDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.drinkStoreDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.drinkStoreDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.drinkStoreDataGridView.ColumnHeadersHeight = 30;
			this.drinkStoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.drinkStoreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drinkNameDataGridViewTextBoxColumn,
            this.drinkPriceDataGridViewTextBoxColumn,
            this.drinkDescriptionDataGridViewTextBoxColumn,
            this.updateTimeDataGridViewTextBoxColumn,
            this.numberUpdateDataGridViewTextBoxColumn,
            this.registerTimeDataGridViewTextBoxColumn});
			this.drinkStoreDataGridView.DataSource = this.drinkBindingSource;
			this.drinkStoreDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.drinkStoreDataGridView.EnableHeadersVisualStyles = false;
			this.drinkStoreDataGridView.Location = new System.Drawing.Point(0, 6);
			this.drinkStoreDataGridView.MultiSelect = false;
			this.drinkStoreDataGridView.Name = "drinkStoreDataGridView";
			this.drinkStoreDataGridView.ReadOnly = true;
			this.drinkStoreDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.drinkStoreDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.drinkStoreDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.drinkStoreDataGridView.RowHeadersVisible = false;
			this.drinkStoreDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Purple;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			this.drinkStoreDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.drinkStoreDataGridView.RowTemplate.ReadOnly = true;
			this.drinkStoreDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.drinkStoreDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.drinkStoreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.drinkStoreDataGridView.Size = new System.Drawing.Size(980, 319);
			this.drinkStoreDataGridView.TabIndex = 0;
			this.drinkStoreDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DrinkStoreDataGridView_CellDoubleClick);
			// 
			// drinkNameDataGridViewTextBoxColumn
			// 
			this.drinkNameDataGridViewTextBoxColumn.DataPropertyName = "DrinkName";
			this.drinkNameDataGridViewTextBoxColumn.HeaderText = "نام نوشیدنی";
			this.drinkNameDataGridViewTextBoxColumn.Name = "drinkNameDataGridViewTextBoxColumn";
			this.drinkNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// drinkPriceDataGridViewTextBoxColumn
			// 
			this.drinkPriceDataGridViewTextBoxColumn.DataPropertyName = "DrinkPrice";
			this.drinkPriceDataGridViewTextBoxColumn.HeaderText = " مبلغ نوشیدنی";
			this.drinkPriceDataGridViewTextBoxColumn.Name = "drinkPriceDataGridViewTextBoxColumn";
			this.drinkPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// drinkDescriptionDataGridViewTextBoxColumn
			// 
			this.drinkDescriptionDataGridViewTextBoxColumn.DataPropertyName = "DrinkDescription";
			this.drinkDescriptionDataGridViewTextBoxColumn.HeaderText = "توضیحات";
			this.drinkDescriptionDataGridViewTextBoxColumn.Name = "drinkDescriptionDataGridViewTextBoxColumn";
			this.drinkDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// updateTimeDataGridViewTextBoxColumn
			// 
			this.updateTimeDataGridViewTextBoxColumn.DataPropertyName = "UpdateTime";
			this.updateTimeDataGridViewTextBoxColumn.HeaderText = "اخرین به روز رسانی";
			this.updateTimeDataGridViewTextBoxColumn.Name = "updateTimeDataGridViewTextBoxColumn";
			this.updateTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// numberUpdateDataGridViewTextBoxColumn
			// 
			this.numberUpdateDataGridViewTextBoxColumn.DataPropertyName = "NumberUpdate";
			this.numberUpdateDataGridViewTextBoxColumn.HeaderText = "تعداد به روز رسانی";
			this.numberUpdateDataGridViewTextBoxColumn.Name = "numberUpdateDataGridViewTextBoxColumn";
			this.numberUpdateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// registerTimeDataGridViewTextBoxColumn
			// 
			this.registerTimeDataGridViewTextBoxColumn.DataPropertyName = "RegisterTime";
			this.registerTimeDataGridViewTextBoxColumn.HeaderText = "زمان ثبت";
			this.registerTimeDataGridViewTextBoxColumn.Name = "registerTimeDataGridViewTextBoxColumn";
			this.registerTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// drinkBindingSource
			// 
			this.drinkBindingSource.DataSource = typeof(Models.Drink);
			// 
			// drinkStorePanel
			// 
			this.drinkStorePanel.Controls.Add(this.drinkStoreDataGridView);
			this.drinkStorePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.drinkStorePanel.Location = new System.Drawing.Point(0, 75);
			this.drinkStorePanel.Name = "drinkStorePanel";
			this.drinkStorePanel.Size = new System.Drawing.Size(980, 325);
			this.drinkStorePanel.TabIndex = 5;
			// 
			// drinkStoreTitleLabel
			// 
			this.drinkStoreTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.drinkStoreTitleLabel.AutoSize = true;
			this.drinkStoreTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.drinkStoreTitleLabel.ForeColor = System.Drawing.Color.White;
			this.drinkStoreTitleLabel.Location = new System.Drawing.Point(858, 7);
			this.drinkStoreTitleLabel.Name = "drinkStoreTitleLabel";
			this.drinkStoreTitleLabel.Size = new System.Drawing.Size(86, 17);
			this.drinkStoreTitleLabel.TabIndex = 15;
			this.drinkStoreTitleLabel.Text = "موجودی نوشیدنی";
			// 
			// titelPanel
			// 
			this.titelPanel.Controls.Add(this.drinkStoreTitleLabel);
			this.titelPanel.Controls.Add(this.minimizButton);
			this.titelPanel.Controls.Add(this.drinkLogoPicturBox);
			this.titelPanel.Controls.Add(this.closeButton);
			this.titelPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titelPanel.Location = new System.Drawing.Point(0, 0);
			this.titelPanel.Name = "titelPanel";
			this.titelPanel.Size = new System.Drawing.Size(980, 30);
			this.titelPanel.TabIndex = 3;
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
			// drinkLogoPicturBox
			// 
			this.drinkLogoPicturBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.drinkLogoPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("drinkLogoPicturBox.Image")));
			this.drinkLogoPicturBox.Location = new System.Drawing.Point(950, 0);
			this.drinkLogoPicturBox.Name = "drinkLogoPicturBox";
			this.drinkLogoPicturBox.Size = new System.Drawing.Size(30, 30);
			this.drinkLogoPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.drinkLogoPicturBox.TabIndex = 14;
			this.drinkLogoPicturBox.TabStop = false;
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
			this.searchPanel.Controls.Add(this.drinkSearchTextBox);
			this.searchPanel.Controls.Add(this.drinkSearchPanel);
			this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.searchPanel.Location = new System.Drawing.Point(0, 30);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(980, 45);
			this.searchPanel.TabIndex = 6;
			// 
			// allClearButton
			// 
			this.allClearButton.BackColor = System.Drawing.Color.DarkRed;
			this.allClearButton.FlatAppearance.BorderSize = 0;
			this.allClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.allClearButton.ForeColor = System.Drawing.Color.White;
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
			this.deleteRecordButton.BackColor = System.Drawing.Color.DarkRed;
			this.deleteRecordButton.FlatAppearance.BorderSize = 0;
			this.deleteRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteRecordButton.ForeColor = System.Drawing.Color.White;
			this.deleteRecordButton.Location = new System.Drawing.Point(12, 16);
			this.deleteRecordButton.Name = "deleteRecordButton";
			this.deleteRecordButton.Size = new System.Drawing.Size(90, 23);
			this.deleteRecordButton.TabIndex = 1;
			this.deleteRecordButton.Text = "حذف &رکورد";
			this.deleteRecordButton.UseVisualStyleBackColor = false;
			this.deleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
			// 
			// drinkSearchTextBox
			// 
			this.drinkSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.drinkSearchTextBox.BackColor = System.Drawing.Color.LightCoral;
			this.drinkSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.drinkSearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.drinkSearchTextBox.Location = new System.Drawing.Point(618, 10);
			this.drinkSearchTextBox.MaxLength = 30;
			this.drinkSearchTextBox.Name = "drinkSearchTextBox";
			this.drinkSearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.drinkSearchTextBox.Size = new System.Drawing.Size(350, 17);
			this.drinkSearchTextBox.TabIndex = 0;
			this.drinkSearchTextBox.Text = "جستجوی کالا...";
			this.drinkSearchTextBox.TextChanged += new System.EventHandler(this.DrinkSearchTextBox_TextChanged);
			this.drinkSearchTextBox.Enter += new System.EventHandler(this.DrinkSearchTextBox_Enter);
			this.drinkSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrinkSearchTextBox_KeyPress);
			this.drinkSearchTextBox.Leave += new System.EventHandler(this.DrinkSearchTextBox_Leave);
			// 
			// drinkSearchPanel
			// 
			this.drinkSearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.drinkSearchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.drinkSearchPanel.Location = new System.Drawing.Point(618, 33);
			this.drinkSearchPanel.Name = "drinkSearchPanel";
			this.drinkSearchPanel.Size = new System.Drawing.Size(350, 2);
			this.drinkSearchPanel.TabIndex = 0;
			// 
			// DrinkStoreForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCoral;
			this.ClientSize = new System.Drawing.Size(980, 400);
			this.Controls.Add(this.searchPanel);
			this.Controls.Add(this.drinkStorePanel);
			this.Controls.Add(this.titelPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DrinkStoreForm";
			this.Text = "DrinkStoreForm";
			this.Load += new System.EventHandler(this.DrinkStoreForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.drinkStoreDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.drinkBindingSource)).EndInit();
			this.drinkStorePanel.ResumeLayout(false);
			this.titelPanel.ResumeLayout(false);
			this.titelPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.drinkLogoPicturBox)).EndInit();
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Mbb.Windows.Forms.DataGridView drinkStoreDataGridView;
		private Mbb.Windows.Forms.Panel drinkStorePanel;
		private Mbb.Windows.Forms.Label drinkStoreTitleLabel;
		private Mbb.Windows.Forms.Button minimizButton;
		private Mbb.Windows.Forms.PicturBox drinkLogoPicturBox;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Panel titelPanel;
		private Mbb.Windows.Forms.Panel searchPanel;
		private Mbb.Windows.Forms.TextBox drinkSearchTextBox;
		private Mbb.Windows.Forms.Panel drinkSearchPanel;
		private System.Windows.Forms.BindingSource drinkBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn drinkNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn drinkPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn drinkDescriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberUpdateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registerTimeDataGridViewTextBoxColumn;
		private Mbb.Windows.Forms.Button deleteRecordButton;
		private Mbb.Windows.Forms.Button allClearButton;
	}
}