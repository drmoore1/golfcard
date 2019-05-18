using System;
using golfcard.Models;

namespace golfcard
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Course myCourse1 = new Course("GreenGolf", "1212 Greenway Dr", 1, 4, 256);
      Course myCourse2 = new Course("Forbidden Acres", "6006 BadDrive Way", 1, 1, 320);
      System.Console.WriteLine($"{myCourse1.CourseName}");
      System.Console.WriteLine($"The Par for hole {myCourse1.Hole1.HoleNumber} is {myCourse1.Hole1.Par}");
      System.Console.WriteLine($"{myCourse2.CourseName}");
      System.Console.WriteLine($"The Par for hole {myCourse2.Hole1.HoleNumber} is {myCourse2.Hole1.Par}");

      Match myMatch = new Match()
    }
  }
}
