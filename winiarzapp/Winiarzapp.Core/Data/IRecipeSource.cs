using System;
using System.Collections.Generic;

namespace Winiarzapp.Core.Data
{
    /// <summary>
    /// Lista przepisów uległa zmianie.
    /// </summary>
    public delegate void RecipesChangedHandler();

    /// <summary>
    /// Intefejs pozwalający na wiele implementacji miejsca, w którym będą przechowywane dane dotyczące przepisów. 
    /// (np. FileRecipeSource, SQLRecipeSource, RobotWithPencilRecipeSource, etc.).
    /// </summary>
    public interface IRecipeSource : IDisposable
    {
        /// <summary>
        /// Zdarzenie wywołane gdy lista przepisów się zmieni.
        /// </summary>
        event RecipesChangedHandler RecipesChanged;

        /// <summary>
        /// Zwróc wszystkie rekordy przepisów.
        /// </summary>
        IEnumerable<RecipeRecord> GetRecords();

        /// <summary>
        /// Metoda pozwalająca sprawdzić czy dany przepis jest dodany do jakiegoś z istniejących rekordów.
        /// </summary>
        /// <param name="recipe">Przepis, którego istnienie w źródle chcemy sprawdzić.</param>
        bool HasRecipe(Recipe recipe);

        /// <summary>
        /// Znajdź rekord, w którym znajduje się podany przepis.
        /// </summary>
        /// <param name="recipe">Przepis, którego rekord chcemy otrzymać.</param>
        RecipeRecord FindRecord(Recipe recipe);

        /// <summary>
        /// Usuń przepis ze źródła.
        /// </summary>
        /// <param name="recipe">Usuwany przepis.</param>
        void RemoveRecipe(Recipe recipe);

        /// <summary>
        /// Dodaj przepis do źródła. Jeśli rekord nie zostanie podany, to zostanie utworzony nowy.
        /// </summary>
        /// <param name="recipe">Przepis, który chcemy dodać do źródła.</param>
        /// <param name="record">Rekord, do którego dodajemy rewizję.</param>
        RecipeRecord AddRecipe(Recipe recipe, RecipeRecord record = null);
    }
}
