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
        public event EventHandler MyEvent;
        public ContantDetailsInform ContactData { get;  set; }
        public UserControlinformation()
        {
            InitializeComponent();
        }
        public UserControlinformation(ContantDetailsInform contactData)
        {
            InitializeComponent();
            ContactData = contactData;
            this.firstName.Text = contactData.ContactfirstName;
            this.lastName.Text = contactData.ContactlastName;
            this.email.Text = contactData.Contactemail;
            this.telephone.Text = contactData.Contactphone;
            this.genderDisplay.Text = contactData.Contactgender;
            this.dateOfBirth.SelectedDate = contactData.Contactborn;
            this.passwordDisplay.Text = contactData.Contactpassword;
        }
    }
}
