using System.Diagnostics.Metrics;
using System.Numerics;

namespace hw3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task_3a();
            //task_3b();
            //task_4();
            task_5();
            //task_6();
            //task_7();
        }
        static void task_1()
        {
            int n = 0;
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 != 0)
                {
                    n += i;
                }
            }
            Console.WriteLine(n);
        }
        static void task_2()
        {
            int a = 0, b = 0, sum = 0;
            Console.Write("Enter first natural number: ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Enter second natural number: ");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            while (a <= b)
            {
                if (a % 4 == 0)
                {
                    sum += a;
                }
                a++;
            }
            Console.WriteLine("The answer is: " + sum);
        }
        static void task_3a()
        {
            int counter1 = 0, counter2 = 0, num1=0,num2=0;
            
            Console.WriteLine("Next numbers fulfill our condition: ");
            for (int i = 10; i < 100; i++)
            {
                int number = i, number1 = i;
                num1 = number % 10;
                number /= 10;
                num2 = number;
                counter1 = num1 * num1;
                counter2 = num2 * num2;
                if ((counter1+counter2)%13==0)
                {
                    Console.Write(number1 + " ");
                }
            }
        }
        static void task_3b()
        {
            int counter1 = 0, counter2 = 0, num1 = 0, num2 = 0;
            Console.WriteLine("Next numbers fulfill our condition: ");
            for (int i = 10; i < 100; i++)
            {
                int number = i, number1 = i;
                num1 = number % 10;
                number /= 10;
                num2 = number;
                counter1 = num1+num2;
                counter2 = counter1 * counter1;
                if ((counter1 + counter2) == number1)
                {
                    Console.Write(number1 + " ");
                }
            }
        }
        static void task_4()
        {
            int A = 0, B = 0;
            Console.Write("Enter A (A<B): ");
            try
            {
                A = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Enter B (B>A): ");
            try
            {
                B = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int counter1 = 0; long counter2 = 1;
            if (A < B)
            {
                while (A <= B)
                {
                    counter1 += A;
                    counter2 *= A;
                    A++;
                }
                Console.WriteLine("The sum is: " + counter1 + "\nThe product is: " + counter2);
            }
            else
            {
                Console.WriteLine("You`ve entered incorrect data, try to restart the program");
            }
        }
        static void task_5()
        {
            int A = 0, B = 0;
            Console.Write("Enter A (A<B): ");
            try
            {
                A = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Enter B (B>A): ");
            try
            {
                B = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int counter = 0;
            if (A < B)
            {
                counter = B - A;
                Console.Write("The list of numbers from " + A + " to " + B+": \n");
                while (A <= B)
                {
                    Console.Write(A + " ");
                    A++;
                }
                Console.WriteLine("\nThere are " + ++counter + " numbers");
            }
            else
            {
                Console.WriteLine("You`ve entered incorrect data, try to restart the program");
            }
        }
        static void task_6()
        {
            double price = 0;
            Console.Write("Enter the price for 1kg: ");
            try
            {
                price = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for(double i = 1; i <= 2; i+=0.2)
            {
                Console.WriteLine("Price for " + Math.Round(i, 2) + "kg" + " equal to " + Math.Round((price * i),2));
            }
        }
        static void task_7()
        {
            int A = 0, B = 0;
            Console.Write("Enter A (A<B): ");
            try
            {
                A = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Enter B (B>A): ");
            try
            {
                B = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int counter = 0;
            if (A < B)
            {
                counter = B - A;
                Console.Write("The list of numbers from " + A + " to " + B + " N times: \n");
                while (A <= B)
                {
                    for (int i = 0; i < A; i++)
                    {
                        Console.Write(A + " ");
                    }
                    A++;
                }
                Console.WriteLine("\nThere are " + ++counter + " numbers");
            }
            else
            {
                Console.WriteLine("You`ve entered incorrect data, try to restart the program");
            }
        }
    }
}