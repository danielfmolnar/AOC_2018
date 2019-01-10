using System;
using System.IO;
using System.Collections.Generic;

public class Test
{
  static void Main ()
  {
    int sumVar = 0;
    List<int> myList = new List<int>();
    foreach (string line in File.ReadLines("input_01.txt"))
    {
      myList.Add((int)sumVar);
      int numVal = Int32.Parse(line);
      sumVar = sumVar + numVal;
      if (myList.Contains(sumVar))
      {
        Console.WriteLine (sumVar);
      }
    }
/*
    int i = 2;
    List<int> myList = new List<int> {1,2,3,4};
    Console.WriteLine (myList.Contains(i));
*/
  }
}
