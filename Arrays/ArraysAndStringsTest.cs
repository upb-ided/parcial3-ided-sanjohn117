using NUnit.Framework;

namespace Arrays
{
    [TestFixture()]
    internal class ArraysAndStringsTest
    {
		private ArraysAndStrings tested;

        [SetUp]
        public void Prepare()
        {
            tested = new ArraysAndStrings();
        }

        //Prueba del punto 1
        [TestCase("anitalavalatina", 'a', 6)]
        [TestCase("eraseunavezunablancapaloma", 'Z', 0)]
        [TestCase("holAmundo", 'a', 0)]
        public void TestCountCharacterInString(string inputString, char inputChar, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.CountCharInString(inputString, inputChar));
        }

        [TestCase(2, 4)]
        [TestCase(34, 64)]
        [TestCase(1081, 2048)]
        public void TestGetNextPowerOfTwo(int currentNumber, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.NextPowerOfTwo(currentNumber));
        }

        [TestCase(3, 2)]
        [TestCase(10, 34)]
        [TestCase(20, 6765)]
        public void TestFibonacciAtN(int fibonacciPosition, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.FibonacciAtN(fibonacciPosition));
        }

        [TestCase(new int[] { 1, 9, 12 }, 2)]
        [TestCase(new int[] { 1, 4, 16 }, 0)]
        [TestCase(new int[] { 3, 8, 12, 17, 21, 26, 32, 50, 69 }, 4)]
        public void TestMultiplesOfThreeInArray(int[] inputArr, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.MultiplesOfThreeInArray(inputArr));
        }

        [TestCase(3, 2, false)]
        [TestCase(50, 10, true)]
        [TestCase(15625, 25, true)]
        public void TestNumberIsMuktipleOf(int inputNum, int inputFactor, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.NumberIsMultipleOf(inputNum, inputFactor));
        }

        [TestCase(new int[] { 1}, 1)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 1 }, 1)]
        public void TestOperateElementsInArray(int[] inputArr, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.OperateElementsInArray(inputArr));
        }

        [TestCase("murciélago", 5)]
        [TestCase("esternocleidomastoideo", 11)]
        [TestCase("universidad", 5)]
        public void TestCountVowelsInString(string inputString, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.CountVowelsInString(inputString));
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void TestCountConsonantInString(string inputString, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.CountConsonantInString(inputString));
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void TestStringHasOddOrEvenCharCount(string inputString, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.StringHasOddOrEvenCharCount(inputString));
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void TestProductOfElementsIsOddOrEven(int[] inputArr, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.ProductOfElementsIsOddOrEven(inputArr));
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void TestRacerGotFirst(float d1, float t1, float d2, float t2, string compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.RacerGotFirst(d1, t1, d2, t2));
        }
    }
}