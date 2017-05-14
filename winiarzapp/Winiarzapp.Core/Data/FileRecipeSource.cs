using System;

namespace Winiarzapp.Core.Data
{
    public class FileRecipeSource : IRecipeSource
    {
        public event RecipesChangedHandler RecipesChanged;

        /// <summary>
        /// Pochodzi z interfejsu IDisposable. Zostanie wywołane przed zamknięciem programu i powinno zapisać stan obiektu (np. na dysku).
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void AddRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public bool HasRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public bool HasRecipe(Guid recipeGuid)
        {
            throw new NotImplementedException();
        }

        public void RemoveRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void RemoveRecipe(Guid recipeGuid)
        {
            throw new NotImplementedException();
        }
    }
}
