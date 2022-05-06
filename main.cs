// Created by: Jaejun Lee
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int age;
        var dayWeek = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter what day of the week it is:");
        dayWeek = Console.ReadLine();

        if ((dayWeek == "Tuesday" || dayWeek == "Thursday") || (age > 12 && age < 21))
            Console.WriteLine("You're eligible for student pricing!");
        else
            Console.WriteLine("You must pay a regular price.");

    }
}