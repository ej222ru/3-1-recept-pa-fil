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
	static class Extensions
	{

		public static string CenterAlignString(this string s, string other)
		{
			int spaces = ((other.Length - s.Length) / 2);
			int odd = ((other.Length - s.Length) % 2);

			string padLeft = "||".PadRight(spaces);
			string padRight = "||".PadLeft(spaces + odd);
			return string.Format("{0}{1}{2}", padLeft, s, padRight);
		}
	}

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
			Header = recipe.Name;
			ShowHeaderPanel();
			Console.WriteLine("");


			//VievHeader(recipe.Name);
			Console.WriteLine(Strings1.ingredients);
			string frameLine = new string('-', Strings1.ingredients.Length);
			Console.WriteLine(frameLine);
			//for (int i=0; i<recipe.Ingredients.

		}
		public void Show(IEnumerable<IRecipe> recipes)
		{

		}
    }
}
