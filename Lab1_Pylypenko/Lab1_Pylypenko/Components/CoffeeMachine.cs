using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Pylypenko.Components
{
    public partial class CoffeeMachine
    {
        private List<Drinks> listOfDrinks = new List<Drinks>()
        {
            new Drinks(1, "Espresso", 100, 300, 300, 80, 30),
            new Drinks(2, "Doppio", 150, 250, 300, 50, 25),
            new Drinks(3, "Americano", 300, 0, 150, 0, 15),
            new Drinks(4, "Latte", 100, 200, 300, 90, 45),
            new Drinks(5, "Cappuccino", 50, 100, 300, 150, 30),
        };

        private bool IngredientsCheck(uint coffeeNeed, uint milkNeed, uint waterNeed, uint sugarNeed)
        {
            if (CoffeeCurrent < coffeeNeed)
            {
                Console.WriteLine($"Machine have not enough coffee");
                Console.WriteLine($"There are only {CoffeeCurrent} \nWhile your drink needs {coffeeNeed} \n");
                return false;
            }
            else if (MilkCurrent < milkNeed)
            {
                Console.WriteLine($"Machine have not enough milk");
                Console.WriteLine($"There are only {MilkCurrent} \nWhile your drink needs {milkNeed} \n");
                return false;
            }
            else if (WaterCurrent < waterNeed)
            {
                Console.WriteLine($"Machine have not enough water");
                Console.WriteLine($"There are only {WaterCurrent} \nWhile your drink needs {waterNeed}  \n");
                return false;
            }
            else if (SugarCurrent < sugarNeed)
            {
                Console.WriteLine($"Machine have not enough sugar");
                Console.WriteLine($"There are only {SugarCurrent} \nWhile your drink needs {sugarNeed}  \n");
                return false;
            }
            return true;
        }

        public void MakeDrink(uint id, ref uint cash)
        {
            var drink = listOfDrinks.FirstOrDefault(element => element.Id == id);
            if (drink == null)
            {
                throw new ArgumentOutOfRangeException("Drink with current id does not exsist");
            }
            else
            {
                if (cash < drink.Price)
                {
                    Console.WriteLine($"Choosen drink {drink.Name} costs is {drink.Price} hryven'");
                    Console.WriteLine($"But you payed only {cash} hryven'. Please return later when you have money \n");
                }
                else
                {
                    if (IngredientsCheck(drink.CoffeeNeed, drink.MilkNeed, drink.WaterNeed, drink.SugarNeed))
                    {
                        Money += drink.Price;
                        CoffeeCurrent -= drink.CoffeeNeed;
                        MilkCurrent -= drink.MilkNeed;
                        WaterCurrent -= drink.WaterNeed;
                        SugarCurrent -= drink.SugarNeed;
                        cash -= drink.Price;

                        Console.WriteLine($"Your {drink.Name} is done!");
                        Console.WriteLine($"Your change is {cash} hryven' \n");
                    }
                }
            }
        }

        public void MakeManyDrinks(uint[] orderList, ref uint cash)
        {
            foreach (var order in orderList)
            {
                MakeDrink(order, ref cash);
            }
        }
    }
}
