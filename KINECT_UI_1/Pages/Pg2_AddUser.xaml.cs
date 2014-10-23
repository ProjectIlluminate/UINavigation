using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;//new namespace for Observable collection
using System.IO;//new namespace for writing to text file
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
using System.Xml;//new namespace for writing to XML

namespace KINECT_UI_1.Pages
{
    /// <summary>
    /// Interaction logic for Pg2_AddUser.xaml
    /// </summary>
    public partial class Pg2_AddUser : Page
    {
        private ObservableCollection<User> Users = new ObservableCollection<User>();

        public Pg2_AddUser()
        {
            InitializeComponent();

            //Loads XML into an XMLDocument object and saves it out to a file
            //Create the XML document
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<item><name>User Name</name></item>");

            //Adda a price element
            XmlElement newElement = doc.CreateElement("Height");
            newElement.InnerText = "166cm";
            doc.DocumentElement.AppendChild(newElement);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            //Save the document to a file and auto-indent the output
            XmlWriter writer = XmlWriter.Create("Userdata.xml", settings);
            doc.Save(writer);

        }

        private void tbName_GotFocus(object sender, RoutedEventArgs e)
        {
            tbName.Text = "";
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            //User newUser = new User(tbName.Text, DateTime.Parse("10.10.1258"), Convert.ToInt32(tbEstHeight.Text), Convert.ToInt32(tbActHeight.Text), Convert.ToInt32(tbAvgHeight.Text));
            User newUser = new User(tbName.Text, DateTime.Today, Convert.ToInt32(tbEstHeight.Text), Convert.ToInt32(tbActHeight.Text), Convert.ToInt32(tbAvgHeight.Text));
            Users.Add(newUser);//Add newly created user to Users collection

            lstBxUserProfile.Items.Add(newUser);
        }

        private void btnSaveUser_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = new string[lstBxUserProfile.Items.Count];
            User currentUsers;

            for (int i = 0; i < lstBxUserProfile.Items.Count; i++)
            {
                currentUsers = (User)lstBxUserProfile.Items.GetItemAt(i);
                lines[i] = currentUsers.FileWriteFormat();
            }
            File.WriteAllLines("UserList.txt", lines);

            MessageBox.Show("User details have been saved");
        }
    }
}
