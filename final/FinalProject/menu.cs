public class Menu
{
    private RecipeBook _recipes;
    public Menu(RecipeBook recipes)
    {
        _recipes = recipes;
    }
    public void DisplayOptions()
    {
        Console.Write(@"
1) Display Recipes
2) Add Recipe
3) Edit Recipe
4) Quit
");
    }
    public int GetInput()
    {
        Console.Write("Please select a choice:  ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    public void AddRecipe()
    {
        Console.Write(@"
1) Breakfast
2) Lunch
3) Dinner
4) Snack
5) Dessert
");
        Console.Write("Please select the type of recipe you'd like to create:  ");
        int choice = int.Parse(Console.ReadLine());

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

        switch(choice)
        {
            case 1:
                Breakfast breakfast = new Breakfast(name, calories, protein, prepTime, prepType, servings, ingredients);
                _recipes.AddRecipe(breakfast);
                break;
            case 2:
                Lunch lunch = new Lunch(name, calories, protein, prepTime, prepType, servings, ingredients);
                _recipes.AddRecipe(lunch);
                break;
            case 3:
                Dinner dinner = new Dinner(name, calories, protein, prepTime, prepType, servings, ingredients);
                _recipes.AddRecipe(dinner);
                break;
            case 4:
                Snack snack = new Snack(name, calories, protein, prepTime, prepType, servings, ingredients);
                _recipes.AddRecipe(snack);
                break;
            case 5:
                Dessert dessert = new Dessert(name, calories, protein, prepTime, prepType, servings, ingredients);
                _recipes.AddRecipe(dessert);
                break;
        }
    }
    public void EditRecipe()
    {
        _recipes.DisplayAllNames();
        Console.Write("Which recipe would you like to edit?  ");
        int choice = int.Parse(Console.ReadLine());
        _recipes.EditRecipe(choice);
    }
}