using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Winiarzapp.Core.Data;

namespace winiarzapp.UI.Windows.VineCreator
{
    /// <summary>
    /// Logika interakcji dla klasy VineCreator.xaml
    /// </summary>
    public partial class VineCreator : Window
    {


        public VineCreator()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_Nastaw(object sender, RoutedEventArgs e) // przycisk zamykający okno kreatora win
        {
            this.Close();
        }

        private void Button_Click_AddToHistory(object sender, RoutedEventArgs e) // przycisk dodający do historii
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e) // chceckbox odpowiedzialny za komentarz
        {

        }
    }
}
