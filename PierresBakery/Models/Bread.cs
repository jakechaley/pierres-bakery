namespace PierresBakeryBread.Models
{
  public class Bread 
  {
    public int UserBread { get; set; }
    public int Price { get; }
    public Bread(int breadInput)
    {
      UserBread = breadInput;
      Price = 5;
    }

    public int CalculateCost()
    {
      return 23;
    }
  }
}