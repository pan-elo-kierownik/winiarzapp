using System;
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

        public RecipeList()
        {
            InitializeComponent();
        }

        public void Initialize(IRecipeSource recipeSource)
        {
            this.recipeSource = recipeSource;

            //TODO: Nasłuchuj i reaguj na zmiany w źródle przepisów.
            //TODO: Nasłuchuj i reaguj na zmiany frazy filtrującej wyniki.

            StackPanel stackPanel = FindName("StackPanel") as StackPanel;

            // Dodanie pustych elementów żeby zapełnić miejsce. Do usunięcia.
            stackPanel.Children.Add(new ListElement());
            stackPanel.Children.Add(new ListElement());
            stackPanel.Children.Add(new ListElement());
            stackPanel.Children.Add(new ListElement());
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
