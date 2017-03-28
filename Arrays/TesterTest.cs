using NUnit.Framework;

namespace Arrays
{
    [TestFixture()]
    internal class TesterTest
    {
        private const string paramOne = "holamUndo";

        private Tester toTest;

        [SetUp]
        public void Prepare()
        {
            toTest = new Tester();
        }

        //Prueba del punto 1
        [TestCase("anitalavalatina", 'a', 6)]
        [TestCase("eraseunavezunablancapaloma", 'Z', 0)]
        [TestCase("holAmundo", 'a', 0)]
        public void CountCharacterA(string inputString, char inputChar, int compareResultWith)
        {
            Assert.AreEqual(compareResultWith, toTest.CountCharInString(inputString, inputChar));
        }
    }
}