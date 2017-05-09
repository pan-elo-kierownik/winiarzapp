using System;
using System.Windows.Controls;
using Winiarzapp.Core.Data;

namespace winiarzapp.Components
{
    /// <summary>
    /// Lista przepisów.
    /// </summary>
    public partial class RecipeList : UserControl
    {
        IRecipeSource recipeSource;

        public RecipeList()
        {
            InitializeComponent();
        }

        public void Initialize(IRecipeSource recipeSource)
        {
            this.recipeSource = recipeSource;

            //TODO: Nasłuchuj i reaguj na zmiany w źródle przepisów.
        }

        /// <summary>
        /// Przebuduj listę by wyświetlać elementy pasujące do podanej frazy.
        /// </summary>
        public void Filter(string query)
        {
            throw new NotImplementedException();
        }
    }
}
