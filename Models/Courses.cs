using System;
using golfcard.Models;
using System.Collections.Generic;

namespace golfcard.Models
{
  class Course
  {
    public Course(string courseName, string courseAddress, int holeNumber, int par, int distance)
    {
      CourseName = courseName;
      CourseAddress = courseAddress;
      Hole1 = Hole(int holeNumber, int par, int distance);



    }
    public string CourseName { get; set; }
    public string CourseAddress { get; set; }

    public Hole Hole1 { get; set; }
    public Hole Hole2 { get; set; }
    public Hole Hole3 { get; set; }
    public Hole Hole4 { get; set; }
    public Hole Hole5 { get; set; }
    public Hole Hole6 { get; set; }
    public Hole Hole7 { get; set; }
    public Hole Hole8 { get; set; }
    public Hole Hole9 { get; set; }
    public Hole Hole10 { get; set; }
    public Hole Hole11 { get; set; }
    public Hole Hole12 { get; set; }
    public Hole Hole13 { get; set; }
    public Hole Hole14 { get; set; }
    public Hole Hole15 { get; set; }
    public Hole Hole16 { get; set; }
    public Hole Hole17 { get; set; }
    public Hole Hole18 { get; set; }







  }

}