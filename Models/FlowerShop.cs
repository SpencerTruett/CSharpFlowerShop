using System;
using System.Collections.Generic;

namespace flower_shop
{
  public class FlowerShop
  {

    public List<Rose> Rose = new List<Rose>();
    public void addRose(Rose rose)
    {
      Rose.Add(rose);
    }
    public List<Lily> Lily = new List<Lily>();
    public void addLily(Lily lily)
    {
      Lily.Add(lily);
    }
    public List<Tulip> Tulip = new List<Tulip>();
    public void addTulip(Tulip tulip)
    {
      Tulip.Add(tulip);
    }
    public List<Orchid> Orchid = new List<Orchid>();
    public void addOrchid(Orchid orchid)
    {
      Orchid.Add(orchid);
    }

    public List<IMothersDay> MakeMothersDayArrangement()
    {
      List<IMothersDay> Arrangement = new List<IMothersDay>();
      Arrangement.Add(new Rose());
      Arrangement.Add(new Rose());
      Arrangement.Add(new Rose());
      Arrangement.Add(new Lily());
      Arrangement.Add(new Lily());
      Arrangement.Add(new Lily());

      return Arrangement;
    }
    public List<IBirthday> MakeBirthdayArrangement()
    {
      List<IBirthday> Arrangement = new List<IBirthday>();
      Arrangement.Add(new Tulip());
      Arrangement.Add(new Orchid());

      return Arrangement;
    }

    public List<IGetWell> MakeGetWellArrangement()
    {
      List<IGetWell> Arrangement = new List<IGetWell>();

      Arrangement.Add(new Buttercup());
      Arrangement.Add(new Buttercup());
      Arrangement.Add(new Buttercup());

      return Arrangement;
    }
  }
}