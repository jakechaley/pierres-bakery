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
      int total = 0;
      for (int index = 1; index <= UserBread; index++)
      {
        if (index % 3 != 0)
        {
          total += Price;
        }
      }

      return total;
    }
  }
}