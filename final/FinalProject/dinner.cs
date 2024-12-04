public class Dinner : Food
{
    public Dinner(string name, int calories, int protein, int prepTime, string prepType, int servings, string[] ingredients) : base(name, calories, protein, prepTime, prepType, servings, ingredients)
    {
        _timeOfDay = "Evening";
    }

    public override void DisplayRecipe()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Calories: {_calories}");
        Console.WriteLine($"Protein: {_protein}g");
        Console.WriteLine($"Prep Time: {_prepTime} mins");
        Console.WriteLine($"Preparation style:  {_prepType}");
        Console.WriteLine($"Servings: {_servings}");
        Console.Write("Ingredients:  ");
        DisplayIngredients();
    }
}