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