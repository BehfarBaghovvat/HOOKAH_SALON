namespace HOOKAH_SALON.Setting
{
	partial class ClientManegmentForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientManegmentForm));
			this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ClientManegmentBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.regularClientAddBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.permanentClientAddButton = new Mbb.Windows.Forms.Button();
			this.temporaryClientAddBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.temporaryClientAddButton = new Mbb.Windows.Forms.Button();
			this.selectCustomerTypePanel = new Mbb.Windows.Forms.Panel();
			this.menuSelectClientSettingPanel = new Mbb.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
			this.menuSelectClientSettingPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// clientBindingSource
			// 
			this.clientBindingSource.DataSource = typeof(Models.PermanentClient);
			// 
			// ClientManegmentBunifuElipse
			// 
			this.ClientManegmentBunifuElipse.ElipseRadius = 20;
			this.ClientManegmentBunifuElipse.TargetControl = this;
			// 
			// regularClientAddBunifuElipse
			// 
			this.regularClientAddBunifuElipse.ElipseRadius = 25;
			this.regularClientAddBunifuElipse.TargetControl = this.permanentClientAddButton;
			// 
			// permanentClientAddButton
			// 
			this.permanentClientAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.permanentClientAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.permanentClientAddButton.FlatAppearance.BorderSize = 0;
			this.permanentClientAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.permanentClientAddButton.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.permanentClientAddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.permanentClientAddButton.Image = ((System.Drawing.Image)(resources.GetObject("permanentClientAddButton.Image")));
			this.permanentClientAddButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.permanentClientAddButton.Location = new System.Drawing.Point(129, 7);
			this.permanentClientAddButton.Name = "permanentClientAddButton";
			this.permanentClientAddButton.Size = new System.Drawing.Size(360, 100);
			this.permanentClientAddButton.TabIndex = 3;
			this.permanentClientAddButton.Text = "تنظیمات مشتری دائم";
			this.permanentClientAddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.permanentClientAddButton.UseVisualStyleBackColor = false;
			this.permanentClientAddButton.Click += new System.EventHandler(this.PermanentClientAddButton_Click);
			// 
			// temporaryClientAddBunifuElipse
			// 
			this.temporaryClientAddBunifuElipse.ElipseRadius = 25;
			this.temporaryClientAddBunifuElipse.TargetControl = this.temporaryClientAddButton;
			// 
			// temporaryClientAddButton
			// 
			this.temporaryClientAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.temporaryClientAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.temporaryClientAddButton.FlatAppearance.BorderSize = 0;
			this.temporaryClientAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.temporaryClientAddButton.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.temporaryClientAddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.temporaryClientAddButton.Image = ((System.Drawing.Image)(resources.GetObject("temporaryClientAddButton.Image")));
			this.temporaryClientAddButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.temporaryClientAddButton.Location = new System.Drawing.Point(495, 7);
			this.temporaryClientAddButton.Name = "temporaryClientAddButton";
			this.temporaryClientAddButton.Size = new System.Drawing.Size(360, 100);
			this.temporaryClientAddButton.TabIndex = 4;
			this.temporaryClientAddButton.Text = "تنظیمات مشتری موقت";
			this.temporaryClientAddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.temporaryClientAddButton.UseVisualStyleBackColor = false;
			this.temporaryClientAddButton.Click += new System.EventHandler(this.TemporaryClientAddButton_Click);
			// 
			// selectCustomerTypePanel
			// 
			this.selectCustomerTypePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectCustomerTypePanel.BackgroundImage")));
			this.selectCustomerTypePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.selectCustomerTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.selectCustomerTypePanel.Location = new System.Drawing.Point(0, 115);
			this.selectCustomerTypePanel.Name = "selectCustomerTypePanel";
			this.selectCustomerTypePanel.Size = new System.Drawing.Size(985, 320);
			this.selectCustomerTypePanel.TabIndex = 4;
			// 
			// menuSelectClientSettingPanel
			// 
			this.menuSelectClientSettingPanel.Controls.Add(this.temporaryClientAddButton);
			this.menuSelectClientSettingPanel.Controls.Add(this.permanentClientAddButton);
			this.menuSelectClientSettingPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.menuSelectClientSettingPanel.Location = new System.Drawing.Point(0, 0);
			this.menuSelectClientSettingPanel.Name = "menuSelectClientSettingPanel";
			this.menuSelectClientSettingPanel.Size = new System.Drawing.Size(985, 115);
			this.menuSelectClientSettingPanel.TabIndex = 5;
			// 
			// ClientManegmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(985, 435);
			this.Controls.Add(this.selectCustomerTypePanel);
			this.Controls.Add(this.menuSelectClientSettingPanel);
			this.Name = "ClientManegmentForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ClientManegmentForm";
			this.Load += new System.EventHandler(this.ClientManegmentForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
			this.menuSelectClientSettingPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource clientBindingSource;
		private Bunifu.Framework.UI.BunifuElipse ClientManegmentBunifuElipse;
		private Bunifu.Framework.UI.BunifuElipse regularClientAddBunifuElipse;
		private Bunifu.Framework.UI.BunifuElipse temporaryClientAddBunifuElipse;
		public Mbb.Windows.Forms.Panel selectCustomerTypePanel;
		private Mbb.Windows.Forms.Panel menuSelectClientSettingPanel;
		private Mbb.Windows.Forms.Button temporaryClientAddButton;
		private Mbb.Windows.Forms.Button permanentClientAddButton;
	}
}