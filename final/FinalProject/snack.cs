public class Snack : Food
{
    public Snack(string name, int calories, int protein, int prepTime, string prepType, int servings, string[] ingredients) : base(name, calories, protein, prepTime, prepType, servings, ingredients)
    {
        _timeOfDay = "Entire Day";
    }

    public override void DisplayRecipe()
    {
        /*
           Snacks live and die by how easy they are to make. They also usually make a bunch
           to either share or save, so serving size isn't too necessary. 
        */
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Calories: {_calories}");
        Console.WriteLine($"Protein: {_protein}g");
        Console.WriteLine($"Prep Time: {_prepTime} mins");
        Console.Write("Ingredients:  ");
        DisplayIngredients();
    }
}