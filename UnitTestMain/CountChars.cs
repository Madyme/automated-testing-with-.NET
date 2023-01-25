// class liblary to implement new functionality

namespace CharNS
{
    public class Chars
    {
        public int CountMaxDiff(string str) // method to count maximum number of consecutive different chars in astring
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

        public int CountMaxEqualLetters(string str) // method to count maximum number of same consecutive letters in latin alphabet
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

        public int CountMaxEqualNum(string str) // method to count maximum number of consecutive identical digits
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
                throw new ArgumentException("Invalid Format!");
            }
            return max;
        }
    }
}
