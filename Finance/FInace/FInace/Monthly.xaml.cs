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
    /// Interaction logic for Monthly.xaml
    /// </summary>
    public partial class Monthly : Window
    {
        public Monthly()
        {
            InitializeComponent();
            //fill the listBox
            foreach (KeyValuePair<string, string> kvp in functions.monthly)
            {
                listBox.Items.Add(kvp.Key);
            }
        }

        private void add(object sender, RoutedEventArgs e)
        {
            if (!functions.spentTypes.ContainsKey(nameTextBox.Text.ToString())) {
                //add to monthly types
                functions.addMonthlyType(nameTextBox.Text.ToString(), Convert.ToDouble(amountTextBox.Text));
                //add to spent catagories
                functions.addSpentType(nameTextBox.Text.ToString(), Convert.ToDouble(startTextBox.Text));
                //add to listbox
                listBox.Items.Add(nameTextBox.Text.ToString());
                functions.createFile();
            }
            else
            {
                //TO DO
                functions.errorMessageYesNo("Already has a Catagory with same name, fix this later");
            }
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                functions.monthly.Remove(nameTextBox.Text);
                //removes selected from list box
                int i = listBox.SelectedIndex;
                listBox.SelectedIndex = -1;
                listBox.Items.RemoveAt(i);
                listBox.SelectedIndex = -1;
                functions.createFile();
            }
            else
            {
                functions.errorMessage("Please select a Monthly expense to Cancel.");
            }
            //Hide the things that show what is in the account
            nameSelected.Visibility = Visibility.Hidden;
            monthlyLable.Visibility = Visibility.Visible;
            totalLable.Visibility = Visibility.Visible;
        }

        private void delete(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                if (functions.errorMessageOkCancel("This will cancel " + nameTextBox.Text.ToString() + " and also Delete it from your Catagories. Do you wish to procede?"))
                {
                    //remove from monthly and spentTypes
                    functions.monthly.Remove(nameTextBox.Text);
                    functions.spentTypes.Remove(nameTextBox.Text);
                    //removes selected from list box
                    int i = listBox.SelectedIndex;
                    listBox.SelectedIndex = -1;
                    listBox.Items.RemoveAt(i);
                    listBox.SelectedIndex = -1;
                    functions.createFile();
                }
            }
            else
            {
                functions.errorMessage("Please select a Monthly expense to Delete.");
            }
            //Hide the things that show what is in the account
            nameSelected.Visibility = Visibility.Hidden;
            monthlyLable.Visibility = Visibility.Visible;
            totalLable.Visibility = Visibility.Visible;
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                nameSelected.Visibility = Visibility.Visible;
                nameSelected.Content = listBox.SelectedItem.ToString();
                monthlyLable.Visibility = Visibility.Visible;
                monthlyLable.Content = "Monthly Payment $" + functions.monthly[listBox.SelectedItem.ToString()];
                totalLable.Visibility = Visibility.Visible;
                totalLable.Content = "Total spent $" + functions.spentTypes[listBox.SelectedItem.ToString()];
            }
        }
    }
}
