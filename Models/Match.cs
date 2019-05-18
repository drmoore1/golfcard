using System;
using System.Collections.Generic;

namespace golfcard.Models
{

  class Match
  {

    public Match(Course course, List<Player> players, int scores [,]{ { 0},{ 0} })
    {
        
    }
    public Course CoursePlayed { get; set; }
    public List<Player> PlayerList { get; set; }
    public Array PlayerScores { get; set; }



  }
}