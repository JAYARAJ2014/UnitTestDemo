using NUnit.Framework;
using NumberGimmicks;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {

        FizzBuzz fizzBuzz;
        [SetUp]
        public void Setup() => fizzBuzz = new FizzBuzz();

        [Test]
        public void FizzBuzz_Returns_FizzBuzz_When_Input_Is_Divisible_By_Five_And_Three()
        {
            var input = 15;
            var expected = "FizzBuzz";
            var actual = fizzBuzz.GetFizzBuzz(input);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void FizzBuzz_Returns_Fizz_When_Input_Is_Divisible_By_Five_And_Not_By_Three()
        {
            var input = 10;
            var expected = "Fizz";
            var actual = fizzBuzz.GetFizzBuzz(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FizzBuzz_Returns_Buzz_When_Input_Is_Divisible_By_Three_And_Not_By_Five()
        {
            var input = 9;
            var expected = "Buzz";
            var actual = fizzBuzz.GetFizzBuzz(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FizzBuzz_Returns_Input_When_Not_Divisible_By_Three_Or_Five()
        {
            var input = 8;
            var expected = "8";
            var actual = fizzBuzz.GetFizzBuzz(input);
            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown() => fizzBuzz = null;
    }
}