using System;
using System.Collections.Generic;
using System.Text;

namespace ForLoopCriticalThinking
{
    class CalculatorMadness
    {
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int result;

            result = numberOne + numberTwo;

            return result;
            //Console.WriteLine("Please enter the first number:");
            //int numberOne = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter the second number:");
            //int numberTwo = int.Parse(Console.ReadLine());

            //int result = numberOne + numberTwo;
            //Console.WriteLine("The result of this addition is: "+ result);
            
        }

        //public void RunCalculations()
        //{

        //    AddTwoNumbers(5, 7);
        //}

        //public void RunCalculations()
        //{
        //    //AddTwoNumbers(5, 7);
        //    AddTwoNumbers((8+40), (200+50));

        //    Console.WriteLine("Enter first number to add:");
        //    int value1 = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Enter second number to add:");
        //    int value2 = int.Parse(Console.ReadLine());

        //    int output = AddTwoNumbers(value1, value2);
        //    Console.WriteLine("The result is: " +output);

      
        //}
        public int SubtractTwoNumbers(int numberOne, int numberTwo)
        {
            int result;

            result = numberOne - numberTwo;

            return result;
            

        }
        public int MultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            int result;

            result = numberOne * numberTwo;

            return result;


        }
        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            int result;

            result = numberOne / numberTwo;

            return result;

        }
        public void RunCalculations()
        {
            //AddTwoNumbers(5, 7);
            //AddTwoNumbers((8 + 40), (200 + 50));
            DivideTwoNumbers();
            Console.WriteLine("Enter first number to add:");
            int value1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number to add:");
            int value2 = int.Parse(Console.ReadLine());

            int output = AddTwoNumbers(value1, value2);
            Console.WriteLine("The result is: " + output);


        }
    }
}
