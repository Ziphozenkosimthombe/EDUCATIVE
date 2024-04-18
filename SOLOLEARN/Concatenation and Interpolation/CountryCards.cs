/*

You need to make country cards for a school project 📇.

The given program takes the country and the name of its capital name as input.

Task

Complete the code to output a string in the format you are given in the sample output 👇.

Sample Input

Portugal

Lisbon


Sample Output

Country: Portugal, Capital: Lisbon
*/ 


using System;

public class Program
{
    static void Main(string[] args)
    {
        string country = Console.ReadLine();
        string capital = Console.ReadLine();

        //your code goes here
        string output = $"Country: {country}, Capital: {capital}";
        Console.WriteLine(output);
        
    }
}