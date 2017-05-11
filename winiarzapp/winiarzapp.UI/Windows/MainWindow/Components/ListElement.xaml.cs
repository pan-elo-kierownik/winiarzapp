using System.Windows.Controls;
using Winiarzapp.Core.Data;

namespace winiarzapp.UI.Windows.MainWindow.Components
{
    /// <summary>
    /// Pojedynczy element listy. Powinien móc wyświetlać podstawowe informacje o przepisie (Nazwa oraz liczba zapisanych nastawień)
    /// </summary>
    public partial class ListElement : UserControl
    {
        public ListElement()
        {
            InitializeComponent();
        }

        public void RenderRecord(RecipeRecord record)
        {
            //TODO: Zaktualizuj wygląd elementu by odzwierciedlał rekord podany jako argument.
        }
    }
}
