// make new folder mkdir ...
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

// For each non-nullable type T, there's a corresponding nullable type T?, which can hold an additional value, null. 
// For instance, int? is a type that can hold any 32-bit integer or the value null

// turn value/reference data types from one to another
// int i = 123;
// object o = i;    // Boxing
// int j = (int)o;  // Unboxing

// HEAP AND STACK

// STACK
// local value types (primitives)
// pointers to objects on heap
// structs
// new scope = new stack frame

// HEAP
// reference/object types - heap
// copies from the heap will be pointers to the same memory on the stack (changing one changes both)
// things that need to persist beyond local scopes

// Classes

