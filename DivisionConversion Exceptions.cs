using System;

namespace DivisionConversionExceptions
{
class Program
{
	static void Main(string[] args) // Starting point of the application
	{
		while (true) // Loop to allow repeated attempts
		{
			Console.WriteLine("Enter the first number:"); // Prompt for the first number
			string input1 = Console.ReadLine();

			Console.WriteLine("Enter the second number:"); // Prompt for the second number
			string input2 = Console.ReadLine();

			// Call division method and check if the operation was successful
			if (DivideNumbers(input1, input2))
			{
				break; // Exit the loop if division was successful
			}
			else
			{
				Console.WriteLine("Please try again.\n"); // Prompt to try again on failure
			}
		}
	}

	static bool DivideNumbers(string strNum1, string strNum2) // Division method
	{
		try // Try block to attempt conversion and division
		{
			// Convert strings to integers
			int num1 = Convert.ToInt32(strNum1);
			int num2 = Convert.ToInt32(strNum2);

			// Perform the division operation
			int result = num1 / num2;
			Console.WriteLine($"The result of {num1} divided by {num2} is: {result}"); // Display result
			return true; // Return true on successful division
		}
		catch (FormatException) // Handle format exceptions
		{
			Console.WriteLine("Error: Please enter valid integers."); // Inform user of format error
		}
		catch (DivideByZeroException) // Handle divide by zero exceptions
		{
			Console.WriteLine("Error: Division by zero is not allowed."); // Inform user of division error
		}
		catch (Exception ex) // Handle any unexpected exceptions
		{
			Console.WriteLine($"An unexpected error occurred: {ex.Message}"); // Inform user of unexpected error
		}
		return false; // Return false if an error occurred
	}
}
}