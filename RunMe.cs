using System;

class Program
{
  static void Main()
  {
    int n = int.Parse(Console.ReadLine());
    if (n <= 0)
    {
      Console.WriteLine(1); return;
    }

    long[] row = new long[n];
    row[0] = 1;

    for (int i = 1; i < n; i++)
    {
      row[i] = row[i - 1] * (n - i) / i;
      
      if (row[i] <= 0)
      {
        Console.WriteLine("Do you really think I am able to calculate that? THAT IS WAY TO BIG QUEEN");
        return;
      }
      
    }

    string[] strs = new string[n];

    for (int i = 0; i < n; i++)
    {
      strs[i] = row[i].ToString();
    }

    Console.WriteLine(string.Join(" ", strs));
  }
}
