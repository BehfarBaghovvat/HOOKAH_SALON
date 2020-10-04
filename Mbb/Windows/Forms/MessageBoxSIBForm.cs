using System;
using System.Drawing;

namespace Mbb.Windows.Forms
{
	public partial class MessageBoxSIBForm : Form
	{
		private string message;

		public MessageBoxSIBForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string Message
		{
			get
			{
				return messageLabel.Text;
			}
			set
			{
				messageLabel.Text = value;
			}
		}
		public string Caption
		{
			get
			{
				return captionLabel.Text;
			}
			set
			{
				captionLabel.Text = value;
			}
		}
		public System.Drawing.Color OKBackColor
		{
			get
			{
				return okButton.BackColor;
			}
			set
			{
				okButton.BackColor = value;
			}
		}
		public string OKName
		{
			get
			{
				return okButton.Name;
			}
			set
			{
				okButton.Name = value;
			}
		}
		public new System.Drawing.Image Icon
		{
			get
			{
				return iconPicturBox.Image;
			}
			set
			{
				iconPicturBox.Image = value;
			}
		}
		#endregion /Properties

		//-----Begining of the codes.

		#region MessageLabel_SizeChanged
		private void MessageLabel_SizeChanged(object sender, System.EventArgs e)
		{
			///this.Size = new System.Drawing.Size(width: this.Width, height: this.Height + messageLabel.Height);
		}
		#endregion /MessageLabel_SizeChanged

		private void MessageLabel_TextChanged(object sender, System.EventArgs e)
		{
			//message = messageLabel.Text;

			//using (Graphics g = CreateGraphics())
			//{
			//	SizeF size = g.MeasureString(message, messageLabel.Font, messageLabel.Width);
			//	messageLabel.Height = (int)Math.Ceiling(size.Height);
			//	messageLabel.Text = message;
			//}
			//this.Height = messageLabel.Height + 80;
		}

		private void MessageBoxSIBForm_Load(object sender, EventArgs e)
		{
			message = messageLabel.Text;

			using (Graphics g = CreateGraphics())
			{
				SizeF size = g.MeasureString(message, messageLabel.Font, messageLabel.Width);
				messageLabel.Height = (int)Math.Ceiling(size.Height);
				messageLabel.Text = message;
			}
			this.Height = messageLabel.Height + 80;
		}
	}
}
