/*

Time flies when you’re having fun.

You are given a digital clock that measures time over a 24 hour day, and a program that takes the hour of the day as input.

Task

Complete the program so that it outputs AM to the console if the time is between 0 and 12 (inclusive), and outputs PM if the time is between 13 and 24 (inclusive).
*/ 

using System;

public class Program
{
    static void Main(string[] args)
    {
        int hour = Convert.ToInt32(Console.ReadLine());

        //your code goes here
        string time = hour >= 0 && hour <= 12 ? "AM" : "PM";
        Console.WriteLine(time);
        
    }
}