﻿using System;
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
    /// Interaction logic for Magazine.xaml
    /// </summary>
    /// 
    
    public partial class Magazine : Page
    {
        public List<User> users = new List<User>();
        public string PageName = "Magazine";
        public Magazine()
        {
            InitializeComponent();
            this.Title.Text = PageName;

            DataAccess db = new DataAccess();
            users = db.GetUser("latka");
            Output.DataContext = users;
            Output.DisplayMemberPath = "FullInfo";
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();

            users = db.GetUser("latka");

            Output.DataContext = users;
            Output.DisplayMemberPath = "FullInfo";


        }
    }
}
