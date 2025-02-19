using System;

interface IMealPlan {
    string GetMealCategory(); 
    void GenerateMealPlan(); 
}

class VegetarianMeal : IMealPlan {
    public string GetMealCategory() { 
        return "Vegetarian"; 
    }
    public void GenerateMealPlan() { 
        Console.WriteLine("Generating a Vegetarian meal plan with plant-based dishes."); 
    }
}

class VeganMeal : IMealPlan {
    public string GetMealCategory() { 
        return "Vegan"; 
    }
    public void GenerateMealPlan() { 
        Console.WriteLine("Generating a Vegan meal plan with plant-based and cruelty-free dishes."); 
    }
}

class KetoMeal : IMealPlan {
    public string GetMealCategory() { 
        return "Keto"; 
    }
    public void GenerateMealPlan() { 
        Console.WriteLine("Generating a Keto meal plan with low-carb, high-fat dishes."); 
    }
}

class HighProteinMeal : IMealPlan {
    public string GetMealCategory() { 
        return "High-Protein"; 
    }
    public void GenerateMealPlan() { 
        Console.WriteLine("Generating a High-Protein meal plan with protein-rich dishes."); 
    }
}

class Meal<T> where T : IMealPlan {
    private string mealName; 
    private T mealPlan; 

    public Meal(string mealName, T mealPlan) { 
        this.mealName = mealName; 
        this.mealPlan = mealPlan; 
    }

    public void DisplayMealDetails() { 
        Console.WriteLine("Meal Name: " + mealName); 
        Console.WriteLine("Meal Category: " + mealPlan.GetMealCategory()); 
        mealPlan.GenerateMealPlan(); 
    }
}

class MealPlanGenerator {
    public static void GenerateMealPlan<T>(Meal<T> meal) where T : IMealPlan { 
        if (meal == null) { 
            Console.WriteLine("Invalid meal plan. Please choose a valid meal category."); 
            return; 
        }
        meal.DisplayMealDetails(); 
    }
}

class Program {
    public static void Main(string[] args) { 
        var vegetarianMeal = new Meal<VegetarianMeal>("Veggie Delight", new VegetarianMeal()); 
        var veganMeal = new Meal<VeganMeal>("Vegan Fiesta", new VeganMeal()); 
        var ketoMeal = new Meal<KetoMeal>("Keto Power", new KetoMeal()); 
        var highProteinMeal = new Meal<HighProteinMeal>("Protein Boost", new HighProteinMeal()); 

        MealPlanGenerator.GenerateMealPlan(vegetarianMeal); 
        MealPlanGenerator.GenerateMealPlan(veganMeal); 
        MealPlanGenerator.GenerateMealPlan(ketoMeal); 
        MealPlanGenerator.GenerateMealPlan(highProteinMeal); 
    }
}
