using System;
using System.Windows;
using winiarzapp.UI.Windows.MainWindow.Components;
using Winiarzapp.Core.Data;

namespace winiarzapp.UI
{
    /// <summary>
    /// Główny ekran. Umieszczone na nim są komponenty przedstawiające listę przepisów, narzędzia filtrujące oraz przyciski nawigacyjne.
    /// </summary>
    public partial class MainWindow : Window
    {
        IRecipeSource recipeSource;

        public MainWindow()
        {
            InitializeComponent();

            recipeSource = new FileRecipeSource();

            // Inicjalizacja kontrolek.
            RecipeList recipeList = FindName("RecipeList") as RecipeList;
            recipeList.Initialize(recipeSource);

            appControls.Initialize(recipeSource);

            //TODO: Powiązać eventy/handlery
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            recipeSource.Dispose();

            App.Current.Shutdown();
        }
    }
}