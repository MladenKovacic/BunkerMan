using TheBunkerMan.FoodPart;
using TheBunkerMan.StoragePart;

namespace TheBunkerMan.BunkerMan
{
    
   public class BunkerMan
   {
       //Fields camelCase Cubes , internal
       // readonly
       private double health;
       private string name;

       
       
       
       //Propporties PascalCase Wrenches, external
       public double Health
       {
           get { return this.health; }
           
           set { this.health = value; }
       }

       public string Name
       {
           get { return this.name; }
           set { this.name = value; }
       }

       
       // Constructor
       public BunkerMan(string name, int health)
       {
           this.Name = name;
           this.Health = health;
           
       }
       
       
       // Method void no return
       public double EatFood(Food food)
       {
          
           double caloriesConsumed = food.Eat();
           if (caloriesConsumed < 2000 )
           {
               var healthDifference = Math.Round(caloriesConsumed/ 100);
               Health -= healthDifference;
               //Console.WriteLine($"{Health}");
           } 

           if (caloriesConsumed >= 2000)
           {
               var healthDifference = Math.Min(20, Math.Round(caloriesConsumed/ 200));
               Health += healthDifference;
               //Console.WriteLine($"{Health}");
           }
           return caloriesConsumed;
       }

       public bool IsAlive()
       {

           return Health > 0;
       }
       
   }
}
