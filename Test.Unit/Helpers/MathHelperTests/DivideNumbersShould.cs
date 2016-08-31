using NUnit.Framework;
using Core.Helpers;

namespace Test.Unit.Helpers.MathHelperTests
{
    [TestFixture]
    public class DivideNumbersShould
    {
        [Test]
        public void Return0_WhenNumerator_Is0()
        {
            var result = MathHelper.DivideNumbers(0, 10);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Return0_WhenDenomiator_Is0()
        {
            var result = MathHelper.DivideNumbers(10, 0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Return3_WhenNumerator_Is6_AndDenomiator_Is2()
        {
            var result = MathHelper.DivideNumbers(6, 2);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}