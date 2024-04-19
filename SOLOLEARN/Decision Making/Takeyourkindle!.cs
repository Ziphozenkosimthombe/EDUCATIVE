/*

Airlines are offering a special promotion for teenagers and are offering kindles to use during the flight.

The given program takes the passengers` age as input.

Task

Write a program to output Take your kindle , if the age is under or equal to 19.
*/

using System;

public class Program
{
    static void Main(string[] args)
    {
        int age = Convert.ToInt32(Console.ReadLine());

        //your code goes here
        if (age <= 19){
            Console.WriteLine("Take your kindle");
        }
        
    }
}