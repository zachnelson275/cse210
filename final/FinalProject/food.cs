public class Food
{
    private string _name;
    private int _calories;
    private int _protein;
    private int _prepTime;
    private string _prepType;
    private int _servings;
    private string[] _ingredients;
    public Food(string name, int calories, int protein, int prepTime, string prepType, int servings, string[] ingredients)
    {
        _name = name;
        _calories = calories;
        _protein = protein;
        _prepTime = prepTime;
        _prepType = prepType;
        _servings = servings;
        _ingredients = ingredients;
    }

    public void DisplayIngredients()
    {
        string ing = string.Join(", ", _ingredients);
        Console.WriteLine(ing);
    }   
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Calories: {_calories}");
        Console.WriteLine($"Protein: {_protein}g");
        Console.WriteLine($"Prep Time: {_prepTime} mins");
        Console.WriteLine($"Servings: {_servings}");
    }
}   