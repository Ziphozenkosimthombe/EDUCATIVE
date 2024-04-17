/*
Problem Statement 
Declare an integer type variable name intNumber and assign it a value of 30.
Declare a float type variable name floatNumber and assign it a value of 30.78.
Declare a double type variable name doubleNumber and assign it a value of 45.1234.
Declare a bool type variable name boolean and assign it a value of true.
Declare a char type variable name charName and assign it a value of u.
Lastly, print the values of all declared variables.
*/ 

using System;

namespace VariablesExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define your variables here...
            int intNumber = 30;
            float floatNumber = 30.78f;
            double doubleNumber = 45.1234;
            bool boolean = true;
            char charName = 'u';
            
            //Print the values of all declared variables here...
            Console.WriteLine($"Value of Integer is {intNumber}");
            //print your Integer variable here
            Console.WriteLine($"Value of Float is {floatNumber}");
            //print your Float variable here
            Console.WriteLine($"Value of Bool is {boolean}");
            //print your Bool variable here
            Console.WriteLine($"Value of Double is {doubleNumber}");
            //print your Double variable here
            Console.WriteLine($"Value of Char is {charName}");
            //print your Char variable here
        }
    }
}