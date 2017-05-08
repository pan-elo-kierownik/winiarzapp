using System.Collections.Generic;

namespace Winiarzapp.Core.Data
{
    /// <summary>
    /// Intefejs pozwalający na wiele implementacji miejsca, w którym będą przechowywane dane dotyczące przepisów. 
    /// (np. FileRecipeSource, SQLRecipeSource, RobotWithPencilRecipeSource, etc.).
    /// </summary>
    interface IRecipeSource
    {
        /// <summary>
        /// Zwróc wszystkie przepisy.
        /// </summary
        IEnumerable<Recipe> GetRecipes();

        /// <summary>
        /// Metoda pozwalająca sprawdzić czy dany przepis jest dodany do źródła.
        /// </summary
        /// <param name="recipe">Przepis, którego istnienie w źródle chcemy sprawdzić.</param>
        bool HasRecipe(Recipe recipe);

        /// <summary>
        /// Usuń przepis ze źródła.
        /// </summary
        /// <param name="recipe">Usuwany przepis.</param>
        bool RemoveRecipe(Recipe recipe);

        /// <summary>
        /// Dodaj przepis do źródła.
        /// </summary
        /// <param name="recipe">Przepis, który chcemy dodać do źródła.</param>
        void AddRecipe(Recipe recipe);
    }
}
