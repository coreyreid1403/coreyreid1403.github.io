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
 * Adds a Paycheck
 ***********************************/
namespace FInace
{
    public partial class AddFunds : Window
    {
        static double paycheck = 0;
        static double fourK = 0;
        static double fourKMatch = 0;
        static double save = 0;
        static double tithe = 0;
        static double amount1 = 0;
        static double amount2 = 0;
        static double amount3 = 0;
        public AddFunds()
        {
            InitializeComponent();
            // if cont 2 selected, preset the fields with their saved data
            if (functions.currentCont == 2)
            {
                payCheckTxt.Text = functions.secondContributor.PayCheck.ToString();
                fourKTxt.Text = functions.secondContributor.FourK.ToString();
                matchTxt.Text = functions.secondContributor.FourKMatch.ToString();
                savTextBox.Text = functions.secondContributor.PercentSavings.ToString();
                tithTextBox.Text = functions.secondContributor.PercentTith.ToString();
            }
            // if cont 1 selected, preset the fields with their saved data
            else
            {
                payCheckTxt.Text = functions.firstContributor.PayCheck.ToString();
                fourKTxt.Text = functions.firstContributor.FourK.ToString();
                matchTxt.Text = functions.firstContributor.FourKMatch.ToString();
                savTextBox.Text = functions.firstContributor.PercentSavings.ToString();
                tithTextBox.Text = functions.firstContributor.PercentTith.ToString();
            }
        }

        private void submit(object sender, RoutedEventArgs e)
        {
            //set var from txtBoxes
            paycheck = Convert.ToDouble(payCheckTxt.Text);
            fourK = Convert.ToDouble(fourKTxt.Text);
            fourKMatch = Convert.ToDouble(matchTxt.Text);
            save = Convert.ToDouble(savTextBox.Text);
            tithe = Convert.ToDouble(tithTextBox.Text);
            if (functions.currentCont == 2)
            {
                //submit the data to the appropriate accounts, split them by the percents given
                amount1 = paycheck * (save - fourK);
                functions.alterSavings("Cash", amount1);
                amount2 = paycheck * tithe;
            }
            else
            {
                //submit the data to the appropriate accounts, split them by the percents given
                amount1 = paycheck * (save - fourK);
                functions.alterSavings("Cash", amount1);
                amount2 = paycheck * tithe;
            }
            //add remaining to Savings and rewrite file
            functions.alterTith("Total", amount2);
            amount3 = paycheck - amount1 - amount2;
            functions.alterSpending("Total", amount3);
            functions.createFile();
            this.Close();
        }

        private void update(object sender, RoutedEventArgs e)
        {
            paycheck = Convert.ToDouble(payCheckTxt.Text);
            fourK = Convert.ToDouble(fourKTxt.Text);
            fourKMatch = Convert.ToDouble(matchTxt.Text);
            if (functions.currentCont == 2)
            {
                //same as above but also reset the Saved stuff for them
                functions.secondContributor.PayCheck = paycheck;
                functions.secondContributor.FourK = fourK;
                functions.secondContributor.FourKMatch = fourKMatch;
                functions.secondContributor.PercentSavings = save;
                functions.secondContributor.PercentTith = tithe;
                amount1 = paycheck * (functions.secondContributor.PercentSavings - fourK);
                functions.alterSavings("Cash", amount1);
                amount2 = paycheck * functions.secondContributor.PercentTith;
            }
            else
            {
                //same as above but also reset the Saved stuff for them
                functions.firstContributor.PayCheck = paycheck;
                functions.firstContributor.FourK = fourK;
                functions.firstContributor.FourKMatch = fourKMatch;
                functions.firstContributor.PercentSavings = save;
                functions.firstContributor.PercentTith = tithe;
                amount1 = paycheck * (functions.firstContributor.PercentSavings - fourK);
                functions.alterSavings("Cash", amount1);
                amount2 = paycheck * functions.firstContributor.PercentTith;
            }
            //add remaining to Savings and rewrite file
            functions.alterTith("Total", amount2);
            amount3 = paycheck - amount1 - amount2;
            functions.alterSpending("Total", amount3);
            functions.createFile();
            this.Close();
        }
    }
}
