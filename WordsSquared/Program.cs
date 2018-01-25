using System;
using System.Text;
namespace WordsSquared
{
    class Program
    {
        static string middleLines, reverseString = String.Empty;
        static char[] userInput;

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Console.Write("Enter A String :\r\nd");
            userInput = Console.ReadLine().ToCharArray();

            int i = 1;
            do
            {
                middleLines = userInput[i].ToString();
                middleLines = middleLines.PadRight(userInput.Length - 1)
                    + userInput[userInput.Length - (i + 1)];
                sb.AppendLine(middleLines);
                i++;
            } while (i < userInput.Length && i != userInput.Length - 1);

            while (i >= 0)
            {
                reverseString = reverseString + userInput[i];
                i--;
            }

            Console.Write("{0}\r\n{1}{2}\r\n", new string(userInput), sb, reverseString);
            Console.ReadLine();
        }

    }
}
