namespace HOOKAH_SALON.Setting.User
{
	partial class LoginControlForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControlForm));
			this.loginControlLisPanel = new Mbb.Windows.Forms.Panel();
			this.loginControlDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.searchPanel = new Mbb.Windows.Forms.Panel();
			this.printButton = new Mbb.Windows.Forms.Button();
			this.searchPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.userSearchPanel = new Mbb.Windows.Forms.Panel();
			this.userSearchTextBox = new Mbb.Windows.Forms.TextBox();
			this.logHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginControlLisPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.loginControlDataGridView)).BeginInit();
			this.searchPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logHistoryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// loginControlLisPanel
			// 
			this.loginControlLisPanel.Controls.Add(this.loginControlDataGridView);
			this.loginControlLisPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loginControlLisPanel.Location = new System.Drawing.Point(0, 55);
			this.loginControlLisPanel.Name = "loginControlLisPanel";
			this.loginControlLisPanel.Size = new System.Drawing.Size(1050, 300);
			this.loginControlLisPanel.TabIndex = 0;
			// 
			// loginControlDataGridView
			// 
			this.loginControlDataGridView.AllowUserToAddRows = false;
			this.loginControlDataGridView.AllowUserToDeleteRows = false;
			this.loginControlDataGridView.AllowUserToResizeColumns = false;
			this.loginControlDataGridView.AllowUserToResizeRows = false;
			this.loginControlDataGridView.AutoGenerateColumns = false;
			this.loginControlDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.loginControlDataGridView.BackgroundColor = System.Drawing.Color.Gray;
			this.loginControlDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.loginControlDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.loginControlDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.loginControlDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.loginControlDataGridView.ColumnHeadersHeight = 30;
			this.loginControlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.loginControlDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.usernameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.loginControlDataGridView.DataSource = this.logHistoryBindingSource;
			this.loginControlDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loginControlDataGridView.EnableHeadersVisualStyles = false;
			this.loginControlDataGridView.Location = new System.Drawing.Point(0, 0);
			this.loginControlDataGridView.Name = "loginControlDataGridView";
			this.loginControlDataGridView.ReadOnly = true;
			this.loginControlDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.loginControlDataGridView.RowHeadersVisible = false;
			this.loginControlDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSansFaNum", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			this.loginControlDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.loginControlDataGridView.RowTemplate.Height = 25;
			this.loginControlDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.loginControlDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.loginControlDataGridView.Size = new System.Drawing.Size(1050, 300);
			this.loginControlDataGridView.TabIndex = 2;
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
			this.searchPanel.TabIndex = 4;
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
			this.userSearchPanel.BackColor = System.Drawing.Color.Black;
			this.userSearchPanel.Location = new System.Drawing.Point(757, 42);
			this.userSearchPanel.Name = "userSearchPanel";
			this.userSearchPanel.Size = new System.Drawing.Size(280, 1);
			this.userSearchPanel.TabIndex = 1;
			// 
			// userSearchTextBox
			// 
			this.userSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userSearchTextBox.BackColor = System.Drawing.Color.Gray;
			this.userSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.userSearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
			// logHistoryBindingSource
			// 
			this.logHistoryBindingSource.DataSource = typeof(Models.LogHistory);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Full_Name";
			this.dataGridViewTextBoxColumn1.HeaderText = "نام و نام خانوادگی";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// usernameDataGridViewTextBoxColumn
			// 
			this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
			this.usernameDataGridViewTextBoxColumn.HeaderText = "شناسه کاربری";
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Login_Time";
			this.dataGridViewTextBoxColumn2.HeaderText = "زمان و تاریخ ورود";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Logout_Time";
			this.dataGridViewTextBoxColumn3.HeaderText = "زمان و تاریخ خروج";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// LoginControlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(1050, 355);
			this.Controls.Add(this.loginControlLisPanel);
			this.Controls.Add(this.searchPanel);
			this.Name = "LoginControlForm";
			this.Text = "LoginControlForm";
			this.Load += new System.EventHandler(this.LoginControlForm_Load);
			this.loginControlLisPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.loginControlDataGridView)).EndInit();
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logHistoryBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Mbb.Windows.Forms.Panel loginControlLisPanel;
		private Mbb.Windows.Forms.Panel searchPanel;
		private Mbb.Windows.Forms.PicturBox searchPicturBox;
		private Mbb.Windows.Forms.Panel userSearchPanel;
		private Mbb.Windows.Forms.TextBox userSearchTextBox;
		private Mbb.Windows.Forms.Button printButton;
		private Mbb.Windows.Forms.DataGridView loginControlDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn logoutTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.BindingSource logHistoryBindingSource;
	}
}