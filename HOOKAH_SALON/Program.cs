using System;
using System.Linq;
using System.Windows.Forms;

namespace HOOKAH_SALON
{
	static class Program
	{
		public static Models.User AuthenticatedUser { get; set; }
		public static Models.LogHistory AutenticatLogHistory { get; set; }

		//------------------------------------------------------------------
		#region Administrator
		public static void Administrator()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				string adminPic =
				"D:\\Visual Studio Project\\Personal Project\\HOOKAH_SALON\\HOOKAH_SALON\\Resources\\AdminUser.png";
				Models.User adminUser =
					dataBaseContext.Users
					.Where(current => string.Compare(current.Username, "administrator", true) == 0)
					.FirstOrDefault();

				if (adminUser == null)
				{
					adminUser =
						new Models.User
						{
							IsActive = true,
							Access_Level = "مدیریت",
							Username = "administrator",
							Email = "-",
							Password = "administrator",
							Description = "-",
							User_Image = System.IO.File.ReadAllBytes(adminPic),
							First_Name = "Administrator",
							Last_Name = " ",
							Telephone = "-",
							National_Code = "-",
							Address = "-",
							Marital_Status = "-",
							Registration_Time = "-",
							Registration_Date = "-",
						};
					dataBaseContext.Users.Add(adminUser);
				}
				else
				{
					if (adminUser.IsActive == false)
					{
						adminUser.IsActive = true;
					}
					if (string.Compare(adminUser.Access_Level,"کارمند")==0 || string.Compare(adminUser.Access_Level, "نیروی خدمات") ==0)
					{
						adminUser.Access_Level = "مدیریت";
					}
				}
				dataBaseContext.SaveChanges();
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
		#endregion /Administrator
		//-----
		#region LoginForm
		private static LoginForm loginForm;
		public static LoginForm LoginForm
		{
			get
			{
				if (loginForm == null || loginForm.IsDisposed == true)
				{
					loginForm =
						new LoginForm();
				}
				return loginForm;
			}
		}
		#region LoginShow
		public static void LoginShow()
		{
			AuthenticatedUser = null;
			LoginForm.Show();
		}
		#endregion /LoginShow

		#region LogIn
		public static void LogIn(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			LoginForm.Show();
		}
		#endregion /LogIn

		#endregion /LoginForm
		//-----
		#region MainForm
		private static MainForm mainForm = null;
		public static MainForm MainForm
		{
			get
			{
				if (mainForm == null || mainForm.IsDisposed == true)
				{
					mainForm =
						new MainForm();
				}
				return mainForm;
			}
		}
		#region MainShow
		public static void MainShow()
		{
			MainForm.Initialize();
			MainForm.Show();
		}
		#endregion /MainShow

		#endregion /MainForm
		//-----
		#region RegisterForm
		private static RegisterForm registerForm;
		public static RegisterForm RegistrForm
		{
			get
			{
				if (registerForm == null || registerForm.IsDisposed == true)
				{
					registerForm =
						new RegisterForm();
				}
				return registerForm;
			}
		}

		#region RegistrShow
		public static void RegistrShow()
		{
			RegistrForm.Show();
		}
		#endregion /RegistrShow

		#endregion /RegisterForm
		//-----
		#region StartUpProgramForm
		private static StartupProgramForm startupProgramForm;
		public static StartupProgramForm StartpProgramForm
		{
			get
			{
				if (startupProgramForm == null || startupProgramForm.IsDisposed == true)
				{
					startupProgramForm =
						new StartupProgramForm();
				}
				return startupProgramForm;
			}
		}
		#region StartUpShow
		public static void StartUpShow()
		{
			AuthenticatedUser = null;
			//LoginForm.Initialize();
			startupProgramForm.ShowDialog();
		}
		#endregion /StartUpShow
		#endregion /StartUpProgramForm

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Administrator();
			Application.Run(new StartupProgramForm());
		}
	}
}