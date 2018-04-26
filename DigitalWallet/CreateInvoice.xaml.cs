﻿using System;
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
      /// <summary>
      /// Interaction logic for CreateInvoice.xaml
      /// </summary>
      public partial class CreateInvoice : Page
      {
            public CreateInvoice()
            {
                  InitializeComponent();
            }

            private void SaveInvoice_Click(object sender, RoutedEventArgs e)
            {
                  Invoices invoices = new Invoices();
                  NavigationService.Navigate(invoices);

            }

            private void Exit_Click(object sender, RoutedEventArgs e)
            {
                  Invoices invoices = new Invoices();
                  NavigationService.Navigate(invoices);
            }
      }
}
