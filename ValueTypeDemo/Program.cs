using System;

namespace ValueTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal loanAmount = 0;
            decimal loanAmountCopy = 0;

            Console.WriteLine("Please enter a loan amount");

            loanAmount = Convert.ToDecimal(Console.ReadLine());

            loanAmountCopy = loanAmount;

            Console.WriteLine($"loanAmount: {loanAmount}, loanAmountCopy {loanAmountCopy}");

            Console.ReadKey();

            loanAmount = loanAmount + 600;

            Console.WriteLine();
            Console.WriteLine($"After adding 600 pounds loanAmount: {loanAmount}, loanAmountCopy {loanAmountCopy}");

            Console.ReadKey();

            
        }
    }
}
