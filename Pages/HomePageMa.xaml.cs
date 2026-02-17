using Model;
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

namespace WpfTali
{
    /// <summary>
    /// Interaction logic for HomePageMa.xaml
    /// </summary>
    public partial class HomePageMa : Page
    {
        public HomePageMa()
        {
            InitializeComponent();
        }
        public HomePageMa(Manager manager)
        {
            InitializeComponent();
            List<ContantDetailsInform> contacts = new List<ContantDetailsInform>();
            contacts.Add(new ContantDetailsInform
            {
                ContactfirstName = manager.First_name,
                ContactlastName = manager.Last_name,
                Contactemail = manager.Email,
                Contactphone = manager.Telephone,
                Contactborn = manager.Born_date,
                Contactgender = manager.Id_gender.Id == 1 ? "Male" : (manager.Id_gender.Id == 2 ? "Female" : "Other"),
                Contactpassword = manager.Pass

            });
            foreach (ContantDetailsInform contact in contacts)
            {
                UserControlinformation userControl = new UserControlinformation(contact);
                userControl.MyEvent += UserControlinformation_EventHandler;
                this.spContacts.Children.Add(userControl);
            }
        }
        private void UserControlinformation_EventHandler(object sender, EventArgs e)
        {
            if (sender is UserControlinformation spcificUserControl)
            {
                ContantDetailsInform contactData = spcificUserControl.ContactData;
                string contactfirstName = contactData.ContactfirstName;
                string contactlastName = contactData.ContactlastName;
                string contactemail = contactData.Contactemail;
                string contactphone = contactData.Contactphone;
                DateTime? contactborn = contactData.Contactborn;
                string contactgender = contactData.Contactgender;
                string contactpassword = contactData.Contactpassword;
                MessageBox.Show($"First Name: {contactfirstName}\nLast Name: {contactlastName}\nEmail: {contactemail}\nPhone: {contactphone}\nBorn Date: {contactborn}\nGender: {contactgender}\nPassword: {contactpassword}");
            }
            else
            {
                MessageBox.Show("Sender is not a UserControlinformation object.");
            }
        }
    }
}
