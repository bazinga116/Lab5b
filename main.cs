using System;

class MainClass {
  public static void Main (string[] args) {

    //The original code that I made I took from Lab5a but, I was not sure if the cars had to be numbered? It wasn't mentioned in the rubric.


    Console.WriteLine("How many cars are involved?");
    int maxCounter = Convert.ToInt32(Console.ReadLine());

    for(int counter=1;counter<=maxCounter;counter++)
    {
    Console.WriteLine("Enter the distance covered by this car");
    double distance = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the time taken by this car");
    double time = Convert.ToDouble(Console.ReadLine()); 
    double speed = distance/time;
    Console.WriteLine("The speed of this car is " + speed + " miles per hour ");
   
    }
    Console.WriteLine("The End");
  }
}