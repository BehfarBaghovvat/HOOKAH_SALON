using System;
using System.Windows.Forms;

namespace Mbb.Windows.Forms
{
	public class MessageBox
	{
		//System.Windows.Forms.MessageBox.Show("Test");

		//-----Begining of the codes.
		#region Show
		public static System.Windows.Forms.DialogResult Show(string text, string caption, MessageBoxIcon icon, MessageBoxButtons button )
		{
			System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.DialogResult.None;
			//----Single Button
			if (icon == MessageBoxIcon.Success && button == MessageBoxButtons.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.succes_512;
					messageBox.BackColor = System.Drawing.Color.SeaGreen;
					messageBox.OKBackColor = System.Drawing.Color.Green;
					messageBox.OKName = "باشه";
					dialogResult =  messageBox.ShowDialog();
				}
			}

			else if (icon == MessageBoxIcon.Information && button == MessageBoxButtons.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.info_512;
					messageBox.BackColor = System.Drawing.Color.RoyalBlue;
					messageBox.OKBackColor = System.Drawing.Color.FromArgb(0, 85, 225);
					messageBox.OKName = "باشه";
					dialogResult = messageBox.ShowDialog();
				}
			}
			if (icon == MessageBoxIcon.None && button == MessageBoxButtons.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.none_512;
					messageBox.BackColor = System.Drawing.Color.DarkGray;
					messageBox.OKBackColor = System.Drawing.Color.Gray;
					messageBox.OKName = "باشه";
					dialogResult = messageBox.ShowDialog();
				}
			}
			if (icon == MessageBoxIcon.Error && button == MessageBoxButtons.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.error_512;
					messageBox.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
					messageBox.OKBackColor = System.Drawing.Color.Orange;
					messageBox.OKName = "باشه";
					dialogResult = messageBox.ShowDialog();
				}
			}
			if (icon == MessageBoxIcon.Warning && button == MessageBoxButtons.Ok)
			{
				using (MessageBoxSIBForm messageBox = new MessageBoxSIBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.warning_512;
					messageBox.BackColor = System.Drawing.Color.DarkRed;
					messageBox.OKBackColor = System.Drawing.Color.Red;
					messageBox.OKName = "باشه";
					dialogResult = messageBox.ShowDialog();
				}
			}

			//-----Double Buttons
			if (icon == MessageBoxIcon.Question && button == MessageBoxButtons.YesNo)
			{
				using (MessageBoxDOBForm messageBox = new MessageBoxDOBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.question_512;
					messageBox.BackColor = System.Drawing.Color.RoyalBlue;
					messageBox.YesOkBackColor = System.Drawing.Color.FromArgb(0, 85, 225);
					messageBox.YesOkName = "بله";
					messageBox.NoCancelBackColor = System.Drawing.Color.Blue;
					messageBox.NoCancelName = "خیر";
					dialogResult = messageBox.ShowDialog();
				}
			}
			if (icon == MessageBoxIcon.Alert && button == MessageBoxButtons.YesNo)
			{
				using (MessageBoxDOBForm messageBox = new MessageBoxDOBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.alert_512px;
					messageBox.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
					messageBox.YesOkBackColor = System.Drawing.Color.Orange;
					messageBox.YesOkName = "بله";
					messageBox.NoCancelBackColor = System.Drawing.Color.Orange;
					messageBox.NoCancelName = "خیر";
					dialogResult = messageBox.ShowDialog();
				}
			}
			if (icon == MessageBoxIcon.Warning && button == MessageBoxButtons.YesNo)
			{
				using (MessageBoxDOBForm messageBox = new MessageBoxDOBForm())
				{
					messageBox.Message = text;
					messageBox.Caption = caption;
					messageBox.Icon = Properties.Resources.warning_512;
					messageBox.BackColor = System.Drawing.Color.DarkRed;
					messageBox.YesOkBackColor = System.Drawing.Color.Red;
					messageBox.YesOkName = "بله";
					messageBox.NoCancelBackColor = System.Drawing.Color.Red;
					messageBox.NoCancelName = "خیر";
					dialogResult = messageBox.ShowDialog();

				}

			}

			//-----Sobel Buttons
			return dialogResult;

		}
		#endregion /Show

	}
}
