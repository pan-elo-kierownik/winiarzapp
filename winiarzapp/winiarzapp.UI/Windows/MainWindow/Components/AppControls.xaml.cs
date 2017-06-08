using System.Windows.Controls;
using Winiarzapp.Core.Data;

namespace winiarzapp.UI.Windows.MainWindow.Components
{
    /// <summary>
    /// Kontrolka służąca za nawigację. Powinna posiadać 3 przyciski: Pomoc, Historia oraz Dodaj przepis.
    /// </summary>
    public partial class AppControls : UserControl
    {
        private IRecipeSource recipeSource;

        public void Initialize(IRecipeSource recipeSource)
        {
            InitializeComponent();
            this.recipeSource = recipeSource;
        }

        private void Button_Click_Help(object sender, System.Windows.RoutedEventArgs e) //naciśnięcie przycisku help
        {
            Winiarzapp.UI.Services.HelperService.ShowHelp(); //wywołanie metody wyświetlającej okienko z plikiem pomocy
        }
        private void Button_Click_History(object sender, System.Windows.RoutedEventArgs e) //naciśnięcie przycisku history
        {
            Winiarzapp.UI.Services.HelperService.ShowHistory(); //wywołanie metody wyświetlającej okienko z historią przepisów
        }
        private void Button_Click_Add(object sender, System.Windows.RoutedEventArgs e) //naciśnięcie przycisku add
        {
            Winiarzapp.UI.Services.HelperService.ShowRecipeCreator(recipeSource); //wywołanie metody wyświetlającej kreator przepisów
        }
    }
}
