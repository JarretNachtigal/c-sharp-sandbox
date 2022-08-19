class Program
{

  // example from c# documentation for experimentation
  // commenting this out breaks lines:
  // double[] sines = Apply(a, Math.Sin); 
  // double[] doubles = Apply(a, m.Multiply);
  // static double[] Apply(double[] a, Function f) {...}
  delegate double Function(double x); // a reference to a method with a double as a param

  class Multiplier
  {
    double _factor; // 

    public Multiplier(double factor) => _factor = factor; // sets _factor/ constructor

    public double Multiply(double x) => x * _factor; // multiplies x by instance variable _factor
  }

  class DelegateExample
  {
    // static function taking a delegate as a param
    static double[] Apply(double[] a, Function f) // for each in a[], call Function f and pass in a[i]
    {
      var result = new double[a.Length];
      for (int i = 0; i < a.Length; i++) result[i] = f(a[i]); // delegate param called here (Math.sin or m.Multiply or (x) => x* x in this case)
      return result;
    }


    // "An instance of the Function delegate type can reference any method that takes a double argument and returns a double value. 
    // The Apply method applies a given Function to the elements of a double[], returning a double[] with the results."

    // "A delegate can reference either a static method (such as Square or Math.Sin in the previous example) 
    // or an instance method (such as m.Multiply in the previous example). A delegate that references an instance method also references 
    // a particular object, and when the instance method is invoked through the delegate, that object becomes this in the invocation."
    public static void Main(String[] args)
    {
      double[] a = { 0.0, 0.5, 1.0 }; // example data
      double[] squares = Apply(a, (x) => x * x); // example call with function param - (x) => x * x
      double[] sines = Apply(a, Math.Sin); // example call with function param - Math.sin
      Multiplier m = new(2.0); // instantiate Miltiplier class
      double[] doubles = Apply(a, m.Multiply); // example call with lambda function param - m.Multiply
    }
  }
}