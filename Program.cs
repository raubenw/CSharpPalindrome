using System;
using System.Text;

namespace CSharpPalindrome
{

    class Program
    {

        static void Main(string[] args)
        {

            string userString = "";
            (bool, int) result;

            Console.WriteLine("Lets begin");
            while (userString != "exit")
            {
                userString = Console.ReadLine();
                if (userString != "exit")
                {
                    result = isPalindrome(userString);
                    Console.WriteLine($"Is palindrome {result.Item1} and lenght is {result.Item2}");
                }
            }


        }

        static (bool, int) isPalindrome(string inputString)
        {

            string testString = inputString.ToUpper();

            StringBuilder sb = new StringBuilder();
            foreach (char c in testString)
            {
                if (!Char.IsPunctuation(c) && !Char.IsWhiteSpace(c))
                {
                    sb.Append(c);
                }
            }

            testString = sb.ToString();
            int i = 0, j = testString.Length - 1;
            while (i <= j)
            {
                if (testString[i] != testString[j])
                {
                    return (false, 0);
                }
                i++;
                j--;
            }

            return (true, testString.Length);
        }
    }


}