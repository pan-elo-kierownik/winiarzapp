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
		    }

        public void RenderRecord(Recipe recipe)
        {
          this.recipe = recipe;
          //LabelListElement Nazwa konrtrolki label
          LabelListElement.Content = recipe.Name;
		    }

        private void LabelListElement_MouseDoubleClick(object sender, System.Windows.RoutedEventArgs e) //podwójne kliknięcie powodujące otwarcie Kreatora wina
        {
            Winiarzapp.UI.Services.HelperService.ShowVineCreator(recipe); //wywołanie metody wyświetlającej okienko z kreatorem wina
        }
    }
}
