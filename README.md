# Lab03-Review

## Challenge 5 Whiteboard

Write a method in that finds the maximum value in the array. The array is not sorted. You may not use .Sort()

```shell
Example: input [5, 25, 99, 123, 78, 96, 555, 108, 4]
return: 555
```

### Whiteboard Process

![Lab03Challenege05(1)](./Lab03Challenege05(1).PNG)
![Lab03Challenege05(2)](./Lab03Challenege05(2).PNG)

### Approach & Efficiency

The Challenge05 method finds the maximum value in an array of integers (numbers). Here's the breakdown of its approach and efficiency:

1. Input Validation: The method first checks if the input array is null or empty. If it is, an ArgumentException is thrown. This step ensures that the input is valid.

2. Initialization: The method initializes the variable max with the first element of the numbers array.

3. Linear Search: The method iterates over the remaining elements of the numbers array using a for loop. It compares each element with the current maximum value (max). If an element is found that is greater than the current maximum, it updates the value of max to that element.

4. Return the Maximum: After the loop completes, the method returns the maximum value (max) found in the array.

Approach:

* The approach used in this method is a simple linear search through the array.
* It starts by assuming the first element is the maximum and then iterates through the remaining elements, updating the maximum if a larger element is found.
* The maximum value is continuously updated until the end of the array is reached.


Efficiency:

* Time Complexity: The method has a time complexity of O(n), where n is the number of elements in the input array. This is because it performs a single pass over the array to find the maximum value.
* Space Complexity: The method has a space complexity of O(1) since it only uses a constant amount of additional space to store the maximum value (max) and loop variables.


Overall, the Challenge05 method has a straightforward approach and provides an efficient solution to find the maximum value in an array of integers.

### Solution

Function Code:

```shell
        public static int Challenge05(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Input array is null or empty.");
            }

            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
```

Calling from the main Code:

```shell
int[] input = { 22, 18, 99, 102, 1, 2 };
Console.WriteLine(Challenge05(input));
```

The result after running the code:

```shell
102
```


### Test Cases

Tests: 1. Negative numbers 2. All values are the same

```shell
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
```
