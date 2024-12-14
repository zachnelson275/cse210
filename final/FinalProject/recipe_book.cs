public class RecipeBook
{
    public List<Food> _allFoods;
    private int _recipeCount;
    public RecipeBook()
    {
        _allFoods = [];
        _recipeCount = 0;
    }
    public void AddRecipe(Food recipe)
    {
        _allFoods.Add(recipe);
    }
    public void DisplayAll()
    {
        foreach (Food food in _allFoods)
        {
            food.DisplayRecipe();
            Console.WriteLine();
        }
    }
    public void DisplayBreakfast()
    {
        foreach (Food breakfast in _allFoods)
        {
            if (breakfast.Equals(typeof(Breakfast)))
            {
                breakfast.DisplayRecipe();
                Console.WriteLine();

            }
        }
    }
    public void DisplayLunch()
    {
        foreach (Food lunch in _allFoods)
        {
            if (lunch.Equals(typeof(Lunch)))
            {
                lunch.DisplayRecipe();
                Console.WriteLine();
            }
        }
    }
    public void DisplayDinner()
    {
        foreach (Food dinner in _allFoods)
        {
            if (dinner.Equals(typeof(Dinner)))
            {
                dinner.DisplayRecipe();
                Console.WriteLine();
            }
        }
    }
    public void DisplaySnack()
    {
        foreach (Food snack in _allFoods)
        {
            if (snack.Equals(typeof(Snack)))
            {
            snack.DisplayRecipe();
            Console.WriteLine();
            }
        }
    }
    public void DisplayDessert()
    {
        foreach (Food dessert in _allFoods)
        {
            if (dessert.Equals(typeof(Dessert)))
            {
            dessert.DisplayRecipe();
            Console.WriteLine();
            }
        }
    }
    public int GetTotalRecipeCount()
    {
        _recipeCount = _allFoods.Count();
        return _recipeCount;
    }
    public void DisplayAllNames()
    {
        int count = 0;
        foreach (Food food in _allFoods)
        {
            Console.WriteLine($"{count += 1}, {food.GetName}");
        }
    }
    public void EditRecipe(int choice)
    {
        _allFoods[choice].EditRecipe();
    }
}