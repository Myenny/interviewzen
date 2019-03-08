// - answer wanted: return second highest number that is divisible by 7 
// - can try sorting the array from highest to lowest 
// - then go through array twice that matches is divisible by 7.
using System;

public class Program

{
  public static void Main()
  {
    int[] listOfIntegers = new int[] { 0, 1, 2, 3, 4, 7, 8, 14, 49, 280, 1000, 49, 7000, 700, 7000, 7, 7, 7000000 };
    Array.Sort(listOfIntegers);
    Array.Reverse(listOfIntegers);

    int counter = 0;
    int second = 0;
    foreach (int i in listOfIntegers)
    {
      if (i % 7 == 0)
      {
        counter++;

        if (counter == 2)

        {
          second = i;
        }
      }
    }

    System.Console.WriteLine(second);
  }
}