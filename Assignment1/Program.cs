using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void swapping(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        static int multiplication(int x, int y, int z)
        {
            int ans = (x * y * z);
            return ans;
        }
        static void PrintOperationResult(int num1, int num2, string operation, int result)
        {
            Console.WriteLine($"{num1} {operation} {num2} = {result}");
        }
        static void operation(int x, int y, int z)
        {
            int result1 = (x + y)*z;
            int result2 = (x*y) + (y*z);
            Console.WriteLine($"((x+y).z) = {result1} and (x.y + y.z) = {result2}");
        }
        static void display(int x)
        {
            Console.WriteLine("{0} {0} {0} {0}" , x);
            Console.WriteLine("{0}{0}{0}{0}" , x);
        }
        static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        static int sum(int x, int y)
        {
            if (x == y)
            {
                int result1 = ((x+y) * 3);
                return result1;
            }
            else
            {
                int result2 = x + y;
                return result2;
            }
        }
        static int GetAbsoluteDifference(int x, int y)
        {
            int absoluteDifference = Math.Abs(x - y);

            if (x > y)
                return 2 * absoluteDifference;
            else
                return absoluteDifference;
        }
        static void convertDays(int totalDays)
        {
            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int weeks = remainingDays / 7;
            int days = remainingDays % 7;

            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Weeks: {weeks}");
            Console.WriteLine($"Days: {days}");
        }
        static void marks(int x, int y, int z)
        {
            int totalMarks = x+y+z;
            int percentage = totalMarks / 3;
            string grade = "";
            if ( percentage < 35)
            {
                grade = "Fail";
            }
            else if ( percentage > 34 && percentage < 46)
            {
                grade = "Third";
            }
            else if ( percentage > 44 && percentage < 61)
            {
                grade = "Second";
            }
            else if (percentage > 59)
            {
                grade = "First";
            }

            Console.WriteLine("Grade: " + grade);
        }
        static void minmax(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine($"First number: {x} is greater than Second number: {y}");
            }
            else
            {
                Console.WriteLine($"Second number: {y} is greater than First number: {x}");
            }
        }
        static void Main(string[] args)
        {
            //Swap();
            //mul();
            //operation();
            //calculateEquation();
            //disp();
            //convertTemp();
            //Addition();
            //absoluteDifference();
            //DaysToYears();
            //Calculategrade();
            //greaterNumber();
        }

        private static void greaterNumber()
        {
            Console.Write("Input First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            minmax(a, b);
            Console.ReadLine();
        }

        private static void Calculategrade()
        {
            Console.Write("Input First Subject Marks: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Second Subject Marks: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Third Subject Marks: ");
            int c = Convert.ToInt32(Console.ReadLine());

            marks(a, b, c);
            Console.ReadLine();
        }

        private static void DaysToYears()
        {
            Console.Write("Enter the number of days: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());
            convertDays(totalDays);
            Console.ReadLine();
        }

        private static void absoluteDifference()
        {
            Console.Write("Input the First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = GetAbsoluteDifference(a, b);
            Console.WriteLine("Absolute difference: " + result);
            Console.ReadLine();
        }

        private static void Addition()
        {
            Console.Write("Input the First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = sum(a, b);
            Console.WriteLine("Result = " + result);
            Console.ReadLine();
        }

        private static void convertTemp()
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double kelvin = CelsiusToKelvin(celsius);
            double fahrenheit = CelsiusToFahrenheit(celsius);

            Console.WriteLine("Temperature in Kelvin: {0}", kelvin);
            Console.WriteLine("Temperature in Fahrenheit: {0}", fahrenheit);

            Console.ReadLine();
        }

        private static void disp()
        {
            Console.Write("Enter a Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            display(a);
            display(a);
            Console.ReadLine();
        }

        private static void calculateEquation()
        {
            Console.Write("Input the First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Third Number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            operation(a, b, c);
            Console.ReadLine();
        }

        private static void operation()
        {
            Console.Write("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            PrintOperationResult(num1, num2, "+", num1 + num2);
            PrintOperationResult(num1, num2, "-", num1 - num2);
            PrintOperationResult(num1, num2, "x", num1 * num2);
            PrintOperationResult(num1, num2, "/", num1 / num2);
            PrintOperationResult(num1, num2, "mod", num1 % num2);

            Console.ReadKey();
        }

        private static void mul()
        {
            Console.Write("Input the First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Third Number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int ans = multiplication(a, b, c);
            Console.WriteLine($"{a} * {b} * {c} = " + ans);
            Console.ReadLine();
        }

        private static void Swap()
        {
            Console.Write("Input the First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping:");
            Console.WriteLine("First Number: " + a);
            Console.WriteLine("Second Number: " + b);

            swapping(ref a, ref b);

            Console.WriteLine("After Swapping:");
            Console.WriteLine("First Number: " + a);
            Console.WriteLine("Second Number: " + b);

            Console.ReadLine();
        }
    }
}
