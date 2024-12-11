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
        }
    }
    public void DisplayBreakfast()
    {
        foreach (Breakfast breakfast in _allFoods)
        {
            breakfast.DisplayRecipe();
        }
    }
    public void DisplayLunch()
    {
        foreach (Lunch lunch in _allFoods)
        {
            lunch.DisplayRecipe();
        }
    }
    public void DisplayDinner()
    {
        foreach (Dinner dinner in _allFoods)
        {
            dinner.DisplayRecipe();
        }
    }
    public void DisplaySnack()
    {
        foreach (Snack snack in _allFoods)
        {
            snack.DisplayRecipe();
        }
    }
    public void DisplayDessert()
    {
        foreach (Dessert dessert in _allFoods)
        {
            dessert.DisplayRecipe();
        }
    }
    public int GetTotalRecipeCount()
    {
        _recipeCount = _allFoods.Count();
        return _recipeCount;
    }
}