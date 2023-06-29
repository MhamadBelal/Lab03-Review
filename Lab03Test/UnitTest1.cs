using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Lab03Test
{
    public class UnitTest1
    {
        [Fact]
        public void Challenge01_normalAct()
        {
            //arrange
            string numbers = "3 4 5";

            StringReader stringReader = new StringReader(numbers);
            Console.SetIn(stringReader);
            //act
            int product = Lab03Program.Program.Challenge01();

            //assert
            Assert.Equal(60, product);
        }

        [Fact]
        public void Challenge01_moreThanTreenInputs()
        {
            //arrange
            string numbers = "3 4 5 5 9";

            StringReader stringReader = new StringReader(numbers);
            Console.SetIn(stringReader);
            //act
            int product = Lab03Program.Program.Challenge01();


            //assert
            Assert.Equal(60, product);
        }

        [Fact]
        public void Challenge01_lessThanThreeInputs()
        {
            //arrange
            string numbers = "3 4";

            StringReader stringReader = new StringReader(numbers);
            Console.SetIn(stringReader);
            //act
            int product = Lab03Program.Program.Challenge01();


            //assert
            Assert.Equal(0, product);
        }
        [Fact]
        public void Challenge01_negativeInputs()
        {
            //arrange
            string numbers = "3 4 -5";

            StringReader stringReader = new StringReader(numbers);
            Console.SetIn(stringReader);
            //act
            int product = Lab03Program.Program.Challenge01();


            //assert
            Assert.Equal(-60, product);
        }

        [Fact]
        public void Challenge02_WhenValidNumberEntered_ReturnsAverage()
        {
            // Arrange
            string input = "4\n4\n8\n15\n16\n"; // Input with valid number and 5 valid inputs
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // Act
            int result = Lab03Program.Program.Challenge02();

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Challenge02_WhenNumberLessThan2Entered_ReturnsZero()
        {
            // Arrange
            string input = "1\n"; // Input with number less than 2
            System.IO.StringReader stringReader = new System.IO.StringReader(input);
            Console.SetIn(stringReader);

            // Act
            int result = Lab03Program.Program.Challenge02();

            // Assert
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void Challenge02_WhenNumberGreaterThan10Entered_ReturnsZero()
        {
            // Arrange
            string input = "11\n"; // Input with number greater than 10
            System.IO.StringReader stringReader = new System.IO.StringReader(input);
            Console.SetIn(stringReader);

            // Act
            int result = Lab03Program.Program.Challenge02();

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Challenge02_WhenNonNumericInputEntered_ReturnsZero()
        {
            // Arrange
            string input = "4\n1\n2\n3\ninvalid\n";
            System.IO.StringReader stringReader = new System.IO.StringReader(input);
            Console.SetIn(stringReader);

            // Act
            int result = Lab03Program.Program.Challenge02();

            // Assert
            Assert.Equal(-2, result);
        }

        [Fact]
        public void Challenge02_WhenNegativeNumberEntered_ReturnsZero()
        {
            // Arrange
            string input = "4\n1\n2\n-3\n"; // Input with negative number
            System.IO.StringReader stringReader = new System.IO.StringReader(input);
            Console.SetIn(stringReader);

            // Act
            int result = Lab03Program.Program.Challenge02();

            // Assert
            Assert.Equal(-1, result);
        }
        
        [Fact]
        public void Challenge02_WhenAllNumbersAre0s_ReturnsZero()
        {
            // Arrange
            string input = "4\n0\n0\n0\n0\n"; // Input with negative number
            System.IO.StringReader stringReader = new System.IO.StringReader(input);
            Console.SetIn(stringReader);

            // Act
            int result = Lab03Program.Program.Challenge02();

            // Assert
            Assert.Equal(0, result);
        }


        [Fact]
        public void Challenge04_DifferentSizeArrays()
        {
            // Arrange
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 2, 3, 2, 4, 3, 1, 1, 5 };
            int[] numbers3 = { 1 };

            // Act
            int result1 = Lab03Program.Program.Challenge04(numbers1);
            int result2 = Lab03Program.Program.Challenge04(numbers2);
            int result3 = Lab03Program.Program.Challenge04(numbers3);

            // Assert
            Assert.Equal(1, result1);
            Assert.Equal(2, result2);
            Assert.Equal(1, result3);
        }

        [Fact]
        public void Challenge04_AllNumbersSameValue()
        {
            // Arrange
            int[] numbers = { 5, 5, 5, 5, 5 };

            // Act
            int result = Lab03Program.Program.Challenge04(numbers);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Challenge04_NoDuplicatesExist()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Act
            int result = Lab03Program.Program.Challenge04(numbers);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Challenge04_MultipleNumbersSameCount()
        {
            // Arrange
            int[] numbers = { 3, 2, 1, 4, 5, 5, 4, 3, 2, 1 };

            // Act
            int result = Lab03Program.Program.Challenge04(numbers);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Challenge05_NegativeNumbers()
        {
            // Arrange
            int[] numbers = { -10, -5, -20, -15, -30 };

            // Act
            int result = Lab03Program.Program.Challenge05(numbers);

            // Assert
            Assert.Equal(-5, result);
        }

        [Fact]
        public void Challenge05_AllValuesSame()
        {
            // Arrange
            int[] numbers = { 7, 7, 7, 7, 7, 7, 7 };

            // Act
            int result = Lab03Program.Program.Challenge05(numbers);

            // Assert
            Assert.Equal(7, result);
        }

        [Fact]
        public void GetWordLengths_InputSentence_ReturnsCorrectArray()
        {
            // Arrange
            string sentence = "This is a sentence about important things";
            string[] expected = { "This: 4", "is: 2", "a: 1", "sentence: 8", "about: 5", "important: 9", "things: 6" };

            // Act
            string[] actual = Lab03Program.Program.Challenge09(sentence);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetWordLengths_InputSentence_ReturnsArray()
        {
            // Arrange
            string sentence = "Hello world";

            // Act
            string[] wordLengths = Lab03Program.Program.Challenge09(sentence);

            // Assert
            Assert.NotNull(wordLengths);
            Assert.NotEmpty(wordLengths);
        }

        [Fact]
        public void GetWordLengths_InputSentencesWithSymbols_ReturnsCorrectArray()
        {
            // Arrange
            string sentence1 = "Hello, world!";
            string sentence2 = "Programming is fun!!!";
            string[] expected1 = { "Hello,: 6", "world!: 6" };
            string[] expected2 = { "Programming: 11", "is: 2", "fun!!!: 6" };

            // Act
            string[] actual1 = Lab03Program.Program.Challenge09(sentence1);
            string[] actual2 = Lab03Program.Program.Challenge09(sentence2);

            // Assert
            Assert.Equal(expected1, actual1);
            Assert.Equal(expected2, actual2);
        }


    }
}