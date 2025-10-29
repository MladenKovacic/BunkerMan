
using TheBunkerMan.FoodPart;

namespace TheBunkerMan.StoragePart
{
    public class Storage
    {
        
       public List<Food> FoodList = new List<Food>();
     
        
        public Storage()
        {
            FoodList = new List<Food>();
        }

        public Food PickFood()
        {
            FoodList.Add(FoodList[0]);
            FoodList.RemoveAt(0);
            return FoodList.First();
        }
         
        public void StockFood(double numRations)
         {
            Random rng = new Random();
            string[] foodNames = {"Pizza", "Hamburger", "ColeSlaw", "Banana","Ägg","Kaviar","Macka","Köttbullar","Pasta","Kött"};
            for (double i = 0; i < numRations; i++)
            {
                if (numRations >= 0)
                {
                    string name = foodNames[rng.Next(0, foodNames.Length)];
                    double baseCalories = rng.Next(300,2500);
                    FoodList.Add(new Food(name, baseCalories));
                }
            
            }
         } 

    }
}

