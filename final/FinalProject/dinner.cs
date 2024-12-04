public class Dinner : Food
{
    public Dinner(string name, int calories, int protein, int prepTime, string prepType, int servings, string[] ingredients) : base(name, calories, protein, prepTime, prepType, servings, ingredients)
    {
        _timeOfDay = "Evening";
    }

    public override void DisplayRecipe()
    {
        /*
           At dinner, you're going all out. You could be having friends over, cooking for the 
           whole family, or bringing a dish to a party. Any way you slice it, you need every
           detail
        */
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