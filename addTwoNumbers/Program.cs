using System;

namespace addTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Please Enter the First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine("Sum is {0}", result);

            Console.WriteLine("Please press any key to close window");
            Console.ReadKey();
        }
    }
}
