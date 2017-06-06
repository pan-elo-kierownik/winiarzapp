using System.Windows;
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
            QueryChanged += new QueryChangedHandler(Query);
        }

        /// <summary>
        /// Zdarzenie wywołane gdy zmieni się fraza.
        /// </summary>
        public event QueryChangedHandler QueryChanged;

        private void SearchQuery_TextChanged(object sender, TextChangedEventArgs e)
        {
            //TODO: W momencie, gdy zmienia się zawartość pola wyszukiwania powinno zostać wywołane wydarzenie (ISearchBar::QueryChanged)
            TextBox textBox = (TextBox)sender;
            textBox.MaxLength = 20;

            Query(textBox.Text);
        }

        static void Query(string s)
        {
            //nie wiem
        }
    }
}
