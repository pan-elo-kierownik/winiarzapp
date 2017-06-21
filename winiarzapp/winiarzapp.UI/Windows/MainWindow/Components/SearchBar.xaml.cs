using System.Windows.Controls;

namespace winiarzapp.UI.Windows.MainWindow.Components
{
    public delegate void QueryChangedHandler(string query);

    /// <summary>
    /// Komponent służący do filtrowania wyników.
    /// </summary>
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Zdarzenie wywołane gdy zmieni się fraza.
        /// </summary>
        public event QueryChangedHandler QueryChanged;

        /// <summary>
        /// Metoda wywoływana kiedy w SearchBarze zmieniony jest tekst.
        /// </summary>
        private void SearchQuery_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.MaxLength = 20;

            if (QueryChanged != null)
                QueryChanged(textBox.Text ?? "");
        }
    }
}