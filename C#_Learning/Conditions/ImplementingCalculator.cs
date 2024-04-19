/*
Problem Statement
Write a code which will take:

Two float type variables named num1 and num2

a char type variable called Operator

The Operator variable can be passed the following:

+,-,* and /
Use switch statements to compute:

addition,
subtraction,
multiplication
division
*/ 
using System;
class Exercise1 {

  public static double test(double num1, double num2, char Operator) {
    double temp = 0;
    //write the code here
    switch(Operator){
        case '+':
            temp = num1 + num2;
            break;
        case '-':
            temp = num1 - num2;
            break;
        case '*':
            temp = num1 * num2;
        case '/':
            temp = num1 / num2;
            break;
        default:
            temp = 0;
            break;
    }
    return temp;

  }

}