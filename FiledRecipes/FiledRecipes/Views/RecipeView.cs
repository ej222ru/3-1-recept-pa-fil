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
	/// 

    public class RecipeView : ViewBase, IRecipeView
    {
		private static void VievHeader(string text)
		{

			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(Strings1.divider);
			Console.WriteLine(text.CenterAlignString(Strings1.divider));
			Console.WriteLine(Strings1.divider);
			Console.ResetColor();
			Console.WriteLine("");
		}

		public void Show(IRecipe recipe)
		{
			Console.Clear();
			string frameLine = new string('-', Strings1.instructions.Length); 
			Header = recipe.Name;
			ShowHeaderPanel();

			Console.WriteLine("");
			Console.WriteLine(Strings1.ingredients);
			Console.WriteLine(frameLine);
			foreach (Ingredient ingredient in recipe.Ingredients)
			{
				Console.WriteLine(ingredient);
			}

			Console.WriteLine("");
			Console.WriteLine(Strings1.instructions);
			Console.WriteLine(frameLine);
			int index = 1;
			foreach (string instruction in recipe.Instructions)
			{
				Console.WriteLine(string.Format("<{0}>", index));
				Console.WriteLine(instruction);
				index++;
			}
		}
		public void Show(IEnumerable<IRecipe> recipes)
		{
			foreach (Recipe recipie in recipes)
			{
				Show(recipie);
				ContinueOnKeyPressed();
			}
		}
    }
}
