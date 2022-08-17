﻿// See https://aka.ms/new-console-template for more information

using System;

class StaticAndInstanceFieldsExample
{
  // static fields will be shared between all instances of the class
  static int shared;
  int instance;

  public int getShared()
  {
    return shared;
  }

  public int getInstance()
  {
    return instance;
  }

  public void setInstance(int newVal)
  {
    instance = newVal;
  }

  public static void setShared(int newVal)
  {
    shared = newVal;
  }
}


class Program
{
  static void Main(string[] args)
  {
    StaticAndInstanceFieldsExample test1 = new StaticAndInstanceFieldsExample();
    StaticAndInstanceFieldsExample test2 = new StaticAndInstanceFieldsExample();
    test1.setInstance(1);
    test2.setInstance(2);
    StaticAndInstanceFieldsExample.setShared(100); // called this way because its a static method
    // test1.setShared(10); // would be called this way if not a static method
    Console.WriteLine($"test1 = {test1.getInstance()}, test2 = {test2.getInstance()} shared value = {test1.getShared()} and {test2.getShared()}");
    Console.WriteLine("changing values");
    test1.setInstance(10);
    StaticAndInstanceFieldsExample.setShared(200);
    Console.WriteLine($"test1 = {test1.getInstance()}, test2 = {test2.getInstance()} shared value = {test1.getShared()} and {test2.getShared()}");
  }

  // remember that String is a reference type, not a value type
  public static String exampleFunction(int num)
  {
    // initialized on the stack, won't persist
    int localVariable = 4;
    Console.WriteLine($"{localVariable}");
    return $"{num} entered";
  }

}