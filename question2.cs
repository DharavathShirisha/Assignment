using System;
namespace Assignment2;
{
    public Class1()
    {
        static void Main()
        {
            Console.WriteLine("Enter a number between 1 and 900:");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 900){Console.WriteLine("Please enter a number between 1 and 900.");}
            else{Console.WriteLine("In words: " + NumberToWords(number)); }
        }
        static string NumberToWords(int number)
        {
            if (number == 0) return "zero";

            if (number < 0)return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100; }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }return words;
        }
    }
}

