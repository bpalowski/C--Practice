using System;

class MealTime
{
  static void AskWhat(string meal)
  {
    Console.WriteLine("What did you eat for" + meal + "?");
  }
  static void Main()
  {
    AskWhat("BreakFest");
    string yourBreakFest = Console.ReadLine();
    Console.WriteLine("Your BreakFest" + yourBreakFest);

    AskWhat("Lunch");
    string yourLunch = Console.ReadLine();
    Console.WriteLine("Your yLunch" + yourLunch);

    AskWhat("Lunch");
    string yourBreakFest = Console.ReadLine();
    Console.WriteLine("Your BreakFest" + yourBreakFest

  }

}
