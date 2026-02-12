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
    /// Interaction logic for UserControlinformation.xaml
    /// </summary>
    public partial class UserControlinformation : UserControl
    {
        public UserControlinformation()
        {
            InitializeComponent();
        }
        public UserControlinformation(ContantDetailsInform contact)
        {
           InitializeComponent();
            this.firstName.Text = contact.ContactfirstName;
            this.lastName.Text = contact.ContactlastName;
            this.email.Text = contact.Contactemail;
            this.telephone.Text = contact.Contactphone;
           this.GenderComboBox.SelectedItem = contact.Contactgender;
            this.dateOfBirth.SelectedDate = contact.Contactborn;
            this.passwordDisplay.Text = contact.Contactpassword;

        }
    }
}
