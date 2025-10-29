
using TheBunkerMan.FoodPart;
using TheBunkerMan.BunkerMan;
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
            if (FoodList.Count == 0)
            {
                var noFood = new Food("", 0);
               return noFood;
            }
            Food food = FoodList[0];
            FoodList.RemoveAt(0);
            
            return food ;
            
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
                    double baseCalories = rng.Next(1000,2500);
                    FoodList.Add(new Food(name, baseCalories));
                }
            
            }
         } 

    }
}

