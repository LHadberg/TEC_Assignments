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

namespace WPFLogin
{
    /// <summary>
    /// Interaction logic for LoginMenu.xaml
    /// </summary>
    public partial class AccountCreation : Window
    {
        public AccountCreation()
        {
            InitializeComponent();
            MainWindow m = new MainWindow();
            m.people.Add(new Person { FirstName = "Toss", LastName = "Pot", AccountName = "Boinko", EMail = "Donkey@Kong.com", Password = "Bananaman" });
        }

        //Button_Click event when "messageWarning" button is pressed
        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            //
            string fullName = enterFirstName.Text + " " + enterLastName.Text;
            //Check if passwords match
            if (enterPassword.Password == confirmPassword.Password)
            {
                if (MessageBox.Show("Is this information correct?", "Confirmation required", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel && enterPassword.Password == confirmPassword.Password)
                {
                    MessageBox.Show("No information had been added. Try again");
                }
                else
                {
                    MainWindow m = new MainWindow();
                    m.people.Add(new Person
                    {
                        FirstName = enterFirstName.Text,
                        LastName = enterLastName.Text,
                        AccountName = enterAccountName.Text,
                        EMail = enterEmail.Text,
                        Password = enterPassword.Password
                    });
                    m.myComboBox.Items.Refresh();
                    MessageBox.Show($"The user: {  fullName.ToUpper() } has been added.");
                    MainWindow fisk = new MainWindow();
                    fisk.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match. Try again", "Invalid info", MessageBoxButton.OK);
            }
        }
    }
}
