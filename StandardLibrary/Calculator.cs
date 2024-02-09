using System;

namespace StandardLibrary
{
	public class Calculator
	{
		public int Add(int x, int y)
		{
			int output = x + y;
			return output;
		}

		public int Subtract(int x, int y)
		{
			int output = x - y;
			return output;
		}

		public int Multiply(int x, int y)
		{
			int output = x * y;
			return output;
		}

		public int Divide(int x, int y)
		{
			int output = y != 0 ? x / y : throw new DivideByZeroException("You cannot divide by zero.");

			return output;
		}

		public int Modulo(int x, int y)
		{
			int output = y != 0 ? x % y : throw new DivideByZeroException("You cannot divide by zero.");

			return output;
		}
	}
}
