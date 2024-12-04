public class Dessert : Food
{
    public Dessert(string name, int calories, int protein, int prepTime, string prepType, int servings, string[] ingredients) : base(name, calories, protein, prepTime, prepType, servings, ingredients)
    {
        _timeOfDay = "Afternoon or Evening";
    }

    public override void DisplayRecipe()
    {
        /*
           With desserts, you know it's not going to benefit anything besides your taste buds, so
           calories and protein are out. Serving sizes vary wildly based on different recipes, so 
           that's a must here
        */
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Prep Time: {_prepTime} mins");
        Console.WriteLine($"Preparation style:  {_prepType}");
        Console.WriteLine($"Servings: {_servings}");
        Console.Write("Ingredients:  ");
        DisplayIngredients();
    }
}