// Created by: Jaejun Lee
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userAge;
        var dayWeek = Console.ReadLine();

        Console.WriteLine("Write your age:");
        userAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Write day of the week it is (Capital first letter):");
        dayWeek = Console.ReadLine();

        if ((dayWeek == "Tuesday" || dayWeek == "Thursday") && (userAge > 12 && userAge < 21))
            Console.WriteLine("You have a student discount! Pay student pricing.");
        else
            Console.WriteLine("You do not have a student discount! Pay regular pricing.");

    }
}