namespace HOOKAH_SALON
{
	public partial class StartupProgramForm : Infrastructure.BaseForm
	{
		public StartupProgramForm()
		{
			InitializeComponent();
		}

		//-----The beginning of the coding line.

		#region StartUpProgramForm_Load
		private void StartupProgramForm_Load(object sender, System.EventArgs e)
		{
			this.Opacity = 0.0;
			timer1.Start();
		}
		#endregion /StartUpProgramForm_Load

		#region Timer1_Tick
		private void Timer1_Tick(object sender, System.EventArgs e)
		{
			this.Opacity += 0.05;

			if (this.Opacity >= 0.90)
			{
				timer1.Stop();
				timer2.Start();
			}
		}
		#endregion /Timer1_Tick

		#region Timer2_Tick
		private void Timer2_Tick(object sender, System.EventArgs e)
		{
			timer2.Interval += 50;

			if (timer2.Interval == 150)
			{
				bunifuTransition1.HideSync(slideShowUC11);
				bunifuTransition2.ShowSync(slideShowUC21);
			}
			if (timer2.Interval == 350)
			{
				bunifuTransition2.HideSync(slideShowUC21);
				bunifuTransition3.ShowSync(slideShowUC31);
			}
			if (timer2.Interval == 550)
			{
				bunifuTransition3.HideSync(slideShowUC31);
				bunifuTransition1.ShowSync(slideShowUC41);
			}
			if (timer2.Interval == 750)
			{
				timer2.Stop();
				timer3.Start();
			}
		}
		#endregion /Timer2_Tick

		#region Timer3_Tick
		private void Timer3_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.05;

			if (this.Opacity == 0)
			{
				timer3.Stop();
				this.Hide();
				Program.LoginShow();
			}
		}
		#endregion /Timer3_Tick

		//-----End of coding line

	}
}
