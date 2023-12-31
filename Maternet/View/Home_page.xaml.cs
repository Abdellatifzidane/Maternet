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
using System.Windows.Shapes;
using Maternet.Modele;

namespace Maternet.View
{
    /// <summary>
    /// Logique d'interaction pour Home_page.xaml
    /// </summary>
    public partial class Home_page : Window
    {
        public Home_page()
        {
            InitializeComponent();
            userId.Content = Session.CurrentUserId;

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Session.Logout();
            Close();
            Root root = new Root();
            root.ShowDialog();  
        }
    }
}
