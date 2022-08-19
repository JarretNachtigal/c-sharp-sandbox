class Program
{

  // example from c# documentation for experimentation
  delegate double Function(double x);

  class Multiplier
  {
    double _factor; // 

    public Multiplier(double factor) => _factor = factor; // sets _factor/ constructor

    public double Multiply(double x) => x * _factor; // multiplies x by instance variable _factor
  }

  class DelegateExample
  {
    static double[] Apply(double[] a, Function f)
    {
      var result = new double[a.Length];
      for (int i = 0; i < a.Length; i++) result[i] = f(a[i]);
      return result;
    }

    public static void Main(String[] args)
    {
      double[] a = { 0.0, 0.5, 1.0 }; // example data
      double[] squares = Apply(a, (x) => x * x); // example call with lambda function param
      double[] sines = Apply(a, Math.Sin); // example call with lambda function param
      Multiplier m = new(2.0); // instantiate Miltiplier class
      double[] doubles = Apply(a, m.Multiply); // example call with lambda function param
    }
  }
}