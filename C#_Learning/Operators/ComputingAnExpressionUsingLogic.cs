/*
Problem Statement
There’s always some logic in whatever we do, whether it seems like that or not. This time, we are going to give you the logic and all you need to do is implement it. The challenge is to create the expression explained below and find what result it gives!


Coding Exercise#
Now you must do the following:

Find the Boolean NOT of x
Boolean XOR this with x itself
Find the Boolean AND of this answer with y
Return the Boolean NOT of the entire expression
*/ 
class challenge_two{

  public static bool logic(bool x, bool y){
      
    bool answer = false;
    
    //Write your code below this
    //Hint: You can make extra variables if need be
    bool notX = !x; //Boolean NOT of x
    bool xor = notX ^ x; //Boolean XOR this with x itself
    bool and = xor & y; //Boolean AND of this answer with y
    answer = !and; //Boolean NOT of the entire expression
    
    
    //Comment the statement below once you have written your code
    return answer;
    
    //Uncomment the statement below once you have written your code
    //return answer;

}
}