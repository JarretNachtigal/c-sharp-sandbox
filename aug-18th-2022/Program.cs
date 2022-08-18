class Program
{
  public static void Main(String[] args)
  {
    //arrays
    // - reference type
    // type[] name = new type[length]
    // left side sets aside space for a refence to the array, right side instatiates array dynamically at runtime
    int[] a = new int[10];
    //iterate - fill
    for (int i = 0; i < a.Length; i++)
    {
      a[i] = i;
    }
    //iterate - print
    for (int i = 0; i < a.Length; i++)
    {
      // Console.WriteLine(a[i]);
    }

    //multi-dimensional array
    int[,,] b = new int[5, 4, 3]; // 3d array of side 15 by 10, by 5
    // iterate - fill
    int count = 0;
    for (int i = 0; i < b.GetLength(0); i++) // 5
    {
      for (int j = 0; j < b.GetLength(1); j++) // 4
      {
        for (int k = 0; k < b.GetLength(2); k++) // 3
        {
          b[i, j, k] = count;
          count += 1;
        }
      }
    }
    // iterate - print
    // "loops through a [4][3] size array 5 times"
    for (int i = 0; i < b.GetLength(0); i++) // 5
    {
      // loops through a [3] size array 4 times
      for (int j = 0; j < b.GetLength(1); j++) // 4
      {
        // loops prints all 3 ints in the array
        for (int k = 0; k < b.GetLength(2); k++) // 3
        {
          Console.Write($"{b[i, j, k]}, ");
        }
      }
      Console.WriteLine();
      count++;
    }
  }
}