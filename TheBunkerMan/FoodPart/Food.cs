
using TheBunkerMan.StoragePart;
using TheBunkerMan.BunkerMan;

namespace TheBunkerMan.FoodPart
{
    
    public class Food
    {
        //fields
        private double baseCalories;
        private string name;

// proper
        public double BaseCalories
        {
            get { return baseCalories; }
            set { baseCalories = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
   //cunc
        public Food(string name, double baseCalories)
        {
            this.Name = name;
            this.BaseCalories = baseCalories;
        }
        //methods
        public double Eat()
        {
            Random random = new Random();
            double calories = BaseCalories * (random.NextDouble() * 0.5 + 0.75);
            
            return calories;
        }
    }
}

