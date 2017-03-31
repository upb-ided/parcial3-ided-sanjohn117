using NUnit.Framework;

namespace Arrays
{
    [TestFixture()]
    internal class TesterTest
    {
        private Tester toTestAssignment;

        private static readonly int[,] testDiagonalMatrixA = { { 0, 1 }, { 1, 0 } };
        private static readonly int[,] testDiagonalMatrixB = { { 0, 1 }, { 1, 0 } };
        private static readonly int[,] testDiagonalMatrixC = { { 0, 1 }, { 1, 0 } };

        [SetUp]
        public void Prepare()
        {
            toTestAssignment = new Tester();
        }

        //Prueba del punto 1
        [TestCase("anitalavalatina", 'a', 6)]
        [TestCase("eraseunavezunablancapaloma", 'Z', 0)]
        [TestCase("holAmundo", 'a', 0)]
        public void TestCountCharacterInString(string inputString, char inputChar, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTestAssignment.CountCharInString(inputString, inputChar));
        }

        [TestCase(2, 4)]
        [TestCase(34, 64)]
        [TestCase(1081, 2048)]
        public void TestGetNextPowerOfTwo(int currentNumber, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTestAssignment.NextPowerOfTwo(currentNumber));
        }

        [TestCase(3, 2)]
        [TestCase(10, 34)]
        [TestCase(20, 6765)]
        public void TestFibonacciAtN(int fibonacciPosition, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTestAssignment.FibonacciAtN(fibonacciPosition));
        }

        [TestCase(new int[] { 1, 9, 12 }, 2)]
        [TestCase(new int[] { 1, 4, 16 }, 0)]
        [TestCase(new int[] { 3, 8, 12, 17, 21, 26, 32, 50, 69 }, 4)]
        public void TestMultiplesOfThreeInArray(int[] inputArr, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTestAssignment.MultiplesOfThreeInArray(inputArr));
        }

        [TestCase(3, 2, false)]
        [TestCase(50, 10, true)]
        [TestCase(15625, 25, true)]
        public void TestNumberIsMuktipleOf(int inputNum, int inputFactor, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTestAssignment.NumberIsMultipleOf(inputNum, inputFactor));
        }

        /*[TestCase(testDiagonalMatrixA, true)]
        [TestCase(testDiagonalMatrixB, false)]
        [TestCase(testDiagonalMatrixC, true)]
        public void TestMatrixIsIdentity(int[,] inputMatrix, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTest.MatrixIsIdentity(inputMatrix));
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void TestElementsInDiagonalAreEqual(int[,] inputMatrix, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTest.ElementsInDiagonalAreEqual(inputMatrix));
        }*/

        [TestCase(new int[] { 1}, 1)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 1 }, 1)]
        public void TestOperateElementsInArray(int[] inputArr, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTestAssignment.OperateElementsInArray(inputArr));
        }

        [TestCase("murciélago", 5)]
        [TestCase("esternocleidomastoideo", 11)]
        [TestCase("universidad", 5)]
        public void TestCountVowelsInString(string inputString, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTestAssignment.CountVowelsInString(inputString));
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void TestCountConsonantInString(string inputString, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTestAssignment.CountConsonantInString(inputString));
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void TestStringHasOddOrEvenCharCount(string inputString, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTestAssignment.StringHasOddOrEvenCharCount(inputString));
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void TestProductOfElementsIsOddOrEven(int[] inputArr, bool compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTestAssignment.ProductOfElementsIsOddOrEven(inputArr));
        }

        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void TestRacerGotFirst(float d1, float t1, float d2, float t2, string compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTestAssignment.RacerGotFirst(d1, t1, d2, t2));
        }
    }
}