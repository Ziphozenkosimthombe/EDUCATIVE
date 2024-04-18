/*
Problem Statement 
Write code for computing the formula

(a+b)^2
which expands into the following expression:

widget

In your code:

Compute squares of double type variables a and b.
Compute the product 2*a*b
Then Add the squares and the product together.
​Use Math.Pow library to compute the squares of tha variables a and b.
Example 
Input:

a = 2.4;
b = 4.5;
widget
*/ 


using System;
class Exercise1
{
     
    public static double test(double a, double b) {
      double answer=0;
      //write your answer here
        double squareA = Math.Pow(a, 2); //Compute squares of double type variables a and b.
        double squareB = Math.Pow(b, 2); 
        double product = 2 * a * b;//Compute the product 2*a*b
        answer = squareA + squareB + product;
      return answer;
}
    
}