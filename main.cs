// Created by: Jaejun Lee
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        float age;
        int dayint;
        string day;

        void askAge()
        {
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        void askDay()
        {
            Console.WriteLine("Enter day of the week: ");
            Console.WriteLine("1 - Sunday");
            Console.WriteLine("2 - Monday");
            Console.WriteLine("3 - Tuesday");
            Console.WriteLine("4 - Wednesday");
            Console.WriteLine("5 - Thursday");
            Console.WriteLine("6 - Friday");
            Console.WriteLine("7 - Saturday");
            dayint = Convert.ToInt32(Console.ReadLine());
            if (dayint > 7 || dayint < 1)
            {
                Console.Clear();
                Console.WriteLine("\nPlease enter a valid number.");
                askDay();
            }
            else if (dayint == 3 || dayint == 5)
            {
                day = "Free Day";
            }
            else
            {
                day = "Unfree Day";
            }
        }

        askAge();
        askDay();
        if (day == "Free Day" && day != "Unfree Day" || age > 12 && age < 22)
        {
            Console.WriteLine("\nYou can pay with the museum's student pricing.");
        }
        else
        {
            Console.WriteLine("\nYou must pay with the museum's regular pricing.");
        }
        Console.WriteLine("\nDone.");
    }
}