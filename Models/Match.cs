using System;
using System.Collections.Generic;

namespace golfcard.Models
{

  class Match
  {

    public Match(Course course)
    {
      CoursePlayed = course;
      PlayerList = new List<Player>();
    }
    public Course CoursePlayed { get; set; }
    public List<Player> PlayerList { get; set; }




  }
}