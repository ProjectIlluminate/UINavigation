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

namespace KINECT_UI_1.Pages
{
    /// <summary>
    /// Interaction logic for ProjectIlluminate.xaml
    /// </summary>
    public partial class ProjectIlluminate : Page
    {
        public ProjectIlluminate()
        {
            InitializeComponent();
        }

        private void GoTo_LogInPage(object sender, RoutedEventArgs e)
        {
            if (App.NavigationFrame != null)
                App.NavigationFrame.Navigate(new LogInPage());
        }



    }
}
