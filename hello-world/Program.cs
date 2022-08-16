namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // print
      Console.WriteLine("What is your name?");
      // read line from cmd prompt
      var name = Console.ReadLine();
      // current date MM/DD/YYYY
      var currentDate = DateTime.Now;
      // new line - like \n, string interpolation
      Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
      // print with no \n
      Console.Write($"{Environment.NewLine}Press any key to exit...");
      // read keyboard input - how? - doesn't wait for enter key
      Console.ReadKey(true);
    }
  }
}

// make new folder mkdir ...
// new program dotnet new console --framework net6.0 -n name
// dotnet run (optional filename)