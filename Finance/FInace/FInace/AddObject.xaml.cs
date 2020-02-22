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
 * Add a new Child or Contributor
 ***********************************/
namespace FInace
{
//make it so we dont overload Objects, delete buttons
    public partial class AddObject : Window
    {
        public AddObject()
        {
            InitializeComponent();
            //Fill listBox with Children
            int i = 0;
            while (i < functions.child.Count)
            {
                childListBox.Items.Add(functions.child[i]);
                i += 3;
            }
            i = 0;
            //Fill listBox with Contributors
            while (i < functions.contributors.Count)
            {
                contListBox.Items.Add(functions.contributors[i]);
                i += 6;
            }
            if (contListBox.Items.Count == 2)
            {
                addContButton.Visibility = Visibility.Hidden;
                contAddLable.Visibility = Visibility.Visible;
            }
            if (childListBox.Items.Count == 6)
            {
                addChildButton.Visibility = Visibility.Hidden;
                childAddLable.Visibility = Visibility.Visible;
            }
        }

        private void child(object sender, RoutedEventArgs e)
        {
            //add child to list
            functions.child.Add(childNameTextBox.Text);
            functions.child.Add(collegeTextBox.Text);
            functions.child.Add(monthlyTextBox.Text);
            //add to listBox
            childListBox.Items.Add(childNameTextBox.Text);
            //hide add button if at 6 children
            if (childListBox.Items.Count == 6)
            {
                addChildButton.Visibility = Visibility.Hidden;
                childAddLable.Visibility = Visibility.Visible;
            }
            functions.createFile();
        }

        private void cont(object sender, RoutedEventArgs e)
        {
            //add cont to list
            functions.contributors.Add(contNameTextBox.Text);
            functions.contributors.Add(payTextBox.Text);
            functions.contributors.Add(fourKTxtBox.Text);
            functions.contributors.Add(matchTextBox.Text);
            functions.contributors.Add(savingsTextBox.Text);
            functions.contributors.Add(titheTextBox.Text);
            //add to list box
            contListBox.Items.Add(contNameTextBox.Text);
            //remove add button if at 2 contributors
            if (contListBox.Items.Count == 2)
            {
                addContButton.Visibility = Visibility.Hidden;
                contAddLable.Visibility = Visibility.Visible;
            }
            functions.createFile();
        }

        private void deleteChild(object sender, RoutedEventArgs e)
        {
            if (childListBox.SelectedIndex != -1)
            {
                //make sure add button is visable
                addChildButton.Visibility = Visibility.Visible;
                childAddLable.Visibility = Visibility.Hidden;
                // remove from child list
                functions.child.RemoveAt(functions.child.IndexOf(childListBox.SelectedItem) + 2);
                functions.child.RemoveAt(functions.child.IndexOf(childListBox.SelectedItem) + 1);
                functions.child.RemoveAt(functions.child.IndexOf(childListBox.SelectedItem));
                //removes selected from list box
                int i = childListBox.SelectedIndex;
                childListBox.SelectedIndex = -1;
                childListBox.Items.RemoveAt(i);
                childListBox.SelectedIndex = -1;
                functions.createFile();
            }
            else
            {
                functions.errorMessage("Please select a Child to delete.");
            }
        }

        private void deleteCont(object sender, RoutedEventArgs e)
        {
            if (contListBox.SelectedIndex != -1)
            {
                //make sure add button is visable
                addContButton.Visibility = Visibility.Visible;
                contAddLable.Visibility = Visibility.Hidden;
                //remove from cont list
                functions.contributors.RemoveAt(functions.contributors.IndexOf(contListBox.SelectedItem) + 5);
                functions.contributors.RemoveAt(functions.contributors.IndexOf(contListBox.SelectedItem) + 4);
                functions.contributors.RemoveAt(functions.contributors.IndexOf(contListBox.SelectedItem) + 3);
                functions.contributors.RemoveAt(functions.contributors.IndexOf(contListBox.SelectedItem) + 2);
                functions.contributors.RemoveAt(functions.contributors.IndexOf(contListBox.SelectedItem) + 1);
                functions.contributors.RemoveAt(functions.contributors.IndexOf(contListBox.SelectedItem));
                //removes selected from list box
                int i = contListBox.SelectedIndex;
                contListBox.SelectedIndex = -1;
                contListBox.Items.RemoveAt(i);
                contListBox.SelectedIndex = -1;
                functions.createFile();
            }
            else
            {
                functions.errorMessage("Please select a Contributor to delete.");
            }
        }

        private void childListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (childListBox.SelectedIndex != -1)
            {
                //show the selected Childs data in the textviews
                childNameTextBox.Text = functions.child[functions.child.IndexOf(childListBox.SelectedItem)].ToString();
                collegeTextBox.Text = functions.child[functions.child.IndexOf(childListBox.SelectedItem) + 1].ToString();
                monthlyTextBox.Text = functions.child[functions.child.IndexOf(childListBox.SelectedItem) + 2].ToString();
            }
        }

        private void contListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (contListBox.SelectedIndex != -1)
            {
                //show the selected Cont data in the textviews
                contNameTextBox.Text = functions.contributors[functions.contributors.IndexOf(contListBox.SelectedItem)].ToString();
                payTextBox.Text = functions.contributors[functions.contributors.IndexOf(contListBox.SelectedItem) + 1].ToString();
                fourKTxtBox.Text = functions.contributors[functions.contributors.IndexOf(contListBox.SelectedItem) + 2].ToString();
                matchTextBox.Text = functions.contributors[functions.contributors.IndexOf(contListBox.SelectedItem) + 3].ToString();
                savingsTextBox.Text = functions.contributors[functions.contributors.IndexOf(contListBox.SelectedItem) + 4].ToString();
                titheTextBox.Text = functions.contributors[functions.contributors.IndexOf(contListBox.SelectedItem) + 5].ToString();
            }
        }

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
