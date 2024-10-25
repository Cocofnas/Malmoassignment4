using System;

namespace Malmeinl4
{
    public class RecipeManager
    {
        private Recipe?[] recipeList;  // Nullable Recipe array
        private int numOfRecipes;

        public RecipeManager(int maxNumOfRecipes)
        {
            recipeList = new Recipe?[maxNumOfRecipes];
            numOfRecipes = 0;
        }

        public void AddRecipe(Recipe recipe)
        {
            if (numOfRecipes < recipeList.Length)
            {
                recipeList[numOfRecipes++] = recipe;
            }
            else
            {
                throw new InvalidOperationException("Maximum number of recipes reached.");
            }
        }

        public Recipe GetRecipe(int index)
        {
            if (index >= 0 && index < numOfRecipes)
            {
                return recipeList[index] ?? throw new InvalidOperationException("Recipe not found.");
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid recipe index.");
            }
        }

        public void RemoveRecipe(int index)
        {
            if (index >= 0 && index < numOfRecipes)
            {
                for (int i = index; i < numOfRecipes - 1; i++)
                {
                    recipeList[i] = recipeList[i + 1];
                }
                recipeList[--numOfRecipes] = null;  // Now allowed due to nullable array
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid recipe index.");
            }
        }

        public int Count
        {
            get { return numOfRecipes; }
        }
    }
}
