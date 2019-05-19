using System;
using System.Collections.Generic;

namespace golfcard.Models
{

  class Player
  {
    public Player(string name, int handi)
    {
      Name = name;
      Handicap = handi;
      Strokes = new List<int> { };

    }
    public enum Gender { Male, Female }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Handicap { get; set; }
    public Gender PlayerGender { get; set; }
    public List<int> Strokes { get; set; }

  }
}