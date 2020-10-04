namespace HOOKAH_SALON.Store
{
	partial class HookahEditFrom
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HookahEditFrom));
			this.titelPanel = new Mbb.Windows.Forms.Panel();
			this.hookahStoreTitleLabel = new Mbb.Windows.Forms.Label();
			this.minimizButton = new Mbb.Windows.Forms.Button();
			this.RegisterLogoPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.hookahPriceTextBox = new Mbb.Windows.Forms.TextBox();
			this.hookahNamePanel = new Mbb.Windows.Forms.Panel();
			this.hookahPricePanel = new Mbb.Windows.Forms.Panel();
			this.hookahNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.hookahDescriptionPanel = new Mbb.Windows.Forms.Panel();
			this.hookahDescriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.hookahImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.updateDataHookahButton = new Mbb.Windows.Forms.Button();
			this.deleteHookahImageButton = new Mbb.Windows.Forms.Button();
			this.hookahEditFormBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.titelPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RegisterLogoPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hookahImagePicturBox)).BeginInit();
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
			this.titelPanel.Size = new System.Drawing.Size(600, 30);
			this.titelPanel.TabIndex = 0;
			// 
			// hookahStoreTitleLabel
			// 
			this.hookahStoreTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.hookahStoreTitleLabel.AutoSize = true;
			this.hookahStoreTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.hookahStoreTitleLabel.ForeColor = System.Drawing.Color.Black;
			this.hookahStoreTitleLabel.Location = new System.Drawing.Point(497, 7);
			this.hookahStoreTitleLabel.Name = "hookahStoreTitleLabel";
			this.hookahStoreTitleLabel.Size = new System.Drawing.Size(67, 17);
			this.hookahStoreTitleLabel.TabIndex = 18;
			this.hookahStoreTitleLabel.Text = "ویرایش قلیان";
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
			this.minimizButton.TabIndex = 16;
			this.minimizButton.UseVisualStyleBackColor = true;
			this.minimizButton.Click += new System.EventHandler(this.MinimizButton_Click);
			// 
			// RegisterLogoPicturBox
			// 
			this.RegisterLogoPicturBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.RegisterLogoPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("RegisterLogoPicturBox.Image")));
			this.RegisterLogoPicturBox.Location = new System.Drawing.Point(570, 0);
			this.RegisterLogoPicturBox.Name = "RegisterLogoPicturBox";
			this.RegisterLogoPicturBox.Size = new System.Drawing.Size(30, 30);
			this.RegisterLogoPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.RegisterLogoPicturBox.TabIndex = 17;
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
			this.closeButton.TabIndex = 15;
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// hookahPriceTextBox
			// 
			this.hookahPriceTextBox.BackColor = System.Drawing.Color.DarkGray;
			this.hookahPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hookahPriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hookahPriceTextBox.Location = new System.Drawing.Point(314, 115);
			this.hookahPriceTextBox.MaxLength = 30;
			this.hookahPriceTextBox.Name = "hookahPriceTextBox";
			this.hookahPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.hookahPriceTextBox.Size = new System.Drawing.Size(250, 17);
			this.hookahPriceTextBox.TabIndex = 1;
			this.hookahPriceTextBox.Text = "قیمت";
			this.hookahPriceTextBox.TextChanged += new System.EventHandler(this.HookahPriceTextBox_TextChanged);
			this.hookahPriceTextBox.Enter += new System.EventHandler(this.HookahPriceTextBox_Enter);
			this.hookahPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HookahPriceTextBox_KeyPress);
			this.hookahPriceTextBox.Leave += new System.EventHandler(this.HookahPriceTextBox_Leave);
			// 
			// hookahNamePanel
			// 
			this.hookahNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hookahNamePanel.Location = new System.Drawing.Point(314, 101);
			this.hookahNamePanel.Name = "hookahNamePanel";
			this.hookahNamePanel.Size = new System.Drawing.Size(250, 2);
			this.hookahNamePanel.TabIndex = 2;
			// 
			// hookahPricePanel
			// 
			this.hookahPricePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hookahPricePanel.Location = new System.Drawing.Point(314, 138);
			this.hookahPricePanel.Name = "hookahPricePanel";
			this.hookahPricePanel.Size = new System.Drawing.Size(250, 2);
			this.hookahPricePanel.TabIndex = 3;
			// 
			// hookahNameTextBox
			// 
			this.hookahNameTextBox.BackColor = System.Drawing.Color.DarkGray;
			this.hookahNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hookahNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hookahNameTextBox.Location = new System.Drawing.Point(314, 78);
			this.hookahNameTextBox.MaxLength = 30;
			this.hookahNameTextBox.Name = "hookahNameTextBox";
			this.hookahNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.hookahNameTextBox.Size = new System.Drawing.Size(250, 17);
			this.hookahNameTextBox.TabIndex = 0;
			this.hookahNameTextBox.Text = "نام قلیان";
			this.hookahNameTextBox.TextChanged += new System.EventHandler(this.HookahNameTextBox_TextChanged);
			this.hookahNameTextBox.Enter += new System.EventHandler(this.HookahNameTextBox_Enter);
			this.hookahNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HookahNameTextBox_KeyPress);
			this.hookahNameTextBox.Leave += new System.EventHandler(this.HookahNameTextBox_Leave);
			// 
			// hookahDescriptionPanel
			// 
			this.hookahDescriptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hookahDescriptionPanel.Location = new System.Drawing.Point(314, 302);
			this.hookahDescriptionPanel.Name = "hookahDescriptionPanel";
			this.hookahDescriptionPanel.Size = new System.Drawing.Size(250, 2);
			this.hookahDescriptionPanel.TabIndex = 6;
			// 
			// hookahDescriptionTextBox
			// 
			this.hookahDescriptionTextBox.BackColor = System.Drawing.Color.DarkGray;
			this.hookahDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.hookahDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.hookahDescriptionTextBox.Location = new System.Drawing.Point(314, 156);
			this.hookahDescriptionTextBox.MaxLength = 30;
			this.hookahDescriptionTextBox.Multiline = true;
			this.hookahDescriptionTextBox.Name = "hookahDescriptionTextBox";
			this.hookahDescriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.hookahDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.hookahDescriptionTextBox.Size = new System.Drawing.Size(250, 140);
			this.hookahDescriptionTextBox.TabIndex = 2;
			this.hookahDescriptionTextBox.Text = "توضیحات";
			this.hookahDescriptionTextBox.TextChanged += new System.EventHandler(this.HookahDescriptionTextBox_TextChanged);
			this.hookahDescriptionTextBox.Enter += new System.EventHandler(this.HookahDescriptionTextBox_Enter);
			this.hookahDescriptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HookahDescriptionTextBox_KeyPress);
			this.hookahDescriptionTextBox.Leave += new System.EventHandler(this.HookahDescriptionTextBox_Leave);
			// 
			// hookahImagePicturBox
			// 
			this.hookahImagePicturBox.Image = global::HOOKAH_SALON.Properties.Resources.hookah_512px;
			this.hookahImagePicturBox.Location = new System.Drawing.Point(69, 78);
			this.hookahImagePicturBox.Name = "hookahImagePicturBox";
			this.hookahImagePicturBox.Size = new System.Drawing.Size(190, 230);
			this.hookahImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.hookahImagePicturBox.TabIndex = 7;
			this.hookahImagePicturBox.TabStop = false;
			this.hookahImagePicturBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HookahImagePicturBox_MouseDoubleClick);
			// 
			// updateDataHookahButton
			// 
			this.updateDataHookahButton.BackColor = System.Drawing.Color.DimGray;
			this.updateDataHookahButton.FlatAppearance.BorderSize = 0;
			this.updateDataHookahButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateDataHookahButton.ForeColor = System.Drawing.Color.White;
			this.updateDataHookahButton.Location = new System.Drawing.Point(225, 340);
			this.updateDataHookahButton.Name = "updateDataHookahButton";
			this.updateDataHookahButton.Size = new System.Drawing.Size(150, 30);
			this.updateDataHookahButton.TabIndex = 3;
			this.updateDataHookahButton.Text = "به روز رسانی";
			this.updateDataHookahButton.UseVisualStyleBackColor = false;
			this.updateDataHookahButton.Click += new System.EventHandler(this.UpdateDataHookahButton_Click);
			// 
			// deleteHookahImageButton
			// 
			this.deleteHookahImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteHookahImageButton.BackgroundImage")));
			this.deleteHookahImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.deleteHookahImageButton.FlatAppearance.BorderSize = 0;
			this.deleteHookahImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteHookahImageButton.Location = new System.Drawing.Point(38, 78);
			this.deleteHookahImageButton.MaximumSize = new System.Drawing.Size(25, 25);
			this.deleteHookahImageButton.MinimumSize = new System.Drawing.Size(25, 25);
			this.deleteHookahImageButton.Name = "deleteHookahImageButton";
			this.deleteHookahImageButton.Size = new System.Drawing.Size(25, 25);
			this.deleteHookahImageButton.TabIndex = 3;
			this.deleteHookahImageButton.UseVisualStyleBackColor = true;
			this.deleteHookahImageButton.Visible = false;
			this.deleteHookahImageButton.Click += new System.EventHandler(this.DeleteHookahImageButton_Click);
			// 
			// hookahEditFormBunifuElipse
			// 
			this.hookahEditFormBunifuElipse.ElipseRadius = 25;
			this.hookahEditFormBunifuElipse.TargetControl = this;
			// 
			// HookahEditFrom
			// 
			this.AcceptButton = this.updateDataHookahButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.deleteHookahImageButton);
			this.Controls.Add(this.updateDataHookahButton);
			this.Controls.Add(this.hookahImagePicturBox);
			this.Controls.Add(this.hookahDescriptionPanel);
			this.Controls.Add(this.hookahDescriptionTextBox);
			this.Controls.Add(this.hookahNameTextBox);
			this.Controls.Add(this.hookahPricePanel);
			this.Controls.Add(this.hookahNamePanel);
			this.Controls.Add(this.hookahPriceTextBox);
			this.Controls.Add(this.titelPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(600, 400);
			this.MinimumSize = new System.Drawing.Size(600, 400);
			this.Name = "HookahEditFrom";
			this.Text = "HookahEditFrom";
			this.Load += new System.EventHandler(this.HookahEditFrom_Load);
			this.titelPanel.ResumeLayout(false);
			this.titelPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RegisterLogoPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hookahImagePicturBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.Panel titelPanel;
		private Mbb.Windows.Forms.Button minimizButton;
		private Mbb.Windows.Forms.PicturBox RegisterLogoPicturBox;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Label hookahStoreTitleLabel;
		private Mbb.Windows.Forms.TextBox hookahPriceTextBox;
		private Mbb.Windows.Forms.Panel hookahNamePanel;
		private Mbb.Windows.Forms.Panel hookahPricePanel;
		private Mbb.Windows.Forms.TextBox hookahNameTextBox;
		private Mbb.Windows.Forms.Panel hookahDescriptionPanel;
		private Mbb.Windows.Forms.TextBox hookahDescriptionTextBox;
		private Mbb.Windows.Forms.PicturBox hookahImagePicturBox;
		private Mbb.Windows.Forms.Button updateDataHookahButton;
		private Mbb.Windows.Forms.Button deleteHookahImageButton;
		private Bunifu.Framework.UI.BunifuElipse hookahEditFormBunifuElipse;
	}
}