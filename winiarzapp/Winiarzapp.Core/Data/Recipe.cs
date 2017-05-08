using System;
using System.Collections.Generic;

namespace Winiarzapp.Core.Data
{
    /// <summary>
    /// Model przepisu na wino. Zawiera listę składników oraz ich proporcje.
    /// </summary>
    public class Recipe : IRecipe
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<Ingredient> Ingredients => throw new NotImplementedException();

        public void AddIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void RemoveIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
