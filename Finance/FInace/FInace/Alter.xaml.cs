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
 * Alter Accounts and Child Accounts
 ***********************************/
namespace FInace
{
    /// <summary>
    /// Interaction logic for Alter.xaml
    /// </summary>
    public partial class Alter : Window
    {
        public Alter()
        {
            InitializeComponent();

        }
        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            //Pop up
            MessageBoxResult dialogResult = MessageBox.Show("Are you sure these values are correct? There is no going back...", "Double Check", MessageBoxButton.OKCancel);
            if (dialogResult.ToString() == "OK")
            {
                //Alter Savings
                string name = savingsNametextBox.Text;
                double amount = Convert.ToDouble(savingtextBox.Text);
                functions.alterSavings(name, amount);
                name = savingsNametextBox1.Text;
                amount = Convert.ToDouble(savingtextBox1.Text);
                functions.alterSavings(name, amount);
                name = savingsNametextBox2.Text;
                amount = Convert.ToDouble(savingtextBox2.Text);
                functions.alterSavings(name, amount);
                
                //Alter Spending
                name = spendingNametextBox.Text;
                amount = Convert.ToDouble(spendingtextBox.Text);
                functions.alterSpending(name, amount);
                name = spendingNametextBox1.Text;
                amount = Convert.ToDouble(spendingtextBox1.Text);
                functions.alterSpending(name, amount);
                name = spendingNametextBox2.Text;
                amount = Convert.ToDouble(spendingtextBox2.Text);
                functions.alterSpending(name, amount);

                //Alter Tithe
                name = titheNametextBox.Text;
                amount = Convert.ToDouble(tithetextBox.Text);
                functions.alterTith(name, amount);
                name = titheNametextBox1.Text;
                amount = Convert.ToDouble(tithetextBox1.Text);
                functions.alterTith(name, amount);
                name = titheNametextBox2.Text;
                amount = Convert.ToDouble(tithetextBox2.Text);
                functions.alterTith(name, amount);





            }
            functions.createFile();
            this.Close();
        }
    }
}
