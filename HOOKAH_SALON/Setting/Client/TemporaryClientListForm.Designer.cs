namespace HOOKAH_SALON.Setting.Client
{
	partial class TemporaryClientListForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.temporaryClientDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.temporaryClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberVisitsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastVisitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.registerTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.temporaryClientDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.temporaryClientBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// temporaryClientDataGridView
			// 
			this.temporaryClientDataGridView.AllowUserToAddRows = false;
			this.temporaryClientDataGridView.AllowUserToDeleteRows = false;
			this.temporaryClientDataGridView.AutoGenerateColumns = false;
			this.temporaryClientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.temporaryClientDataGridView.BackgroundColor = System.Drawing.Color.RoyalBlue;
			this.temporaryClientDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.temporaryClientDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.temporaryClientDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(75)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(35)))), ((int)(((byte)(75)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.temporaryClientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.temporaryClientDataGridView.ColumnHeadersHeight = 25;
			this.temporaryClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.temporaryClientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn1,
            this.numberVisitsDataGridViewTextBoxColumn1,
            this.lastVisitDataGridViewTextBoxColumn1,
            this.registerTimeDataGridViewTextBoxColumn1});
			this.temporaryClientDataGridView.DataSource = this.temporaryClientBindingSource;
			this.temporaryClientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.temporaryClientDataGridView.EnableHeadersVisualStyles = false;
			this.temporaryClientDataGridView.Location = new System.Drawing.Point(0, 0);
			this.temporaryClientDataGridView.Name = "temporaryClientDataGridView";
			this.temporaryClientDataGridView.ReadOnly = true;
			this.temporaryClientDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.temporaryClientDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.temporaryClientDataGridView.RowHeadersVisible = false;
			this.temporaryClientDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			this.temporaryClientDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.temporaryClientDataGridView.RowTemplate.Height = 25;
			this.temporaryClientDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.temporaryClientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.temporaryClientDataGridView.Size = new System.Drawing.Size(985, 565);
			this.temporaryClientDataGridView.TabIndex = 0;
			// 
			// temporaryClientBindingSource
			// 
			this.temporaryClientBindingSource.DataSource = typeof(Models.TemporaryClient);
			// 
			// clientIDDataGridViewTextBoxColumn1
			// 
			this.clientIDDataGridViewTextBoxColumn1.DataPropertyName = "Client_ID";
			this.clientIDDataGridViewTextBoxColumn1.HeaderText = "کد شناسه";
			this.clientIDDataGridViewTextBoxColumn1.Name = "clientIDDataGridViewTextBoxColumn1";
			this.clientIDDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// fullNameDataGridViewTextBoxColumn1
			// 
			this.fullNameDataGridViewTextBoxColumn1.DataPropertyName = "Full_Name";
			this.fullNameDataGridViewTextBoxColumn1.HeaderText = "نام کامل";
			this.fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
			this.fullNameDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// numberVisitsDataGridViewTextBoxColumn1
			// 
			this.numberVisitsDataGridViewTextBoxColumn1.DataPropertyName = "Number_Visits";
			this.numberVisitsDataGridViewTextBoxColumn1.HeaderText = "تعداد مراجعه";
			this.numberVisitsDataGridViewTextBoxColumn1.Name = "numberVisitsDataGridViewTextBoxColumn1";
			this.numberVisitsDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// lastVisitDataGridViewTextBoxColumn1
			// 
			this.lastVisitDataGridViewTextBoxColumn1.DataPropertyName = "Last_Visit";
			this.lastVisitDataGridViewTextBoxColumn1.HeaderText = "اخرین مراجعه";
			this.lastVisitDataGridViewTextBoxColumn1.Name = "lastVisitDataGridViewTextBoxColumn1";
			this.lastVisitDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// registerTimeDataGridViewTextBoxColumn1
			// 
			this.registerTimeDataGridViewTextBoxColumn1.DataPropertyName = "Register_Time";
			this.registerTimeDataGridViewTextBoxColumn1.HeaderText = "زمان ثبت";
			this.registerTimeDataGridViewTextBoxColumn1.Name = "registerTimeDataGridViewTextBoxColumn1";
			this.registerTimeDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// TemporaryClientListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(985, 565);
			this.Controls.Add(this.temporaryClientDataGridView);
			this.MaximumSize = new System.Drawing.Size(985, 565);
			this.MinimumSize = new System.Drawing.Size(985, 565);
			this.Name = "TemporaryClientListForm";
			this.Text = "TemporaryClientListForm";
			this.Load += new System.EventHandler(this.TemporaryClientListForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.temporaryClientDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.temporaryClientBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.DataGridView temporaryClientDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberVisitsDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastVisitDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn registerTimeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.BindingSource temporaryClientBindingSource;
	}
}