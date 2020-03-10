using System;

namespace flower_shop
{
  public class Lily : IMothersDay
  {

    public string Color { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Cost { get; set; }
    public string WaterSchedule { get; set; }

    public string Fragrant { get; set; }
    public double StemLength { get; set; }

    // public Lily(string color, string name, string type, double cost, string waterschedule, string fragrant, double stemlength)
    // {
    //   Color = color;
    //   Name = name;
    //   Type = type;
    //   Cost = cost;
    //   WaterSchedule = waterschedule;
    //   Fragrant = fragrant;
    //   StemLength = stemlength;
    // }
  }
}