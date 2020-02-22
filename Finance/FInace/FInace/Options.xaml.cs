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
/************************************
 * Buttons to other pages
 ***********************************/
namespace FInace
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
        }

        private void breakDown(object sender, RoutedEventArgs e)
        {
            Breakdown breakdownPage = new Breakdown();
            breakdownPage.Show();
        }

        private void addObject(object sender, RoutedEventArgs e)
        {
            AddObject addObjectPage = new AddObject();
            addObjectPage.Show();
        }

        private void monthly(object sender, RoutedEventArgs e)
        {
            Monthly monthlyPage = new Monthly();
            monthlyPage.Show();
        }

        private void restart(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialogResult = MessageBox.Show("You ... you really sure??? There is no going back ... no second chance ... no reviving this.", "DANGER", MessageBoxButton.OKCancel);
            if (dialogResult.ToString() == "OK")
            {
                functions.clearFile();
                IntroPage introPage = new IntroPage();
                introPage.Show();
            }
        }

        private void sub(object sender, RoutedEventArgs e)
        {
            SubAccount subPage = new SubAccount();
            subPage.Show();
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
