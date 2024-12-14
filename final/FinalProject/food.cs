public abstract class Food
{
    protected string _name;
    protected int _calories;
    protected int _protein;
    protected int _prepTime;
    protected string _prepType;
    protected int _servings;
    protected string[] _ingredients;
    protected string _timeOfDay;
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
    public void DisplayFullInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Calories: {_calories}");
        Console.WriteLine($"Protein: {_protein}g");
        Console.WriteLine($"Prep Time: {_prepTime} mins");
        Console.WriteLine($"Preparation style:  {_prepType}");
        Console.WriteLine($"Servings: {_servings}");
        Console.WriteLine($"Eaten during the {_timeOfDay}");
        Console.Write("Ingredients:  ");
        DisplayIngredients();
    }
    public abstract void DisplayRecipe();
    public void EditRecipe()
    {
        Console.WriteLine("Please enter the following information about your recipe");
        Console.Write("Name:  ");
        string name = Console.ReadLine();

        Console.Write("Calorie count:  ");
        int calories = int.Parse(Console.ReadLine());

        Console.Write("Protein in grams:  ");
        int protein = int.Parse(Console.ReadLine());

        Console.Write("Prep Time in minutes:  ");
        int prepTime = int.Parse(Console.ReadLine());

        Console.Write("Prep type (e.g. crockpot, skillet, oven):  ");
        string prepType = Console.ReadLine();

        Console.Write("Servings:  ");
        int servings = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingredients (enter 'done' to stop):  ");
        string entry;
        string[] ingredients = [];
        do
        {
            entry = Console.ReadLine();
            ingredients = ingredients.Append(entry).ToArray();
        }
        while (entry != "done");

        // delete last entry in ingredients, which should be "done"
        ingredients = ingredients[..^1];

        _name = name;
        _calories = calories;
        _protein = protein;
        _prepTime = prepTime;
        _prepType = prepType;
        _servings = servings;
        _ingredients = ingredients;
    }
    public string GetName()
    {
        return _name;
    }
}   