using CharNS;
class Program
{
    
    static char ConvertToChar(int num)
    {
        if (num >= 0 && num <= 9)
            return Convert.ToChar(num + 48);
        else
            return Convert.ToChar(num - 10 + 65);
    }

    static string ConvertToBase(int baseNum, int num)
    {
        string str = "";

        while (num > 0)
        {
            str += ConvertToChar(num % baseNum);
            num /= baseNum;
        }
        char[] res = str.ToCharArray();

        Array.Reverse(res);
        return new String(res);
    }
    static void Main()
    {
        Console.WriteLine(CountMaxEqualNum("0092139999"));
        Console.Write("Input an integer in decimal form: ");
        string? num = Console.ReadLine();
        int cleanNum;
        while (!int.TryParse(num, out cleanNum))
        {
            Console.Write("This is not valid input. Please enter an integer value: ");
            num = Console.ReadLine();
        }
        Console.Write("Input base number you want to convert to: ");
        string? baseNum = Console.ReadLine();
        int cleanBaseNum;
        while (!int.TryParse(baseNum, out cleanBaseNum))
        {
            Console.Write("This is not valid input. Please enter an integer value: ");
            baseNum = Console.ReadLine();
        }
        Console.WriteLine(num + " in base " + cleanBaseNum + " is " + ConvertToBase(cleanBaseNum, cleanNum));
    }
}
