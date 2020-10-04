using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Mbb.Windows.Forms
{
	public partial class MessageBoxDOBForm : Form
	{
		private string message;

		public MessageBoxDOBForm()
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
		public System.Drawing.Color YesOkBackColor
		{
			get
			{
				return yesOkButton.BackColor;
			}
			set
			{
				yesOkButton.BackColor = value;
			}
		}
		public string YesOkName
		{
			get
			{
				return yesOkButton.Text;
			}
			set
			{
				yesOkButton.Text = value;
			}
		}
		public System.Drawing.Color NoCancelBackColor
		{
			get
			{
				return noCancelButton.BackColor;
			}
			set
			{
				noCancelButton.BackColor = value;
			}
		}
		public string NoCancelName
		{
			get
			{
				return noCancelButton.Text;
			}
			set
			{
				noCancelButton.Text = value;
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
			//this.Size = new System.Drawing.Size(width: this.Width, height: this.Height + messageLabel.Height);
		}
		#endregion /MessageLabel_SizeChanged

		private void messageLabel_TextChanged(object sender, System.EventArgs e)
		{
			//message = messageLabel.Text;

			//using (Graphics g = CreateGraphics())
			//{
			//	SizeF size = g.MeasureString(message, messageLabel.Font, messageLabel.Width);
			//	messageLabel.Height = (int)Math.Ceiling(size.Height);
			//	messageLabel.Text = message;
			//}
			//this.Height = messageLabel.Height + 50;
		}

		private void MessageBoxDOBForm_Load(object sender, System.EventArgs e)
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
