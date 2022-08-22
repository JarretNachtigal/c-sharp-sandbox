// - this is the order needed to use top level statements as entry point
// - they will take priority over Main() even if Main is specified
// - they can still access the args variable (which is never null, but can be of length 0) to access command line arguments
// can return an int value at end like in Main()/exit code

// MyClass.TestMethod();
// MyNamespace.MyClass.MyMethod();
// return 1

// public class MyClass
// {
//     public static void TestMethod()
//     {
//         Console.WriteLine("Hello World!");
//     }

// }


// The information stored in a type can include the following items:
// - The storage space that a variable of the type requires.
// - The maximum and minimum values that it can represent.
// - The members (methods, fields, events, and so on) that it contains.
// - The base type it inherits from.
// - The interface(s) it implements.
// - The kinds of operations that are permitted.

// Generic types - classes that take a data type as a param on creation

// List<string> stringList = new List<string>();
// stringList.Add("String example");
// // compile time error adding a type other than a string:
// stringList.Add(4);