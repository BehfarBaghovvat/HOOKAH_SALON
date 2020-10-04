namespace HOOKAH_SALON.Store
{
	partial class DrinkEditeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkEditeForm));
			this.titelPanel = new Mbb.Windows.Forms.Panel();
			this.hookahStoreTitleLabel = new Mbb.Windows.Forms.Label();
			this.minimizButton = new Mbb.Windows.Forms.Button();
			this.RegisterLogoPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.updateDataDrinkButton = new Mbb.Windows.Forms.Button();
			this.drinkDescriptionPanel = new Mbb.Windows.Forms.Panel();
			this.drinkDescriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.drinkNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.drinkPricePanel = new Mbb.Windows.Forms.Panel();
			this.drinkNamePanel = new Mbb.Windows.Forms.Panel();
			this.drinkPriceTextBox = new Mbb.Windows.Forms.TextBox();
			this.deleteDrinkImageButton = new Mbb.Windows.Forms.Button();
			this.drinkImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.drinkEditeFormBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.titelPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RegisterLogoPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.drinkImagePicturBox)).BeginInit();
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
			this.titelPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.titelPanel.Name = "titelPanel";
			this.titelPanel.Size = new System.Drawing.Size(600, 30);
			this.titelPanel.TabIndex = 10;
			// 
			// hookahStoreTitleLabel
			// 
			this.hookahStoreTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.hookahStoreTitleLabel.AutoSize = true;
			this.hookahStoreTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.hookahStoreTitleLabel.ForeColor = System.Drawing.Color.Black;
			this.hookahStoreTitleLabel.Location = new System.Drawing.Point(481, 7);
			this.hookahStoreTitleLabel.Name = "hookahStoreTitleLabel";
			this.hookahStoreTitleLabel.Size = new System.Drawing.Size(82, 17);
			this.hookahStoreTitleLabel.TabIndex = 18;
			this.hookahStoreTitleLabel.Text = "ویرایش نوشیدنی";
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
			this.minimizButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
			this.RegisterLogoPicturBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
			this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(50, 30);
			this.closeButton.TabIndex = 15;
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// updateDataDrinkButton
			// 
			this.updateDataDrinkButton.BackColor = System.Drawing.Color.OrangeRed;
			this.updateDataDrinkButton.FlatAppearance.BorderSize = 0;
			this.updateDataDrinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateDataDrinkButton.ForeColor = System.Drawing.Color.White;
			this.updateDataDrinkButton.Location = new System.Drawing.Point(224, 316);
			this.updateDataDrinkButton.Name = "updateDataDrinkButton";
			this.updateDataDrinkButton.Size = new System.Drawing.Size(150, 30);
			this.updateDataDrinkButton.TabIndex = 3;
			this.updateDataDrinkButton.Text = "&به روز رسانی";
			this.updateDataDrinkButton.UseVisualStyleBackColor = false;
			this.updateDataDrinkButton.Click += new System.EventHandler(this.UpdateDataDrinkButton_Click);
			// 
			// drinkDescriptionPanel
			// 
			this.drinkDescriptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.drinkDescriptionPanel.Location = new System.Drawing.Point(313, 278);
			this.drinkDescriptionPanel.Name = "drinkDescriptionPanel";
			this.drinkDescriptionPanel.Size = new System.Drawing.Size(250, 2);
			this.drinkDescriptionPanel.TabIndex = 17;
			// 
			// drinkDescriptionTextBox
			// 
			this.drinkDescriptionTextBox.BackColor = System.Drawing.Color.LightCoral;
			this.drinkDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.drinkDescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.drinkDescriptionTextBox.Location = new System.Drawing.Point(313, 132);
			this.drinkDescriptionTextBox.MaxLength = 30;
			this.drinkDescriptionTextBox.Multiline = true;
			this.drinkDescriptionTextBox.Name = "drinkDescriptionTextBox";
			this.drinkDescriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.drinkDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.drinkDescriptionTextBox.Size = new System.Drawing.Size(250, 140);
			this.drinkDescriptionTextBox.TabIndex = 2;
			this.drinkDescriptionTextBox.Text = "توضیحات";
			this.drinkDescriptionTextBox.TextChanged += new System.EventHandler(this.DrinkDescriptionTextBox_TextChanged);
			this.drinkDescriptionTextBox.Enter += new System.EventHandler(this.DrinkDescriptionTextBox_Enter);
			this.drinkDescriptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrinkDescriptionTextBox_KeyPress);
			this.drinkDescriptionTextBox.Leave += new System.EventHandler(this.DrinkDescriptionTextBox_Leave);
			// 
			// drinkNameTextBox
			// 
			this.drinkNameTextBox.BackColor = System.Drawing.Color.LightCoral;
			this.drinkNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.drinkNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.drinkNameTextBox.Location = new System.Drawing.Point(313, 54);
			this.drinkNameTextBox.MaxLength = 30;
			this.drinkNameTextBox.Name = "drinkNameTextBox";
			this.drinkNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.drinkNameTextBox.Size = new System.Drawing.Size(250, 17);
			this.drinkNameTextBox.TabIndex = 0;
			this.drinkNameTextBox.Text = "نام نوشیدنی";
			this.drinkNameTextBox.TextChanged += new System.EventHandler(this.DrinkNameTextBox_TextChanged);
			this.drinkNameTextBox.Enter += new System.EventHandler(this.DrinkNameTextBox_Enter);
			this.drinkNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrinkNameTextBox_KeyPress);
			this.drinkNameTextBox.Leave += new System.EventHandler(this.DrinkNameTextBox_Leave);
			// 
			// drinkPricePanel
			// 
			this.drinkPricePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.drinkPricePanel.Location = new System.Drawing.Point(313, 114);
			this.drinkPricePanel.Name = "drinkPricePanel";
			this.drinkPricePanel.Size = new System.Drawing.Size(250, 2);
			this.drinkPricePanel.TabIndex = 15;
			// 
			// drinkNamePanel
			// 
			this.drinkNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.drinkNamePanel.Location = new System.Drawing.Point(313, 77);
			this.drinkNamePanel.Name = "drinkNamePanel";
			this.drinkNamePanel.Size = new System.Drawing.Size(250, 2);
			this.drinkNamePanel.TabIndex = 14;
			// 
			// drinkPriceTextBox
			// 
			this.drinkPriceTextBox.BackColor = System.Drawing.Color.LightCoral;
			this.drinkPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.drinkPriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.drinkPriceTextBox.Location = new System.Drawing.Point(313, 91);
			this.drinkPriceTextBox.MaxLength = 30;
			this.drinkPriceTextBox.Name = "drinkPriceTextBox";
			this.drinkPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.drinkPriceTextBox.Size = new System.Drawing.Size(250, 17);
			this.drinkPriceTextBox.TabIndex = 1;
			this.drinkPriceTextBox.Text = "قیمت";
			this.drinkPriceTextBox.TextChanged += new System.EventHandler(this.DrinkPriceTextBox_TextChanged);
			this.drinkPriceTextBox.Enter += new System.EventHandler(this.DrinkPriceTextBox_Enter);
			this.drinkPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrinkPriceTextBox_KeyPress);
			this.drinkPriceTextBox.Leave += new System.EventHandler(this.DrinkPriceTextBox_Leave);
			// 
			// deleteDrinkImageButton
			// 
			this.deleteDrinkImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteDrinkImageButton.BackgroundImage")));
			this.deleteDrinkImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.deleteDrinkImageButton.FlatAppearance.BorderSize = 0;
			this.deleteDrinkImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteDrinkImageButton.Location = new System.Drawing.Point(37, 54);
			this.deleteDrinkImageButton.MaximumSize = new System.Drawing.Size(25, 25);
			this.deleteDrinkImageButton.MinimumSize = new System.Drawing.Size(25, 25);
			this.deleteDrinkImageButton.Name = "deleteDrinkImageButton";
			this.deleteDrinkImageButton.Size = new System.Drawing.Size(25, 25);
			this.deleteDrinkImageButton.TabIndex = 19;
			this.deleteDrinkImageButton.UseVisualStyleBackColor = true;
			this.deleteDrinkImageButton.Visible = false;
			this.deleteDrinkImageButton.Click += new System.EventHandler(this.DeleteDrinkImageButton_Click);
			// 
			// drinkImagePicturBox
			// 
			this.drinkImagePicturBox.Image = global::HOOKAH_SALON.Properties.Resources.drink_512;
			this.drinkImagePicturBox.Location = new System.Drawing.Point(68, 54);
			this.drinkImagePicturBox.Name = "drinkImagePicturBox";
			this.drinkImagePicturBox.Size = new System.Drawing.Size(190, 230);
			this.drinkImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.drinkImagePicturBox.TabIndex = 18;
			this.drinkImagePicturBox.TabStop = false;
			this.drinkImagePicturBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DrinkImagePicturBox_MouseDoubleClick);
			// 
			// drinkEditeFormBunifuElipse
			// 
			this.drinkEditeFormBunifuElipse.ElipseRadius = 25;
			this.drinkEditeFormBunifuElipse.TargetControl = this;
			// 
			// DrinkEditeForm
			// 
			this.AcceptButton = this.updateDataDrinkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCoral;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.deleteDrinkImageButton);
			this.Controls.Add(this.updateDataDrinkButton);
			this.Controls.Add(this.drinkImagePicturBox);
			this.Controls.Add(this.drinkDescriptionPanel);
			this.Controls.Add(this.drinkDescriptionTextBox);
			this.Controls.Add(this.drinkNameTextBox);
			this.Controls.Add(this.drinkPricePanel);
			this.Controls.Add(this.drinkNamePanel);
			this.Controls.Add(this.drinkPriceTextBox);
			this.Controls.Add(this.titelPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.MaximumSize = new System.Drawing.Size(600, 400);
			this.MinimumSize = new System.Drawing.Size(600, 400);
			this.Name = "DrinkEditeForm";
			this.Text = "DrinkEditeForm";
			this.Load += new System.EventHandler(this.DrinkEditeForm_Load);
			this.titelPanel.ResumeLayout(false);
			this.titelPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RegisterLogoPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.drinkImagePicturBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.Panel titelPanel;
		private Mbb.Windows.Forms.Label hookahStoreTitleLabel;
		private Mbb.Windows.Forms.Button minimizButton;
		private Mbb.Windows.Forms.PicturBox RegisterLogoPicturBox;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Button deleteDrinkImageButton;
		private Mbb.Windows.Forms.Button updateDataDrinkButton;
		private Mbb.Windows.Forms.PicturBox drinkImagePicturBox;
		private Mbb.Windows.Forms.Panel drinkDescriptionPanel;
		private Mbb.Windows.Forms.TextBox drinkDescriptionTextBox;
		private Mbb.Windows.Forms.TextBox drinkNameTextBox;
		private Mbb.Windows.Forms.Panel drinkPricePanel;
		private Mbb.Windows.Forms.Panel drinkNamePanel;
		private Mbb.Windows.Forms.TextBox drinkPriceTextBox;
		private Bunifu.Framework.UI.BunifuElipse drinkEditeFormBunifuElipse;
	}
}