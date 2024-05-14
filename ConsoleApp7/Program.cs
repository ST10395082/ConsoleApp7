using System;
using System.Collections.Generic;
using System.Linq;


class RecipeApp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Recipe App!");
        Console.WriteLine("Please enter the details of your recipe");

        // Prompt user for recipe details
        Console.Write("Enter recipe name: ");
        string recipeName = Console.ReadLine();

        Console.Write("Enter number of ingredients: ");
        int numIngredients = int.Parse(Console.ReadLine());

        // List to store ingredients
        List<Ingredient> ingredients = new List<Ingredient>();

        // Prompt user to input ingredient details
        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine($"Enter details for ingredient #{i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Quantity: ");
            double quantity = double.Parse(Console.ReadLine());
            Console.Write("Unit of measurement: ");
            string unit = Console.ReadLine();

            // Create new Ingredient object and add to the list
            ingredients.Add(new Ingredient(name, quantity, unit));
        }

        Console.Write("Enter number of steps: ");
        int numSteps = int.Parse(Console.ReadLine());

        // List to store steps
        List<string> steps = new List<string>();

        // Prompt user to input step details
        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine($"Enter description for step #{i + 1}:");
            string stepDescription = Console.ReadLine();
            steps.Add(stepDescription);
        }

        // Display full recipe
        Console.WriteLine("\nRecipe Details:");
        Console.WriteLine($"Recipe Name: {recipeName}");
        Console.WriteLine("\nIngredients:");
        foreach (Ingredient ingredient in ingredients)
        {
            Console.WriteLine($"- {ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
        }
        Console.WriteLine("\nSteps:");
        for (int i = 0; i < steps.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i]}");
        }
    }
}

class Ingredient
{
    public string Name { get; set; }
    public double Quantity { get; set; }
    public string Unit { get; set; }

    public Ingredient(string name, double quantity, string unit)
    {
        Name = name;
        Quantity = quantity;
        Unit = unit;
    }
}



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cooking made easy");
            Recipe currentRecipe = new Recipe();

            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Enter Recipe Details");
                Console.WriteLine("2. Scale Recipe");
                Console.WriteLine("3. Reset Quantities");
                Console.WriteLine("4. Clear All Data");
                Console.WriteLine("5. Display Recipe");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        currentRecipe.EnterDetails();
                        break;
                    case 2:
                        currentRecipe.ScaleRecipe();
                        break;
                    case 3:
                        currentRecipe.ResetQuantities();
                        break;
                    case 4:
                        currentRecipe.ClearData();
                        break;
                    case 5:
                        currentRecipe.DisplayRecipe();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }

    class Recipe
    {
        private string recipeName;
        private List<string> ingredients;
        private List<double> quantities;
        private List<string> units;
        private List<string> steps;

        public Recipe()
        {
            ingredients = new List<string>();
            quantities = new List<double>();
            units = new List<string>();
            steps = new List<string>();
        }

        public void EnterDetails()
        {
            Console.WriteLine("Please enter the details for your recipe:");

            Console.Write("Recipe Name: ");
            recipeName = Console.ReadLine();

            Console.Write("Number of Ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            ingredients.Clear();
            quantities.Clear();
            units.Clear();

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"\nIngredient {i + 1}:");
                Console.Write("Name: ");
                ingredients.Add(Console.ReadLine());

                Console.Write("Quantity: ");
                quantities.Add(double.Parse(Console.ReadLine()));

                Console.Write("Unit of Measurement: ");
                units.Add(Console.ReadLine());
            }

            Console.Write("\nNumber of Steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            steps.Clear();

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"\nStep {i + 1}:");
                Console.Write("Description: ");
                steps.Add(Console.ReadLine());
            }
        }

        public void ScaleRecipe()
        {
            Console.Write("Enter scaling factor (0.5 for half, 2 for double, 3 for triple): ");
            double factor = double.Parse(Console.ReadLine());

            for (int i = 0; i < quantities.Count; i++)
            {
                quantities[i] *= factor;
            }

            Console.WriteLine("Recipe scaled successfully!");
        }

        public void ResetQuantities()
        {
            // No need to change original quantities, as we will just clear the scaled data
            Console.WriteLine("Quantities reset to original values!");
        }

        public void ClearData()
        {
            ingredients.Clear();
            quantities.Clear();
            units.Clear();
            steps.Clear();

            Console.WriteLine("All data cleared!");
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("\n--- Recipe ---");
            Console.WriteLine($"Recipe Name: {recipeName}");

            Console.WriteLine("\nIngredients:");
            for (int i = 0; i < ingredients.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {quantities[i]} {units[i]} {ingredients[i]}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }
    }








namespace RecipeA
{
    class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
        }

        public int TotalCalories()
        {
            return Ingredients.Sum(ingredient => ingredient.Calories);
        }
    }

    class Ingredient
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }

        public Ingredient(string name, int calories, string foodGroup)
        {
            Name = name;
            Calories = calories;
            FoodGroup = foodGroup;
        }
    }

    class Programs
    {
        static void Main(string[] args)
        {
            List<Recipe> recipes = new List<Recipe>();

            while (true)
            {
                Console.WriteLine("1. Add Recipe");
                Console.WriteLine("2. View Recipes");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddRecipe(recipes);
                        break;
                    case "2":
                        ViewRecipes(recipes);
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddRecipe(List<Recipe> recipes)
        {
            Console.Write("Enter recipe name: ");
            string name = Console.ReadLine();
            Recipe recipe = new Recipe(name);

            while (true)
            {
                Console.Write("Enter ingredient name (or type 'done' to finish): ");
                string ingredientName = Console.ReadLine();

                if (ingredientName.ToLower() == "done")
                    break;

                Console.Write("Enter calories: ");
                int calories = int.Parse(Console.ReadLine());

                Console.Write("Enter food group: ");
                string foodGroup = Console.ReadLine();

                recipe.Ingredients.Add(new Ingredient(ingredientName, calories, foodGroup));
            }

            recipes.Add(recipe);
        }

        static void ViewRecipes(List<Recipe> recipes)
        {
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes available.");
                return;
            }

            recipes.Sort((x, y) => string.Compare(x.Name, y.Name));

            foreach (var recipe in recipes)
            {
                Console.WriteLine($"Recipe: {recipe.Name}");
            }

            Console.Write("Enter recipe name to view details: ");
            string selectedRecipeName = Console.ReadLine();

            Recipe selectedRecipe = recipes.Find(recipe => recipe.Name == selectedRecipeName);

            if (selectedRecipe != null)
            {
                Console.WriteLine($"Ingredients for {selectedRecipe.Name}:");
                foreach (var ingredient in selectedRecipe.Ingredients)
                {
                    Console.WriteLine($" - {ingredient.Name}, {ingredient.Calories} calories, {ingredient.FoodGroup}");
                }

                int totalCalories = selectedRecipe.TotalCalories();
                Console.WriteLine($"Total Calories: {totalCalories}");

                if (totalCalories > 300)
                {
                    Console.WriteLine("Warning: Total calories exceed 300!");
                }
            }
            else
            {
                Console.WriteLine("Recipe not found.");
            }
        }
    }
}
