// See https://aka.ms/new-console-template for more information

using System;

class Program
{
  static void Main(string[] args)
  {

  }

  // remembet that String is a reference type, not a value type
  public static String exampleFunction(int num)
  {
    int localVariable = 4;
    Console.WriteLine($"{localVariable}");
    return $"{num} entered";
  }
}