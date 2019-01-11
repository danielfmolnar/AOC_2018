using System;
using System.IO;
using System.Collections.Generic;

public class Test
{
  static void Main ()
  {
    List<string> myList = new List<string>();

    foreach (string line in File.ReadLines("input_02.txt"))
    {
      myList.Add(line);
    }
  }
}
