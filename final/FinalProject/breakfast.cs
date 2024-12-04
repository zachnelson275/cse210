public class Breakfast : Food
{
    public Breakfast(string name, int calories, int protein, int prepTime, string prepType, int servings, string[] ingredients) : base(name, calories, protein, prepTime, prepType, servings, ingredients)
    {
        _timeOfDay = "Morning";
    }
    public override void DisplayRecipe()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Prep Time: {_prepTime} mins");
        Console.WriteLine($"Preparation style:  {_prepType}");
        Console.Write("Ingredients:  ");
        DisplayIngredients();
    }
}
