using System;

namespace flower_shop
{
  public class Orchid : IBirthday
  {

    public string Color { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Cost { get; set; }
    public string WaterSchedule { get; set; }
    public string Fragrant { get; set; }

    // public Orchid(string color, string name, string type, double cost, string waterschedule, string fragrant)
    // {
    //   Color = color;
    //   Name = name;
    //   Type = type;
    //   Cost = cost;
    //   WaterSchedule = waterschedule;
    //   Fragrant = fragrant;
    // }
  }
}