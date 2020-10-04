namespace HOOKAH_SALON.Setting
{
	public partial class AdministratorSettingForm : Infrastructure.BaseForm
	{
		public AdministratorSettingForm()
		{
			InitializeComponent();
		}

		#region UsersListForm
		private User.UsersListForm usersListForm = null;

		public User.UsersListForm UsersListForm
		{
			get
			{
				if (usersListForm == null || usersListForm.IsDisposed == true)
				{
					usersListForm =
						new User.UsersListForm();
				}
				return usersListForm;
			}
		}
		#endregion /UsersListForm

		#region LoginControlForm
		private User.LoginControlForm loginControlForm = null;

		public User.LoginControlForm LoginControlForm
		{
			get
			{
				if (loginControlForm == null || loginControlForm.IsDisposed == true)
				{
					loginControlForm =
						new User.LoginControlForm();
				}
				return loginControlForm;
			}
		}
		#endregion /LoginControlForm

		#region ActionsControlForm
		private User.EventControlForm actionsControlForm = null;

		public User.EventControlForm ActionsControlForm
		{
			get
			{
				if (actionsControlForm == null || actionsControlForm.IsDisposed == true)
				{
					actionsControlForm =
						new User.EventControlForm();
				}
				return actionsControlForm;
			}
		}
		#endregion /ActionsControlForm



		private void AdministratorSettingForm_Load(object sender, System.EventArgs e)
		{

		}

		#region MyRegion
		private void UsersListButton_Click(object sender, System.EventArgs e)
		{
			UsersListForm.Dock = System.Windows.Forms.DockStyle.Fill;
			UsersListForm.TopLevel = false;
			UsersListForm.TopMost = true;

			showMenuPanel.Controls.Clear();
			showMenuPanel.Controls.Add(UsersListForm);
			UsersListForm.Show();
		}
		#endregion

		#region MyRegion
		private void LoginControlButton_Click(object sender, System.EventArgs e)
		{
			LoginControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
			LoginControlForm.TopLevel = false;
			LoginControlForm.TopMost = true;

			showMenuPanel.Controls.Clear();
			showMenuPanel.Controls.Add(LoginControlForm);
			LoginControlForm.Show();
		}
		#endregion

		#region MyRegion
		private void ActionsControlButton_Click(object sender, System.EventArgs e)
		{
			ActionsControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
			ActionsControlForm.TopLevel = false;
			ActionsControlForm.TopMost = true;

			showMenuPanel.Controls.Clear();
			showMenuPanel.Controls.Add(ActionsControlForm);
			ActionsControlForm.Show();
		} 
		#endregion
	}
}
