using System;

namespace Casino
{
	public class RandomSlots
	{
		public int oneTime = 0;
		private const int slotNumber = 3;
		private const int slotTypeNumber = 7;

		public Random random = new Random();
		public int[] quantity = new int[3];
		public int[] slots = new int[3];

		public RandomSlots()
		{
			for(int i = 0; i < slotNumber; i++)
			{
				slots[i] = Randomize(slotTypeNumber);
			}
		}

		public int Randomize(int num)
		{
			return random.Next(0, num);
		}

		public int Bigger(int num)
		{
			int biggest;

			for(int i = 0; i < 3; i++)
			{
				quantity[i] = Randomize(num);
			}

			biggest = quantity[0];

			for(int i = 1; i <= 2; i++)
			{
				if(biggest < quantity[i])
				{
					biggest = quantity[i];
				}
			}
			return biggest;
		}

		public void RollSlots()
		{
			oneTime++;
			for (int i = 0; i < slotNumber; i++)
			{
				if (quantity[i] >= oneTime)
				{
					slots[i]++;
				}
			}
		}
	}
}
