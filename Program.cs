﻿using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            GreetUser();
            //CheckUser();
        }

        public static void HelloWorld()
        {
            Console.WriteLine("It's a wonderful world!");
        }

        public static void GreetUser()
        {
            Console.WriteLine("Enter your first name:");
            string firstname = Console.ReadLine();
            Console.WriteLine($"Hello, {firstname}");
            CheckUser();
        }

        public static void CheckUser()
        {
            Console.WriteLine("Enter your year of birth:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2022 - yearOfBirth;

            if(userAge < 18)
            {
                Console.WriteLine("Your are too young to use the app.");
            }
            else
            {
                Console.WriteLine("Welcome!");
            }
        }
    }
}
