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
 * Add or Delete a Catagory
 ***********************************/
namespace FInace
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddCat : Window
    {
        public AddCat()
        {
            InitializeComponent();
            //Fill listBox with the different catagories
            foreach (KeyValuePair<string, string> kvp in functions.spentTypes)
            {
                listBox.Items.Add(kvp.Key);
            }
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void add(object sender, RoutedEventArgs e)
        {
            //add catagory to dict
            functions.addSpentType(catName.Text, Convert.ToDouble(catNumber.Text));

            //add to listBox
            listBox.Items.Add(catName.Text);

            //write the memory file
            functions.createFile();
        }

        private void listBox_Selected(object sender, RoutedEventArgs e)
        {
            //Show the amount in the Catagory when clicked
            if (listBox.SelectedIndex != -1)
            {
                valueLable.Content = listBox.SelectedItem  + " " + functions.spentTypes[listBox.SelectedItem.ToString()];
            }

        }

        private void remove(object sender, RoutedEventArgs e)
        {
            //pop-up alert
            if(functions.errorMessageOkCancel("Are you sure you want to delete" + listBox.SelectedItem.ToString() + " and its content forever?"))
            {
                //Remove selected item from Dict
                functions.spentTypes.Remove(listBox.SelectedItem.ToString());
                //Remove selected from listBox
                int i = listBox.SelectedIndex;
                valueLable.Content = "";
                listBox.SelectedIndex = -1;
                listBox.Items.RemoveAt(i);
            }
            //write memory file
            functions.createFile();
        }
    }
}
