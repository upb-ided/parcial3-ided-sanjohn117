using NUnit.Framework;
using System;
namespace Arrays
{
	[TestFixture()]
	public class ArraysTest
	{
		private Arrays toTest;

		[SetUp]
		public void Prepare()
		{
			toTest = new Arrays ();
		}

		[Test()]
		public void AveragePositiveNumbers ()
		{
			int[] numbers = new int[] { 1, 2, 3 };
			int average = toTest.Average (numbers);
			Assert.AreEqual (2, average);
		}

		[Test()]
		public void SortReversedArray ()
		{
			int[] numbers = new int[] { 3, 2, 1 };
			int[] sorted  = toTest.Sort (numbers);
			Assert.AreEqual(new int[] { 1, 2, 3}, sorted);
		}
	}
}
