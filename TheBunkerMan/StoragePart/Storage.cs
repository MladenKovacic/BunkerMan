using TheBunkerMan.BunkerMan;
using TheBunkerMan.FoodPart;
using System.Collections.Generic;

namespace TheBunkerMan.StoragePart
{
    public class Storage
    {

        //fields
        private List<Food> foodList = new List<Food>();
        

       // proper
        public List<Food> FoodList
        {
            get
            {
                return foodList;
            }

            set
            {
                foodList = value;
            }
        }
        //cunc
        public Storage()
        {
            FoodList = new List<Food>();
        }
        //methods
        public Food PickFood()
        {
            
            //foodList.RemoveAll(food => food == null);
            // if (foodList.Count == 0)
            // {
            //     Console.WriteLine("No food found");
            //     return null;
            // }
            return foodList[0];
        }
         
        public void StockFood(int numRations)
         {
            Random rng = new Random();
            string[] foodNames = {"Pizza", "Hamburger", "ColeSlaw", "Banana","Ägg","Kaviar","Macka"};
            for (int i = 0; i < numRations; i++)
            {
                if (numRations > 0)
                {
                    string name = foodNames[rng.Next(0, foodNames.Length -1)];
                    double baseCalories = rng.Next(1500,2200);
                    foodList.Add(new Food(name, baseCalories));
                }
                else if (numRations == 0)
                {
                    break;
                }
            }
         } 

    }

   
}

