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
 * Add a Purchase
 * -subtracts it from inputed account
 * -adds it to the specified accounts
 ***********************************/
namespace FInace
{
    public partial class Purchase : Window
    {
        static double total;
        static string catagory;
        static string percent;
        static double add;
        public Purchase()
        {
            InitializeComponent();

            //fills drop down
            comboBox.Items.Add("Spending");
            comboBox.Items.Add("Savings");
            comboBox.Items.Add("Tithe");
            foreach (KeyValuePair<string, string> kvp in functions.savingsTypes)
            {
                comboBox.Items.Add(kvp.Key);
            }
            
            //Displays the Catagories
            foreach (KeyValuePair<string, string> kvp in functions.spentTypes)
            {
                listBox.Items.Add(kvp.Key);
            }

        }

        private void submit(object sender, RoutedEventArgs e)
        {
            //Displays Error pop-up if they it does not add up to 1
            error.Visibility = Visibility.Hidden;
            if (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text) + Convert.ToDouble(textBox.Text) != 1)
            {
                error.Content = "Your math sucks, try again.";
                error.Visibility = Visibility.Visible;
            }
            else {
                total = Convert.ToDouble(amountTxt.Text);
                //subtracts from said account
                if(comboBox.SelectedItem.ToString() == "Spending")
                {
                    functions.alterSpending("Total", 1 - total);
                }
                else if (comboBox.SelectedItem.ToString() == "Savings")
                {
                    functions.alterSavings("Cash", 1 - total);
                }
                else if(comboBox.SelectedItem.ToString() == "Tithe")
                {
                    functions.alterTith("Total", 1 - total);
                }
                else if (functions.savingsTypes.ContainsKey(comboBox.SelectedItem.ToString()))
                {
                    functions.errorMessage("Not set up yet for savingAccounts");
                }
                else
                {
                    functions.errorMessage("Why dont I have that account accounted for?");
                }
                    //adds specified amounts to the catagories if they are specified
                    if (button.Visibility == Visibility.Visible)
                {
                    catagory = button.Content.ToString();
                    percent = textBox1.Text;
                    add = Convert.ToDouble(total) * Convert.ToDouble(percent);
                    functions.spentTypes[catagory] = (Convert.ToDouble(functions.spentTypes[catagory]) + add).ToString();
                }
                if (button1.Visibility == Visibility.Visible)
                {
                    catagory = button1.Content.ToString();
                    percent = textBox2.Text;
                    add = Convert.ToDouble(total) * Convert.ToDouble(percent);
                    functions.spentTypes[catagory] = (Convert.ToDouble(functions.spentTypes[catagory]) + add).ToString();
                }
                if (button2.Visibility == Visibility.Visible)
                {
                    catagory = button2.Content.ToString();
                    percent = textBox3.Text;
                    add = Convert.ToDouble(total) * Convert.ToDouble(percent);
                    functions.spentTypes[catagory] = (Convert.ToDouble(functions.spentTypes[catagory]) + add).ToString();
                }
                if (button3.Visibility == Visibility.Visible)
                {
                    catagory = button3.Content.ToString();
                    percent = textBox4.Text;
                    add = Convert.ToDouble(total) * Convert.ToDouble(percent);
                    functions.spentTypes[catagory] = (Convert.ToDouble(functions.spentTypes[catagory]) + add).ToString();
                }
                if (button4.Visibility == Visibility.Visible)
                {
                    catagory = button4.Content.ToString();
                    percent = textBox.Text;
                    add = Convert.ToDouble(total) * Convert.ToDouble(percent);
                    functions.spentTypes[catagory] = (Convert.ToDouble(functions.spentTypes[catagory]) + add).ToString();
                }
                if (button5.Visibility == Visibility.Visible)
                {
                    catagory = button5.Content.ToString();
                    percent = textBox5.Text;
                    add = Convert.ToDouble(total) * Convert.ToDouble(percent);
                    functions.spentTypes[catagory] = (Convert.ToDouble(functions.spentTypes[catagory]) + add).ToString();
                }
                functions.createFile();
                this.Close();
            }
        }

        private void addCatagory(object sender, RoutedEventArgs e)
        {
            AddCat addCat = new AddCat();
            addCat.Show();
        }
        private void clearButton1(object sender, RoutedEventArgs e)
        {
            //removed the Button and txt box if clicked
            button.Visibility = Visibility.Hidden;
            textBox1.Visibility = Visibility.Hidden;
            error.Visibility = Visibility.Hidden;
        }
        private void clearButton2(object sender, RoutedEventArgs e)
        {
            //removed the Button and txt box if clicked
            button1.Visibility = Visibility.Hidden;
            textBox2.Visibility = Visibility.Hidden;
            error.Visibility = Visibility.Hidden;
        }
        private void clearButton3(object sender, RoutedEventArgs e)
        {
            //removed the Button and txt box if clicked
            button2.Visibility = Visibility.Hidden;
            textBox3.Visibility = Visibility.Hidden;
            error.Visibility = Visibility.Hidden;
        }
        private void clearButton4(object sender, RoutedEventArgs e)
        {
            //removed the Button and txt box if clicked
            button3.Visibility = Visibility.Hidden;
            textBox4.Visibility = Visibility.Hidden;
            error.Visibility = Visibility.Hidden;
        }
        private void clearButton5(object sender, RoutedEventArgs e)
        {
            //removed the Button and txt box if clicked
            button4.Visibility = Visibility.Hidden;
            textBox.Visibility = Visibility.Hidden;
            error.Visibility = Visibility.Hidden;
        }
        private void clearButton6(object sender, RoutedEventArgs e)
        {
            //removed the Button and txt box if clicked
            button5.Visibility = Visibility.Hidden;
            textBox5.Visibility = Visibility.Hidden;
            error.Visibility = Visibility.Hidden;
        }

        private void listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Double click the Catagory to add it to a Button with txtBox
            if (button.Visibility == Visibility.Hidden)
            {
                button.Content = listBox.SelectedItem.ToString();
                button.Visibility = Visibility.Visible;
                textBox1.Visibility = Visibility.Visible;
            }
            else if (button1.Visibility == Visibility.Hidden)
            {
                button1.Content = listBox.SelectedItem.ToString();
                button1.Visibility = Visibility.Visible;
                textBox2.Visibility = Visibility.Visible;
            }
            else if (button2.Visibility == Visibility.Hidden)
            {
                button2.Content = listBox.SelectedItem.ToString();
                button2.Visibility = Visibility.Visible;
                textBox3.Visibility = Visibility.Visible;
            }
            else if (button3.Visibility == Visibility.Hidden)
            {
                button3.Content = listBox.SelectedItem.ToString();
                button3.Visibility = Visibility.Visible;
                textBox4.Visibility = Visibility.Visible;
            }
            else if (button4.Visibility == Visibility.Hidden)
            {
                button4.Content = listBox.SelectedItem.ToString();
                button4.Visibility = Visibility.Visible;
                textBox.Visibility = Visibility.Visible;
            }
            else if (button5.Visibility == Visibility.Hidden)
            {
                button5.Content = listBox.SelectedItem.ToString();
                button5.Visibility = Visibility.Visible;
                textBox5.Visibility = Visibility.Visible;
            }
            else
            {
                //Say there you can only have 6 Catagories at once
                error.Visibility = Visibility.Visible;
            }
        }
    }
}
