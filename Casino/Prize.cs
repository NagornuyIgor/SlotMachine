using System;
using System.Windows.Forms;
using System.Windows.Media;

namespace Casino
{
	public class Prize
	{
		public int GivePrize(int[] slots, MediaPlayer sound, ref int money, int rate, ref int gainMoney)
		{
			if (slots[0] == slots[1] && slots[1] == slots[2])
			{
				sound.Play();
				sound.Position = TimeSpan.Zero;
				MessageBox.Show($"Центр + {(rate * 10).ToString()} монет!");
				money += (rate * 10);
				gainMoney += (rate * 10);
			}
			else if (slots[0] + 1 == slots[1] && slots[1] == slots[2] - 1 ||
					 slots[0] - 1 == slots[1] && slots[1] == slots[2] + 1)
			{
				sound.Play();
				sound.Position = TimeSpan.Zero;
				MessageBox.Show($"Диагональ + {(rate * 6).ToString()} монет!");
				money += (rate * 6);
				gainMoney += (rate * 6);

			}
			else if (slots[0] == slots[1] || slots[1] == slots[2])
			{
				sound.Play();
				sound.Position = TimeSpan.Zero;
				MessageBox.Show($"Две сбоку + {(rate * 2).ToString()} монет!");
				money += (rate * 2);
				gainMoney += (rate * 2); 
			}
			else
			{
				MessageBox.Show("Ты проиграл " + rate.ToString());
			}
			return money;
		}
	}
}
