using System.Text;

namespace Session04
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Loops
			// For Loop
			// Works on the original array
			/*
			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine($"{i} T");
			}
			*/

			// Foreach
			// Works on a copy of the array
			// Works on a class that implememnts IEnumrable -> to use GetEnumrator to use copy

			/*int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] == 5)
				{
					break;
					//continue
				}

				Console.WriteLine(numbers[i]);
			}*/

			/*
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			foreach (int number in numbers)
			{
				Console.WriteLine(number);
			}
			*/


			// While and do while
			/*
			int number;
			bool flag;
			do
			{
				Console.WriteLine("Enter a number:");
				// Returns a boolean
				flag = int.TryParse(Console.ReadLine(), out number);
				//number = int.Parse(Console.ReadLine());
			} while (number % 2 == 1 || !flag);

			Console.WriteLine($"{number} is even.");
			*/

			// While
			/*
			int number = 3;
			bool flag = false;
			while (number % 2 == 1 || !flag)
			{
				flag = int.TryParse(Console.ReadLine(), out number);
				Console.WriteLine($"{number} is even.");
			
			}
			*/

			#region String
			/*
				String  
				Class => Reference type (Immutable)
				String => Array of characters
			*/
			// 4 bytes in stack
			/*string name;
			string Name01 = "Ahmed";
			string Name02 = "Ahmed";

			Console.WriteLine(Name01);
			Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
			Console.WriteLine(Name02);
			Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");*/

			/*string Name01 = "Ahmed";
			string Name02 = "Ali";
			Console.WriteLine(Name01);
			Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
			Console.WriteLine(Name02);
			Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");

			Name02 = Name01;
			Console.WriteLine("********* Name02 = Name01 *****");
			Console.WriteLine(Name01);
			Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
			Console.WriteLine(Name02);
			Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");*/

			/*string Message = "Hello";

			Console.WriteLine(Message);
			Console.WriteLine(Message.GetHashCode());

			Message += " Route";

			Console.WriteLine(Message);
			Console.WriteLine(Message.GetHashCode());*/

			#region StringBuilder
			// Linkedlist of characters
			/*StringBuilder Message;

			Message = new StringBuilder("Hello");

			Console.WriteLine(Message);
			Console.WriteLine(Message.GetHashCode());*/

			//Message += " Route";
			/*Message.Append(" Route");

			Console.WriteLine(Message);
			Console.WriteLine(Message.GetHashCode());*/

			#region String Builder Methods
			/*StringBuilder Message = new StringBuilder("Welcome");

			Message.Append(" To Route");
			Message.AppendLine(" Mostafa");
			Message.Append("Hany");

			Message.Remove(0, 7);

			Message.Insert(0, "Hello");
			Console.WriteLine(Message);

			int Age = 10;
			string Name = "Ali";
			Message.AppendFormat("Name : {0} , Age : {1}", Name, Age);

			Console.WriteLine(Message); 
			Message.AppendJoin("/", "Mostafa", "Hany", "Mohammed", 2);
			Console.WriteLine(Message);*/

			#region Array 1 D
			/*int[] Numbers = new int[3];

			for (int i = 0; i < Numbers.Length; i++)
			{
				Console.WriteLine($"Enter Element Number {i + 1}");
				Numbers[i] = int.Parse(Console.ReadLine());
			}

			for (int i = 0; i < Numbers.Length; i++)
			{
				Console.WriteLine(Numbers[i]);
			}

			Console.WriteLine(Numbers.Length);
			Console.WriteLine(Numbers.Rank);*/
			/*int[,] Marks = new int[3, 5];
			for (int i = 0; i < Marks.GetLength(0); i++)
			{
				Console.WriteLine($"Enter grades of Student {i + 1}");
				for (int k = 0; k < Marks.GetLength(1); k++)
				{
					Console.WriteLine($"Enter Grade Subject [{k + 1}]");
					Marks[i, k] = int.Parse(Console.ReadLine());
				}
			}

			for (int i = 0; i < Marks.GetLength(0); i++)
			{
				Console.WriteLine($"Grades Student ({i + 1})");
				for (int k = 0; k < Marks.GetLength(1); k++)
				{ 
					Console.Write($"Grade Subject [{k + 1}] : ");
					Console.WriteLine(Marks[i, k]);
				}
			}*/
			//Console.WriteLine(Marks.Length);
			//Console.WriteLine(Marks.Rank);
			//Console. WriteLine(Marks. GetLength(0));
			//Console. WriteLine(Marks. GetLength(1));


			/*int[,] Marks = new int[3, 5];
			for (int i = 0; i < Marks.GetLength(0); i++)
			{
				Console.WriteLine(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)]);

			}*/
			/*int[][] Number = new int[3][];
			Number[0] = new int[3] { 1, 2, 3 };
			Number[1] = new int[2] { 4, 5 };
			Number[2] = new int[1] { 6 };

			for (int i = 0; i < Number.Length; i++)
			{
				for(int j = 0; j < Number[i].Length; j++)
				{
					Console.WriteLine(Number[i][j]);
				}


			}*/

			#region Assignment 04
			// 1. Write a program that allows the user to insert an integer then print all numbers between 1 to that number
			/*Console.WriteLine("Enter a number: ");
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine("***************");

			for (int i = 1; i <= number; i++)
			{
				Console.WriteLine(i);
			}*/



			// 2. Write a program that allows the user to insert an integer then print a multiplication table up to 12
			/*Console.WriteLine("Enter a number: ");
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine("***************");
			for (int i = 1; i <= 12; i++)
			{
				Console.WriteLine($"{i} {i * number}");
			}*/

			// 3. Write a program that allows to insert an integer then print all even numbers between 1 to that number
			//Console.WriteLine("Enter a number: ");
			//int number = int.Parse(Console.ReadLine());
			//Console.WriteLine("***************");
			//for (int i = 1; i <= number; i++)
			//{
			//	// i % 2 == 0
			//	if (i % 2 == 0)
			//	{
			//		Console.WriteLine(i);
			//	}
			//}


			// 4. Write a program that takes two integers then prints the power
			/*Console.WriteLine("Enter first number: ");
			int baseNumber = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter second number: ");
			int exponent = int.Parse(Console.ReadLine());
			Console.WriteLine("********");

			double result = Math.Pow(baseNumber, exponent);

			Console.WriteLine($"Base number {baseNumber} raised to the power {exponent} = {result}");*/

			// 5. Write a program to allow the user to enter a string and print the reverse of it
			/*Console.WriteLine("Enter a string: ");
			string input = Console.ReadLine();
			char[] chars = input.ToCharArray();
			Array.Reverse(chars);
			string reversed = new string(chars);
			Console.WriteLine($"Reversed string: {reversed}");*/


			// 6. Write a program in C# Sharp to find prime numbers within a range of numbers
			/*Console.WriteLine("Enter starting range: ");
			int startingRange = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter ending range: ");
			int endingRange = int.Parse(Console.ReadLine());


			for (int i = startingRange; i <= endingRange; i++)
			{
				bool isPrime = true;
				for (int j = 2; j <= i / 2; j++)
				{
					if (i % j == 0)
					{
						isPrime = false;
						break;
					}
				}

				if (isPrime)
				{
					Console.WriteLine(i);
				}
			}*/

			// 7. Write a program in C# Sharp to convert a decimal number into binary without using an array.
			/*Console.Write("Enter a decimal number: ");
			int decimalNumber = int.Parse(Console.ReadLine());

			string binary = "";

			if (decimalNumber == 0)
			{
				binary = "0";
			}
			else
			{
				while (decimalNumber > 0)
				{
					// Get the remainder (0 or 1) and prepend it to the binary string
					binary = (decimalNumber % 2) + binary;
					decimalNumber /= 2;
				}
			}

			Console.WriteLine("Binary representation: " + binary);*/

			// 8. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n

			/*Console.Write("Enter the size of the identity matrix (n): ");
			int n = int.Parse(Console.ReadLine());

			Console.WriteLine("Identity Matrix:");
			for (int i = 0; i < n; i++) // Loop through rows
			{
				for (int j = 0; j < n; j++) // Loop through columns
				{
					// Print 1 if row index equals column index, otherwise 0
					if (i == j)
						Console.Write("1 ");
					else
						Console.Write("0 ");
				}
				Console.WriteLine(); // Move to the next row

			}*/


			// 9. Write C# program that Extract a substring from a given string
			/*Console.Write("Enter the original string: ");
			string originalString = Console.ReadLine();

			// Get the starting position
			Console.Write("Enter the starting position (0-based index): ");
			int startPosition = int.Parse(Console.ReadLine());

			// Get the length of the substring
			Console.Write("Enter the length of the substring: ");
			int length = int.Parse(Console.ReadLine());

			// Validate the input
			if (startPosition < 0 || startPosition >= originalString.Length)
			{
				Console.WriteLine("Error: Starting position is out of range.");
			}
			else if (length < 0 || startPosition + length > originalString.Length)
			{
				Console.WriteLine("Error: Length is out of range.");
			}
			else
			{
				// Extract the substring
				string substring = originalString.Substring(startPosition, length);
				Console.WriteLine("Extracted Substring: " + substring);
			}*/



			// 10. Write C# program that take two string variables and print them as one variable 
			/*Console.WriteLine("Enter first string:");
			string firstString = Console.ReadLine();

			Console.WriteLine("Enter second string:");
			string secondString = Console.ReadLine();


			string combinedString = firstString + " " + secondString;
			Console.WriteLine(combinedString);*/


			// 11. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

			/*Console.Write("Enter the size of the identity matrix (n): ");
			int n = int.Parse(Console.ReadLine());

			// Generate and print the identity matrix
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (i == j)
					{
						Console.Write("1 ");
					}
					else
					{
						Console.Write("0 ");
					}
				}
				Console.WriteLine(); // Move to the next row
			}*/

			// 12. Write a program in C# Sharp to find the sum of all elements of the array.

			/*Console.Write("Enter the size of the array: ");
			int size = int.Parse(Console.ReadLine());

			int[] array = new int[size];
			int sum = 0;

			// Input elements into the array
			Console.WriteLine("Enter the elements of the array:");
			for (int i = 0; i < size; i++)
			{
				Console.Write($"Element {i + 1}: ");
				array[i] = int.Parse(Console.ReadLine());
			}

			// Calculate the sum of the array elements
			for (int i = 0; i < size; i++)
			{
				sum += array[i];
			}

			// Display the sum
			Console.WriteLine($"The sum of all elements in the array is: {sum}");*/


			// 13. Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order

			/*Console.Write("Enter the size of the arrays: ");
			int size = int.Parse(Console.ReadLine());

			int[] array1 = new int[size];
			int[] array2 = new int[size];
			int[] mergedArray = new int[size * 2];

			// Input elements for the first array
			Console.WriteLine("Enter the elements of the first array:");
			for (int i = 0; i < size; i++)
			{
				Console.Write($"Element {i + 1}: ");
				array1[i] = int.Parse(Console.ReadLine());
			}

			// Input elements for the second array
			Console.WriteLine("Enter the elements of the second array:");
			for (int i = 0; i < size; i++)
			{
				Console.Write($"Element {i + 1}: ");
				array2[i] = int.Parse(Console.ReadLine());
			}

			// Merge the two arrays
			for (int i = 0; i < size; i++)
			{
				mergedArray[i] = array1[i];
				mergedArray[size + i] = array2[i];
			}

			// Sort the merged array in ascending order
			Array.Sort(mergedArray);

			// Display the sorted merged array
			Console.WriteLine("The merged and sorted array is:");
			foreach (int element in mergedArray)
			{
				Console.Write(element + " ");
			}
			Console.WriteLine();*/


			// 14. Write a program in C# Sharp to count the frequency of each element of an array.
			/*Console.Write("Enter the size of the array: ");
			int size = int.Parse(Console.ReadLine());

			int[] array = new int[size];

			// Input elements into the array
			Console.WriteLine("Enter the elements of the array:");
			for (int i = 0; i < size; i++)
			{
				Console.Write($"Element {i + 1}: ");
				array[i] = int.Parse(Console.ReadLine());
			}

			// Dictionary to store frequency of elements
			Dictionary<int, int> frequency = new Dictionary<int, int>();

			// Count the frequency of each element
			foreach (int element in array)
			{
				if (frequency.ContainsKey(element))
				{
					frequency[element]++;
				}
				else
				{
					frequency[element] = 1;
				}
			}

			// Display the frequency of each element
			Console.WriteLine("Frequency of each element:");
			foreach (var kvp in frequency)
			{
				Console.WriteLine($"{kvp.Key}: {kvp.Value}");
			}*/

			// 15. Write a program in C# Sharp to find maximum and minimum element in an array
			/*Console.Write("Enter the size of the array: ");
			int size = int.Parse(Console.ReadLine());

			int[] array = new int[size];

			
			Console.WriteLine("Enter the elements of the array:");
			for (int i = 0; i < size; i++)
			{
				Console.Write($"Element {i + 1}: ");
				array[i] = int.Parse(Console.ReadLine());
			}

			
			int max = array[0];
			int min = array[0];

			
			for (int i = 1; i < size; i++)
			{
				if (array[i] > max)
				{
					max = array[i];
				}

				if (array[i] < min)
				{
					min = array[i];
				}
			}

			
			Console.WriteLine($"The maximum element in the array is: {max}");
			Console.WriteLine($"The minimum element in the array is: {min}");*/

			// 16. Write a program in C# Sharp to find the second largest element in an array.
			/*Console.Write("Enter the size of the array: ");
			int size = int.Parse(Console.ReadLine());

			if (size < 2)
			{
				Console.WriteLine("Array must contain at least two elements.");
				return;
			}

			int[] array = new int[size];

			// Input elements into the array
			Console.WriteLine("Enter the elements of the array:");
			for (int i = 0; i < size; i++)
			{
				Console.Write($"Element {i + 1}: ");
				array[i] = int.Parse(Console.ReadLine());
			}

			// Initialize the first and second largest values
			int largest = int.MinValue;
			int secondLargest = int.MinValue;

			// Find the largest and second largest elements
			for (int i = 0; i < size; i++)
			{
				if (array[i] > largest)
				{
					secondLargest = largest;  // Update second largest
					largest = array[i];       // Update largest
				}
				else if (array[i] > secondLargest && array[i] != largest)
				{
					secondLargest = array[i]; // Update second largest
				}
			}

			// Check if there is a second largest element
			if (secondLargest == int.MinValue)
			{
				Console.WriteLine("There is no second largest element.");
			}
			else
			{
				Console.WriteLine($"The second largest element in the array is: {secondLargest}");
			}*/

			// 17. Consider an Array of Integer values with size N
			/*Console.Write("Enter the size of the array: ");
			int size = int.Parse(Console.ReadLine());

			int[] array = new int[size];

			// Input elements into the array
			Console.WriteLine("Enter the elements of the array:");
			for (int i = 0; i < size; i++)
			{
				Console.Write($"Element {i + 1}: ");
				array[i] = int.Parse(Console.ReadLine());
			}

			// Variable to store the longest distance
			int longestDistance = 0;

			// Loop to find the longest distance between equal elements
			for (int i = 0; i < size; i++)
			{
				for (int j = i + 1; j < size; j++)
				{
					if (array[i] == array[j])
					{
						int distance = j - i;  // Calculate the distance
						if (distance > longestDistance)  // Update longest distance if necessary
						{
							longestDistance = distance;
						}
					}
				}
			}

			// Output the result
			Console.WriteLine($"The longest distance between two equal elements is: {longestDistance}");*/

			// 18. Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array

			/*Console.Write("Enter the number of rows: ");
			int rows = int.Parse(Console.ReadLine());

			Console.Write("Enter the number of columns: ");
			int cols = int.Parse(Console.ReadLine());

			// Create two multidimensional arrays of the same size
			int[,] array1 = new int[rows, cols];
			int[,] array2 = new int[rows, cols];

			// Input values into the first array
			Console.WriteLine("Enter the elements of the first array:");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write($"Element at position ({i},{j}): ");
					array1[i, j] = int.Parse(Console.ReadLine());
				}
			}

			// Copy elements from the first array to the second array
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					array2[i, j] = array1[i, j];
				}
			}

			// Display the second array
			Console.WriteLine("\nElements of the second array (after copying from the first array):");
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					Console.Write(array2[i, j] + " ");
				}
				Console.WriteLine();
			}*/
			// 19. Write a Program to Print One Dimensional Array in Reverse Order
			/*Console.Write("Enter the size of the array: ");
			int n = int.Parse(Console.ReadLine());

			int[] arr = new int[n];

			// Asking the user to input the elements of the array
			Console.WriteLine($"Enter {n} elements of the array:");
			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}

			// Printing the array in reverse order
			Console.WriteLine("Array in reverse order:");
			for (int i = n - 1; i >= 0; i--)
			{
				Console.Write(arr[i] + " ");
			}*/

			#endregion
			#endregion
			#endregion
			#endregion
			#endregion
			#endregion


		}
	}
}
