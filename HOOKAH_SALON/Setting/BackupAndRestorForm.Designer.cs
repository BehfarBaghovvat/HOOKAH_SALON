namespace HOOKAH_SALON.Setting
{
	partial class BackupAndRestorForm
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
			this.backupButton = new Mbb.Windows.Forms.Button();
			this.groupBox1 = new Mbb.Windows.Forms.GroupBox();
			this.selectSavePathButton = new Mbb.Windows.Forms.Button();
			this.savePathPanel = new Mbb.Windows.Forms.Panel();
			this.groupBox2 = new Mbb.Windows.Forms.GroupBox();
			this.selectLoadPathButton = new Mbb.Windows.Forms.Button();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.loadBackupButton = new Mbb.Windows.Forms.Button();
			this.savePathTextBox = new Mbb.Windows.Forms.TextBox();
			this.loadPathTextBox = new Mbb.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// backupButton
			// 
			this.backupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.backupButton.FlatAppearance.BorderSize = 0;
			this.backupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backupButton.Location = new System.Drawing.Point(166, 155);
			this.backupButton.Name = "backupButton";
			this.backupButton.Size = new System.Drawing.Size(150, 23);
			this.backupButton.TabIndex = 2;
			this.backupButton.Text = "تهیه نسخه پشتیبان";
			this.backupButton.UseVisualStyleBackColor = false;
			this.backupButton.Click += new System.EventHandler(this.BackupButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.savePathTextBox);
			this.groupBox1.Controls.Add(this.selectSavePathButton);
			this.groupBox1.Controls.Add(this.savePathPanel);
			this.groupBox1.Controls.Add(this.backupButton);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(535, 65);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox1.Size = new System.Drawing.Size(450, 200);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "گرفتن نسخه پشتیبان";
			// 
			// selectSavePathButton
			// 
			this.selectSavePathButton.BackColor = System.Drawing.Color.Teal;
			this.selectSavePathButton.FlatAppearance.BorderSize = 0;
			this.selectSavePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.selectSavePathButton.Location = new System.Drawing.Point(337, 88);
			this.selectSavePathButton.Name = "selectSavePathButton";
			this.selectSavePathButton.Size = new System.Drawing.Size(100, 25);
			this.selectSavePathButton.TabIndex = 3;
			this.selectSavePathButton.Text = "انتخاب مسیر";
			this.selectSavePathButton.UseVisualStyleBackColor = false;
			this.selectSavePathButton.Click += new System.EventHandler(this.SelectSavePathButton_Click);
			// 
			// savePathPanel
			// 
			this.savePathPanel.BackColor = System.Drawing.Color.White;
			this.savePathPanel.Location = new System.Drawing.Point(6, 111);
			this.savePathPanel.Name = "savePathPanel";
			this.savePathPanel.Size = new System.Drawing.Size(325, 2);
			this.savePathPanel.TabIndex = 6;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.loadPathTextBox);
			this.groupBox2.Controls.Add(this.selectLoadPathButton);
			this.groupBox2.Controls.Add(this.panel2);
			this.groupBox2.Controls.Add(this.loadBackupButton);
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(66, 65);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupBox2.Size = new System.Drawing.Size(450, 200);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "بازگردانی نسخه پشتیبان";
			// 
			// selectLoadPathButton
			// 
			this.selectLoadPathButton.BackColor = System.Drawing.Color.Teal;
			this.selectLoadPathButton.FlatAppearance.BorderSize = 0;
			this.selectLoadPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.selectLoadPathButton.Location = new System.Drawing.Point(339, 88);
			this.selectLoadPathButton.Name = "selectLoadPathButton";
			this.selectLoadPathButton.Size = new System.Drawing.Size(100, 25);
			this.selectLoadPathButton.TabIndex = 9;
			this.selectLoadPathButton.Text = "انتخاب مسیر";
			this.selectLoadPathButton.UseVisualStyleBackColor = false;
			this.selectLoadPathButton.Click += new System.EventHandler(this.SelectLoadPathButton_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(10, 111);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(325, 2);
			this.panel2.TabIndex = 10;
			// 
			// loadBackupButton
			// 
			this.loadBackupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.loadBackupButton.FlatAppearance.BorderSize = 0;
			this.loadBackupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loadBackupButton.Location = new System.Drawing.Point(170, 155);
			this.loadBackupButton.Name = "loadBackupButton";
			this.loadBackupButton.Size = new System.Drawing.Size(150, 23);
			this.loadBackupButton.TabIndex = 8;
			this.loadBackupButton.Text = "بازگردانی نسخه پشتیبان";
			this.loadBackupButton.UseVisualStyleBackColor = false;
			this.loadBackupButton.Click += new System.EventHandler(this.LoadBackupButton_Click);
			// 
			// savePathTextBox
			// 
			this.savePathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
			this.savePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.savePathTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.savePathTextBox.ForeColor = System.Drawing.Color.Gray;
			this.savePathTextBox.HideSelection = false;
			this.savePathTextBox.Location = new System.Drawing.Point(6, 86);
			this.savePathTextBox.Name = "savePathTextBox";
			this.savePathTextBox.ReadOnly = true;
			this.savePathTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.savePathTextBox.ShortcutsEnabled = false;
			this.savePathTextBox.Size = new System.Drawing.Size(325, 17);
			this.savePathTextBox.TabIndex = 7;
			this.savePathTextBox.Text = "Save Path...";
			// 
			// loadPathTextBox
			// 
			this.loadPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
			this.loadPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.loadPathTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loadPathTextBox.ForeColor = System.Drawing.Color.Gray;
			this.loadPathTextBox.HideSelection = false;
			this.loadPathTextBox.Location = new System.Drawing.Point(10, 88);
			this.loadPathTextBox.Name = "loadPathTextBox";
			this.loadPathTextBox.ReadOnly = true;
			this.loadPathTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.loadPathTextBox.ShortcutsEnabled = false;
			this.loadPathTextBox.Size = new System.Drawing.Size(325, 17);
			this.loadPathTextBox.TabIndex = 11;
			this.loadPathTextBox.Text = "Load Path...";
			// 
			// BackupAndRestorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1050, 485);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "BackupAndRestorForm";
			this.Text = "BackupAndRestorForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Button backupButton;
		private Mbb.Windows.Forms.GroupBox groupBox1;
		private Mbb.Windows.Forms.GroupBox groupBox2;
		private Mbb.Windows.Forms.Button selectSavePathButton;
		private Mbb.Windows.Forms.Panel savePathPanel;
		private Mbb.Windows.Forms.Button selectLoadPathButton;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.Button loadBackupButton;
		private Mbb.Windows.Forms.TextBox savePathTextBox;
		private Mbb.Windows.Forms.TextBox loadPathTextBox;
	}
}