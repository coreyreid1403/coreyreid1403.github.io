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
using System.Windows.Shapes;

namespace FInace
{
    /// <summary>
    /// Interaction logic for Contr.xaml
    /// </summary>
    public partial class Contr : Window
    {
        public Contr()
        {
            InitializeComponent();
            contButton1.Content = functions.firstContributor.Name;
            contButton2.Content = functions.secondContributor.Name;
        }

        private void Cont1(object sender, RoutedEventArgs e)
        {
            functions.currentCont = 1;
            AddFunds addFundsPage = new AddFunds();
            addFundsPage.Show();
            this.Close();
        }

        private void Cont2(object sender, RoutedEventArgs e)
        {
            functions.currentCont = 2;
            AddFunds addFundsPage = new AddFunds();
            addFundsPage.Show();
            this.Close();
        }
    }
}
