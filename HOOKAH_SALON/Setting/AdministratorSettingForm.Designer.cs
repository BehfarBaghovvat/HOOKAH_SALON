namespace HOOKAH_SALON.Setting
{
	partial class AdministratorSettingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorSettingForm));
			this.administratorSettingFormBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.showMenuPanel = new Mbb.Windows.Forms.Panel();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usersListButton = new Mbb.Windows.Forms.Button();
			this.menuPanel = new Mbb.Windows.Forms.Panel();
			this.actionsControlButton = new Mbb.Windows.Forms.Button();
			this.loginControlButton = new Mbb.Windows.Forms.Button();
			this.usersSettingButtonBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.controlLoginButtonBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.reportActionsButtonBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// administratorSettingFormBunifuElipse
			// 
			this.administratorSettingFormBunifuElipse.ElipseRadius = 25;
			this.administratorSettingFormBunifuElipse.TargetControl = this;
			// 
			// showMenuPanel
			// 
			this.showMenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showMenuPanel.BackgroundImage")));
			this.showMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.showMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.showMenuPanel.Location = new System.Drawing.Point(0, 130);
			this.showMenuPanel.Name = "showMenuPanel";
			this.showMenuPanel.Size = new System.Drawing.Size(1050, 355);
			this.showMenuPanel.TabIndex = 1;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(Models.User);
			// 
			// usersListButton
			// 
			this.usersListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.usersListButton.BackColor = System.Drawing.Color.DarkGray;
			this.usersListButton.FlatAppearance.BorderSize = 0;
			this.usersListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.usersListButton.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.usersListButton.ForeColor = System.Drawing.Color.White;
			this.usersListButton.Image = ((System.Drawing.Image)(resources.GetObject("usersListButton.Image")));
			this.usersListButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.usersListButton.Location = new System.Drawing.Point(257, 14);
			this.usersListButton.Name = "usersListButton";
			this.usersListButton.Size = new System.Drawing.Size(175, 100);
			this.usersListButton.TabIndex = 2;
			this.usersListButton.Text = "لیست کاربران";
			this.usersListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.usersListButton.UseVisualStyleBackColor = false;
			this.usersListButton.Click += new System.EventHandler(this.UsersListButton_Click);
			// 
			// menuPanel
			// 
			this.menuPanel.Controls.Add(this.actionsControlButton);
			this.menuPanel.Controls.Add(this.loginControlButton);
			this.menuPanel.Controls.Add(this.usersListButton);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(1050, 130);
			this.menuPanel.TabIndex = 0;
			// 
			// actionsControlButton
			// 
			this.actionsControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.actionsControlButton.BackColor = System.Drawing.Color.DarkGray;
			this.actionsControlButton.FlatAppearance.BorderSize = 0;
			this.actionsControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.actionsControlButton.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.actionsControlButton.ForeColor = System.Drawing.Color.White;
			this.actionsControlButton.Image = ((System.Drawing.Image)(resources.GetObject("actionsControlButton.Image")));
			this.actionsControlButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.actionsControlButton.Location = new System.Drawing.Point(619, 14);
			this.actionsControlButton.Name = "actionsControlButton";
			this.actionsControlButton.Size = new System.Drawing.Size(175, 100);
			this.actionsControlButton.TabIndex = 4;
			this.actionsControlButton.Text = "فعالیت ها";
			this.actionsControlButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.actionsControlButton.UseVisualStyleBackColor = false;
			this.actionsControlButton.Click += new System.EventHandler(this.ActionsControlButton_Click);
			// 
			// loginControlButton
			// 
			this.loginControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.loginControlButton.BackColor = System.Drawing.Color.DarkGray;
			this.loginControlButton.FlatAppearance.BorderSize = 0;
			this.loginControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginControlButton.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.loginControlButton.ForeColor = System.Drawing.Color.White;
			this.loginControlButton.Image = ((System.Drawing.Image)(resources.GetObject("loginControlButton.Image")));
			this.loginControlButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.loginControlButton.Location = new System.Drawing.Point(438, 14);
			this.loginControlButton.Name = "loginControlButton";
			this.loginControlButton.Size = new System.Drawing.Size(175, 100);
			this.loginControlButton.TabIndex = 3;
			this.loginControlButton.Text = "ورود و خروج";
			this.loginControlButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.loginControlButton.UseVisualStyleBackColor = false;
			this.loginControlButton.Click += new System.EventHandler(this.LoginControlButton_Click);
			// 
			// usersSettingButtonBunifuElipse
			// 
			this.usersSettingButtonBunifuElipse.ElipseRadius = 25;
			this.usersSettingButtonBunifuElipse.TargetControl = this.usersListButton;
			// 
			// controlLoginButtonBunifuElipse
			// 
			this.controlLoginButtonBunifuElipse.ElipseRadius = 25;
			this.controlLoginButtonBunifuElipse.TargetControl = this.loginControlButton;
			// 
			// reportActionsButtonBunifuElipse
			// 
			this.reportActionsButtonBunifuElipse.ElipseRadius = 25;
			this.reportActionsButtonBunifuElipse.TargetControl = this.actionsControlButton;
			// 
			// AdministratorSettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(1050, 485);
			this.Controls.Add(this.showMenuPanel);
			this.Controls.Add(this.menuPanel);
			this.Name = "AdministratorSettingForm";
			this.Text = "AdministratorSettingForm";
			this.Load += new System.EventHandler(this.AdministratorSettingForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.menuPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse administratorSettingFormBunifuElipse;
		private System.Windows.Forms.BindingSource userBindingSource;
		private Mbb.Windows.Forms.Panel menuPanel;
		private Mbb.Windows.Forms.Button usersListButton;
		private Mbb.Windows.Forms.Button actionsControlButton;
		private Mbb.Windows.Forms.Button loginControlButton;
		private Bunifu.Framework.UI.BunifuElipse usersSettingButtonBunifuElipse;
		private Bunifu.Framework.UI.BunifuElipse controlLoginButtonBunifuElipse;
		private Bunifu.Framework.UI.BunifuElipse reportActionsButtonBunifuElipse;
		public Mbb.Windows.Forms.Panel showMenuPanel;
	}
}