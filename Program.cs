using System;

class Program
{
	
// To return char for a value. For
// example '2' is returned for 2.
// 'A' is returned for 10. 'B' for 11
static char ConvertToChar(int num)
{
	if (num >= 0 && num <= 9)
		return Convert.ToChar(num + 48);
	else
		return Convert.ToChar(num - 10 + 65);
}

// Function to convert a given decimal number
// to a base 'base' and
static string ConvertToBase(int base1, int inputNum)
{
	string s = "";

	// Convert input number is given
	// base by repeatedly dividing it
	// by base and taking remainder
	while (inputNum > 0)
	{
		s += ConvertToChar(inputNum % base1);
		inputNum /= base1;
	}
	char[] res = s.ToCharArray();

	// Reverse the result
	Array.Reverse(res);
	return new String(res);
}
static void Main()
{
    Console.Write("Input an integer in decimal form: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input base number you want to convert to: ");
    int baseNum = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine(num + " in base "+baseNum+" is " + ConvertToBase(baseNum, num));
}
}
