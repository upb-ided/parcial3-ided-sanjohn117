using NUnit.Framework;

namespace Parcial3_Base
{
    [TestFixture()]
    internal class MatrixOperatorTest
    {
        public static object[] MatrixAddCases =
        {
            new object[]
            {
                new int[,] { { 1, 0}, { 0, 1} },
                new int[,] { { 0, 1}, { 1, 0} },
                new int[,] { { 1, 1}, { 1, 1} }
            },
            new object[]
            {
                new int[,] { { 1, 2}, { -1, 0} },
                new int[,] { { -2, 9}, { 3, 5} },
                new int[,] { { -1, 11}, { 2, 5} }
            },
            new object[]
            {
                new int[,] { { 6, 12}, { -14, 0} },
                new int[,] { { -3, 9}, { 2, -16} },
                new int[,] { { 3, 21}, { -12, -16} }
            },
            new object[]
            {
                new int[,] { { 3, 0, 3}, { 0, 6, -6 }, { -3, 6, -3} },
                new int[,] { { -1, -3,-2 }, { -1, 9, 5 }, { -3, -1, 1} },
                new int[,] { { 2, -3, 1}, { -1, 15, -1 }, { -6, 5, -2} },
            },
        };

        public static object[] MatrixProductCases =
        {
            new object[] {
                new int[,] { { 2 }, { -1 } },
                new int[,] { { 3, 5} },
                new int[,] { { 6, 10}, { -3, -5} }
            },
            new object[] {
                new int[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } },
                new int[,] { { 1, -1, 2 }, { 2, -1, 2 }, { 3, -3, 0 } },
                new int[,] { { 30, -26, 10}, { 36, -31, 14 }, { 42, -36, 18 } }
            },
            new object[] {
                new int[,] { { -3, 0, 2 }, { -1, 0, 1}, { 2, 5, -2 } },
                new int[,] { { 3, 1, 5 }, { 0, -2, 6}, { 3, -3, 7 } },
                new int[,] { { -3, -9, -1 }, { 0, -4, 2 }, { 0, -2, 26 } }
            },
            new object[] {
                new int[,] { { 1, 2 }, { -1, 0 }, { -3, -1 } },
                new int[,] { { 2, 0, 1 }, { -5, 2, 3 } },
                new int[,] { { -8, 4, 7 }, { -2, 0, -1 }, { -1, -2, -6 } }
            },

            new object[] {
                new int[,] { { 1, 2 }, { -1, 0 }, { -3, -1 } },
                new int[,] { { 2, 0, 1 }},
                null
            },
        };

        public static object[] MatrixMixCases =
        {
             new object[] {
                new int[,] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } },
                new int[,] { { 4, 5, 6 }, { 4, 5, 6 }, { 4, 5, 6 } },
                new int[,] { { 4, 5, 6 }, { 1, 10, 6 }, { 1, 2, 18 } }
            },

             new object[] {
                new int[,] { { 10, 5, 8, 4 }, { 12, 9, 4, 16 }, { 3, 8, 9, 20 }, { 4, 15, 23, 1} },
                new int[,] { { 1, 0, 0, 0}, { 0, 1, 0, 0 }, { 0, 0, 1, 0}, { 0, 0, 0, 1} },
                new int[,] { { 10, 0, 0, 0 }, { 12, 9, 0, 0 }, { 3, 8, 9, 0 }, { 4, 15, 23, 1} }
            },
        };

        private static object[] ProductByScalarCases = 
        {
             new object[] {
                new int[,] { { 10, 5, 8, 4 }, { 12, 9, 4, 16 }, { 3, 8, 9, 20 }, { 4, 15, 23, 1} },
                6,
                new int[,] { { 60, 30, 48, 24 }, { 72, 54, 24, 96 }, { 18, 48, 54, 120 }, { 24, 90, 138, 6} },
            },
             new object[] {
                new int[,] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } },
                1500,
                new int[,] { { 1500, 3000, 4500 }, { 1500, 3000, 4500 }, { 1500, 3000, 4500 } },
             },
              new object[] {
                new int[,] { { 1, 2 }, { -1, 0 }, { -3, -1 } },
                2,
                new int[,] { { 2, 4 }, { -2, 0 }, { -6, -2 } },
            },

        };
        

        private MatrixOperator operatorObject;

        [SetUp]
        public void Prepare()
        {
            operatorObject = new MatrixOperator();
        }

        [Test, TestCaseSource("MatrixAddCases")]
        public void TestAddMatrices(int[,] matrixA, int[,] matrixB, int[,] compareResultWith)
        {
            Assert.AreEqual(compareResultWith, operatorObject.AddMatrix(matrixA, matrixB));
        }

        [Test, TestCaseSource("MatrixProductCases")]
        public void TestMultiplyMatrices(int[,] matrixA, int[,] matrixB, int[,] compareResultWith)
        {
            Assert.AreEqual(compareResultWith, operatorObject.MultiplyMatrices(matrixA, matrixB));
        }

        [Test, TestCaseSource("MatrixMixCases")]
        public void TestMixMatrices(int[,] matrixA, int[,] matrixB, int[,] compareResultWith)
        {
            Assert.AreEqual(compareResultWith, operatorObject.MixMatrix(matrixA, matrixB));
        }

        [Test, TestCaseSource("ProductByScalarCases")]
        public void TestProductByScalar(int[,] matrix, int scalar, int[,] compareResultWith)
        {
            Assert.AreEqual(compareResultWith, operatorObject.MultiplyMatrixByScalar(matrix, scalar));
        }
    }
}