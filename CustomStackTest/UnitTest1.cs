using EvaluationSampleCode;

namespace CustomStackTest
{
    [TestClass]
    public class UnitTest1
    {
        private CustomStack _customStack;

        [TestMethod]
        public void Count_NumberOfIntInList_CountInt()
        {
            _customStack = new CustomStack();
            var result = _customStack.Count();
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        [DataRow(8)]
        public void Count_NumberOfIntInList_CountFloat(int expectedResult)
        {
            _customStack = new CustomStack();
            var result = _customStack.Count();
            Assert.AreNotEqual(expectedResult, result);
        }
        /*[TestMethod]
        [DataRow(8,1,8)]
        public void Push_ElementInListShouldReturnTwo(int numberOne, int numberTwo, int expectedResult,)
        {
            _customStack = new CustomStack();
            _customStack.Push(numberOne);
            Assert.IsTrue(expectedResult);
        }*/

        [TestMethod]
        public void Pop_NoElementInList_ShouldThrowsArgumentException()
        {
            _customStack = new CustomStack();
            Assert.ThrowsException<Exception>(() => _customStack.Pop());
        }

        //Pas eu le temps de finir

    }
}