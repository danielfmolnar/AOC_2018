using System;
using System.IO;
using System.Collections.Generic;

public class Test
{
  static void Main ()
  {
    int sumVar = 0;
    List<int> myList = new List<int>();
    myList.Add(sumVar);

    foreach (string line in File.ReadLines("input_01.txt"))
    {
      int numVal = Int32.Parse(line);
      sumVar = sumVar + numVal;
      myList.Add((int)sumVar);
    }

    bool notYet = true;
    for (int i = 0; i < myList.Count; i++)
    {
      for (int j = i+1; j < myList.Count; j++)
      {
        if (myList[i] == myList[j] && notYet)
        {
          Console.WriteLine (myList[i]);
          notYet = false;
        }
      }
    }
  }
}
