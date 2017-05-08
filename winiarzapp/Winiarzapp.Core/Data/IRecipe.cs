using System.Collections.Generic;

namespace Winiarzapp.Core.Data
{
    public interface IRecipe
    {
        /// <summary>
        /// Zwraca <c>true</c> gdy przepis jest poprawny. 
        /// </summary>
        bool Validate();

        /// <summary>
        /// Nazwa przepisu. 
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Opis przepisu.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Składniki przepisu.
        /// </summary>
        IEnumerable<Ingredient> Ingredients { get; }

        /// <summary>
        /// Dodaj składnik.
        /// </summary>
        void AddIngredient(Ingredient ingredient);

        /// <summary>
        /// Usuń składnik.
        /// </summary>
        void RemoveIngredient(Ingredient ingredient);
    }
}
