/*
Age Groups
The given program takes the age of a person as input.

Task

Write a program to output their age group.

Here are the age groups you need to handle:

Child: 0 to 11

Teen: 12 to 17

Adult: 18 to 64
*/ 

using System;

public class Program
{
    static void Main(string[] args)
    {
        int age = Convert.ToInt32(Console.ReadLine());

        //your code goes here
        if (age >= 0 && age <= 11){
            Console.WriteLine("Child");
        }else if(age >= 12 && age <= 17){
            Console.WriteLine("Teen");
        }else if (age >= 18 && age <= 64){
            Console.WriteLine("Adult");
        }
        
    }
}