using TheBunkerMan.FoodPart;
using TheBunkerMan.StoragePart;

namespace TheBunkerMan.BunkerMan
{
    
   public class BunkerMan
   {
       public double Health
       {
           get;
           set;
       }
       public string Name
           {
               get;
               set;
           }
       public BunkerMan(string name, double health)
       {
           Name = name;
           Health = health;
           
       }
       public double EatFood(Food food)
       {

           double caloriesConsumed = food.Eat();
           
           
           if (caloriesConsumed < 2000 )
           {   
              var healthDifference = Math.Round((2000- caloriesConsumed)/100); 
                Health -= healthDifference;
              
           } 

           if (caloriesConsumed >= 2000)
           {
               var healthDifference = Math.Min(20, Math.Round((caloriesConsumed - 2000)/200));
              Health += healthDifference;
            
           }
           
           return caloriesConsumed > 0 ? caloriesConsumed : 0;
       }

       public bool IsAlive()
       {

           return Health > 0;
       }
       
   }
}
