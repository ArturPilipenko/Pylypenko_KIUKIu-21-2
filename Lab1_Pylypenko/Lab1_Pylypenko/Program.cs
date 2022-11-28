using Lab1_Pylypenko.Components;

CoffeeMachine Bob = new CoffeeMachine("Bob", 2000, 2000, 2000, 2000, 2000, 2000, 2000, 2000);
uint[] firstList = new uint[] { 1, 2, 3, 4, 5, 5, 4 };
uint bobmoney = 200;

CoffeeMachine Bryan = new CoffeeMachine("Bryan", 2000, 2000, 2000, 2000, 2000, 2000, 2000, 2000);
uint[] secondList = new uint[] { 5, 3, 2, 4, 1, 1, 2 };
uint[] thirdList = new uint[] { 5, 3 };
uint bryanMoney = 500;

Bob.MakeManyDrinks(firstList, ref bobmoney);
Console.WriteLine(Bob.Money);

Bryan.MakeManyDrinks(secondList, ref bryanMoney);
Console.WriteLine(Bryan.Money);
Console.WriteLine(bryanMoney);

Bryan.MakeManyDrinks(thirdList, ref bryanMoney);
Bryan.WaterCurrent = 2000;
Bryan.MakeManyDrinks(thirdList, ref bryanMoney);

Console.WriteLine(Bryan.Money);
Console.WriteLine(bryanMoney);
