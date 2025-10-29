// See https://aka.ms/new-console-template for more information

using TheBunkerMan.BunkerMan;
using TheBunkerMan.StoragePart;

public class Init
{
    static void Main()
    {
        
        Console.WriteLine("How many days do you think you can survive!");
        int numberOfDays;
        
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out numberOfDays))
            {
                Console.WriteLine("You need to enter a number! \n Restart the game!");
                  break;
            }
            
            Console.WriteLine("How many rations do you think you need to survive!");
            int numberOfRations;
            if (!int.TryParse(Console.ReadLine(), out numberOfRations))
            {
                Console.WriteLine("You need to enter a number! \n Restart the game!");
                break;
            }
            
            Storage storage = new Storage();

            storage.StockFood(numberOfRations);

            BunkerMan BunkerMan = new BunkerMan("BunkerMan", 100);

            Console.WriteLine($"The Bunker Man --- days={numberOfDays} rations={numberOfRations}");

            for (int i = 0; i < numberOfDays; i++)
            {
                
                if (i <= storage.FoodList.Count -1)
               
                {
                    var food = storage.PickFood();

                    double kcal = BunkerMan.EatFood(food);

                    if (kcal >= 2000)
                    {
                        Console.WriteLine(
                            $"Day {i + 1}: Ate | ({storage.FoodList[i].Name}) -> (base={storage.FoodList[i].BaseCalories}) -> (kcal={Math.Round(kcal)}) health change=+{Math.Round((kcal - 2000) / 200)} health={Math.Round(BunkerMan.Health)}");
                    }

                    if (kcal < 2000)
                    {
                        Console.WriteLine(
                            $"Day {i + 1}: Ate | ({storage.FoodList[i].Name}) -> (base={storage.FoodList[i].BaseCalories}) -> (kcal={Math.Round(kcal)}) health change={Math.Round((2000 - kcal) / 100)} health={Math.Round(BunkerMan.Health)}");
                    }


                }
                else if (i > storage.FoodList.Count)
                {
                    BunkerMan.Health -= 20;
                    Console.WriteLine(
                        $"Day {i + 1}: No Food |                          -> kcal=0 health change = =-20  {BunkerMan.Health}  ");
                }

                if (i + 1 == numberOfDays)
                {
                    Console.WriteLine($"Outcome: Survived all {i + 1} days.");
                }

                if (!BunkerMan.IsAlive())
                {
                    Console.WriteLine($"Outcome: Perished on day {i + 1}: ");
                    break;
                }
            }
        }
    }
}