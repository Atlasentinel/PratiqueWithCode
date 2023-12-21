using EvaluationSampleCode;

namespace HtmlFormatTest
{
    [TestClass]
    public class UnitTest1
    {
        private HtmlFormatHelper _htmlFormat;

        [TestMethod]
        [DataRow($"<b>Test</b>")]
        public void GetBoldFormat_ShouldReturnBold_IsTrue(string boldValue)
        {
            _htmlFormat = new HtmlFormatHelper();
            var result = _htmlFormat.GetBoldFormat("Test");
            Assert.AreEqual(result,boldValue);
        }

        [TestMethod]
        [DataRow($"<h3>Test</h3>")]
        public void GetBoldFormat_ShouldReturnBold_IsFalse(string boldValue)
        {
            _htmlFormat = new HtmlFormatHelper();
            var result = _htmlFormat.GetBoldFormat("Test");
            Assert.AreNotEqual(result, boldValue);
        }

        [TestMethod]
        [DataRow($"<i>Test</i>")]
        public void GetItalicFormatt_ShouldReturnItalic_IsTrue(string boldValue)
        {
            _htmlFormat = new HtmlFormatHelper();
            var result = _htmlFormat.GetItalicFormat("Test");
            Assert.AreEqual(result, boldValue);
        }
        [TestMethod]
        [DataRow($"<span>Test</span>")]
        public void GetItalicFormatt_ShouldReturnItalic_IsFalse(string boldValue)
        {
            _htmlFormat = new HtmlFormatHelper();
            var result = _htmlFormat.GetItalicFormat("Test");
            Assert.AreNotEqual(result, boldValue);
        }

        [TestMethod]
        [DataRow("Pomme")]
        public void GetFormattedListElements_ShouldReturnAStringOfListFormat_IsTrue(string elementOne)
        {
            _htmlFormat = new HtmlFormatHelper();
            List<string> _list = new List<string>();
            _list.Append(elementOne);
            Assert.AreEqual("Pomme", _htmlFormat.GetFormattedListElements(_list));
        }

        [TestMethod]
        [DataRow("Pomme")]
        public void GetFormattedListElements_ShouldReturnAStringOfListFormat_IsFalse(string elementOne)
        {
            _htmlFormat = new HtmlFormatHelper();
            List<string> _list = new List<string>();
            _list.Append(elementOne);
            Assert.AreNotEqual("<ul><li>Pomme</li></ul>", _htmlFormat.GetFormattedListElements(_list));
        }

    }
}