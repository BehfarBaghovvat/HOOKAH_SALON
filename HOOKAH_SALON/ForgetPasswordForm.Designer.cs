namespace HOOKAH_SALON
{
	partial class ForgetPasswordForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordForm));
			this.titlePanel = new Mbb.Windows.Forms.Panel();
			this.minimizButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.securityCodeLabel = new Mbb.Windows.Forms.Label();
			this.selectSendGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.emailRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.smsRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.notificationLabel = new Mbb.Windows.Forms.Label();
			this.sendEmailPanel = new Mbb.Windows.Forms.Panel();
			this.changePasswordButton = new Mbb.Windows.Forms.Button();
			this.groupBox00 = new Mbb.Windows.Forms.GroupBox();
			this.emailStatusPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.codeTextBox = new Mbb.Windows.Forms.TextBox();
			this.codePanel = new Mbb.Windows.Forms.Panel();
			this.emailTextBox = new Mbb.Windows.Forms.TextBox();
			this.sendCodeButton = new Mbb.Windows.Forms.Button();
			this.emailPanel = new Mbb.Windows.Forms.Panel();
			this.groupBox01 = new Mbb.Windows.Forms.GroupBox();
			this.userStatusLabel = new Mbb.Windows.Forms.Label();
			this.userCheckLabel = new Mbb.Windows.Forms.Label();
			this.passwordConfirmPanel = new Mbb.Windows.Forms.Panel();
			this.passwordConfirmTextBox = new Mbb.Windows.Forms.TextBox();
			this.usernamePanel = new Mbb.Windows.Forms.Panel();
			this.passwordPanel = new Mbb.Windows.Forms.Panel();
			this.passwordTextBox = new Mbb.Windows.Forms.TextBox();
			this.usernameTextBox = new Mbb.Windows.Forms.TextBox();
			this.statusInternetLabel = new Mbb.Windows.Forms.Label();
			this.netConnectionStatusLabel = new Mbb.Windows.Forms.Label();
			this.checkIntenetTimer = new System.Windows.Forms.Timer(this.components);
			this.titlePanel.SuspendLayout();
			this.selectSendGroupBox.SuspendLayout();
			this.sendEmailPanel.SuspendLayout();
			this.groupBox00.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.emailStatusPicturBox)).BeginInit();
			this.groupBox01.SuspendLayout();
			this.SuspendLayout();
			// 
			// titlePanel
			// 
			this.titlePanel.BackColor = System.Drawing.Color.Transparent;
			this.titlePanel.Controls.Add(this.minimizButton);
			this.titlePanel.Controls.Add(this.closeButton);
			this.titlePanel.Controls.Add(this.securityCodeLabel);
			this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlePanel.Location = new System.Drawing.Point(0, 0);
			this.titlePanel.Name = "titlePanel";
			this.titlePanel.Size = new System.Drawing.Size(500, 30);
			this.titlePanel.TabIndex = 1;
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
			this.minimizButton.TabIndex = 10;
			this.minimizButton.UseVisualStyleBackColor = true;
			this.minimizButton.Click += new System.EventHandler(this.MinimizButton_Click);
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
			this.closeButton.TabIndex = 9;
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// securityCodeLabel
			// 
			this.securityCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.securityCodeLabel.ForeColor = System.Drawing.Color.White;
			this.securityCodeLabel.Location = new System.Drawing.Point(366, 2);
			this.securityCodeLabel.Name = "securityCodeLabel";
			this.securityCodeLabel.Size = new System.Drawing.Size(133, 27);
			this.securityCodeLabel.TabIndex = 4;
			this.securityCodeLabel.Text = "بازیابی رمز عبور";
			this.securityCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.securityCodeLabel.Visible = false;
			// 
			// selectSendGroupBox
			// 
			this.selectSendGroupBox.Controls.Add(this.emailRadioButton);
			this.selectSendGroupBox.Controls.Add(this.smsRadioButton);
			this.selectSendGroupBox.ForeColor = System.Drawing.Color.White;
			this.selectSendGroupBox.Location = new System.Drawing.Point(5, 36);
			this.selectSendGroupBox.Name = "selectSendGroupBox";
			this.selectSendGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.selectSendGroupBox.Size = new System.Drawing.Size(490, 69);
			this.selectSendGroupBox.TabIndex = 3;
			this.selectSendGroupBox.TabStop = false;
			this.selectSendGroupBox.Text = "روش ارسال را انتخاب کنید";
			// 
			// emailRadioButton
			// 
			this.emailRadioButton.AutoSize = true;
			this.emailRadioButton.ForeColor = System.Drawing.Color.White;
			this.emailRadioButton.Location = new System.Drawing.Point(68, 32);
			this.emailRadioButton.Name = "emailRadioButton";
			this.emailRadioButton.Size = new System.Drawing.Size(172, 21);
			this.emailRadioButton.TabIndex = 1;
			this.emailRadioButton.TabStop = true;
			this.emailRadioButton.Text = "ارسال کد با کمک پست الکترونیک";
			this.emailRadioButton.UseVisualStyleBackColor = true;
			this.emailRadioButton.CheckedChanged += new System.EventHandler(this.EmailRadioButton_CheckedChanged);
			// 
			// smsRadioButton
			// 
			this.smsRadioButton.AutoSize = true;
			this.smsRadioButton.ForeColor = System.Drawing.Color.White;
			this.smsRadioButton.Location = new System.Drawing.Point(296, 32);
			this.smsRadioButton.Name = "smsRadioButton";
			this.smsRadioButton.Size = new System.Drawing.Size(144, 21);
			this.smsRadioButton.TabIndex = 0;
			this.smsRadioButton.TabStop = true;
			this.smsRadioButton.Text = "ارسال کد با کمک پیام کوتاه";
			this.smsRadioButton.UseVisualStyleBackColor = true;
			this.smsRadioButton.CheckedChanged += new System.EventHandler(this.SmsRadioButton_CheckedChanged);
			// 
			// notificationLabel
			// 
			this.notificationLabel.AutoSize = true;
			this.notificationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.notificationLabel.Location = new System.Drawing.Point(219, 108);
			this.notificationLabel.Name = "notificationLabel";
			this.notificationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.notificationLabel.Size = new System.Drawing.Size(269, 17);
			this.notificationLabel.TabIndex = 28;
			this.notificationLabel.Text = "جهت فعال سازی باید هزینه سرویس مورد نظر پرداخت گردد.";
			this.notificationLabel.Visible = false;
			// 
			// sendEmailPanel
			// 
			this.sendEmailPanel.BackColor = System.Drawing.Color.LightSlateGray;
			this.sendEmailPanel.Controls.Add(this.changePasswordButton);
			this.sendEmailPanel.Controls.Add(this.groupBox00);
			this.sendEmailPanel.Controls.Add(this.groupBox01);
			this.sendEmailPanel.Controls.Add(this.statusInternetLabel);
			this.sendEmailPanel.Controls.Add(this.netConnectionStatusLabel);
			this.sendEmailPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sendEmailPanel.Location = new System.Drawing.Point(0, 125);
			this.sendEmailPanel.MaximumSize = new System.Drawing.Size(500, 350);
			this.sendEmailPanel.MinimumSize = new System.Drawing.Size(500, 310);
			this.sendEmailPanel.Name = "sendEmailPanel";
			this.sendEmailPanel.Size = new System.Drawing.Size(500, 335);
			this.sendEmailPanel.TabIndex = 29;
			// 
			// changePasswordButton
			// 
			this.changePasswordButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.changePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.changePasswordButton.Enabled = false;
			this.changePasswordButton.FlatAppearance.BorderSize = 0;
			this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.changePasswordButton.ForeColor = System.Drawing.Color.White;
			this.changePasswordButton.Location = new System.Drawing.Point(10, 288);
			this.changePasswordButton.Name = "changePasswordButton";
			this.changePasswordButton.Size = new System.Drawing.Size(139, 30);
			this.changePasswordButton.TabIndex = 20;
			this.changePasswordButton.Text = "تغییر رمز عبور";
			this.changePasswordButton.UseVisualStyleBackColor = false;
			this.changePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
			// 
			// groupBox00
			// 
			this.groupBox00.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.groupBox00.Controls.Add(this.emailStatusPicturBox);
			this.groupBox00.Controls.Add(this.codeTextBox);
			this.groupBox00.Controls.Add(this.codePanel);
			this.groupBox00.Controls.Add(this.emailTextBox);
			this.groupBox00.Controls.Add(this.sendCodeButton);
			this.groupBox00.Controls.Add(this.emailPanel);
			this.groupBox00.Location = new System.Drawing.Point(10, 5);
			this.groupBox00.Name = "groupBox00";
			this.groupBox00.Size = new System.Drawing.Size(478, 105);
			this.groupBox00.TabIndex = 19;
			this.groupBox00.TabStop = false;
			// 
			// emailStatusPicturBox
			// 
			this.emailStatusPicturBox.Image = global::HOOKAH_SALON.Properties.Resources.Tik_False;
			this.emailStatusPicturBox.Location = new System.Drawing.Point(5, 17);
			this.emailStatusPicturBox.Name = "emailStatusPicturBox";
			this.emailStatusPicturBox.Size = new System.Drawing.Size(21, 22);
			this.emailStatusPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.emailStatusPicturBox.TabIndex = 6;
			this.emailStatusPicturBox.TabStop = false;
			this.emailStatusPicturBox.Visible = false;
			// 
			// codeTextBox
			// 
			this.codeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.codeTextBox.BackColor = System.Drawing.Color.LightSlateGray;
			this.codeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.codeTextBox.Enabled = false;
			this.codeTextBox.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.codeTextBox.ForeColor = System.Drawing.Color.Black;
			this.codeTextBox.Location = new System.Drawing.Point(253, 65);
			this.codeTextBox.Name = "codeTextBox";
			this.codeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.codeTextBox.Size = new System.Drawing.Size(219, 21);
			this.codeTextBox.TabIndex = 4;
			this.codeTextBox.Text = "کد";
			this.codeTextBox.TextChanged += new System.EventHandler(this.CodeTextBox_TextChanged);
			this.codeTextBox.Enter += new System.EventHandler(this.CodeTextBox_Enter);
			this.codeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeTextBox_KeyPress);
			this.codeTextBox.Leave += new System.EventHandler(this.CodeTextBox_Leave);
			// 
			// codePanel
			// 
			this.codePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.codePanel.BackColor = System.Drawing.Color.Black;
			this.codePanel.Location = new System.Drawing.Point(253, 91);
			this.codePanel.Name = "codePanel";
			this.codePanel.Size = new System.Drawing.Size(219, 1);
			this.codePanel.TabIndex = 5;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emailTextBox.BackColor = System.Drawing.Color.LightSlateGray;
			this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.emailTextBox.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailTextBox.ForeColor = System.Drawing.Color.Black;
			this.emailTextBox.Location = new System.Drawing.Point(31, 18);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.emailTextBox.Size = new System.Drawing.Size(438, 21);
			this.emailTextBox.TabIndex = 1;
			this.emailTextBox.Text = "پست الکترونیکی";
			this.emailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
			this.emailTextBox.Enter += new System.EventHandler(this.EmailTextBox_Enter);
			this.emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
			this.emailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
			// 
			// sendCodeButton
			// 
			this.sendCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sendCodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.sendCodeButton.Enabled = false;
			this.sendCodeButton.FlatAppearance.BorderSize = 0;
			this.sendCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sendCodeButton.ForeColor = System.Drawing.Color.White;
			this.sendCodeButton.Location = new System.Drawing.Point(5, 61);
			this.sendCodeButton.Name = "sendCodeButton";
			this.sendCodeButton.Size = new System.Drawing.Size(238, 30);
			this.sendCodeButton.TabIndex = 3;
			this.sendCodeButton.Text = "ارسال کد امنیتی";
			this.sendCodeButton.UseVisualStyleBackColor = false;
			this.sendCodeButton.Click += new System.EventHandler(this.SendCodeButton_Click);
			// 
			// emailPanel
			// 
			this.emailPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.emailPanel.BackColor = System.Drawing.Color.Black;
			this.emailPanel.Location = new System.Drawing.Point(31, 47);
			this.emailPanel.Name = "emailPanel";
			this.emailPanel.Size = new System.Drawing.Size(438, 1);
			this.emailPanel.TabIndex = 2;
			// 
			// groupBox01
			// 
			this.groupBox01.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.groupBox01.Controls.Add(this.userStatusLabel);
			this.groupBox01.Controls.Add(this.userCheckLabel);
			this.groupBox01.Controls.Add(this.passwordConfirmPanel);
			this.groupBox01.Controls.Add(this.passwordConfirmTextBox);
			this.groupBox01.Controls.Add(this.usernamePanel);
			this.groupBox01.Controls.Add(this.passwordPanel);
			this.groupBox01.Controls.Add(this.passwordTextBox);
			this.groupBox01.Controls.Add(this.usernameTextBox);
			this.groupBox01.Location = new System.Drawing.Point(10, 112);
			this.groupBox01.Name = "groupBox01";
			this.groupBox01.Size = new System.Drawing.Size(478, 170);
			this.groupBox01.TabIndex = 18;
			this.groupBox01.TabStop = false;
			// 
			// userStatusLabel
			// 
			this.userStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userStatusLabel.ForeColor = System.Drawing.Color.White;
			this.userStatusLabel.Location = new System.Drawing.Point(151, 19);
			this.userStatusLabel.Name = "userStatusLabel";
			this.userStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.userStatusLabel.Size = new System.Drawing.Size(249, 17);
			this.userStatusLabel.TabIndex = 19;
			this.userStatusLabel.Text = "وضعیت";
			// 
			// userCheckLabel
			// 
			this.userCheckLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userCheckLabel.AutoSize = true;
			this.userCheckLabel.ForeColor = System.Drawing.Color.White;
			this.userCheckLabel.Location = new System.Drawing.Point(406, 19);
			this.userCheckLabel.Name = "userCheckLabel";
			this.userCheckLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.userCheckLabel.Size = new System.Drawing.Size(60, 17);
			this.userCheckLabel.TabIndex = 18;
			this.userCheckLabel.Text = "بررسی کاربر:";
			// 
			// passwordConfirmPanel
			// 
			this.passwordConfirmPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordConfirmPanel.BackColor = System.Drawing.Color.Black;
			this.passwordConfirmPanel.Location = new System.Drawing.Point(15, 150);
			this.passwordConfirmPanel.Name = "passwordConfirmPanel";
			this.passwordConfirmPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.passwordConfirmPanel.Size = new System.Drawing.Size(448, 1);
			this.passwordConfirmPanel.TabIndex = 17;
			// 
			// passwordConfirmTextBox
			// 
			this.passwordConfirmTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordConfirmTextBox.BackColor = System.Drawing.Color.LightSlateGray;
			this.passwordConfirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordConfirmTextBox.Enabled = false;
			this.passwordConfirmTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordConfirmTextBox.ForeColor = System.Drawing.Color.Black;
			this.passwordConfirmTextBox.Location = new System.Drawing.Point(15, 124);
			this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
			this.passwordConfirmTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.passwordConfirmTextBox.Size = new System.Drawing.Size(448, 21);
			this.passwordConfirmTextBox.TabIndex = 16;
			this.passwordConfirmTextBox.Text = "تایید رمز عبور";
			this.passwordConfirmTextBox.Enter += new System.EventHandler(this.PasswordConfirmTextBox_Enter);
			this.passwordConfirmTextBox.Leave += new System.EventHandler(this.PasswordConfirmTextBox_Leave);
			// 
			// usernamePanel
			// 
			this.usernamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernamePanel.BackColor = System.Drawing.Color.Black;
			this.usernamePanel.Location = new System.Drawing.Point(15, 68);
			this.usernamePanel.Name = "usernamePanel";
			this.usernamePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.usernamePanel.Size = new System.Drawing.Size(448, 1);
			this.usernamePanel.TabIndex = 13;
			// 
			// passwordPanel
			// 
			this.passwordPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordPanel.BackColor = System.Drawing.Color.Black;
			this.passwordPanel.Location = new System.Drawing.Point(15, 109);
			this.passwordPanel.Name = "passwordPanel";
			this.passwordPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.passwordPanel.Size = new System.Drawing.Size(448, 1);
			this.passwordPanel.TabIndex = 15;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.BackColor = System.Drawing.Color.LightSlateGray;
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Enabled = false;
			this.passwordTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
			this.passwordTextBox.Location = new System.Drawing.Point(15, 83);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.passwordTextBox.Size = new System.Drawing.Size(448, 21);
			this.passwordTextBox.TabIndex = 14;
			this.passwordTextBox.Text = "رمز عبور";
			this.passwordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
			this.passwordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.BackColor = System.Drawing.Color.LightSlateGray;
			this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameTextBox.Enabled = false;
			this.usernameTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.ForeColor = System.Drawing.Color.Black;
			this.usernameTextBox.Location = new System.Drawing.Point(15, 42);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.usernameTextBox.Size = new System.Drawing.Size(448, 21);
			this.usernameTextBox.TabIndex = 12;
			this.usernameTextBox.Text = "نام کاربری";
			this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
			this.usernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
			this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTextBox_KeyPress);
			this.usernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
			// 
			// statusInternetLabel
			// 
			this.statusInternetLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.statusInternetLabel.AutoSize = true;
			this.statusInternetLabel.ForeColor = System.Drawing.Color.White;
			this.statusInternetLabel.Location = new System.Drawing.Point(411, 295);
			this.statusInternetLabel.Name = "statusInternetLabel";
			this.statusInternetLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusInternetLabel.Size = new System.Drawing.Size(80, 17);
			this.statusInternetLabel.TabIndex = 17;
			this.statusInternetLabel.Text = "وضعیت اینترنت:";
			// 
			// netConnectionStatusLabel
			// 
			this.netConnectionStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.netConnectionStatusLabel.ForeColor = System.Drawing.Color.White;
			this.netConnectionStatusLabel.Location = new System.Drawing.Point(188, 295);
			this.netConnectionStatusLabel.Name = "netConnectionStatusLabel";
			this.netConnectionStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.netConnectionStatusLabel.Size = new System.Drawing.Size(221, 17);
			this.netConnectionStatusLabel.TabIndex = 16;
			this.netConnectionStatusLabel.Text = "اتصال شبکه";
			// 
			// checkIntenetTimer
			// 
			this.checkIntenetTimer.Interval = 500;
			this.checkIntenetTimer.Tick += new System.EventHandler(this.CheckIntenetTimer_Tick);
			// 
			// ForgetPasswordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSlateGray;
			this.ClientSize = new System.Drawing.Size(500, 460);
			this.Controls.Add(this.sendEmailPanel);
			this.Controls.Add(this.notificationLabel);
			this.Controls.Add(this.selectSendGroupBox);
			this.Controls.Add(this.titlePanel);
			this.Name = "ForgetPasswordForm";
			this.Text = "ForgetPasswordForm";
			this.Load += new System.EventHandler(this.ForgetPasswordForm_Load);
			this.titlePanel.ResumeLayout(false);
			this.selectSendGroupBox.ResumeLayout(false);
			this.selectSendGroupBox.PerformLayout();
			this.sendEmailPanel.ResumeLayout(false);
			this.sendEmailPanel.PerformLayout();
			this.groupBox00.ResumeLayout(false);
			this.groupBox00.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.emailStatusPicturBox)).EndInit();
			this.groupBox01.ResumeLayout(false);
			this.groupBox01.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.Panel titlePanel;
		private Mbb.Windows.Forms.Label securityCodeLabel;
		private Mbb.Windows.Forms.GroupBox selectSendGroupBox;
		private Mbb.Windows.Forms.RadioButton emailRadioButton;
		private Mbb.Windows.Forms.RadioButton smsRadioButton;
		private Mbb.Windows.Forms.Label notificationLabel;
		private Mbb.Windows.Forms.Panel sendEmailPanel;
		private Mbb.Windows.Forms.Button changePasswordButton;
		private Mbb.Windows.Forms.GroupBox groupBox00;
		private Mbb.Windows.Forms.PicturBox emailStatusPicturBox;
		private Mbb.Windows.Forms.TextBox codeTextBox;
		private Mbb.Windows.Forms.Panel codePanel;
		private Mbb.Windows.Forms.TextBox emailTextBox;
		private Mbb.Windows.Forms.Button sendCodeButton;
		private Mbb.Windows.Forms.Panel emailPanel;
		private Mbb.Windows.Forms.GroupBox groupBox01;
		private Mbb.Windows.Forms.Label userStatusLabel;
		private Mbb.Windows.Forms.Label userCheckLabel;
		private Mbb.Windows.Forms.Panel passwordConfirmPanel;
		private Mbb.Windows.Forms.TextBox passwordConfirmTextBox;
		private Mbb.Windows.Forms.Panel usernamePanel;
		private Mbb.Windows.Forms.Panel passwordPanel;
		private Mbb.Windows.Forms.TextBox passwordTextBox;
		private Mbb.Windows.Forms.TextBox usernameTextBox;
		private Mbb.Windows.Forms.Label statusInternetLabel;
		private Mbb.Windows.Forms.Label netConnectionStatusLabel;
		private Mbb.Windows.Forms.Button minimizButton;
		private Mbb.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Timer checkIntenetTimer;
	}
}