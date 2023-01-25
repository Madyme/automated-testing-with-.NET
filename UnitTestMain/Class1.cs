namespace ProgramNS
{
    public class Program
    {
        public int CountMaxDiff(string str)
        {
            int count = 1;
            int max = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                while (i < str.Length - 1 && str[i] != str[i + 1])
                {
                    count++;
                    i++;
                }
                if (max < count)
                {
                    max = count;
                }
                count = 1;

            }
            return max;
        }

        public int CountMaxEqualLetters(string str)
        {

            int max = 0;
            string upperString = str.ToUpper();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (upperString[i] >= 'A' && upperString[i] <= 'Z')
                {
                    int count = 1;
                    while (i < upperString.Length - 1 && upperString[i] == upperString[i + 1])
                    {
                        count++;
                        i++;
                    }
                    if (max < count)
                    {
                        max = count;
                    }
                    count = 1;
                }
            }
            return max;
        }

        public int CountMaxEqualNum(string str)
        {
            int max = 0;
            if (int.TryParse(str, out int res))
            {
                int count = 1;
                for (int i = 0; i < str.Length - 1; i++)
                {
                    while (i < str.Length - 1 && str[i] == str[i + 1])
                    {
                        count++;
                        i++;
                    }
                    if (max < count)
                    {
                        max = count;
                    }
                    count = 1;

                }
            }
            else
            {
                Console.WriteLine("Invalid format!");
            }
            return max;
        }
        // static char ConvertToChar(int num)
        // {
        //     if (num >= 0 && num <= 9)
        //         return Convert.ToChar(num + 48);
        //     else
        //         return Convert.ToChar(num - 10 + 65);
        // }

        // static string ConvertToBase(int baseNum, int num)
        // {
        //     string str = "";

        //     while (num > 0)
        //     {
        //         str += ConvertToChar(num % baseNum);
        //         num /= baseNum;
        //     }
        //     char[] res = str.ToCharArray();

        //     Array.Reverse(res);
        //     return new String(res);
        // }
        static void Main()
        {
            // Console.WriteLine(CountMaxEqualNum("0092139999"));
            // Console.Write("Input an integer in decimal form: ");
            // string? num = Console.ReadLine();
            // int cleanNum;
            // while (!int.TryParse(num, out cleanNum))
            // {
            //     Console.Write("This is not valid input. Please enter an integer value: ");
            //     num = Console.ReadLine();
            // }
            // Console.Write("Input base number you want to convert to: ");
            // string? baseNum = Console.ReadLine();
            // int cleanBaseNum;
            // while (!int.TryParse(baseNum, out cleanBaseNum))
            // {
            //     Console.Write("This is not valid input. Please enter an integer value: ");
            //     baseNum = Console.ReadLine();
            // }
            // Console.WriteLine(num + " in base " + cleanBaseNum + " is " + ConvertToBase(cleanBaseNum, cleanNum));
        }
    }
}
