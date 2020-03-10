using System;

namespace flower_shop
{
  public class Rose : IMothersDay
  {

    public string Color { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Cost { get; set; }
    public string WaterSchedule { get; set; }
    public bool Thorny { get; set; }
    public string Fragrant { get; set; }
    public double StemLength { get; set; }

    // public Rose(string color, string name, string type, double cost, string waterschedule, bool thorny, string fragrant, double stemlength)
    // {
    //   Color = color;
    //   Name = name;
    //   Type = type;
    //   Cost = cost;
    //   WaterSchedule = waterschedule;
    //   Thorny = thorny;
    //   Fragrant = fragrant;
    //   StemLength = stemlength;
    // }
  }
}