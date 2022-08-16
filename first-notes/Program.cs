// make new folder mkdir ...
// new program dotnet new console --framework net6.0 -n name
// dotnet run (optional filename)
// Console.WriteLine("top level statements take precedence, breaks Main() or at least gives a warning");
// main method must be in a class
// class Hello
// {
//   static void Main(String[] args)
//   {
//     Console.WriteLine("main does not take precedence with top level statements");
//   }

// }

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

// public class Point
// {
//   public int X { get; }
//   public int Y { get; }

//   public Point(int x, int y) => (X, Y) = (x, y);
// }

// var p1 = new Point(0, 0);
// var p2 = new Point(10, 20);

// Type Parameters

// public class Pair<TFirst, TSecond>
// {
//     public TFirst First { get; }
//     public TSecond Second { get; }

//     public Pair(TFirst first, TSecond second) => 
//         (First, Second) = (first, second);
// }

// define type params in instantiation "constructed type"

// var pair = new Pair<int, string>(1, "two");
// int i = pair.First;     //TFirst int
// string s = pair.Second; //TSecond string

// inheritence

// public class Point3D : Point ... 

// structs - no inheritence - primarily used to hold hold data values

// public struct Point
// {
//     public double X { get; }
//     public double Y { get; }

//     public Point(double x, double y) => (X, Y) = (x, y);
// }

// interface - contract for classes/structs to follow in implementation

// interface IControl
// {
//     void Paint();
// }

// interface ITextBox : IControl
// {
//     void SetText(string text);
// }

// interface IListBox : IControl
// {
//     void SetItems(string[] items);
// }

// interface IComboBox : ITextBox, IListBox { }


// enums
namespace TestingEnum
{
  class program
  {

    public enum SomeRootVegetable
    {
      HorseRadish,
      Radish,
      Turnip
    }

    // can be used with flags

    [Flags]
    public enum Seasons
    {
      None = 0,
      Summer = 1,
      Autumn = 2,
      Winter = 4,
      Spring = 8,
      All = Summer | Autumn | Winter | Spring
    }
    static void Main(String[] args)
    {


      // use

      var turnip = SomeRootVegetable.Turnip;
      var spring = Seasons.Spring;
      int springVal = (int)Seasons.Spring;
      var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
      var theYear = Seasons.All;

      Console.WriteLine($"{turnip}, {spring}, {springVal}, {startingOnEquinox}, {theYear}");
      // 
    }
  }
}

// tuples

// (double Sum, int Count) t2 = (4.5, 3);
// Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
//Output:
//Sum of 3 elements is 4.5.