using System;

namespace flower_shop
{
  public class Buttercup : IGetWell
  {

    public string Color { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Cost { get; set; }
    public string WaterSchedule { get; set; }

    public string Fragrant { get; set; }
    public double StemLength { get; set; }

  }
}