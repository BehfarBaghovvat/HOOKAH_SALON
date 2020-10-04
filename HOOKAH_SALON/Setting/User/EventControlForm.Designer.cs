namespace HOOKAH_SALON.Setting.User
{
	partial class EventControlForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventControlForm));
			this.actionsControlLisPanel = new Mbb.Windows.Forms.Panel();
			this.eventControlDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.searchPanel = new Mbb.Windows.Forms.Panel();
			this.printButton = new Mbb.Windows.Forms.Button();
			this.searchPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.userSearchPanel = new Mbb.Windows.Forms.Panel();
			this.userSearchTextBox = new Mbb.Windows.Forms.TextBox();
			this.eventLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eventTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.actionsControlLisPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.eventControlDataGridView)).BeginInit();
			this.searchPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eventLogBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// actionsControlLisPanel
			// 
			this.actionsControlLisPanel.Controls.Add(this.eventControlDataGridView);
			this.actionsControlLisPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.actionsControlLisPanel.Location = new System.Drawing.Point(0, 55);
			this.actionsControlLisPanel.Name = "actionsControlLisPanel";
			this.actionsControlLisPanel.Size = new System.Drawing.Size(1050, 300);
			this.actionsControlLisPanel.TabIndex = 5;
			// 
			// eventControlDataGridView
			// 
			this.eventControlDataGridView.AllowUserToAddRows = false;
			this.eventControlDataGridView.AllowUserToDeleteRows = false;
			this.eventControlDataGridView.AllowUserToResizeColumns = false;
			this.eventControlDataGridView.AllowUserToResizeRows = false;
			this.eventControlDataGridView.AutoGenerateColumns = false;
			this.eventControlDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.eventControlDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.eventControlDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.eventControlDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.eventControlDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.eventControlDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.eventControlDataGridView.ColumnHeadersHeight = 30;
			this.eventControlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.eventControlDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.eventTitleDataGridViewTextBoxColumn});
			this.eventControlDataGridView.DataSource = this.eventLogBindingSource;
			this.eventControlDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.eventControlDataGridView.EnableHeadersVisualStyles = false;
			this.eventControlDataGridView.Location = new System.Drawing.Point(0, 0);
			this.eventControlDataGridView.Name = "eventControlDataGridView";
			this.eventControlDataGridView.ReadOnly = true;
			this.eventControlDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.eventControlDataGridView.RowHeadersVisible = false;
			this.eventControlDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansFaNum", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			this.eventControlDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.eventControlDataGridView.RowTemplate.Height = 25;
			this.eventControlDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.eventControlDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.eventControlDataGridView.Size = new System.Drawing.Size(1050, 300);
			this.eventControlDataGridView.TabIndex = 1;
			// 
			// searchPanel
			// 
			this.searchPanel.BackColor = System.Drawing.Color.Transparent;
			this.searchPanel.Controls.Add(this.printButton);
			this.searchPanel.Controls.Add(this.searchPicturBox);
			this.searchPanel.Controls.Add(this.userSearchPanel);
			this.searchPanel.Controls.Add(this.userSearchTextBox);
			this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.searchPanel.Location = new System.Drawing.Point(0, 0);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(1050, 55);
			this.searchPanel.TabIndex = 6;
			// 
			// printButton
			// 
			this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.printButton.FlatAppearance.BorderSize = 0;
			this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.printButton.Image = ((System.Drawing.Image)(resources.GetObject("printButton.Image")));
			this.printButton.Location = new System.Drawing.Point(12, 24);
			this.printButton.Name = "printButton";
			this.printButton.Size = new System.Drawing.Size(25, 25);
			this.printButton.TabIndex = 3;
			this.printButton.UseVisualStyleBackColor = true;
			this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// searchPicturBox
			// 
			this.searchPicturBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchPicturBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchPicturBox.BackgroundImage")));
			this.searchPicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.searchPicturBox.Location = new System.Drawing.Point(1013, 11);
			this.searchPicturBox.Name = "searchPicturBox";
			this.searchPicturBox.Size = new System.Drawing.Size(25, 25);
			this.searchPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.searchPicturBox.TabIndex = 2;
			this.searchPicturBox.TabStop = false;
			// 
			// userSearchPanel
			// 
			this.userSearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userSearchPanel.BackColor = System.Drawing.Color.Gray;
			this.userSearchPanel.Location = new System.Drawing.Point(757, 42);
			this.userSearchPanel.Name = "userSearchPanel";
			this.userSearchPanel.Size = new System.Drawing.Size(280, 1);
			this.userSearchPanel.TabIndex = 1;
			// 
			// userSearchTextBox
			// 
			this.userSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.userSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.userSearchTextBox.ForeColor = System.Drawing.Color.Gray;
			this.userSearchTextBox.Location = new System.Drawing.Point(757, 15);
			this.userSearchTextBox.Name = "userSearchTextBox";
			this.userSearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.userSearchTextBox.Size = new System.Drawing.Size(250, 17);
			this.userSearchTextBox.TabIndex = 0;
			this.userSearchTextBox.Text = "جستجوی کاربر...";
			this.userSearchTextBox.TextChanged += new System.EventHandler(this.UserSearchTextBox_TextChanged);
			this.userSearchTextBox.Enter += new System.EventHandler(this.UserSearchTextBox_Enter);
			this.userSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserSearchTextBox_KeyPress);
			this.userSearchTextBox.Leave += new System.EventHandler(this.UserSearchTextBox_Leave);
			// 
			// eventLogBindingSource
			// 
			this.eventLogBindingSource.DataSource = typeof(Models.EventLog);
			// 
			// usernameDataGridViewTextBoxColumn
			// 
			this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
			this.usernameDataGridViewTextBoxColumn.HeaderText = "شناسه کاربری";
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// eventDateDataGridViewTextBoxColumn
			// 
			this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "Event_Date";
			this.eventDateDataGridViewTextBoxColumn.HeaderText = "تاریخ رخداد";
			this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
			this.eventDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// eventTitleDataGridViewTextBoxColumn
			// 
			this.eventTitleDataGridViewTextBoxColumn.DataPropertyName = "Event_Title";
			this.eventTitleDataGridViewTextBoxColumn.HeaderText = "عنوان رخداد";
			this.eventTitleDataGridViewTextBoxColumn.Name = "eventTitleDataGridViewTextBoxColumn";
			this.eventTitleDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// EventControlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1050, 355);
			this.Controls.Add(this.actionsControlLisPanel);
			this.Controls.Add(this.searchPanel);
			this.Name = "EventControlForm";
			this.Text = "ActionsControlForm";
			this.Load += new System.EventHandler(this.EventControlForm_Load);
			this.actionsControlLisPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.eventControlDataGridView)).EndInit();
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eventLogBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel actionsControlLisPanel;
		private Mbb.Windows.Forms.DataGridView eventControlDataGridView;
		private Mbb.Windows.Forms.Panel searchPanel;
		private Mbb.Windows.Forms.Button printButton;
		private Mbb.Windows.Forms.PicturBox searchPicturBox;
		private Mbb.Windows.Forms.Panel userSearchPanel;
		private Mbb.Windows.Forms.TextBox userSearchTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn eventRegistrationDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn eventDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn eventTitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource eventLogBindingSource;
	}
}