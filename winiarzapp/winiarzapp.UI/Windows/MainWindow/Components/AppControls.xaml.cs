using System.Windows.Controls;

namespace winiarzapp.UI.Windows.MainWindow.Components
{
    /// <summary>
    /// Kontrolka służąca za nawigację. Powinna posiadać 3 przyciski: Pomoc, Historia oraz Dodaj przepis.
    /// </summary>
    public partial class AppControls : UserControl
    {
        public AppControls()
        {
            InitializeComponent();
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

        }
    }
}
