// - this is the order needed to use top level statements as entry point
// - they will take priority over Main() even if Main is specified
// - they can still access the args variable (which is never null, but can be of length 0) to access command line arguments

// MyClass.TestMethod();
// MyNamespace.MyClass.MyMethod();

// public class MyClass
// {
//     public static void TestMethod()
//     {
//         Console.WriteLine("Hello World!");
//     }

// }