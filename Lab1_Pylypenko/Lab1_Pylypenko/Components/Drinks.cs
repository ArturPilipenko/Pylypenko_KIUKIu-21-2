using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Pylypenko.Components
{
    public sealed class Drinks
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public uint CoffeeNeed { get; set; }
        public uint MilkNeed { get; set; }
        public uint WaterNeed { get; set; }
        public uint SugarNeed { get; set; }
        public uint Price { get; set; }

        public Drinks(uint id, string name, uint coffeeNeed, uint milkNeed, uint waterNeed, uint sugarNeed, uint price)
        {
            Id = id;
            Name = name;
            CoffeeNeed = coffeeNeed;
            MilkNeed = milkNeed;
            WaterNeed = waterNeed;
            SugarNeed = sugarNeed;
            Price = price;
        }
    }
}
