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
using DoomsdayManager.Pages;

namespace DoomsdayManager
{
    /// <summary>
    /// Interaction logic for Magazine.xaml
    /// </summary>
    /// 
    
    public partial class Magazine : Page
    {
        public List<Item> mItems = new List<Item>();
        public string PageName = "Magazine";
        public Magazine()
        {
            InitializeComponent();
            this.Title.Text = PageName;

            GetDataGridData();
        }

        private void GetDataGridData()
        {
            DataAccess db = new DataAccess();
            mItems = db.GetItemList();
            MagazineData.ItemsSource = mItems;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();

            //users = db.GetUser("latka");

            //Output.DataContext = users;
            //Output.DisplayMemberPath = "FullInfo";

            //Output.Text = users[0].FirstName;


        }
        private void OpenWindowToAddNewItemClick(object sender, RoutedEventArgs e)
        {
            MagazineGrid.Visibility = Visibility.Hidden;
            AddNewItem content = new AddNewItem();
            MagazineMainFrame.Content = content;
        }
    }
}
