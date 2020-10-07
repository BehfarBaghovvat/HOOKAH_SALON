namespace HOOKAH_SALON
{
	public partial class ShowUserImageForm : Infrastructure.BaseForm
	{
		public ShowUserImageForm()
		{
			InitializeComponent();
		}

		#region ShowUserImageForm_Load
		private void ShowUserImageForm_Load(object sender, System.EventArgs e)
		{
			var image = Program.AuthenticatedUser.User_Image;

			using (System.IO.MemoryStream userImagMS = new System.IO.MemoryStream(image))
			{
				userImagePicturBox.BackgroundImage = System.Drawing.Image.FromStream(userImagMS);
			}
		}

		#endregion /ShowUserImageForm_Load

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		#endregion /CloseButton_Click
	}
}
