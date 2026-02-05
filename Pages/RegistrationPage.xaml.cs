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
            string a = pName.Text;
            string b = lName.Text;
            string c = Email.Text;
            string d = UserName.Text;
            string h;
            string j = idNum.Text;
            string k = gender.Text;
            string m = telephone.Text;
            string p = Pass.Password;


            Trainee trainee = new Trainee() { First_name = a, Last_name = b, Email = c, Telephone = m, User_name = d, Pass = p, };

            Apiservice apiservice = new Apiservice();
            apiservice.InsertATrainee(trainee);
            apiservice.InsertAManager(manager);
            apiservice.InsertATrainer(trainer);




            NavigationService.Navigate(new RegistrationPage());
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
