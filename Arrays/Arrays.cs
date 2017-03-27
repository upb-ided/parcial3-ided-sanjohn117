using System;
namespace Arrays
{
	public class Arrays
	{
		public int[] Sort (int[] numbers)
		{
			return numbers;
		}

		public int Average(int[] numbers)
		{
			int sum = 0;
			for (int i = 0; i < numbers.Length; i++)
				sum += numbers[i];
			return sum / numbers.Length;
		}
	}
}
