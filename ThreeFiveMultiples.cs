/*
Have the function ThreeFiveMultiples(num) return the sum of all the multiples of 3 and 5 that are below num. For example: if num is 10, the multiples of 3 and 5 that are below 10 are 3, 5, 6, and 9, and adding them up you get 23, so your program should return 23. The integer being passed will be between 1 and 100.
*/
using System;

class MainClass {

  public static int SearchingChallenge(int num) {

    int returnedNumber = 0;
    if(1<=num && num<=100){
      for(int i=0;i<num;i++){
          if(i%3==0 || i%5==0) returnedNumber += i;
      }
    }
    return returnedNumber;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(SearchingChallenge(Console.ReadLine()));
  } 

}
