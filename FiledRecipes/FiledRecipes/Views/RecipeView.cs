using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {

        public void Show(IRecipe recipe)
        {
            // Presenterar panel med receptnamn.
            Console.Clear();
            Header = recipe.Name;
            ShowHeaderPanel();

            Console.WriteLine("\nIngredienser");
            Console.WriteLine("---------------\n");

            // Hämtar ingredienser och skriver ut dem.
            foreach (IIngredient Ingredients in recipe.Ingredients)
	        {
                Console.WriteLine(Ingredients);
	        }
                Console.WriteLine("\nGör så här");
                Console.WriteLine("---------------\n");
            
            // Hämtar instruktioner och skriver ut dem.
            foreach (string Instructions in recipe.Instructions)
	        {
                Console.WriteLine(Instructions);
	        }
        }

        public void Show(IEnumerable<IRecipe> recipes)
        {
            // Skriver ut alla recept.
            foreach (IRecipe Recipe in recipes)
            {
                Show(Recipe);
                ContinueOnKeyPressed();
            }
        }
    }

}
