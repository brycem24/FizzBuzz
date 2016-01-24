import java.util.Scanner;

class FizzBuzz
{
	public static void main(String[] args) {
		System.out.println("Enter the value you want to check up to.");

		Scanner input = new Scanner(System.in);
		int maxValue = input.nextInt();

		for (int i = 1; i <= maxValue; i++)
		{
			if (i % 3 == 0 && i % 5 == 0)
				System.out.print("Fizz Buzz!, ");
			else if (i % 3 == 0)
				System.out.print("Fizz!, ");
			else if (i % 5 == 0)
				System.out.print("Buzz!, ");
			else
				System.out.print(i + ", ");
		}
		
	}
}
