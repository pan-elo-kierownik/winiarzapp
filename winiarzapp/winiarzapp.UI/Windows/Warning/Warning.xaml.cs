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

namespace winiarzapp.UI.Windows.Warning
{
    /// <summary>
    /// Logika interakcji dla klasy Warning.xaml
    /// </summary>
    public partial class Warning : Window
    {
        public Warning()
        {
            InitializeComponent();
        }

        private void Button_Click_Close_Warning(object sender, RoutedEventArgs e)
        {
                this.Close();
        }
    }
}
