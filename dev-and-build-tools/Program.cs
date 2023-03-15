using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some string: ");
            string tempChar = ""; // temp char to find repeated values in entered string
            string? word = Console.ReadLine();
            int[] newArr = new int[word.Length];
            int index = 0; //index for newArr array
            int count = 1;
            int max = 0;
            if (word != "")
            {
                for (int i = 0; i < word.Length - 1; i++)
                {
                    for (int j = i + 1; j < word.Length; j++)
                    {
                        if (word[i] != word[j])
                        {
                            if (tempChar != word[j].ToString())
                            {
                                count++;
                            }
                            else
                            {
                                count = 1;
                                break;
                            }
                        }
                        else if (word[i] == word[j])
                        {
                            tempChar = word[j].ToString();
                            break;
                        }

                    }
                    newArr[index] = count;
                    index++;
                    count = 1;
                }
                max = newArr[0];
                for (int i = 0; i < newArr.Length; i++)
                {
                    if (max < newArr[i])
                    {
                        max = newArr[i];
                    }
                }
                Console.WriteLine(max);
            } 
        }
    }
}