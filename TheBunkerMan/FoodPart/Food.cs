namespace TheBunkerMan.FoodPart
{
    
    public class Food
    {
        public double BaseCalories
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
   
        public Food(string name, double baseCalories)
        {
            Name = name;
            BaseCalories = baseCalories;
        }
        
        public double Eat()
        {
            Random random = new Random();
            double calories = BaseCalories * (random.NextDouble() * 0.5 + 0.75);
            
            return calories;
        }
    }
}

