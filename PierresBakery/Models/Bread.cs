namespace PierresBakeryBread.Models
{
  public class Bread 
  {
    public int UserBread { get; }
    public Bread(int breadInput)
    {
      UserBread = breadInput;
    }

    public int CalculateCost()
    {
      return 23;
    }
  }
}