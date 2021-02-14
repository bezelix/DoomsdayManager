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

namespace DoomsdayManager
{
    /// <summary>
    /// Interaction logic for AddNewResident.xaml
    /// </summary>
    public partial class AddNewResident : Page
    {
        public AddNewResident()
        {
            InitializeComponent();
        }

        private void AddNewItem1_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertNewResidents(NameInput.Text, LastNameInput.Text, GenderInput.Text, WeightInput.Text, HeightInput.Text, BirthDate.SelectedDate.ToString());
        }
    }
}
