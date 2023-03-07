using CookingRecipe;
using System.ComponentModel;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        1 pc chicken
        1 tbsp vinegar
        1 tbsp cooking oil
        1 cup soy sauce 
        10 clove garlic 
        1 tbsp pepercorn
        2 pc laurel
        */
        Measurement[] volume = new Measurement[5];//tsp,tbsp,cup,cloves,pc
        volume[0] = Measurement.tsp;
        volume[1] = Measurement.tbsp;
        volume[2] = Measurement.cup;
        volume[3] = Measurement.cloves;
        volume[4] = Measurement.pc;

        Ingredient[] ingredients = new Ingredient[7];
        ingredients[0] = new Ingredient("Chicken", 1, volume[4]);
        ingredients[1] = new Ingredient("Vinegar", 1, volume[1]);
        ingredients[2] = new Ingredient("Cooking Oil", 1, volume[1]);
        ingredients[3] = new Ingredient("soy sauce", 1, volume[2]);
        ingredients[4] = new Ingredient("garlic", 10, volume[3]);
        ingredients[5] = new Ingredient("pepper corn", 1, volume[4]);
        ingredients[6] = new Ingredient("laurel", 2, volume[4]);

        List<Ingredient> ingre = new List<Ingredient>();
        for(int i = 0; i < ingredients.Length; i++)
            ingre.Add(ingredients[i]);

        string[] step = new string[2];
        step[0] = "step1";
        step[1] = "step2";

        List<string> strings = new List<string>(); 
        for(int i = 0; i < 2; i++)
            strings.Add(step[i]);
        MainDish adobo = new MainDish("Adobo", ingre, Difficulty.Moderate, strings, "40min");

        Console.WriteLine("name: "+adobo.Name);   
        Console.WriteLine("Main Protein: " + adobo.MainProtein);
        Console.WriteLine("Difficulty: "+adobo.Difficulty);
        Console.WriteLine("Cooking time: "+adobo.CookingTime);
        Console.WriteLine("Ingredients:");
        foreach (Ingredient i in adobo.Ingredients)
            Console.WriteLine("\t" + i.Unit + " " + i.Measurement + " " + i.Name);
        foreach(string s in adobo.Procedure)
                Console.WriteLine(s);
    }
}