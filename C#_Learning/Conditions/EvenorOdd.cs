/*
Problem Statement
Write a code which will check whether a given integer number is even or odd.

Hint: Think along the lines of using if-else condition.
*/ 

using System;
class Exercise1 {

  public static int test(int number) {
    int temp = 2;
    //write your code here and return 1 for odd number and 0 for even number
    if(number % 2 == 0)
    {
      temp = 0;
    }
    else
    {
      temp = 1;
    }
    return temp;
  }

}