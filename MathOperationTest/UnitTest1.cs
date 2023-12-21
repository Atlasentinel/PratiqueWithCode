using EvaluationSampleCode;

namespace MathOperationTest
{
    [TestClass]
    public class UnitTest1
    {

        private MathOperations _mathOperation;
        [TestInitialize]
        public void Init()
        {
            _mathOperation = new MathOperations();
        }

        //test pour l'Addition
        [TestMethod]
        [DataRow(4, 5, 9)]
        [DataRow(0, 2, 2)]
        [DataRow(100, 100, 200)]
        public void Add_TwoNumbers_ReturnTrue(int numberOne, int numberTwo, int expectedResult)
        {
            var result = _mathOperation.Add(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(4, 5, 3)]
        [DataRow(0, 2, 5)]
        [DataRow(100, 100, 404)]
        public void Add_TwoNumbers_ReturnFalse(int numberOne, int numberTwo, int expectedResult)
        {
            var result = _mathOperation.Add(numberOne, numberTwo);

            Assert.AreNotEqual(expectedResult, result);
        }

        //test pour la Division
        [TestMethod]
        [DataRow(4, 0)]
        [DataRow(3, 0)]
        public void Divide_SecondNumberAsZero_ShouldThrowsArgumentException(int numberOne, int numberTwo)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperation.Divide(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(10, 2, 5f)]
        [DataRow(1, 2, 0.5f)]
        [DataRow(404, 2, 202)]
        public void Divide_WithTwoNumbers_ReturnsDivision(int numberOne, int numberTwo, float expectedResult)
        {
            var result = _mathOperation.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(-4)]
        [DataRow(-378)]
        public void GetOddNumbers_WithNegativeNumber_ShouldThrowArgumentException(int numberOne)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperation.GetOddNumbers(numberOne));
        }

        /* Pas encore compris pourquoi je n'arrivais pas à le tester
         * 
         * [TestMethod]
        [DataRow(4)]
        [DataRow(3)]
        [DataRow(6)]
        public void GetOddNumbers_WithNumber_ShouldReturnNumberOfOddNumber_InList(int numberOne)
        {
            var result = _mathOperation.GetOddNumbers(numberOne);
            Assert.AreEqual(_mathOperation.GetOddNumbers(numberOne), 2);
        }*/

    }
}