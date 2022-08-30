using NUnit.Framework;
using UnitApp;

namespace Unit.Tests
{
    
    public class Tests
    {
        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CheckIsEmptyByEmptyStringTesting(string text)
        {
            bool result = SimpleClass.IsEmpty(text);
            Assert.True(result);
        }
       
        [Test]
        public void CheckIsEmptyByNonEmptyStringTesting()
        {
            bool result = SimpleClass.IsEmpty("text");
            Assert.False(result);
        }
        
        
        [Test]
        public void CheckIsDigitalByStringValueTesting()
        {
            Assert.False(SimpleClass.IsDigital("sddfgadfaga"));
        }
        
        [Test]
        public void CheckIsDigitalByNumberValueTesting()
        {
            Assert.True(SimpleClass.IsDigital("5448549149419"));
        }

        [Test]
        public void CheckIsLengthLessMaxIntegerLengthByBigValueTesting()
        {
            Assert.False(SimpleClass.IsLengthLessMaxInteger("3565363563653635635"));
        }
        
        [Test]
        public void CheckIsLengthLessMaxIntegerLengthBySmallValueTesting()
        {
            Assert.True(SimpleClass.IsLengthLessMaxInteger("45634"));
        }
    }
}