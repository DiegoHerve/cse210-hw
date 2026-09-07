using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string gradepercent = Console.ReadLine();

        int percentage = int.Parse(gradepercent);

        string grade = "";

        if (percentage >= 90 )
        {
            grade = "A";
        }

        else if (percentage >= 80)
        {
            grade = "B";
        }

        else if (percentage >= 70)
        {
            grade = "C";

        }

        else if (percentage >= 60)
        {
            grade = "D";

        }

        else
        {
            grade = "F";
        }

        Console.WriteLine($" Your grade is {grade}");

        if (percentage >= 70) 
        {
            Console.WriteLine("Congratulations, You passed!");
        }

        else
        {
            Console.WriteLine("Thank you for your effort, You did not pass");
        }
     
    }
}