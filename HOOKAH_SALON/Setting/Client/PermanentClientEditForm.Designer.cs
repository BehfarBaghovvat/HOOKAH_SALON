namespace HOOKAH_SALON.Setting.Client
{
	partial class PermanentClientEditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermanentClientEditForm));
			this.titelPanel = new Mbb.Windows.Forms.Panel();
			this.clientAddLabel = new Mbb.Windows.Forms.Label();
			this.minimizButton = new Mbb.Windows.Forms.Button();
			this.RegisterLogoPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.clientIDTextBox = new Mbb.Windows.Forms.TextBox();
			this.clientIDPanel = new Mbb.Windows.Forms.Panel();
			this.editClientButton = new Mbb.Windows.Forms.Button();
			this.fullNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.fullNamePanel = new Mbb.Windows.Forms.Panel();
			this.confirmClientIDPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.showMessageToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.titelPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RegisterLogoPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.confirmClientIDPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// titelPanel
			// 
			this.titelPanel.Controls.Add(this.clientAddLabel);
			this.titelPanel.Controls.Add(this.minimizButton);
			this.titelPanel.Controls.Add(this.RegisterLogoPicturBox);
			this.titelPanel.Controls.Add(this.closeButton);
			this.titelPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titelPanel.Location = new System.Drawing.Point(0, 0);
			this.titelPanel.Name = "titelPanel";
			this.titelPanel.Size = new System.Drawing.Size(550, 30);
			this.titelPanel.TabIndex = 11;
			// 
			// clientAddLabel
			// 
			this.clientAddLabel.AutoSize = true;
			this.clientAddLabel.ForeColor = System.Drawing.Color.White;
			this.clientAddLabel.Location = new System.Drawing.Point(416, 7);
			this.clientAddLabel.Name = "clientAddLabel";
			this.clientAddLabel.Size = new System.Drawing.Size(98, 17);
			this.clientAddLabel.TabIndex = 15;
			this.clientAddLabel.Text = "ویرایش مشتری دائم";
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
			this.RegisterLogoPicturBox.Location = new System.Drawing.Point(520, 0);
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
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// clientIDTextBox
			// 
			this.clientIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.clientIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.clientIDTextBox.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientIDTextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.clientIDTextBox.Location = new System.Drawing.Point(175, 45);
			this.clientIDTextBox.MaxLength = 11;
			this.clientIDTextBox.Name = "clientIDTextBox";
			this.clientIDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.clientIDTextBox.Size = new System.Drawing.Size(200, 19);
			this.clientIDTextBox.TabIndex = 10;
			this.clientIDTextBox.Text = "کد شناسه";
			this.clientIDTextBox.TextChanged += new System.EventHandler(this.ClientIDTextBox_TextChanged);
			this.clientIDTextBox.Enter += new System.EventHandler(this.ClientIDTextBox_Enter);
			this.clientIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientIDTextBox_KeyPress);
			this.clientIDTextBox.Leave += new System.EventHandler(this.ClientIDTextBox_Leave);
			// 
			// clientIDPanel
			// 
			this.clientIDPanel.BackColor = System.Drawing.Color.DarkGray;
			this.clientIDPanel.Location = new System.Drawing.Point(175, 70);
			this.clientIDPanel.Name = "clientIDPanel";
			this.clientIDPanel.Size = new System.Drawing.Size(200, 2);
			this.clientIDPanel.TabIndex = 9;
			// 
			// editClientButton
			// 
			this.editClientButton.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.editClientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.editClientButton.Enabled = false;
			this.editClientButton.FlatAppearance.BorderSize = 0;
			this.editClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editClientButton.ForeColor = System.Drawing.Color.Transparent;
			this.editClientButton.Location = new System.Drawing.Point(200, 140);
			this.editClientButton.Name = "editClientButton";
			this.editClientButton.Size = new System.Drawing.Size(150, 30);
			this.editClientButton.TabIndex = 14;
			this.editClientButton.Text = "ویرایش مشتری";
			this.editClientButton.UseVisualStyleBackColor = false;
			this.editClientButton.Click += new System.EventHandler(this.EditClientButton_Click);
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.fullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.fullNameTextBox.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.fullNameTextBox.ForeColor = System.Drawing.Color.DarkGray;
			this.fullNameTextBox.Location = new System.Drawing.Point(175, 85);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.fullNameTextBox.Size = new System.Drawing.Size(200, 19);
			this.fullNameTextBox.TabIndex = 12;
			this.fullNameTextBox.Text = "نام کامل";
			this.fullNameTextBox.Enter += new System.EventHandler(this.FullNameTextBox_Enter);
			this.fullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBox_KeyPress);
			this.fullNameTextBox.Leave += new System.EventHandler(this.FullNameTextBox_Leave);
			// 
			// fullNamePanel
			// 
			this.fullNamePanel.BackColor = System.Drawing.Color.DarkGray;
			this.fullNamePanel.Location = new System.Drawing.Point(175, 110);
			this.fullNamePanel.Name = "fullNamePanel";
			this.fullNamePanel.Size = new System.Drawing.Size(200, 2);
			this.fullNamePanel.TabIndex = 13;
			// 
			// confirmClientIDPicturBox
			// 
			this.confirmClientIDPicturBox.Image = global::HOOKAH_SALON.Properties.Resources.Tik_True;
			this.confirmClientIDPicturBox.Location = new System.Drawing.Point(144, 42);
			this.confirmClientIDPicturBox.Name = "confirmClientIDPicturBox";
			this.confirmClientIDPicturBox.Size = new System.Drawing.Size(25, 25);
			this.confirmClientIDPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.confirmClientIDPicturBox.TabIndex = 16;
			this.confirmClientIDPicturBox.TabStop = false;
			this.confirmClientIDPicturBox.Visible = false;
			this.confirmClientIDPicturBox.WaitOnLoad = true;
			// 
			// showMessageToolTip
			// 
			this.showMessageToolTip.AutomaticDelay = 50;
			this.showMessageToolTip.AutoPopDelay = 50;
			this.showMessageToolTip.BackColor = System.Drawing.Color.White;
			this.showMessageToolTip.InitialDelay = 5000;
			this.showMessageToolTip.ReshowDelay = 10;
			this.showMessageToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
			// 
			// PermanentClientEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(550, 180);
			this.Controls.Add(this.titelPanel);
			this.Controls.Add(this.clientIDTextBox);
			this.Controls.Add(this.clientIDPanel);
			this.Controls.Add(this.editClientButton);
			this.Controls.Add(this.confirmClientIDPicturBox);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.fullNamePanel);
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.MaximumSize = new System.Drawing.Size(550, 180);
			this.MinimumSize = new System.Drawing.Size(550, 180);
			this.Name = "PermanentClientEditForm";
			this.Text = "PermanentClientEditForm";
			this.Load += new System.EventHandler(this.PermanentClientEditForm_Load);
			this.titelPanel.ResumeLayout(false);
			this.titelPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RegisterLogoPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.confirmClientIDPicturBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Mbb.Windows.Forms.Panel titelPanel;
		private Mbb.Windows.Forms.Label clientAddLabel;
		private Mbb.Windows.Forms.Button minimizButton;
		private Mbb.Windows.Forms.PicturBox RegisterLogoPicturBox;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.TextBox clientIDTextBox;
		private Mbb.Windows.Forms.Panel clientIDPanel;
		private Mbb.Windows.Forms.Button editClientButton;
		private Mbb.Windows.Forms.PicturBox confirmClientIDPicturBox;
		private Mbb.Windows.Forms.TextBox fullNameTextBox;
		private Mbb.Windows.Forms.Panel fullNamePanel;
		private System.Windows.Forms.ToolTip showMessageToolTip;
	}
}