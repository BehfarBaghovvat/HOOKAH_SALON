namespace HOOKAH_SALON
{
	public partial class ShowUserImageForm : Infrastructure.BaseForm
	{
		public ShowUserImageForm()
		{
			InitializeComponent();
		}

		private void ShowUserImageForm_Load(object sender, System.EventArgs e)
		{
			var image = Program.AuthenticatedUser.User_Image;

			using (System.IO.MemoryStream userImagMS = new System.IO.MemoryStream(image))
			{
				userImagePicturBox.BackgroundImage = System.Drawing.Image.FromStream(userImagMS);
			}
		}

		private void ShowUserImageForm_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.Close();
		}

		private void UserImagePicturBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.Close();
		}
	}
}
