using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;

namespace Casino
{
	public partial class MainForm : Form
	{
		bool isRunning; 
		public Prize prize = new Prize();
		public RandomSlots randomSlots;
		public string location = AppDomain.CurrentDomain.BaseDirectory + @"Resources\";
		private Bitmap coin;

		private MediaPlayer mediaKlubnichka = new MediaPlayer();
		private MediaPlayer soundSlotMachineGiveMoney = new MediaPlayer();
		private MediaPlayer soundStopkaMonet = new MediaPlayer();
		private MediaPlayer soundZvukMonet = new MediaPlayer();
		private MediaPlayer soundMoneta = new MediaPlayer();

		bool isValid;
		public int rate;
		public int roundsCounter;
		public int bigger;

		public int gameMoney;
		private int supplied;
		public int gainMoney;


		public MainForm(int suppliedMoney, int gain, int money)
		{
			InitializeComponent();

			soundMoneta.MediaEnded += SoundMoneta_MediaEnded;

			suppliedMoneyLabel.Text = suppliedMoney.ToString();
			gainLabel.Text = gain.ToString();
			label1.Text = money.ToString();

			coin = new Bitmap(location + @"Pictures\" + "50kop.png");

			soundSlotMachineGiveMoney.Open(new Uri(location + @"Sounds\" + "SlotMachineGiveMoney.wav"));
			soundStopkaMonet.Open(new Uri(location + @"Sounds\" + "StopkaMonet.wav"));
			soundZvukMonet.Open(new Uri(location + @"Sounds\" + "ZvukMonet.wav"));
			soundMoneta.Open(new Uri(location + @"Sounds\" + "1moneta.wav"));
			soundStopkaMonet.Volume = 1;
			soundMoneta.Volume = 0.1;
			mediaKlubnichka.Open(new Uri(location + @"Sounds\" + "Klubnichka.wav"));
			mediaKlubnichka.Volume = 0.05;
			mediaKlubnichka.Play();
			mediaKlubnichka.MediaEnded += PlayNext;

			supplied = int.Parse(suppliedMoneyLabel.Text);
			gainMoney = int.Parse(gainLabel.Text);
			gameMoney = int.Parse(label1.Text);

			randomSlots = new RandomSlots();
			FillSolts(randomSlots.slots);

			bigger = 0;
		}

		private void SoundMoneta_MediaEnded(object sender, EventArgs e)
		{
			soundMoneta.Stop();
			soundMoneta.Position = TimeSpan.Zero;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (!isRunning)
			{
				isValid = int.TryParse(rateBox.Text, out rate);

				if(gameMoney == 0)
				{
					MessageBox.Show("Пополните счет!");
				}
				else if (isValid && gameMoney >= rate)
				{
					isRunning = true;
					roundsCounter = 0;
					randomSlots.oneTime = 0;
					gameMoney -= rate;
					gainMoney -= rate;
					label1.Text = gameMoney.ToString();
					soundSlotMachineGiveMoney.Play();
					bigger = randomSlots.Bigger(20);
					Roll(bigger);
				}
				else if(gameMoney < rate)
				{
					MessageBox.Show("Недостаточно денег!");
				}
				else
				{
					MessageBox.Show("Выберите ставку!");
				}
			}
		}

		public void Roll(int num)
		{
			timer1.Start();
			while (roundsCounter <= num)
			{
				Application.DoEvents();
			}
		}

		public void FillSolts(int[] slots)
		{

			if (slots[0] == 6)
			{
				pictureBox5.Image = imageList1.Images[slots[0] - 1];
				pictureBox3.Image = imageList1.Images[slots[0]];
				pictureBox4.Image = imageList1.Images[0];
			}
			else if (slots[0] == 0)
			{
				pictureBox5.Image = imageList1.Images[6];
				pictureBox3.Image = imageList1.Images[slots[0]];
				pictureBox4.Image = imageList1.Images[slots[0] + 1];
			}			
			else if(slots[0] == 7)
			{
				slots[0] = 0;
			}
			else
			{
				pictureBox5.Image = imageList1.Images[slots[0] - 1];
				pictureBox3.Image = imageList1.Images[slots[0]];
				pictureBox4.Image = imageList1.Images[slots[0] + 1];
			}

			if (slots[1] == 6)
			{
				pictureBox7.Image = imageList1.Images[slots[1] - 1];
				pictureBox6.Image = imageList1.Images[slots[1]];
				pictureBox8.Image = imageList1.Images[0];
			}
			else if (slots[1] == 0)
			{
				pictureBox7.Image = imageList1.Images[6];
				pictureBox6.Image = imageList1.Images[slots[1]];
				pictureBox8.Image = imageList1.Images[slots[1] + 1];
			}
			else if (slots[1] == 7)
			{
				slots[1] = 0;
			}
			else
			{
				pictureBox7.Image = imageList1.Images[slots[1] - 1];
				pictureBox6.Image = imageList1.Images[slots[1]];
				pictureBox8.Image = imageList1.Images[slots[1] + 1];
			}

			if (slots[2] == 6)
			{
				pictureBox11.Image = imageList1.Images[slots[2] - 1];
				pictureBox9.Image = imageList1.Images[slots[2]];
				pictureBox10.Image = imageList1.Images[0];
			}
			else if (slots[2] == 0)
			{
				pictureBox11.Image = imageList1.Images[6];
				pictureBox9.Image = imageList1.Images[slots[2]];
				pictureBox10.Image = imageList1.Images[slots[2] + 1];
			}
			else if (slots[2] == 7)
			{
				slots[2] = 0;
			}
			else
			{
				pictureBox11.Image = imageList1.Images[slots[2] - 1];
				pictureBox9.Image = imageList1.Images[slots[2]];
				pictureBox10.Image = imageList1.Images[slots[2] + 1];
			}
		}

		private void PlayNext(object sender, EventArgs e)
		{
			var player = (MediaPlayer)sender;
			player.Position = TimeSpan.Zero;
			player.Play();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			randomSlots.RollSlots();
			FillSolts(randomSlots.slots);
			roundsCounter++;

			if (roundsCounter == bigger)
			{
				timer1.Stop();
				prize.GivePrize(randomSlots.slots, soundStopkaMonet, ref gameMoney, rate, ref gainMoney);
				label1.Text = gameMoney.ToString();
				gainLabel.Text = gainMoney.ToString();

				soundSlotMachineGiveMoney.Stop();
				soundSlotMachineGiveMoney.Position = TimeSpan.Zero;
				isRunning = false;
				pictureMoneta.Focus();
			}
		}

		private void pictureMoneta_Click(object sender, EventArgs e)
		{
			if(gameMoney < 1000)
			{
				soundMoneta.Play();
				gameMoney += 50;
				supplied += 50;
				
			}
			suppliedMoneyLabel.Text = supplied.ToString();
			label1.Text = gameMoney.ToString();
		}

		private void pictureMoneta_MouseLeave(object sender, EventArgs e)
		{
			pictureMoneta.BackgroundImage = null;
		}

		private void pictureMoneta_MouseEnter(object sender, EventArgs e)
		{
			if(gameMoney < 1000)
			{
				pictureMoneta.BackgroundImage = coin;
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Properties.Settings.Default.Gain = int.Parse(gainLabel.Text);
			Properties.Settings.Default.Supplied = int.Parse(suppliedMoneyLabel.Text);
			Properties.Settings.Default.Money = int.Parse(label1.Text);
			Properties.Settings.Default.WasStarted = true;
			Properties.Settings.Default.Save();

			mediaKlubnichka.Stop();
			mediaKlubnichka.Close();
			soundSlotMachineGiveMoney.Close();
			soundStopkaMonet.Close();
			Application.Exit();
		}
	}
}
