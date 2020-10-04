namespace Mbb.Windows.Forms
{
	partial class MessageBoxDOBForm
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
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.captionLabel = new Mbb.Windows.Forms.Label();
			this.noCancelButton = new Mbb.Windows.Forms.Button();
			this.yesOkButton = new Mbb.Windows.Forms.Button();
			this.messageBoxDOBFormBunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.iconPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.messageLabel = new Mbb.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.captionLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 30);
			this.panel1.TabIndex = 0;
			// 
			// captionLabel
			// 
			this.captionLabel.Dock = System.Windows.Forms.DockStyle.Right;
			this.captionLabel.ForeColor = System.Drawing.Color.White;
			this.captionLabel.Location = new System.Drawing.Point(325, 0);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(125, 30);
			this.captionLabel.TabIndex = 1;
			this.captionLabel.Text = "عنوان";
			this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// noCancelButton
			// 
			this.noCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.noCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
			this.noCancelButton.DialogResult = System.Windows.Forms.DialogResult.No;
			this.noCancelButton.FlatAppearance.BorderSize = 0;
			this.noCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.noCancelButton.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.noCancelButton.ForeColor = System.Drawing.Color.White;
			this.noCancelButton.Location = new System.Drawing.Point(228, 100);
			this.noCancelButton.Name = "noCancelButton";
			this.noCancelButton.Size = new System.Drawing.Size(95, 25);
			this.noCancelButton.TabIndex = 3;
			this.noCancelButton.Text = "خیر";
			this.noCancelButton.UseCompatibleTextRendering = true;
			this.noCancelButton.UseVisualStyleBackColor = false;
			// 
			// yesOkButton
			// 
			this.yesOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.yesOkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
			this.yesOkButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.yesOkButton.FlatAppearance.BorderSize = 0;
			this.yesOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.yesOkButton.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.yesOkButton.ForeColor = System.Drawing.Color.White;
			this.yesOkButton.Location = new System.Drawing.Point(127, 100);
			this.yesOkButton.Name = "yesOkButton";
			this.yesOkButton.Size = new System.Drawing.Size(95, 25);
			this.yesOkButton.TabIndex = 4;
			this.yesOkButton.Text = "بله";
			this.yesOkButton.UseCompatibleTextRendering = true;
			this.yesOkButton.UseVisualStyleBackColor = false;
			// 
			// messageBoxDOBFormBunifuElipse
			// 
			this.messageBoxDOBFormBunifuElipse.ElipseRadius = 20;
			this.messageBoxDOBFormBunifuElipse.TargetControl = this;
			// 
			// iconPicturBox
			// 
			this.iconPicturBox.Location = new System.Drawing.Point(388, 42);
			this.iconPicturBox.Name = "iconPicturBox";
			this.iconPicturBox.Size = new System.Drawing.Size(50, 50);
			this.iconPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.iconPicturBox.TabIndex = 5;
			this.iconPicturBox.TabStop = false;
			// 
			// messageLabel
			// 
			this.messageLabel.AutoEllipsis = true;
			this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.messageLabel.ForeColor = System.Drawing.Color.White;
			this.messageLabel.Location = new System.Drawing.Point(68, 36);
			this.messageLabel.Name = "messageLabel";
			this.messageLabel.Size = new System.Drawing.Size(314, 30);
			this.messageLabel.TabIndex = 8;
			this.messageLabel.Text = "پیغام";
			this.messageLabel.TextChanged += new System.EventHandler(this.messageLabel_TextChanged);
			// 
			// MessageBoxDOBForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(450, 135);
			this.Controls.Add(this.messageLabel);
			this.Controls.Add(this.iconPicturBox);
			this.Controls.Add(this.yesOkButton);
			this.Controls.Add(this.noCancelButton);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(450, 135);
			this.Name = "MessageBoxDOBForm";
			this.Opacity = 0.9D;
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "MessageBoxSIBForm";
			this.Load += new System.EventHandler(this.MessageBoxDOBForm_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.iconPicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Bunifu.Framework.UI.BunifuElipse messageBoxDOBFormBunifuElipse;
		private Label captionLabel;
		private PicturBox iconPicturBox;
		private Button noCancelButton;
		private Button yesOkButton;
		private Label messageLabel;
	}
}