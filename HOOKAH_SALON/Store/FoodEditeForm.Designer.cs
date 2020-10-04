namespace HOOKAH_SALON.Store
{
	partial class FoodEditeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodEditeForm));
			this.titelPanel = new Mbb.Windows.Forms.Panel();
			this.foodStoreTitleLabel = new Mbb.Windows.Forms.Label();
			this.minimizButton = new Mbb.Windows.Forms.Button();
			this.RegisterLogoPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.deleteFoodImageButton = new Mbb.Windows.Forms.Button();
			this.updateDataFoodButton = new Mbb.Windows.Forms.Button();
			this.foodImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.foodDescriptionPanel = new Mbb.Windows.Forms.Panel();
			this.foodDescriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.foodNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.foodPricePanel = new Mbb.Windows.Forms.Panel();
			this.foodNamePanel = new Mbb.Windows.Forms.Panel();
			this.foodPriceTextBox = new Mbb.Windows.Forms.TextBox();
			this.foodEditFormBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.titelPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RegisterLogoPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foodImagePicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// titelPanel
			// 
			this.titelPanel.Controls.Add(this.foodStoreTitleLabel);
			this.titelPanel.Controls.Add(this.minimizButton);
			this.titelPanel.Controls.Add(this.RegisterLogoPicturBox);
			this.titelPanel.Controls.Add(this.closeButton);
			this.titelPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titelPanel.Location = new System.Drawing.Point(0, 0);
			this.titelPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.titelPanel.Name = "titelPanel";
			this.titelPanel.Size = new System.Drawing.Size(600, 30);
			this.titelPanel.TabIndex = 11;
			// 
			// foodStoreTitleLabel
			// 
			this.foodStoreTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.foodStoreTitleLabel.AutoSize = true;
			this.foodStoreTitleLabel.BackColor = System.Drawing.Color.Transparent;
			this.foodStoreTitleLabel.ForeColor = System.Drawing.Color.Black;
			this.foodStoreTitleLabel.Location = new System.Drawing.Point(505, 7);
			this.foodStoreTitleLabel.Name = "foodStoreTitleLabel";
			this.foodStoreTitleLabel.Size = new System.Drawing.Size(59, 17);
			this.foodStoreTitleLabel.TabIndex = 18;
			this.foodStoreTitleLabel.Text = "ویرایش غذا";
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
			// deleteFoodImageButton
			// 
			this.deleteFoodImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteFoodImageButton.BackgroundImage")));
			this.deleteFoodImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.deleteFoodImageButton.FlatAppearance.BorderSize = 0;
			this.deleteFoodImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteFoodImageButton.Location = new System.Drawing.Point(37, 54);
			this.deleteFoodImageButton.MaximumSize = new System.Drawing.Size(25, 25);
			this.deleteFoodImageButton.MinimumSize = new System.Drawing.Size(25, 25);
			this.deleteFoodImageButton.Name = "deleteFoodImageButton";
			this.deleteFoodImageButton.Size = new System.Drawing.Size(25, 25);
			this.deleteFoodImageButton.TabIndex = 28;
			this.deleteFoodImageButton.UseVisualStyleBackColor = true;
			this.deleteFoodImageButton.Visible = false;
			this.deleteFoodImageButton.Click += new System.EventHandler(this.DeleteFoodImageButton_Click);
			// 
			// updateDataFoodButton
			// 
			this.updateDataFoodButton.BackColor = System.Drawing.Color.DarkGreen;
			this.updateDataFoodButton.FlatAppearance.BorderSize = 0;
			this.updateDataFoodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateDataFoodButton.ForeColor = System.Drawing.Color.White;
			this.updateDataFoodButton.Location = new System.Drawing.Point(224, 316);
			this.updateDataFoodButton.Name = "updateDataFoodButton";
			this.updateDataFoodButton.Size = new System.Drawing.Size(150, 30);
			this.updateDataFoodButton.TabIndex = 3;
			this.updateDataFoodButton.Text = "به روز رسانی";
			this.updateDataFoodButton.UseVisualStyleBackColor = false;
			this.updateDataFoodButton.Click += new System.EventHandler(this.UpdateDataFoodButton_Click);
			// 
			// foodImagePicturBox
			// 
			this.foodImagePicturBox.Image = global::HOOKAH_SALON.Properties.Resources.pizza_food_512px;
			this.foodImagePicturBox.Location = new System.Drawing.Point(68, 54);
			this.foodImagePicturBox.Name = "foodImagePicturBox";
			this.foodImagePicturBox.Size = new System.Drawing.Size(190, 230);
			this.foodImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.foodImagePicturBox.TabIndex = 27;
			this.foodImagePicturBox.TabStop = false;
			this.foodImagePicturBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DrinkImagePicturBox_MouseDoubleClick);
			// 
			// foodDescriptionPanel
			// 
			this.foodDescriptionPanel.BackColor = System.Drawing.Color.Black;
			this.foodDescriptionPanel.ForeColor = System.Drawing.Color.Black;
			this.foodDescriptionPanel.Location = new System.Drawing.Point(313, 278);
			this.foodDescriptionPanel.Name = "foodDescriptionPanel";
			this.foodDescriptionPanel.Size = new System.Drawing.Size(250, 2);
			this.foodDescriptionPanel.TabIndex = 26;
			// 
			// foodDescriptionTextBox
			// 
			this.foodDescriptionTextBox.BackColor = System.Drawing.Color.SeaGreen;
			this.foodDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.foodDescriptionTextBox.ForeColor = System.Drawing.Color.Black;
			this.foodDescriptionTextBox.Location = new System.Drawing.Point(313, 132);
			this.foodDescriptionTextBox.MaxLength = 30;
			this.foodDescriptionTextBox.Multiline = true;
			this.foodDescriptionTextBox.Name = "foodDescriptionTextBox";
			this.foodDescriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.foodDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.foodDescriptionTextBox.Size = new System.Drawing.Size(250, 140);
			this.foodDescriptionTextBox.TabIndex = 2;
			this.foodDescriptionTextBox.Text = "توضیحات";
			this.foodDescriptionTextBox.TextChanged += new System.EventHandler(this.FoodDescriptionTextBox_TextChanged);
			this.foodDescriptionTextBox.Enter += new System.EventHandler(this.FoodDescriptionTextBox_Enter);
			this.foodDescriptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodDescriptionTextBox_KeyPress);
			this.foodDescriptionTextBox.Leave += new System.EventHandler(this.FoodDescriptionTextBox_Leave);
			// 
			// foodNameTextBox
			// 
			this.foodNameTextBox.BackColor = System.Drawing.Color.SeaGreen;
			this.foodNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.foodNameTextBox.ForeColor = System.Drawing.Color.Black;
			this.foodNameTextBox.Location = new System.Drawing.Point(313, 54);
			this.foodNameTextBox.MaxLength = 30;
			this.foodNameTextBox.Name = "foodNameTextBox";
			this.foodNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.foodNameTextBox.Size = new System.Drawing.Size(250, 17);
			this.foodNameTextBox.TabIndex = 0;
			this.foodNameTextBox.Text = "نام غذا";
			this.foodNameTextBox.TextChanged += new System.EventHandler(this.FoodNameTextBox_TextChanged);
			this.foodNameTextBox.Enter += new System.EventHandler(this.FoodNameTextBox_Enter);
			this.foodNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodNameTextBox_KeyPress);
			this.foodNameTextBox.Leave += new System.EventHandler(this.FoodNameTextBox_Leave);
			// 
			// foodPricePanel
			// 
			this.foodPricePanel.BackColor = System.Drawing.Color.Black;
			this.foodPricePanel.ForeColor = System.Drawing.Color.Black;
			this.foodPricePanel.Location = new System.Drawing.Point(313, 114);
			this.foodPricePanel.Name = "foodPricePanel";
			this.foodPricePanel.Size = new System.Drawing.Size(250, 2);
			this.foodPricePanel.TabIndex = 24;
			// 
			// foodNamePanel
			// 
			this.foodNamePanel.BackColor = System.Drawing.Color.Black;
			this.foodNamePanel.ForeColor = System.Drawing.Color.Black;
			this.foodNamePanel.Location = new System.Drawing.Point(313, 77);
			this.foodNamePanel.Name = "foodNamePanel";
			this.foodNamePanel.Size = new System.Drawing.Size(250, 2);
			this.foodNamePanel.TabIndex = 23;
			// 
			// foodPriceTextBox
			// 
			this.foodPriceTextBox.BackColor = System.Drawing.Color.SeaGreen;
			this.foodPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.foodPriceTextBox.ForeColor = System.Drawing.Color.Black;
			this.foodPriceTextBox.Location = new System.Drawing.Point(313, 91);
			this.foodPriceTextBox.MaxLength = 30;
			this.foodPriceTextBox.Name = "foodPriceTextBox";
			this.foodPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.foodPriceTextBox.Size = new System.Drawing.Size(250, 17);
			this.foodPriceTextBox.TabIndex = 1;
			this.foodPriceTextBox.Text = "قیمت";
			this.foodPriceTextBox.TextChanged += new System.EventHandler(this.FoodPriceTextBox_TextChanged);
			this.foodPriceTextBox.Enter += new System.EventHandler(this.FoodPriceTextBox_Enter);
			this.foodPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodPriceTextBox_KeyPress);
			this.foodPriceTextBox.Leave += new System.EventHandler(this.FoodPriceTextBox_Leave);
			// 
			// foodEditFormBunifuElipse
			// 
			this.foodEditFormBunifuElipse.ElipseRadius = 25;
			this.foodEditFormBunifuElipse.TargetControl = this;
			// 
			// FoodEditeForm
			// 
			this.AcceptButton = this.updateDataFoodButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaGreen;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.deleteFoodImageButton);
			this.Controls.Add(this.updateDataFoodButton);
			this.Controls.Add(this.foodImagePicturBox);
			this.Controls.Add(this.foodDescriptionPanel);
			this.Controls.Add(this.foodDescriptionTextBox);
			this.Controls.Add(this.foodNameTextBox);
			this.Controls.Add(this.foodPricePanel);
			this.Controls.Add(this.foodNamePanel);
			this.Controls.Add(this.foodPriceTextBox);
			this.Controls.Add(this.titelPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FoodEditeForm";
			this.Text = "FoodEditeForm";
			this.Load += new System.EventHandler(this.FoodEditeForm_Load);
			this.titelPanel.ResumeLayout(false);
			this.titelPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RegisterLogoPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foodImagePicturBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.Panel titelPanel;
		private Mbb.Windows.Forms.Label foodStoreTitleLabel;
		private Mbb.Windows.Forms.Button minimizButton;
		private Mbb.Windows.Forms.PicturBox RegisterLogoPicturBox;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Button deleteFoodImageButton;
		private Mbb.Windows.Forms.Button updateDataFoodButton;
		private Mbb.Windows.Forms.PicturBox foodImagePicturBox;
		private Mbb.Windows.Forms.Panel foodDescriptionPanel;
		private Mbb.Windows.Forms.TextBox foodDescriptionTextBox;
		private Mbb.Windows.Forms.TextBox foodNameTextBox;
		private Mbb.Windows.Forms.Panel foodPricePanel;
		private Mbb.Windows.Forms.Panel foodNamePanel;
		private Mbb.Windows.Forms.TextBox foodPriceTextBox;
		private Bunifu.Framework.UI.BunifuElipse foodEditFormBunifuElipse;
	}
}