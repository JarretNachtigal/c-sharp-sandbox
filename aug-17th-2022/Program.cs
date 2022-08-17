

class StaticAndInstanceFieldsExample
{
  // static fields will be shared between all instances of the class
  //A static constructor is a member that implements the actions required to initialize a class itself when it's first loaded.
  //  ------ not called --------
  static StaticAndInstanceFieldsExample()//takes no params, cannot be called manually
  {
    shared = 1000;
  }
  //An instance constructor is a member that implements the actions required to initialize an instance of a class. 
  public StaticAndInstanceFieldsExample(int val)
  {
    instance = val;
  }

  static int shared;
  int instance;

  public void DoThing()
  {
    Console.WriteLine($"{shared}, {instance}");
  }
  // PROPERTIES - accessors
  public int Shared
  {
    get => shared;
    set => shared = value;
  }

  public int Instance
  {
    get => instance;
    set
    {
      instance = value; // value is the 'param' - test1.Instance = 9999(this part)
    }
  }
}

// overriding, abstract methods and classes, overloading all work like java

class Program
{
  static void Main(string[] args)
  {
    StaticAndInstanceFieldsExample test1 = new StaticAndInstanceFieldsExample(1);
    StaticAndInstanceFieldsExample test2 = new StaticAndInstanceFieldsExample(2);
    // test standard setters and getters
    // test1.setInstance(1);
    // test2.setInstance(2);
    // test1.setShared(10); // would be called this way if not a static method
    // Console.WriteLine($"test1 = {test1.getInstance()}, test2 = {test2.getInstance()} shared value from static constructor = {test1.getShared()} and {test2.getShared()}");
    // Console.WriteLine("changing values");
    // StaticAndInstanceFieldsExample.setShared(100); // called this way because its a static method
    // test1.setInstance(10);
    // Console.WriteLine($"test1 = {test1.getInstance()}, test2 = {test2.getInstance()} shared value = {test1.getShared()} and {test2.getShared()}");

    // test properties - basically setters and getters

    Console.WriteLine(test1.Instance);
    test1.Instance = 10;
    Console.WriteLine(test1.Instance);
    int val = test1.Shared; //  why is this not 1000?
    val = test1.Shared;
    Console.WriteLine(val); // static field and accessors
    test1.Shared = 9999; // static field and accessors
    val = test1.Shared;
    Console.WriteLine(val); // static field and accessors
    test1.Instance = 100;
    Console.WriteLine(test1.Instance);
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
