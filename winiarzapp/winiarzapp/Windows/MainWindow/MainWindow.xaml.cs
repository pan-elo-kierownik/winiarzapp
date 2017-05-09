using System.Windows;
using winiarzapp.Components;
using Winiarzapp.Core.Data;

namespace winiarzapp
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

            // Inicializacja kontrolek.
            RecipeList recipeList = FindName("RecipeList") as RecipeList;
            recipeList.Initialize(recipeSource);

            //TODO: Powiązać eventy/handlery
        }
    }
}
