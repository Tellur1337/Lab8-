using ConsoleApp1;

namespace TestProject
{
    public class Tests
    {
        [TestCase(new int[] { 1, 4, 7, 3, 6, 8, 2, 0, 9, 5 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        public void TestSorting(int[] testString)
        {
            int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Assert.IsTrue(Enumerable.SequenceEqual(Lab1.Sorting(testString), expected));
        }
        [TestCase(new int[] { })]
        public void TestSortingException(int[] testString)
        {
            var errorMessage = Assert.Throws<Exception>(() => Lab1.Sorting(testString));
            StringAssert.Contains("Массив не может быть пустым! ", errorMessage.ToString());
        }
        [TestCase("123454321")]
        [TestCase("!:%?((?%:!")]
        public void TestPalindrom(string testString)
        {
            Assert.IsTrue(Lab1.Palindrom(testString));
        }
        [TestCase("1231")]
        [TestCase("!3Daô!")]
        public void TestPalindromFalse(string testString)
        {
            Assert.IsFalse(Lab1.Palindrom(testString));
        }
        [TestCase(0)]
        [TestCase(-1)]
        public void TestFactorialException(int testNumber)
        {
            var errorMessage = Assert.Throws<Exception>(() => Lab1.Factorial(testNumber));
            StringAssert.Contains("Число не может быть меньше единицы! ", errorMessage.ToString());
        }
        [TestCase(1, ExpectedResult = 1)]
        [TestCase(3, ExpectedResult = 6)]
        [TestCase(5, ExpectedResult = 120)]
        public int TestFactorial(int testNumber)
        {
            return Lab1.Factorial(testNumber);
        }
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(2, ExpectedResult = 1)]
        [TestCase(6, ExpectedResult = 8)] 
        public int TestFibonacci(int testNum)
        {
            return Lab1.Fibonacci(testNum);
        }
        [TestCase(-1)]
        [TestCase(-100)]
        public void TestFibonacciException(int testNum)
        {
            var errorMessage = Assert.Throws<Exception>(() => Lab1.Fibonacci(testNum));
            StringAssert.Contains("Число не может быть меньше нуля!", errorMessage.ToString());
        }
        [TestCase(-12, 0, ExpectedResult = 1)]
        [TestCase(14, 1.7, ExpectedResult = 88.801)]
        [TestCase(12.643, -2.4, ExpectedResult = 0.002)]
        [TestCase(7.96, 4.31, ExpectedResult = 7637.22)]
        public double TestDoubleNum(double testNumber, double testDegree)
        {
            return Lab1.DoubleNum(testNumber, testDegree);
        }
        [TestCase(11)]
        [TestCase(23)]
        public void TestSimpleDigit(int testNumber)
        {
            Assert.IsTrue(Lab1.SimpleDigit(testNumber));
        }
        [TestCase(0)]
        [TestCase(-7)]
        public void TestSimpleDigitException(int testNumber)
        {
            var errMes = Assert.Throws<Exception>(() => Lab1.SimpleDigit(testNumber));
            StringAssert.Contains("Число sможет быть меньше единицы!", errMes.ToString());
        }
    }
}