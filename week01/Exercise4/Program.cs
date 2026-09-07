using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        double sum = 0;
        double largest = numbers[0];

        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];

            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        double average = sum / numbers.Count;

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + largest);
    }
}



    


