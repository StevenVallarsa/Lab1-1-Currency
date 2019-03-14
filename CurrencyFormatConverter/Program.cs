using System;
using System.Globalization;
using System.Linq;

namespace CurrencyFormatConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three currency amounts (in the XXX.XX format):\n");


            // using function GetNumber() to try/catch non-numeric input
            Console.Write("Your first number: ");
            double firstNumber = GetNumber();

            Console.Write("Your second number: ");
            double secondNumber = GetNumber();

            Console.Write("Your third number: ");
            double thirdNumber = GetNumber();

            Console.WriteLine("\n");


            // finds average, max, and min, and then converting them to currency format
            double total = firstNumber + secondNumber + thirdNumber;
            double average = total / 3;
            string averageStr = average.ToString("N2");

            double[] numbers = { firstNumber, secondNumber, thirdNumber };

            double maxNum = numbers.Max();
            string maxNumStr = maxNum.ToString("N2");

            double minNum = numbers.Min();
            string minNumStr = minNum.ToString("N2");


            Console.WriteLine("The average of the numbers is {0}", averageStr);
            Console.WriteLine("The smallest number is {0}", minNumStr);
            Console.WriteLine("The largest number is {0}", maxNumStr);

            Console.WriteLine("\n");

            Console.WriteLine("US: \t\t" + total.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("Swedish: \t" + total.ToString("c", CultureInfo.CreateSpecificCulture("sv-SE")));
            Console.WriteLine("Japanese: \t" + total.ToString("c", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Thai: \t\t" + total.ToString("c", CultureInfo.CreateSpecificCulture("th-TH")));

            // Japan - ja-JP - JPY
            // Thailand - th-TH - THB
            // Sweeden - sv-SE - SEK
            // US - en-US

        }

        public static double GetNumber()
        {
            while(true)
            {
                try
                {
                    double num = double.Parse(Console.ReadLine());
                    return num;

                }
                catch (Exception)
                {
                    Console.Write("Oops. That input wasn't correct. Try typing a currency again: ");
                }

            }
        }
    }
}
