namespace golfcard.Models
{
  class Hole
  {

    public int HoleNumber { get; set; }
    public int Par { get; set; }
    public int Distance { get; set; }


    public Hole(int holeNumber, int par, int distance)
    {
      HoleNumber = holeNumber;
      Par = par;
      Distance = distance;
    }


  }

}