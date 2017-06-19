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
        /// Metoda pozwalająca sprawdzić czy dany przepis jest przechowywany w źródle danych.
        /// </summary>
        /// <param name="recipe">Przepis, którego istnienie w źródle chcemy sprawdzić.</param>
        bool HasRecipe(Recipe recipe);

        /// <summary>
        /// Metoda pozwalająca sprawdzić czy dany przepis jest przechowywany w źródle danych.
        /// </summary>
        /// <param name="recipeGuid">Unikalne ID przepisu.</param>
        bool HasRecipe(Guid recipeGuid);

        /// <summary>
        /// Usuń przepis ze źródła.
        /// </summary>
        /// <param name="recipe">Usuwany przepis.</param>
        void RemoveRecipe(Recipe recipe);

        /// <summary>
        /// Usuń przepis ze źródła.
        /// </summary>
        /// <param name="recipe">Usuwany przepis.</param>
        void RemoveRecipe(Guid recipeGuid);

        /// <summary>
        /// Dodaj przepis do źródła. Jeśli rekord nie zostanie podany, to zostanie utworzony nowy.
        /// </summary>
        /// <param name="recipe">Przepis, który chcemy dodać do źródła.</param>
        /// <param name="record">Rekord, do którego dodajemy rewizję.</param>
        void AddRecipe(Recipe recipe);

        /// <summary>
        /// Zwróć listę przepisów.
        /// </summary>
        List<Recipe> Recipes { get; }
    }
}
