namespace HOOKAH_SALON.Setting
{
	public partial class ClientManegmentForm : Infrastructure.BaseForm
	{
		public ClientManegmentForm()
		{
			InitializeComponent();
		}

		#region PermanentClientListForm
		private static Setting.Client.PermanentClientListForm permanentClientListForm;

		public static Setting.Client.PermanentClientListForm PermanentClientListForm
		{
			get
			{
				if (permanentClientListForm == null || permanentClientListForm.IsDisposed == true)
				{
					permanentClientListForm
						= new Client.PermanentClientListForm();
				}
				return permanentClientListForm;
			}
		}
		#endregion /PermanentClientListForm

		#region TemporaryClientListForm
		private Setting.Client.TemporaryClientListForm temporaryClientListForm;

		public Setting.Client.TemporaryClientListForm TemporaryClientListForm
		{
			get
			{
				if (temporaryClientListForm == null || temporaryClientListForm.IsDisposed == true)
				{
					temporaryClientListForm =
						new Client.TemporaryClientListForm();
				}
				return temporaryClientListForm;
			}
		}
		#endregion /TemporaryClientListForm

		//-----The beginning of the coding line.

		#region ClientManegmentForm_Load
		private void ClientManegmentForm_Load(object sender, System.EventArgs e)
		{
			selectCustomerTypePanel.Controls.Clear();
		}
		#endregion /ClientManegmentForm_Load

		#region PermanentClientAddButton_Click
		private void PermanentClientAddButton_Click(object sender, System.EventArgs e)
		{
			PermanentClientListForm.Dock = System.Windows.Forms.DockStyle.Fill;
			PermanentClientListForm.TopLevel = false;
			PermanentClientListForm.TopMost = true;

			selectCustomerTypePanel.Controls.Clear();
			selectCustomerTypePanel.Controls.Add(PermanentClientListForm);
			PermanentClientListForm.Show();
		}
		#endregion /PermanentClientAddButton_Click

		#region TemporaryClientAddButton_Click
		private void TemporaryClientAddButton_Click(object sender, System.EventArgs e)
		{
			

			
		}
		#endregion /TemporaryClientAddButton_Click

		//-----End of coding line
	}
}
