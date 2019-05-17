using System;
namespace golfcard.Models
{

  class Player
  {
    public enum Gender { Male, Female }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Handicap { get; set; }
    public Gender PlayerGender { get; set; }


  }
}