using System;
using golfcard.Models;

namespace golfcard
{
  class Program
  {
    static void Main(string[] args)
    {
      //This is all just testing stuff and creating 2 courses with 1 hole each
      Course myCourse1 = new Course("GreenGolf", "1212 Greenway Dr", 1, 4, 256);
      Course myCourse2 = new Course("Forbidden Acres", "6006 BadDrive Way", 1, 1, 320);
      System.Console.WriteLine($"{myCourse1.CourseName}");
      System.Console.WriteLine($"The Par for hole {myCourse1.Hole1.HoleNumber} is {myCourse1.Hole1.Par}");
      System.Console.WriteLine($"{myCourse2.CourseName}");
      System.Console.WriteLine($"The Par for hole {myCourse2.Hole1.HoleNumber} is {myCourse2.Hole1.Par}");
      // begining trials for logic
      Course courseSelected = null;
      int CurrentRound = 1;

      GetCourse();


      Match myMatch = new Match(courseSelected);
      Console.Clear();
      int PlayerCount = 0;
      PlayerCount = GetPlayers();
      if (PlayerCount == 4)
      {
        Console.Clear();
        System.Console.WriteLine("Please Input Name");
        string name = Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("Please Input Handicap");
        Int32 handi = Convert.ToInt32(Console.ReadLine());
        Player Player4 = new Player(name, handi);
        myMatch.PlayerList.Add(Player4);
        PlayerCount--;
      }
      if (PlayerCount == 3)
      {
        Console.Clear();
        System.Console.WriteLine("Please Input Name");
        string name = Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("Please Input Handicap");
        Int32 handi = Convert.ToInt32(Console.ReadLine());
        Player Player3 = new Player(name, handi);
        myMatch.PlayerList.Add(Player3);
        PlayerCount--;
      }
      if (PlayerCount == 2)
      {
        Console.Clear();
        System.Console.WriteLine("Please Input Name");
        string name = Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("Please Input Handicap");
        Int32 handi = Convert.ToInt32(Console.ReadLine());
        Player Player2 = new Player(name, handi);
        myMatch.PlayerList.Add(Player2);
        PlayerCount--;
      }
      if (PlayerCount == 1)
      {
        Console.Clear();
        System.Console.WriteLine("Please Input Name");
        string name = Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("Please Input Handicap");
        Int32 handi = Convert.ToInt32(Console.ReadLine());
        Player Player1 = new Player(name, handi);
        myMatch.PlayerList.Add(Player1);
        PlayerCount--;
      }
      int count = 0;
      foreach (Player Player in myMatch.PlayerList)
      {

        System.Console.WriteLine(count);
        count++;
      }
      Console.Clear();
      System.Console.WriteLine($"Your Match at {myMatch.CoursePlayed.CourseName} is ready to begin.");
      System.Console.WriteLine("For each Hole you will be prompted to enter each players score.");
      Console.ReadLine();
      RunHoles();







      void RunHoles()
      {
        System.Console.WriteLine($"The current Round is Hole {CurrentRound}");

        foreach (Player player in myMatch.PlayerList)
        {
          System.Console.WriteLine($"Please Input Score for ");

        }
      }

      Int32 GetPlayers()
      {
        System.Console.WriteLine("How Many Players?");
        try
        {
          int playerCount = Convert.ToInt32(Console.ReadLine());
          if (playerCount < 5 && playerCount > 0)
          {
            Console.Clear();
            return playerCount;
          }
          else
          {
            System.Console.WriteLine("Please Select 1 to 4 Players");
            GetPlayers();
            return 0;
          }
        }
        catch
        {
          Console.Clear();
          System.Console.WriteLine("Please Input Numbers Only");
          GetPlayers();
          return 0;
        }
      }

      Course GetCourse()
      {
        System.Console.WriteLine("Welcome to GolfCard Please Select a Course");
        System.Console.WriteLine($"Course 1, {myCourse1.CourseName}");
        System.Console.WriteLine($"Course 2, {myCourse2.CourseName}");
        try
        {
          Int32 userSelection = Convert.ToInt32(Console.ReadLine());
          if (userSelection == 1)
          {
            return myCourse1;
          }
          if (userSelection == 2)
          {
            return myCourse2;
          }
          else
          {
            GetCourse();
            return null;
          }
        }
        catch
        {
          GetCourse();
          return null;
        }
      }
    }



  }
}


