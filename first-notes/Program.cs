﻿// make new folder mkdir ...
// new program dotnet new console --framework net6.0 -n name
// dotnet run (optional filename)
// Console.WriteLine("top level statements take precedence, breaks Main() or at least gives a warning");
// main method must be in a class
class Hello
{
  static void Main(String[] args)
  {
    Console.WriteLine("main does not take precedence with top level statements");
  }

}

// reference vs value types

// value/primitive - store value directly in memory. if passed into a method and then changed inside of it, 
//a copy is made instead, the original remains the same

// bool
// byte
// char
// decimal
// double
// enum
// float
// int
// long
// sbyte
// short
// struct
// uint
// ulong
// ushort

// reference - stores data as a reference/ stores the a pointer to the address of the data - if passed into a method and changed
// the same location is referenced, and it will change

// String
// Arrays (even if their elements are value types)
// Class
// Delegate