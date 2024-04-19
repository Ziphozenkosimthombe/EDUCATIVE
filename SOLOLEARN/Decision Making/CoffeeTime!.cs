/*
A coffee vending machine makes 3 types of coffee ☕:

1 - Americano

2 - Espresso

3 - Cappuccino

The given program takes the number from the customer as input.

Task

Complete the program to serve the corresponding coffee type. It should output Unknown if there is no match.


*/ 

using System;

public class Program
{
    static void Main(string[] args)
    {
        int choice = Convert.ToInt32(Console.ReadLine());

        //your code goes here
        switch(choice){
            case 1:
                Console.WriteLine("Americano");
                break;
            case 2:
                Console.WriteLine("Espresso");
                break;
            case 3:
                Console.WriteLine("Cappuccino");
                break;
            default:
        }
    }
}