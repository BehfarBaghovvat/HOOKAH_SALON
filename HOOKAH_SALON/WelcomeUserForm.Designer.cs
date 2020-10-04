namespace HOOKAH_SALON
{
	partial class WelcomeUserForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeUserForm));
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.namePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.usernameLabel = new Mbb.Windows.Forms.Label();
			this.persainCalendarLabel = new Mbb.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.welcomeUserFormBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.panel3 = new Mbb.Windows.Forms.Panel();
			this.bunifuCircleProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
			this.userImagePicturBox = new Mbb.Windows.Forms.CircularPictureBox();
			this.label1 = new Mbb.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.namePicturBox)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.panel2.Controls.Add(this.namePicturBox);
			this.panel2.Controls.Add(this.usernameLabel);
			this.panel2.Controls.Add(this.persainCalendarLabel);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 100);
			this.panel2.TabIndex = 1;
			// 
			// namePicturBox
			// 
			this.namePicturBox.BackColor = System.Drawing.Color.Transparent;
			this.namePicturBox.Image = ((System.Drawing.Image)(resources.GetObject("namePicturBox.Image")));
			this.namePicturBox.Location = new System.Drawing.Point(228, 12);
			this.namePicturBox.MaximumSize = new System.Drawing.Size(345, 60);
			this.namePicturBox.MinimumSize = new System.Drawing.Size(345, 60);
			this.namePicturBox.Name = "namePicturBox";
			this.namePicturBox.Size = new System.Drawing.Size(345, 60);
			this.namePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.namePicturBox.TabIndex = 1;
			this.namePicturBox.TabStop = false;
			// 
			// usernameLabel
			// 
			this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
			this.usernameLabel.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.usernameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.usernameLabel.Location = new System.Drawing.Point(595, 65);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.usernameLabel.Size = new System.Drawing.Size(200, 30);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "نام کاربر";
			this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.usernameLabel.UseCompatibleTextRendering = true;
			// 
			// persainCalendarLabel
			// 
			this.persainCalendarLabel.BackColor = System.Drawing.Color.Transparent;
			this.persainCalendarLabel.Font = new System.Drawing.Font("IRANSansFaNum", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.persainCalendarLabel.ForeColor = System.Drawing.Color.Gold;
			this.persainCalendarLabel.Location = new System.Drawing.Point(5, 65);
			this.persainCalendarLabel.Name = "persainCalendarLabel";
			this.persainCalendarLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.persainCalendarLabel.Size = new System.Drawing.Size(200, 30);
			this.persainCalendarLabel.TabIndex = 0;
			this.persainCalendarLabel.Text = "تقویم شمسی";
			this.persainCalendarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.persainCalendarLabel.UseCompatibleTextRendering = true;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			// 
			// welcomeUserFormBunifuElipse
			// 
			this.welcomeUserFormBunifuElipse.ElipseRadius = 20;
			this.welcomeUserFormBunifuElipse.TargetControl = this;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(554, 100);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(246, 350);
			this.panel1.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel3.Controls.Add(this.bunifuCircleProgressbar);
			this.panel3.Controls.Add(this.userImagePicturBox);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 100);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(554, 350);
			this.panel3.TabIndex = 4;
			// 
			// bunifuCircleProgressbar
			// 
			this.bunifuCircleProgressbar.animated = false;
			this.bunifuCircleProgressbar.animationIterval = 5;
			this.bunifuCircleProgressbar.animationSpeed = 300;
			this.bunifuCircleProgressbar.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCircleProgressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar.BackgroundImage")));
			this.bunifuCircleProgressbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuCircleProgressbar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCircleProgressbar.ForeColor = System.Drawing.Color.Green;
			this.bunifuCircleProgressbar.LabelVisible = true;
			this.bunifuCircleProgressbar.LineProgressThickness = 8;
			this.bunifuCircleProgressbar.LineThickness = 5;
			this.bunifuCircleProgressbar.Location = new System.Drawing.Point(22, 259);
			this.bunifuCircleProgressbar.Margin = new System.Windows.Forms.Padding(6);
			this.bunifuCircleProgressbar.MaxValue = 100;
			this.bunifuCircleProgressbar.Name = "bunifuCircleProgressbar";
			this.bunifuCircleProgressbar.ProgressBackColor = System.Drawing.Color.Gainsboro;
			this.bunifuCircleProgressbar.ProgressColor = System.Drawing.Color.DarkViolet;
			this.bunifuCircleProgressbar.Size = new System.Drawing.Size(82, 82);
			this.bunifuCircleProgressbar.TabIndex = 12;
			this.bunifuCircleProgressbar.Value = 0;
			// 
			// userImagePicturBox
			// 
			this.userImagePicturBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userImagePicturBox.BackColor = System.Drawing.Color.Transparent;
			this.userImagePicturBox.BackgroundImage = global::HOOKAH_SALON.Properties.Resources.user_1024;
			this.userImagePicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.userImagePicturBox.Image = ((System.Drawing.Image)(resources.GetObject("userImagePicturBox.Image")));
			this.userImagePicturBox.Location = new System.Drawing.Point(13, 3);
			this.userImagePicturBox.Name = "userImagePicturBox";
			this.userImagePicturBox.Size = new System.Drawing.Size(100, 100);
			this.userImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.userImagePicturBox.TabIndex = 10;
			this.userImagePicturBox.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.Silver;
			this.label1.Location = new System.Drawing.Point(397, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 42);
			this.label1.TabIndex = 11;
			this.label1.Text = "خوش آمدید";
			// 
			// WelcomeUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.MaximumSize = new System.Drawing.Size(800, 450);
			this.MinimumSize = new System.Drawing.Size(800, 450);
			this.Name = "WelcomeUserForm";
			this.Opacity = 0.95D;
			this.Text = "WelcomeUserForm";
			this.Load += new System.EventHandler(this.WelcomeUserForm_Load);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.namePicturBox)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.Label usernameLabel;
		private Mbb.Windows.Forms.Label persainCalendarLabel;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private Bunifu.Framework.UI.BunifuElipse welcomeUserFormBunifuElipse;
		private Mbb.Windows.Forms.Panel panel1;
		private Mbb.Windows.Forms.Panel panel3;
		private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar;
		private Mbb.Windows.Forms.CircularPictureBox userImagePicturBox;
		private Mbb.Windows.Forms.Label label1;
		private Mbb.Windows.Forms.PicturBox namePicturBox;
	}
}