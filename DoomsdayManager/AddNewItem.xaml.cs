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
using DoomsdayManager.Data;

namespace DoomsdayManager.Pages
{
    /// <summary>
    /// Interaction logic for AddNewItem.xaml
    /// </summary>
    public partial class AddNewItem : Page
    {
        public AddNewItem()
        {
            InitializeComponent();
        }

        private void AddNewItem1_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertNewItem(NameInput.Text, QuantityInput.Text, WeightInput.Text, SizeInput.Text, KcalInput.Text, ProteinInput.Text, CarbsInput.Text, FatInput.Text);
        }
    }
}
