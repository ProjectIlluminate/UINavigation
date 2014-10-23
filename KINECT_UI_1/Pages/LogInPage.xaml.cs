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

using KINECT_UI_1.Pages;//enables connection to other pages

namespace KINECT_UI_1.Pages
{
    /// <summary>
    /// Interaction logic for LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        public LogInPage()
        {
            InitializeComponent();

        }

        //User Name
        private void tbName_GotFocus(object sender, RoutedEventArgs e)
        {
            tbName.Text = "";
        }

        //User Password
        private void passwordBx_GotFocus(object sender, RoutedEventArgs e)
        {
            //public bool passwordValidation
            //{
            //    get{
            //        if (tbName.Text == passwordBx.ToString())
            //        return true;
            //            else
            //            return false;
            //        }
            //}

            App.NavigationFrame.Navigate(new StartPage());//Navigate to Start page
        }

    }
}
