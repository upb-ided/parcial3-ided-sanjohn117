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

        //Prueba del punto 3
        [TestCase("anitalavalatina", 'a', 6)]
        [TestCase("eraseunavezunablancapaloma", 'Z', 0)]
        [TestCase("holAmundo", 'a', 0)]
        public void TestCountCharacterInString(string inputString, char inputChar, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.CountCharInString(inputString, inputChar));
        }

        //Prueba del punto 1
        [TestCase(2, 4)]
        [TestCase(34, 64)]
        [TestCase(1081, 2048)]
        public void TestGetNextPowerOfTwo(int currentNumber, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.NextPowerOfTwo(currentNumber));
        }

        //Prueba del punto 2
        [TestCase(3, 2)]
        [TestCase(10, 34)]
        [TestCase(20, 6765)]
        public void TestFibonacciAtN(int fibonacciPosition, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.FibonacciAtN(fibonacciPosition));
        }

        //Prueba del punto 4
        [TestCase(new int[] { 1, 9, 12 }, 2)]
        [TestCase(new int[] { 1, 4, 16 }, 0)]
        [TestCase(new int[] { 3, 8, 12, 17, 21, 26, 32, 50, 69 }, 4)]
        public void TestMultiplesOfThreeInArray(int[] inputArr, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.MultiplesOfThreeInArray(inputArr));
        }

        //Prueba del punto 5
        [TestCase(3, 2, false)]
        [TestCase(50, 10, true)]
        [TestCase(15625, 25, true)]
        public void TestNumberIsMuktipleOf(int inputNum, int inputFactor, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.NumberIsMultipleOf(inputNum, inputFactor));
        }

        //Prueba del punto 6
        [TestCase(new int[] { 1, 5, 10, 15, 25, 40, 60}, 288000)]
        [TestCase(new int[] { 20, 30, 4, 12 }, 8640)]
        [TestCase(new int[] { 10, 2, 69, 4, 87 }, 1328)]
        public void TestOperateElementsInArray(int[] inputArr, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.OperateElementsInArray(inputArr));
        }

        //Prueba del punto 7
        [TestCase("murciélago", 5)]
        [TestCase("esternocleidomastoideo", 11)]
        [TestCase("universidad", 5)]
        public void TestCountVowelsInString(string inputString, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.CountVowelsInString(inputString));
        }

        //Prueba del punto 8
        [TestCase("murciélago", 5)]
        [TestCase("esternocleidomastoideo", 11)]
        [TestCase("universidad", 6)]
        public void TestCountConsonantInString(string inputString, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.CountConsonantInString(inputString));
        }

        //Prueba del punto 9
        [TestCase("universidad", "IMPAR")]
        [TestCase("esternocleidomastoideo", "PAR")]
        [TestCase("estetallerestamuyfacil", "PAR")]
        public void TestStringHasOddOrEvenCharCount(string inputString, string compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.StringHasOddOrEvenCharCount(inputString));
        }

        //Prueba del punto 10
        [TestCase(new int[] { 1, 5, 10, 15, 20, 40 }, "PAR")]
        [TestCase(new int[] { 20, 15, 40, 90, 120, 200 }, "PAR")]
        [TestCase(new int[] { 1, 3, 5, 7, 9, 11 }, "IMPAR")]
        public void TestProductOfElementsIsOddOrEven(int[] inputArr, string compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.ProductOfElementsIsOddOrEven(inputArr));
        }

        //Prueba del punto 11
        [TestCase(200, 5, 300, 4, "SEGUNDO")]
        [TestCase(45, 4, 23, 2, "PRIMERO")]
        [TestCase(75, 6, 105, 9, "SEGUNDO")]
        public void TestRacerGotFirst(float d1, float t1, float d2, float t2, string compareResultWith)
        {
            Assert.AreEqual(compareResultWith, tested.RacerGotFirst(d1, t1, d2, t2));
        }
    }
}