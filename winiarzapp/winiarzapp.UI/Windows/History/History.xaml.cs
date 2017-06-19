using System.Windows;
using Winiarzapp.Core.Data;

namespace winiarzapp.UI.Windows.History
{
    /// <summary>
    /// Okno wyświetlająće historię przepisów.
    /// </summary>
    public partial class History : Window
    {
        public History()
        {
            InitializeComponent();
        }

        public void Initialize(IRecipeHistory history)
        {
            historyView.ItemsSource = history.Batches;
        }
    }
}
