/*
You are developing a program that will be used in a robot that categorizes items by their color.

Each color corresponds to a box with a specific number.

For simplicity, our program will handle 3 colors:

🔴 red goes to box #1

🟢 green goes to box #2

⚫ black goes to box #3

Your program needs to take color as input and output the corresponding box in the given format.

In the case of an unsupported colors, the program should output unknown.


*/
using System;

public class Program
{
    static void Main(string[] args)
    {
        string color = Console.ReadLine();

        //your code goes here
        if (color == "red"){
            Console.WriteLine("box #1");
        }else if (color == "green"){
            Console.WriteLine("box #2");
        }else if (color == "black"){
            Console.WriteLine("box #3");
        }else{
            Console.WriteLine("unknown");
        }
        
    }
} 