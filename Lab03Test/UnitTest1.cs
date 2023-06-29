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
        


    }
}