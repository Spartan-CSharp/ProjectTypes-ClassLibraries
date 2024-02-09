using System;

using StandardLibrary;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			Calculator calculator = new Calculator();

			int sum = calculator.Add(3, 4);
			int difference = calculator.Subtract(4, 3);
			int product = calculator.Multiply(3, 4);
			int quotient = calculator.Divide(4, 3);
			int modulus = calculator.Modulo(4, 3);

			Console.WriteLine($"The sum of 3 and 4 is {sum}.");
			Console.WriteLine($"The difference between 4 and 3 is {difference}.");
			Console.WriteLine($"The product of 3 and 4 is {product}.");
			Console.WriteLine($"The quotient of 4 and 3 is {quotient}.");
			Console.WriteLine($"The modulus of 4 and 3 is {modulus}.");
		}
	}
}
