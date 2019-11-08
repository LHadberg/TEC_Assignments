using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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

namespace WPFLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();

            people.Add(new Person { FirstName = "Lasse", LastName = "Hadberg", AccountName = "Yoshicide", EMail = "Yoshicide@hotmail.com", Password = "Ducktales" });
            people.Add(new Person { FirstName = "Tess", LastName = "Dummie", AccountName = "Boinko", EMail = "Donkey@Kong.com", Password = "Bananaman" });
            myComboBox.ItemsSource = people;
            myComboBox.Items.Refresh();
        }

        //If the 'Create Account' button is clicked, open the 
        private void createAccountButton_Click(object sender, RoutedEventArgs e)
        {
            AccountCreation accountCreation = new AccountCreation();
            accountCreation.Show();
            this.Close();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {

        }

        //public void readPeople()

        ////https://www.c-sharpcorner.com/UploadFile/prathore/login-and-registration-process-in-wpf-application/

        //{
        //    var allLines = File.ReadAllLines(@"C:\Users\lasha\Documents\test.txt");
        //var listOfPersons = new List<Person>();
        //    foreach (var line in allLines)
        //    {
        //        string[] splittedLines = line.Split(',');
        //        if (splittedLines != null && splittedLines.Any())
        //        {
        //            listOfPersons.Add(new Person
        //            {
        //                FirstName = splittedLines[0],
        //                LastName = splittedLines.Length > 1 ? splittedLines[1] : null,
        //                AccountName = splittedLines.Length > 2 ? splittedLines[2] : null,
        //                EMail = splittedLines.Length > 2 ? splittedLines[3] : null,
        //                Password = splittedLines.Length > 2 ? splittedLines[4] : null
        //            });
        //        }
        //    }
        //}
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
