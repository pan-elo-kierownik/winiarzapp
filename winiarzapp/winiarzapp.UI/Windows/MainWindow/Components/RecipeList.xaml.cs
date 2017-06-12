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


            Recipe r = new Recipe(new Ingredient[] {
                new Ingredient("Test Ingredient", "Bababa", 0.5, Unit.LITER),
                new Ingredient("Test Ingredient2", "Asdfg", 0.5, Unit.KILOGRAM)
            }, "Test Recipe", "Awesome recipe!");



            // Dodanie pustych elementów żeby zapełnić miejsce. Do usunięcia.
            for (int i = 0; i < 5; i++)
            {
                var x = new ListElement();
                x.RenderRecord(r);
                stackPanel.Children.Add(x);
            }

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
