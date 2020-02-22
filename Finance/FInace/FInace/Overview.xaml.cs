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
 * Overview of Accounts and Child Accounts
 ***********************************/
namespace FInace
{
    /// <summary>
    /// Interaction logic for Overview.xaml
    /// </summary>
    public partial class Overview : Window
    {
        public Overview()
        {
            InitializeComponent();
            //Sets the Ammounts in Accounts
            labelSavings.Content = functions.savings["Cash"];
            labelSpendings.Content = functions.spending["Total"];
            labelTith.Content = functions.tith["Total"];
            //toString the Children if they exist
            if (functions.child.Count > 0)
            {
                labelChild.Content = functions.firstChild.toString();
                if (functions.child.Count > 3)
                {
                    labelChild2.Content = functions.secondChild.toString();
                    if (functions.child.Count > 6)
                    {
                        labelChild3.Content = functions.thirdChild.toString();
                        if (functions.child.Count > 9)
                        {
                            labelChild4.Content = functions.fourthChild.toString();
                            if (functions.child.Count > 12)
                            {
                                labelChild5.Content = functions.fifthChild.toString();
                                if (functions.child.Count > 15)
                                {
                                    labelChild6.Content = functions.sixthChild.toString();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void alterButton(object sender, RoutedEventArgs e)
        {
            Alter alterPage = new Alter();
            alterPage.Show();
        }

        private void statsClick(object sender, RoutedEventArgs e)
        {
            //AddFunds addFundsPage = new AddFunds();
            //addFundsPage.Show();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
