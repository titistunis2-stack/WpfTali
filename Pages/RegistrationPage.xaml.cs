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
using Model;
using Service;
using WpfTali.Pages;

namespace WpfTali
{
    /// <summary>
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();

        }
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = pName.Text;
            string lastName = lName.Text;
            string email = Email.Text;
            string userName = UserName.Text;
            string phone = telephone.Text;
            string password = Pass.Password;
            string gender = (GenderComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            DatePicker born=bornDate;
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select your gender");
                return;
            }

            Apiservice apiservice = new Apiservice();

            // קבלת סוג המשתמש שנבחר
            string selectedUserType =
                (UserTypeComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (string.IsNullOrEmpty(selectedUserType))
            {
                MessageBox.Show("Please select kind of user");
                return;
            }

            switch (selectedUserType)
            {
                case "Trainee":
                    Trainee trainee = new Trainee()
                    {
                        First_name = firstName,
                        Last_name = lastName,
                        Email = email,
                        Telephone = phone,
                        User_name = userName,
                        Pass = password

                    };

                    apiservice.InsertATrainee(trainee);
                    NavigationService.Navigate(new HomePageTe());
                    break;

                case "Trainer":
                    Trainer trainer = new Trainer()
                    {
                        First_name = firstName,
                        Last_name = lastName,
                        Email = email,
                        Telephone = phone,
                        User_name = userName,
                        Pass = password
                    };

                    apiservice.InsertATrainer(trainer);
                    NavigationService.Navigate(new HomePageTr());
                    break;

                case "Manager":
                    Manager manager = new Manager()
                    {
                        First_name = firstName,
                        Last_name = lastName,
                        Email = email,
                        Telephone = phone,
                        User_name = userName,
                        Pass = password
                    };

                    apiservice.InsertAManager(manager);
                    NavigationService.Navigate(new HomePageMa());
                    break;

            }
        }


        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());   
        }

        private void AboutUsButton_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new AboutUsPage());
        }
    }
}
