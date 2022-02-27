namespace PierresBakeryBread.Models
{
  public class Pastry
  {
    public int PastryAmount { get; set; }
    public int Price { get; }
    public Pastry(int pastryAmount)
    {
      PastryAmount = pastryAmount;
      Price = 2;
    }
  }
}

