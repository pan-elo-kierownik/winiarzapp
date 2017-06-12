using System.Windows.Controls;
using Winiarzapp.Core.Data;

namespace winiarzapp.UI.Windows.MainWindow.Components
{
	/// <summary>
	/// Pojedynczy element listy. Powinien móc wyświetlać podstawowe informacje o przepisie (Nazwa oraz liczba zapisanych nastawień)
	/// </summary>
	/// 
	
    public partial class ListElement : UserControl
    {

		Recipe recipe;

		public ListElement()
        {

			InitializeComponent();

			//LabelListElement Nazwa konrtrolki label
		
		}

        public void RenderRecord(Recipe recipe)
        {
			this.recipe = recipe;

			LabelListElement.Content = recipe.Name;

			//TODO: Zaktualizuj wygląd elementu by odzwierciedlał rekord podany jako argument.
		}
	}
}
