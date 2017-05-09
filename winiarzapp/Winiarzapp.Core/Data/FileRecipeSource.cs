using System;
using System.Collections.Generic;

namespace Winiarzapp.Core.Data
{
    public class FileRecipeSource : IRecipeSource
    {
        public event RecipesChangedHandler RecipesChanged;

        public void AddRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recipe> GetRecipes()
        {
            throw new NotImplementedException();
        }

        public bool HasRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public bool RemoveRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
