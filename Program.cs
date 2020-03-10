using System;
using System.Collections.Generic;

namespace flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose myRose = new Rose()
            {
                Color = "Red",
                Name = "Rosey",
                Type = "American Beauty",
                Cost = 3.99,
                WaterSchedule = "Weekly",
                Thorny = true,
                Fragrant = "Very",
                StemLength = 23.1
            };

            Lily myLily = new Lily()
            {
                Color = "White",
                Name = "Lil7",
                Type = "Casa Blanka",
                Cost = 2.99,
                WaterSchedule = "Weekly",
                Fragrant = "Very",
                StemLength = 15.6
            };

            Tulip myTulip = new Tulip()
            {
                Color = "Pink",
                Name = "Tulla",
                Type = "Garden Tulip",
                Cost = 4.99,
                WaterSchedule = "Weekly",
                Fragrant = "Very"
            };

            Orchid myOrchid = new Orchid()
            {
                Color = "Purple",
                Name = "Margret",
                Type = "Singaore Orchid",
                Cost = 9.99,
                WaterSchedule = "Weekly",
                Fragrant = "Very"
            };

            Buttercup myButtercup = new Buttercup()
            {
                Color = "Yellow",
                Name = "Buddy",
                Type = "Meadow Buttercup",
                Cost = 3.99,
                WaterSchedule = "Weekly",
                Fragrant = "Very"
            };

            FlowerShop MacsFlowerSHop = new FlowerShop();
            List<IBirthday> Arrangemnet = MacsFlowerSHop.MakeBirthdayArrangement();

        }
    }
}