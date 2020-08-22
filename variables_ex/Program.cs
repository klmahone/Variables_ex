using System;

namespace variables_ex
{
    class Program
    {
        static void Main(string[] args)
        {

            string myName = "Kevin";
            int age = 55;
            char firstInitial = 'K';
            bool lovesJob = true;
            double YearsOnjob = 10.5;
            decimal currentTemp = 92.5m;

            Console.WriteLine($"My name is {myName} and I am {age} years old. \n" +
                $"The first letter of my nmae is {firstInitial}.\n" +
                $"I love my job {lovesJob}! I've been on the job {YearsOnjob} and love every minute of it, until it gets hot!\n" +
                $"The current temperature outside is {currentTemp}!\n");
        }
    }
}
