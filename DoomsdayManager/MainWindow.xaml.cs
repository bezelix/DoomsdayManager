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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string ActivePageName { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Planning_Click(object sender, RoutedEventArgs e)
        {
            Planning content = new Planning();
            MainFrame.Content = content;
            this.ActivePageName = content.PageName;
        }

        private void Plan_Click(object sender, RoutedEventArgs e)
        {
            Plan content = new Plan();
            MainFrame.Content = content;
            this.ActivePageName = content.PageName;
        }

        private void Residents_Click(object sender, RoutedEventArgs e)
        {
            Residents content = new Residents();
            MainFrame.Content = content;
            this.ActivePageName = content.PageName;
        }

        private void Magazine_Click(object sender, RoutedEventArgs e)
        {
            Magazine content = new Magazine();
            MainFrame.Content = content;
            this.ActivePageName = content.PageName;
            
        }

        private void Statistics_Click(object sender, RoutedEventArgs e)
        {
            Statistics content = new Statistics();
            MainFrame.Content = content;
            this.ActivePageName = content.PageName;
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            Settings content = new Settings();
            MainFrame.Content = content;
            this.ActivePageName = content.PageName;
        }
    }
}
