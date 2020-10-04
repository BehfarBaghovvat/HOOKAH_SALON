using System.Linq;

namespace HOOKAH_SALON.Setting.Client
{
	public partial class TemporaryClientListForm : Infrastructure.BaseForm
	{
		public TemporaryClientListForm()
		{
			InitializeComponent();
		}

		//-----The beginning of the coding line.

		#region TemporaryClientListForm_Load
		private void TemporaryClientListForm_Load(object sender, System.EventArgs e)
		{
			TemporaryClientLoaded();
		}
		#endregion /TemporaryClientListForm_Load

		//-----End of coding line

		#region Founction
		//-----
		#region TemporaryClientLoaded
		private void TemporaryClientLoaded()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.TemporaryClient> temporaryClients = null;

				temporaryClients =
					dataBaseContext.TemporaryClients
					.OrderBy(current => current.Full_Name)
					.ToList();

				temporaryClientDataGridView.DataSource = temporaryClients;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.ExceptionShow(ex);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /TemporaryClientLoaded
		//-----
		#endregion /Founction
	}
}
