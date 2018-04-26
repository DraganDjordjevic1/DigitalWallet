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
      public partial class Invoices : Page
      {
            public string firstname { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public int invoiceNo { get; set; }
            public int invoiceID { get; set; }
            public int age { get; set; }


            private List<Invoices> LoadCollectionData()
            {

                  CreateInvoice createinvoice = new CreateInvoice();
                  List<Invoices> accinvoices = new List<Invoices>();
                  accinvoices.Add(new Invoices())
                  {
                        createinvoice.firstName.Text = firstname;
                        createinvoice.lastName.Text = lastName;
                        createinvoice.address.Text = address;
                        createinvoice.invoiceID.Text = invoiceID.ToString();
                        createinvoice.age.Text = age.ToString();
                        createinvoice.invoice.Text = invoiceNo.ToString();
                  };
                  return accinvoices;
            }

            public Invoices()
            {
                  InitializeComponent();
                  dgInvoices.ItemsSource = LoadCollectionData();
                  dgInvoices.IsReadOnly = true;
            }

            private void CreateInvoice_Click(object sender, RoutedEventArgs e)
            {
                  CreateInvoice createInvoice = new CreateInvoice();
                  NavigationService.Navigate(createInvoice);
            }

            private void UpdateInvoice_Click(object sender, RoutedEventArgs e)
            {
                  CreateInvoice createInvoice = new CreateInvoice();
                  NavigationService.Navigate(createInvoice);
            }

            private void PayInvoice_Click(object sender, RoutedEventArgs e)
            {
                  PayInvoice payInvoice = new PayInvoice();
                  NavigationService.Navigate(payInvoice);
            }

            private void Exit_Click(object sender, RoutedEventArgs e)
            {
                  MainMenuStudent mainMenuStudent = new MainMenuStudent();
                  NavigationService.Navigate(mainMenuStudent);
            }

            private void dgInvoices_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

            }
      }
}
