using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int theNumberFive = 5;
            // theNumberFive = 12; -- does not work b/c you can't assign a new value to a constant variable

            // explicit variable declaration, no value is requied on the right-hand side
            int myFirstInteger;
            // (csharp type) short = int16 in dotnet
            // (csharp type) long = int64 in dotnet
            // int = int32 in dotnet
            myFirstInteger = 12;

            // decimal is good for money, doubles and floats are good for sciencey and mathy stuff
            decimal money = 12.50m;
            double moreDecimalStuff = 12.50d;
            float floatingPoint = 12.50f;

            // implicit variable declaration, type is determiend by value is required on right-hand side
            var myFirstBoolean = true;

            var myFirstString = "This is a string...";
            // myFirstString = true; -- doesn not work b/c variable is still statically typed despite implicit declaration

            char oneCharacter = 'c';
             
            DateTime today = DateTime.Now;

            var poem = @"Roses are red,
                        violets are blue,
                        csharp is great,
                        and so are you";

            var name = "Nathan";
            var age = 34;
            // string interpolation, like javascript, but different
            var greeting = $"My name is {name} and I'm {age} years old.";

            // reference types - does not hold a value, holds a location where the value can be found
            // object types are reference types, integers and strings are value types
            // assigning value types to references is called "boxing" (may be an interview question)
            // doing so is lame and time consuming
            // in the below, to look at the number/string, you have to pull it out of the object and return it to a value type
            // when instead you could have just assigned it a value type in the first place

            object myNumber = 1;
            myNumber = "steve";
            // the above technically works, because both 1 and steve are typed as an object, and it's a bad way to write code

            // Creating an Anonymous Type
            var steve = new { Name = "Steve" };
            greeting = $"My name is {steve.Name} and I'm {age} years old.";

            var names = new string[10];
            names[0] = "Dylan";

            Console.WriteLine(names[0]);
            names[1] = "Todd";
            names[3] = "Anca";

            Console.WriteLine(greeting);

            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"{name} was in the name variable");
                return;
            }

            switch (oneCharacter)
            {
                case 'a':
                case 'b':
                    Console.WriteLine("it's the letter a");
                    break;
                case 'c':
                    Console.WriteLine("Duh it's c");
                    break;
                default:
                    Console.WriteLine("It wasn't a or c");
                    break;
            }

            for (int i = 0; i < names.Length; i++)
            {
                if (i < 3)
                {
                    continue;
                }
                Console.WriteLine($"The current name is {names[i]}");
            }

            foreach (var n in names)
            {
                Console.WriteLine($"The current name is {n}");
            }

            while (true)
            {
                if (DateTime.Now > new DateTime(2020, 7, 27, 19, 23, 30))
                {
                    break;
                }
            }

            Console.WriteLine("Please enter your name.");
            var input = Console.ReadLine();
            Console.WriteLine($"Hello, {input}");

            Console.WriteLine("Please enter a comma separated list of numbers.");
            input = Console.ReadLine();

            var numbers = input.Split(',');

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
