// Created by: Youngwook
// Created on: NOV 2022
//
// This function gets random number and user number
// This function compares random number and user number and answer.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // input
        int input;

        Console.WriteLine("This program gets user age and answer properly.\n");

        Console.Write("Enter your age : "); input = Convert.ToInt32(Console.ReadLine());

        if (input >= 17)
        {
            Console.WriteLine("You can see an R movie alone.\n");
        }
        else if (input >= 13)
        {
            Console.WriteLine("You can see a PG-13 movie alone\n");
        }
        else if (input >= 5)
        {
            Console.WriteLine("You can see a G or PG movie alone\n");
        }
        else
        {
            Console.WriteLine("You're too young for most thing\n");
        }

        Console.WriteLine("Thanks for verifyng your age");
        Console.WriteLine("\ndone.");
    }
}
