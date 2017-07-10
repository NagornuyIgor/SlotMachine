using System;
using System.Windows.Forms;

namespace Casino
{
	public partial class StartupMenuForm : Form
	{
		MainForm mainForm;

		public StartupMenuForm()
		{
			InitializeComponent();

			label1.Text = $"Привет! {Environment.NewLine}Ты готов проиграть свой дом?{Environment.NewLine}Если проскочил баг это судьба!{Environment.NewLine}\"Кнопка Load\" - загрузить игру{Environment.NewLine}если приложение{Environment.NewLine}запущено первый{Environment.NewLine}раз включатся стандартные{Environment.NewLine}настройки{Environment.NewLine}Дизайн...";
		}

		private void buttonLoad_Click(object sender, EventArgs e)
		{
			if(!Properties.Settings.Default.WasStarted)
			{
				MessageBox.Show("У вас нет сохранения!");
			}
			else if(Properties.Settings.Default.WasStarted)
			{
				mainForm = new MainForm(Properties.Settings.Default.Supplied, Properties.Settings.Default.Gain, Properties.Settings.Default.Money);
				mainForm.Show();
				Hide();
			}
		}

		private void buttonNewGame_Click(object sender, EventArgs e)
		{
			mainForm = new MainForm(500, 0, 500);
			mainForm.Show();
			Hide();
		}
	}
}
