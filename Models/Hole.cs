namespace golfcard.Models
{
  class Hole
  {

    public int HoleNumber { get; set; }
    public int Par { get; set; }
    public int Distance { get; set; }


    public Hole(int holeNum, int par, int distance)
    {
      HoleNumber = holeNum;
      Par = par;
      Distance = distance;
    }


  }

}