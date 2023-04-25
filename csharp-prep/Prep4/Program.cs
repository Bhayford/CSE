using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int usernumber = -1
        while (usernumber != 0)
        {
            Console.Write("Enter a number (hit 0 to stop. )");
            string userresponse = Console.ReadLine();

            usernumber = int.Parse(userresponse);

            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The total of all was {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

               int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}