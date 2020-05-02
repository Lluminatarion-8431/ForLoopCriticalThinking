using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ForLoopCriticalThinking
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);

            };
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.Write("Enter the word you would like to print out: ");
            string word = Console.ReadLine();

            Console.Write("Enter the amount of times you would like to print " + word + ": ");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
                Console.WriteLine(word);

            int numberOfLetters = 0;
            foreach (char letter in "Hello World")
            {
                Console.WriteLine(numberOfLetters++);
            }

            //string text = "Hello World";
            //foreach (char c in text)
            //{
            //    Console.Write(c);
            //};
            //(i+2)


            //int i;
            //string str = "Hello World";
            //for (i = 0; i < str.Length; i++)
            //{
            //    Console.Write(str[i]);

            //};
            foreach (char c in "this is a test")
                Console.WriteLine(c);

          
            //20 times
        }


    }
}
