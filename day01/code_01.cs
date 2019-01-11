using System;
using System.IO;

public class Test
{
  static void Main ()
  {
    int sumVar = 0;
    foreach (string line in File.ReadLines("input_01.txt"))
    {
      int numVal = Int32.Parse(line);
      sumVar = sumVar + numVal;
    }
    Console.WriteLine (sumVar);
  }
}
