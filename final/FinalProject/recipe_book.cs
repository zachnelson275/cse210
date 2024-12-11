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
        foreach (Breakfast breakfast in _allFoods)
        {
            breakfast.DisplayRecipe();
            Console.WriteLine();
        }
    }
    public void DisplayLunch()
    {
        foreach (Lunch lunch in _allFoods)
        {
            lunch.DisplayRecipe();
            Console.WriteLine();
        }
    }
    public void DisplayDinner()
    {
        foreach (Dinner dinner in _allFoods)
        {
            dinner.DisplayRecipe();
            Console.WriteLine();
        }
    }
    public void DisplaySnack()
    {
        foreach (Snack snack in _allFoods)
        {
            snack.DisplayRecipe();
            Console.WriteLine();
        }
    }
    public void DisplayDessert()
    {
        foreach (Dessert dessert in _allFoods)
        {
            dessert.DisplayRecipe();
            Console.WriteLine();
        }
    }
    public int GetTotalRecipeCount()
    {
        _recipeCount = _allFoods.Count();
        return _recipeCount;
    }
}