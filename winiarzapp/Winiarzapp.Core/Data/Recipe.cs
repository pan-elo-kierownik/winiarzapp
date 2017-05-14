using System;
using System.Collections.Generic;

namespace Winiarzapp.Core.Data
{
    /// <summary>
    /// Model przepisu na wino. Zawiera listę składników oraz ich proporcje.
    /// </summary>
    [Serializable]
    public class Recipe : IComparable
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<Ingredient> Ingredients => throw new NotImplementedException();
        public Guid UniqueID { get; set; }

        public Recipe(Ingredient[] ingredients, string name, string description)
        {
            UniqueID = Guid.NewGuid();
            //TODO: Sprawdź czy proporcje przepisów sumują się do 1.0
            //TODO: Zapisz składniki.
        }

        public int CompareTo(object obj)
        {
            //TODO: Sprawdź, czy argument jest tym przepisem.
            throw new NotImplementedException();
        }
    }
}
