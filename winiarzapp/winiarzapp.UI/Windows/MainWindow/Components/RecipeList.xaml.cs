using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Winiarzapp.Core.Data;

namespace winiarzapp.UI.Windows.MainWindow.Components
{
    /// <summary>
    /// Lista przepisów.
    /// </summary>
    public partial class RecipeList : UserControl
    {
        IRecipeSource recipeSource;
        StackPanel stackPanel;
        string query;

        public RecipeList()
        {
            InitializeComponent();
        }

        public void Initialize(IRecipeSource recipeSource)
        {
            this.recipeSource = recipeSource;

            //TODO: Nasłuchuj i reaguj na zmiany w źródle przepisów.
            //TODO: Nasłuchuj i reaguj na zmiany frazy filtrującej wyniki.
            stackPanel = FindName("StackPanel") as StackPanel;

            recipeSource.RecipesChanged += IRecipeSource_RecipesChanged;
        }

        private void IRecipeSource_RecipesChanged()
        {
            Filter(query);
            // nie wiedziałem co tutaj wrzucić, więc wrzuciłem ponowne wykonanie wyszukiwania, żeby 
            // przeszukać zmienioną bazę przepisów
        }

        private void SearchBar_QueryChanged(string query)
        {
            this.query = query;

            Filter(query);
        }

        /// <summary>
        /// Przebuduj listę by wyświetlać elementy pasujące do podanej frazy.
        /// </summary>
        public void Filter(string query)
        {
            stackPanel.Children.Clear();

            foreach (Recipe recipe in recipeSource.Recipes)
            {
               if (recipe.Name.ToLower().Contains(query.ToLower()))
               {
                    ListElement listElement = new ListElement();
                    listElement.RenderRecord(recipe);
                    stackPanel.Children.Add(listElement);
                }
            }
        }
    }
}
