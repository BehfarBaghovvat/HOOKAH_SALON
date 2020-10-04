namespace HOOKAH_SALON.Setting.User
{
	partial class UsersListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersListForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.usersStatusPanel = new Mbb.Windows.Forms.Panel();
			this.accessLevelGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.simpleUserRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.serviceForceRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.employeedRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.administratorRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.userImagePictureBox = new Mbb.Windows.Forms.CircularPictureBox();
			this.updateButton = new Mbb.Windows.Forms.Button();
			this.activationCheckBox = new Mbb.Windows.Forms.CheckBox();
			this.usenamePanel = new Mbb.Windows.Forms.Panel();
			this.usernameLabel = new Mbb.Windows.Forms.Label();
			this.searchPanel = new Mbb.Windows.Forms.Panel();
			this.searchPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.userSearchPanel = new Mbb.Windows.Forms.Panel();
			this.userSearchTextBox = new Mbb.Windows.Forms.TextBox();
			this.userListPanel = new Mbb.Windows.Forms.Panel();
			this.userListDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accessLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usersStatusPanel.SuspendLayout();
			this.accessLevelGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).BeginInit();
			this.searchPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchPicturBox)).BeginInit();
			this.userListPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userListDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// usersStatusPanel
			// 
			this.usersStatusPanel.BackColor = System.Drawing.Color.DimGray;
			this.usersStatusPanel.Controls.Add(this.accessLevelGroupBox);
			this.usersStatusPanel.Controls.Add(this.userImagePictureBox);
			this.usersStatusPanel.Controls.Add(this.updateButton);
			this.usersStatusPanel.Controls.Add(this.activationCheckBox);
			this.usersStatusPanel.Controls.Add(this.usenamePanel);
			this.usersStatusPanel.Controls.Add(this.usernameLabel);
			this.usersStatusPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.usersStatusPanel.Location = new System.Drawing.Point(750, 0);
			this.usersStatusPanel.Name = "usersStatusPanel";
			this.usersStatusPanel.Size = new System.Drawing.Size(300, 355);
			this.usersStatusPanel.TabIndex = 1;
			// 
			// accessLevelGroupBox
			// 
			this.accessLevelGroupBox.Controls.Add(this.simpleUserRadioButton);
			this.accessLevelGroupBox.Controls.Add(this.serviceForceRadioButton);
			this.accessLevelGroupBox.Controls.Add(this.employeedRadioButton);
			this.accessLevelGroupBox.Controls.Add(this.administratorRadioButton);
			this.accessLevelGroupBox.ForeColor = System.Drawing.Color.White;
			this.accessLevelGroupBox.Location = new System.Drawing.Point(6, 170);
			this.accessLevelGroupBox.Name = "accessLevelGroupBox";
			this.accessLevelGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.accessLevelGroupBox.Size = new System.Drawing.Size(282, 101);
			this.accessLevelGroupBox.TabIndex = 12;
			this.accessLevelGroupBox.TabStop = false;
			this.accessLevelGroupBox.Text = "سطح دسترسی";
			// 
			// simpleUserRadioButton
			// 
			this.simpleUserRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleUserRadioButton.AutoSize = true;
			this.simpleUserRadioButton.ForeColor = System.Drawing.Color.Black;
			this.simpleUserRadioButton.Location = new System.Drawing.Point(83, 56);
			this.simpleUserRadioButton.Name = "simpleUserRadioButton";
			this.simpleUserRadioButton.Size = new System.Drawing.Size(69, 21);
			this.simpleUserRadioButton.TabIndex = 4;
			this.simpleUserRadioButton.Text = "کاربر ساده";
			this.simpleUserRadioButton.UseVisualStyleBackColor = true;
			this.simpleUserRadioButton.CheckedChanged += new System.EventHandler(this.SimpleUserRadioButton_CheckedChanged);
			// 
			// serviceForceRadioButton
			// 
			this.serviceForceRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.serviceForceRadioButton.AutoSize = true;
			this.serviceForceRadioButton.ForeColor = System.Drawing.Color.Black;
			this.serviceForceRadioButton.Location = new System.Drawing.Point(188, 56);
			this.serviceForceRadioButton.Name = "serviceForceRadioButton";
			this.serviceForceRadioButton.Size = new System.Drawing.Size(87, 21);
			this.serviceForceRadioButton.TabIndex = 3;
			this.serviceForceRadioButton.Text = "نیروی خدمات";
			this.serviceForceRadioButton.UseVisualStyleBackColor = true;
			this.serviceForceRadioButton.CheckedChanged += new System.EventHandler(this.ServiceForceRadioButton_CheckedChanged);
			// 
			// employeedRadioButton
			// 
			this.employeedRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.employeedRadioButton.AutoSize = true;
			this.employeedRadioButton.ForeColor = System.Drawing.Color.Black;
			this.employeedRadioButton.Location = new System.Drawing.Point(99, 29);
			this.employeedRadioButton.Name = "employeedRadioButton";
			this.employeedRadioButton.Size = new System.Drawing.Size(53, 21);
			this.employeedRadioButton.TabIndex = 2;
			this.employeedRadioButton.Text = "کارمند";
			this.employeedRadioButton.UseVisualStyleBackColor = true;
			this.employeedRadioButton.CheckedChanged += new System.EventHandler(this.EmployeedRadioButton_CheckedChanged);
			// 
			// administratorRadioButton
			// 
			this.administratorRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.administratorRadioButton.AutoSize = true;
			this.administratorRadioButton.ForeColor = System.Drawing.Color.Black;
			this.administratorRadioButton.Location = new System.Drawing.Point(213, 29);
			this.administratorRadioButton.Name = "administratorRadioButton";
			this.administratorRadioButton.Size = new System.Drawing.Size(62, 21);
			this.administratorRadioButton.TabIndex = 1;
			this.administratorRadioButton.Text = "مدیریت";
			this.administratorRadioButton.UseVisualStyleBackColor = true;
			this.administratorRadioButton.CheckedChanged += new System.EventHandler(this.AdministratorRadioButton_CheckedChanged);
			// 
			// userImagePictureBox
			// 
			this.userImagePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.userImagePictureBox.BackColor = System.Drawing.Color.Transparent;
			this.userImagePictureBox.BackgroundImage = global::HOOKAH_SALON.Properties.Resources.user_1024;
			this.userImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.userImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userImagePictureBox.Image")));
			this.userImagePictureBox.Location = new System.Drawing.Point(105, 35);
			this.userImagePictureBox.Name = "userImagePictureBox";
			this.userImagePictureBox.Size = new System.Drawing.Size(90, 90);
			this.userImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userImagePictureBox.TabIndex = 11;
			this.userImagePictureBox.TabStop = false;
			// 
			// updateButton
			// 
			this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.updateButton.BackColor = System.Drawing.Color.SlateBlue;
			this.updateButton.Enabled = false;
			this.updateButton.FlatAppearance.BorderSize = 0;
			this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateButton.ForeColor = System.Drawing.Color.White;
			this.updateButton.Location = new System.Drawing.Point(63, 315);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(175, 30);
			this.updateButton.TabIndex = 5;
			this.updateButton.Text = "&به روز رسانی";
			this.updateButton.UseVisualStyleBackColor = false;
			this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// activationCheckBox
			// 
			this.activationCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.activationCheckBox.AutoSize = true;
			this.activationCheckBox.ForeColor = System.Drawing.Color.Black;
			this.activationCheckBox.Location = new System.Drawing.Point(175, 277);
			this.activationCheckBox.Name = "activationCheckBox";
			this.activationCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.activationCheckBox.Size = new System.Drawing.Size(92, 21);
			this.activationCheckBox.TabIndex = 4;
			this.activationCheckBox.Text = "فعال بودن کاربر";
			this.activationCheckBox.UseVisualStyleBackColor = true;
			this.activationCheckBox.CheckedChanged += new System.EventHandler(this.ActivationCheckBox_CheckedChanged);
			// 
			// usenamePanel
			// 
			this.usenamePanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.usenamePanel.BackColor = System.Drawing.Color.Black;
			this.usenamePanel.Location = new System.Drawing.Point(48, 157);
			this.usenamePanel.Name = "usenamePanel";
			this.usenamePanel.Size = new System.Drawing.Size(205, 1);
			this.usenamePanel.TabIndex = 1;
			// 
			// usernameLabel
			// 
			this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
			this.usernameLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.usernameLabel.Location = new System.Drawing.Point(48, 134);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.usernameLabel.Size = new System.Drawing.Size(200, 20);
			this.usernameLabel.TabIndex = 5;
			this.usernameLabel.Text = "شناسه کاربری";
			this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.usernameLabel.TextChanged += new System.EventHandler(this.UsernameLabel_TextChanged);
			// 
			// searchPanel
			// 
			this.searchPanel.BackColor = System.Drawing.Color.Transparent;
			this.searchPanel.Controls.Add(this.searchPicturBox);
			this.searchPanel.Controls.Add(this.userSearchPanel);
			this.searchPanel.Controls.Add(this.userSearchTextBox);
			this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.searchPanel.Location = new System.Drawing.Point(0, 0);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(750, 55);
			this.searchPanel.TabIndex = 3;
			// 
			// searchPicturBox
			// 
			this.searchPicturBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchPicturBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchPicturBox.BackgroundImage")));
			this.searchPicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.searchPicturBox.Location = new System.Drawing.Point(719, 11);
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
			this.userSearchPanel.Location = new System.Drawing.Point(463, 42);
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
			this.userSearchTextBox.Location = new System.Drawing.Point(463, 15);
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
			// userListPanel
			// 
			this.userListPanel.Controls.Add(this.userListDataGridView);
			this.userListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userListPanel.Location = new System.Drawing.Point(0, 55);
			this.userListPanel.Name = "userListPanel";
			this.userListPanel.Size = new System.Drawing.Size(750, 300);
			this.userListPanel.TabIndex = 2;
			// 
			// userListDataGridView
			// 
			this.userListDataGridView.AllowUserToAddRows = false;
			this.userListDataGridView.AllowUserToDeleteRows = false;
			this.userListDataGridView.AllowUserToResizeColumns = false;
			this.userListDataGridView.AllowUserToResizeRows = false;
			this.userListDataGridView.AutoGenerateColumns = false;
			this.userListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.userListDataGridView.BackgroundColor = System.Drawing.Color.Gray;
			this.userListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.userListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.userListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.userListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.userListDataGridView.ColumnHeadersHeight = 30;
			this.userListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.userListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.accessLevelDataGridViewTextBoxColumn,
            this.registrationTimeDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn});
			this.userListDataGridView.DataSource = this.userBindingSource;
			this.userListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userListDataGridView.EnableHeadersVisualStyles = false;
			this.userListDataGridView.Location = new System.Drawing.Point(0, 0);
			this.userListDataGridView.Name = "userListDataGridView";
			this.userListDataGridView.ReadOnly = true;
			this.userListDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.userListDataGridView.RowHeadersVisible = false;
			this.userListDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo;
			this.userListDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.userListDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.userListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.userListDataGridView.Size = new System.Drawing.Size(750, 300);
			this.userListDataGridView.TabIndex = 6;
			this.userListDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserListDataGridView_CellDoubleClick);
			// 
			// usernameDataGridViewTextBoxColumn
			// 
			this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
			this.usernameDataGridViewTextBoxColumn.HeaderText = "شناسه کاربری";
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "نام";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// accessLevelDataGridViewTextBoxColumn
			// 
			this.accessLevelDataGridViewTextBoxColumn.DataPropertyName = "Access_Level";
			this.accessLevelDataGridViewTextBoxColumn.HeaderText = "سطح دسترسی";
			this.accessLevelDataGridViewTextBoxColumn.MaxInputLength = 11;
			this.accessLevelDataGridViewTextBoxColumn.Name = "accessLevelDataGridViewTextBoxColumn";
			this.accessLevelDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// registrationTimeDataGridViewTextBoxColumn
			// 
			this.registrationTimeDataGridViewTextBoxColumn.DataPropertyName = "Registration_Time";
			this.registrationTimeDataGridViewTextBoxColumn.HeaderText = "زمان ثبت";
			this.registrationTimeDataGridViewTextBoxColumn.Name = "registrationTimeDataGridViewTextBoxColumn";
			this.registrationTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// registrationDateDataGridViewTextBoxColumn
			// 
			this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "Registration_Date";
			this.registrationDateDataGridViewTextBoxColumn.HeaderText = "تاریخ ثبت";
			this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
			this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(Models.User);
			// 
			// UsersListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(1050, 355);
			this.Controls.Add(this.userListPanel);
			this.Controls.Add(this.searchPanel);
			this.Controls.Add(this.usersStatusPanel);
			this.Name = "UsersListForm";
			this.Text = "UsersListForm";
			this.Load += new System.EventHandler(this.UsersListForm_Load);
			this.usersStatusPanel.ResumeLayout(false);
			this.usersStatusPanel.PerformLayout();
			this.accessLevelGroupBox.ResumeLayout(false);
			this.accessLevelGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePictureBox)).EndInit();
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.searchPicturBox)).EndInit();
			this.userListPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.userListDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Mbb.Windows.Forms.Panel usersStatusPanel;
		private Mbb.Windows.Forms.Panel usenamePanel;
		private Mbb.Windows.Forms.Label usernameLabel;
		private Mbb.Windows.Forms.Panel searchPanel;
		private Mbb.Windows.Forms.PicturBox searchPicturBox;
		private Mbb.Windows.Forms.Panel userSearchPanel;
		private Mbb.Windows.Forms.TextBox userSearchTextBox;
		private Mbb.Windows.Forms.CheckBox activationCheckBox;
		private Mbb.Windows.Forms.Button updateButton;
		private Mbb.Windows.Forms.CircularPictureBox userImagePictureBox;
		private Mbb.Windows.Forms.Panel userListPanel;
		private Mbb.Windows.Forms.DataGridView userListDataGridView;
		private Mbb.Windows.Forms.GroupBox accessLevelGroupBox;
		private Mbb.Windows.Forms.RadioButton serviceForceRadioButton;
		private Mbb.Windows.Forms.RadioButton employeedRadioButton;
		private Mbb.Windows.Forms.RadioButton administratorRadioButton;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accessLevelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
		private Mbb.Windows.Forms.RadioButton simpleUserRadioButton;
	}
}