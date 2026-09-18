using System;
using System.Threading;
class ThreadProgram
{
  public void DisplayNumbers()
  {
    for (int i = 1; i <= 5; i++)
    {
      Console.WriteLine("Number : " + i);
      Thread.Sleep(500);
    }
  }
  public void DisplayAlphabets()
  {
    for (char ch = 'A'; ch <= 'E'; ch++)
    {
      Console.WriteLine("Alphabet : " + ch);
      Thread.Sleep(500);
    }
  }
  static void Main(string[] args)
  {
    ThreadProgram obj = new ThreadProgram();
    Thread t1 = new Thread(obj.DisplayNumbers);
    Thread t2 = new Thread(obj.DisplayAlphabets);
    Console.WriteLine("Starting Threads...\n");
    t1.Start();
    t2.Start();
    t1.Join();
    t2.Join();
    Console.WriteLine("\nBoth threads completed successfully.");
    Console.WriteLine("Program Ended.");
  }
}