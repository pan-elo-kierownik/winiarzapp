using System;
using System.Collections.Generic;

namespace Winiarzapp.Core.Data
{
    /// <summary>
    /// Rekord przechowujący wszystkie historyczne wersje danego przepisu. 
    /// 
    /// Dlaczego?
    /// Przykład: Historyczne nastawienie zostaje zapisane dla rewizji 3 przepisu X. Przepis został zedytowany. Historyczne nastawienie nadal będzie mogło wyświetlać poprawny przepis, gdyż istnieje historia rewizji. 
    /// </summary>
    [Serializable]
    public class RecipeRecord
    {
        private Dictionary<Recipe, int> revisions = new Dictionary<Recipe, int>();
        public int CurrentRevision { get; set; }
        public Guid RecipeGuid { get; set; }

        public RecipeRecord()
        {
            CurrentRevision = 0;
            RecipeGuid = Guid.NewGuid(); // Unikalny Guid przepisu.
        }

        /// <summary>
        /// Dodaj nową rewizję przepisu. True, jeśli dodano pomyślnie, false jeśli identyczny przepis już istnieje.
        /// </summary>
        public bool AddNewRevision(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zwraca true, jeśli przepis znajduje się w rekordzie.
        /// </summary>
        public bool ContainsRevision(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public Recipe GetRevision(int revisionId)
        {
            //TODO: Znajdź i zwróć daną rewizję przepisu. Jeśli go nie ma, to zwróć null.
            throw new NotImplementedException();
        }
    }
}
