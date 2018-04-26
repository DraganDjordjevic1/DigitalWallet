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

namespace DigitalWallet
{
    public partial class CreateEditAccount : Page
    {
        public CreateEditAccount()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            AccountTeacher accountTeacher = new AccountTeacher();
            NavigationService.Navigate(accountTeacher);
        }

        private void SaveAccount_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
