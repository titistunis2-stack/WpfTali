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

namespace WpfTali
{
    /// <summary>
    /// Interaction logic for HomePageTe.xaml
    /// </summary>
    public partial class HomePageTe : Page
    {

        public HomePageTe(Trainee trainee)
        {
            InitializeComponent();
            List<ContantDetailsInform> contacts = new List<ContantDetailsInform>();
            contacts.Add(new ContantDetailsInform
            {
                ContactfirstName = trainee.First_name,
                ContactlastName = trainee.Last_name,
                Contactemail = trainee.Email,
                Contactphone = trainee.Telephone,
                Contactborn = trainee.Born_date
            }); 
            foreach (ContantDetailsInform contact in contacts)
            {
                UserControlinformation userControl = new UserControlinformation(contact);
                this.spContacts.Children.Add(userControl);
            }
        }
    }
}
