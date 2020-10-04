namespace HOOKAH_SALON
{
	partial class ShowUserImageForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowUserImageForm));
			this.showUserImageFormBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.userImagePicturBox = new Mbb.Windows.Forms.CircularPictureBox();
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// showUserImageFormBunifuElipse
			// 
			this.showUserImageFormBunifuElipse.ElipseRadius = 50;
			this.showUserImageFormBunifuElipse.TargetControl = this;
			// 
			// userImagePicturBox
			// 
			this.userImagePicturBox.BackColor = System.Drawing.Color.Gray;
			this.userImagePicturBox.BackgroundImage = global::HOOKAH_SALON.Properties.Resources.user_1024;
			this.userImagePicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.userImagePicturBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userImagePicturBox.Image = ((System.Drawing.Image)(resources.GetObject("userImagePicturBox.Image")));
			this.userImagePicturBox.Location = new System.Drawing.Point(0, 0);
			this.userImagePicturBox.Name = "userImagePicturBox";
			this.userImagePicturBox.Size = new System.Drawing.Size(400, 400);
			this.userImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userImagePicturBox.TabIndex = 0;
			this.userImagePicturBox.TabStop = false;
			this.userImagePicturBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserImagePicturBox_MouseDoubleClick);
			// 
			// ShowUserImageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(400, 400);
			this.Controls.Add(this.userImagePicturBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(400, 400);
			this.MinimumSize = new System.Drawing.Size(400, 400);
			this.Name = "ShowUserImageForm";
			this.Text = "ShowUserImageForm";
			this.Load += new System.EventHandler(this.ShowUserImageForm_Load);
			this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShowUserImageForm_MouseDoubleClick);
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Bunifu.Framework.UI.BunifuElipse showUserImageFormBunifuElipse;
		private Mbb.Windows.Forms.CircularPictureBox userImagePicturBox;
	}
}