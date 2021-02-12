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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DoomsdayManager
{
    /// <summary>
    /// Interaction logic for Residents.xaml
    /// </summary>
    public partial class Residents : Page
    {
        public string PageName = "Residents";
        public Residents()
        {

            InitializeComponent();
            this.Title.Text = PageName;
        }

        private void OpenWindowToAddNewResidentClick(object sender, RoutedEventArgs e)
        {
            ResidentsGrid.Visibility = Visibility.Hidden;
            AddNewResident content = new AddNewResident();
            ResidentsMainFrame.Content = content;
        }
    }
}
