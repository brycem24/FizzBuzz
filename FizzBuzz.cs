using System;

public class FizzBuzz
{
	public static void Main()
	{
		int maxNumber = 0;
		Console.WriteLine("Enter the amount of terms: ");
		maxNumber = Int32.Parse(Console.ReadLine());

		for (int i = 1; i <= maxNumber; i++)
		{
			if (i % 3 == 0 && i % 5 == 0)
				Console.Write("Fizz Buzz!, ");
			else if (i % 3 == 0)
				Console.Write("Fizz!, ");
			else if (i % 5 == 0)
				Console.Write("Buzz!, ");
			else
				Console.Write(i + ", ");
		}
		
  	}

}
