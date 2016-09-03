using NUnit.Framework;
using Core.Helpers;

namespace Test.Unit.Helpers.MathHelperTests
{
    [TestFixture]
    public class AddNumbersShould
    {
        [Test]
        public void Return3_WhenGiven_1And2()
        {
            var result = MathHelper.AddNumbers(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}