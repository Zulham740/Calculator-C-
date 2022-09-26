using System;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            char variabel_1 = '1';
            do
            {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("---------------");
            Console.WriteLine("Calculator Sederhana");
            Console.WriteLine("---------------");
            Console.WriteLine("");
        
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multipication");
            Console.WriteLine("Press 4 for Division");

            int inputan = Convert.ToInt32(Console.ReadLine());
            switch (inputan)
                {
                    case 1:
                        Console.Write("Enter the 1st input: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the 2nd input: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;

                    case 2:
                        Console.Write("Enter the 1st input: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the 2nd input: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;

                    case 3:
                        Console.Write("Enter the 1st input: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the 2nd input: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;

                    case 4:
                        Console.Write("Enter the 1st input: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the 2nd input: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;

                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Would you like to continue?: ");
                Console.WriteLine("Y = yes, N = no");

            }while(Console.ReadLine().ToUpper() == "Y");
            Console.ReadKey();

        }
    }
}