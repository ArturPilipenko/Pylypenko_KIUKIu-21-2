using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Pylypenko.Components
{
    public partial class CoffeeMachine
    {
        private string machineName;

        private uint coffeeCapacity;
        private uint milkCapacity;
        private uint waterCapacity;
        private uint sugarCapacity;

        private uint coffeeCurrent;
        private uint milkCurrent;
        private uint waterCurrent;
        private uint sugarCurrent;

        public string MachineName
        {
            get => machineName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name of machine can not be null or white-spaced");
                }
                else
                {
                    machineName = value.Trim();
                }
            }
        }

        public uint CoffeeCapacity
        {
            get => coffeeCapacity;
            set
            {
                if (value == 0 )
                {
                    throw new ArgumentException("Capacity of coffee can not be zero");
                }
                else
                {
                    coffeeCapacity = value;
                }
            }
        }

        public uint MilkCapacity
        {
            get => milkCapacity;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Capacity of milk can not be zero");
                }
                else
                {
                    milkCapacity = value;
                }
            }
        }

        public uint WaterCapacity
        {
            get => waterCapacity;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Capacity of water can not be zero");
                }
                else
                {
                    waterCapacity = value;
                }
            }
        }

        public uint SugarCapacity
        {
            get => sugarCapacity;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Capacity of sugar can not be zero");
                }
                else
                {
                    sugarCapacity = value;
                }
            }
        }

        public uint CoffeeCurrent
        {
            get => coffeeCurrent;
            set
            {
                if (value > CoffeeCapacity)
                {
                    throw new ArgumentException("Current count of coffee can not be higher than coffee capacity");
                }
                else
                {
                    coffeeCurrent = value;
                }
            }
        }

        public uint MilkCurrent
        {
            get => milkCurrent;
            set
            {
                if (value > MilkCapacity)
                {
                    throw new ArgumentException("Current count of milk can not be higher than milk capacity");
                }
                else
                {
                    milkCurrent = value;
                }
            }
        }

        public uint WaterCurrent
        {
            get => waterCurrent;
            set
            {
                if (value > WaterCapacity)
                {
                    throw new ArgumentException("Current count of water can not be higher than water capacity");
                }
                else
                {
                    waterCurrent = value;
                }
            }
        }

        public uint SugarCurrent
        {
            get => sugarCurrent;
            set
            {
                if (value > SugarCapacity)
                {
                    throw new ArgumentException("Current count of sugar can not be higher than sugar capacity");
                }
                else
                {
                    sugarCurrent = value;
                }
            }
        }

        public uint Money { get; set; }

        public CoffeeMachine()
        {
            MachineName = "unknown";


            CoffeeCapacity = 10;
            CoffeeCurrent = 10;

            MilkCurrent = 5;
            MilkCapacity = 5;

            WaterCapacity = 10;
            WaterCurrent = 10;

            SugarCapacity = 5;
            SugarCurrent = 5;
        }

        public CoffeeMachine(string name) => MachineName = name;

        public CoffeeMachine(string name, uint coffeeMax, uint coffeeCurr, uint milkMax, uint milkCurr, uint waterMax, uint waterCurr, uint sugarMax, uint sugarCurr)
        {
            MachineName = "unknown";

            CoffeeCapacity = coffeeMax;
            CoffeeCurrent = coffeeCurr;

            MilkCapacity = milkCurr;
            MilkCurrent = milkMax;

            WaterCapacity = waterMax;
            WaterCurrent = waterCurr;

            SugarCapacity = sugarMax;
            SugarCurrent = sugarCurr;
        }
    }
}
