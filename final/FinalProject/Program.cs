using System;

RecipeBook recipe_book = new RecipeBook();
Menu menu = new Menu(recipe_book);

recipe_book._allFoods.AddRange(new List<Food>
{
    // Breakfast Recipes
    new Breakfast(
        "Banana Oat Pancakes",
        180,
        6,
        20,
        "Panfry",
        4,
        new string[]
        {
            "1 cup rolled oats", "2 ripe bananas", "2 eggs", "1/2 cup milk",
            "1 tsp vanilla extract", "1/2 tsp baking powder", "1/2 tsp cinnamon", "1 pinch of salt"
        }
    ),
    new Breakfast(
        "Spinach and Feta Omelet",
        250,
        12,
        15,
        "Panfry",
        2,
        new string[]
        {
            "4 large eggs", "1/4 cup milk", "1 cup fresh spinach, chopped",
            "1/4 cup feta cheese, crumbled", "1 tbsp olive oil", "Salt and pepper to taste"
        }
    ),

    // Lunch Recipes
    new Lunch(
        "Grilled Chicken Caesar Wrap",
        350,
        20,
        20,
        "Grill",
        2,
        new string[]
        {
            "2 medium whole-grain tortillas", "1 grilled chicken breast, sliced",
            "1 cup romaine lettuce, chopped", "1/4 cup Caesar dressing", "1/4 cup Parmesan cheese, grated"
        }
    ),
    new Lunch(
        "Quinoa Veggie Bowl",
        400,
        12,
        25,
        "Simmer",
        4,
        new string[]
        {
            "1 cup quinoa", "2 cups water", "1 cup cherry tomatoes, halved",
            "1 cup cucumber, diced", "1/2 cup feta cheese", "1/4 cup olive oil",
            "2 tbsp lemon juice", "Salt and pepper to taste"
        }
    ),

    // Dinner Recipes
    new Dinner(
        "Beef Stir-Fry with Veggies",
        450,
        30,
        30,
        "Panfry",
        4,
        new string[]
        {
            "1 lb beef sirloin, sliced into thin strips", "2 cups broccoli florets",
            "1 red bell pepper, sliced", "1 yellow onion, sliced", "3 tbsp soy sauce",
            "2 tbsp olive oil", "1 tsp garlic, minced", "1 tsp ginger, minced"
        }
    ),
    new Dinner(
        "Baked Lemon Salmon",
        300,
        25,
        25,
        "Bake",
        4,
        new string[]
        {
            "4 salmon fillets (6 oz each)", "2 lemons, thinly sliced", "2 tbsp olive oil",
            "1 tsp garlic, minced", "Salt and pepper to taste", "Fresh dill for garnish"
        }
    ),

    // Snack Recipes
    new Snack(
        "Greek Yogurt Parfait",
        150,
        8,
        5,
        "Assemble",
        2,
        new string[]
        {
            "1 cup Greek yogurt", "1/2 cup granola", "1/2 cup mixed berries",
            "1 tbsp honey"
        }
    ),
    new Snack(
        "Hummus and Veggie Platter",
        120,
        4,
        10,
        "Assemble",
        4,
        new string[]
        {
            "1 cup hummus", "1 cup carrot sticks", "1 cup cucumber slices", "1 cup celery sticks"
        }
    ),

    // Dessert Recipes
    new Dessert(
        "Chocolate Avocado Mousse",
        200,
        5,
        10,
        "Blender",
        4,
        new string[]
        {
            "2 ripe avocados", "1/4 cup cocoa powder", "1/4 cup honey or maple syrup",
            "1/4 cup almond milk", "1 tsp vanilla extract"
        }
    ),
    new Dessert(
        "No-Bake Peanut Butter Energy Bites",
        100,
        3,
        15,
        "Mix",
        12,
        new string[]
        {
            "1 cup rolled oats", "1/2 cup peanut butter", "1/4 cup honey",
            "1/4 cup chocolate chips", "1/4 cup ground flaxseeds"
        }
    )
});

int choice = 0;
do 
{
    menu.DisplayOptions();
    choice = menu.GetInput();
    if (choice == 1)
    {
        recipe_book.DisplayAll();
    }
    
    if (choice == 2)
    {
        menu.AddRecipe();
    }

    if (choice == 3)
    {
        break;
    }
}
while (choice != 4);