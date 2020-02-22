using System;
using System.Collections.Generic;
using System.Collections;
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
using System.IO;
using System.Globalization;
/************************************
 * First Page
 * -reads File
 * -fills Dictionarys
 * -creates Objects
 * -Prints to console the Dicts and Objects
 ***********************************/
namespace FInace
{
    public partial class MainWindow : Window
    {
        /*
        static string path = Directory.GetCurrentDirectory();
        static string txtpath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\..\txts"));
        string file = txtpath + "/try.txt";
        static string line;
        static int blank = 0;
        static double tmpDouble = 0;
        static int i;
        static int j;
        DateTime date1 = DateTime.Now;
        Dictionary<string, string> savings = new Dictionary<string, string>();
        Dictionary<string, string> spending = new Dictionary<string, string>();
        Dictionary<string, string> tith = new Dictionary<string, string>();
        Dictionary<string, string> spent = new Dictionary<string, string>();
        Dictionary<string, string> tithTypes= new Dictionary<string, string>();
        Dictionary<string, string> spentTypes = new Dictionary<string, string>();
        StreamReader fr;
        StreamWriter fw;
        ArrayList fileLines = new ArrayList();
        ArrayList child = new ArrayList();
        ArrayList contributors = new ArrayList();
        */
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine("Start");
            //if new user, open New User page
            if ( new FileInfo(functions.file).Length < 2)
            {
                IntroPage introPage = new IntroPage();
                introPage.Show();
                this.Close();
            }

            //read file the file and the fill Dictionarys
            functions.makeDir();

            //Make Objects
            functions.makeChild();
            functions.makeContributor();

            //take current dir and rewrite file
            //functions.createFile();


            Console.WriteLine("End");
        }
        /*
        public void readFileToConsel()
        {
            try
            {
                //Reopen the stream
                fr = new StreamReader(file);
                //Read the first line of text
                line = fr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = fr.ReadLine();
                }

                //close the file
                fr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public void readFileToArray()
        {
            try
            {
                fr = new StreamReader(file);
                line = fr.ReadLine();
                while (line != null)
                {
                    fileLines.Add(line);
                    line = fr.ReadLine();

                }
                fr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public void writeFile(string word) { 
            try
            {
                fw = new StreamWriter(file, append: true);
                //Write a line of text
                fw.Write(word);

                //Close the file
                fw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public void clearFile()
        {
            fw = new StreamWriter(file);
            fw.WriteLine("");
            fw.Close();
        }
        public void makeDir()
        {
            readFileToArray();
            i = 0;
            //make this while loop work
            while (i < fileLines.Count) 
            {
                string[] lineSplit = fileLines[i].ToString().Split(',');
                if (lineSplit[0] == "Savings")
                {
                    makeSavingsDir(lineSplit);
                }
                else if (lineSplit[0] == "Spending")
                {
                    makeSpendingDir(lineSplit);
                }
                else if (lineSplit[0] == "Tith")
                {
                    makeTithDir(lineSplit);
                }
                else if (lineSplit[0] == "Spent")
                {
                    makeSpentDir(lineSplit);
                }
                else if (lineSplit[0] == "TithTypes")
                {
                    makeTithTypes(lineSplit);
                }
                else if (lineSplit[0] == "SpentTypes")
                {
                    makeSpentTypes(lineSplit);
                }
                else if (lineSplit[0] == "Child")
                {
                    makeChildArray(lineSplit);
                }
                else if (lineSplit[0] == "Contributor")
                {
                    makeContributorsArray(lineSplit);
                }
                else
                {
                    blank++;
                    if (blank != 1){
                        Console.WriteLine("There is more thank one blank Line");
                    }
                }
                i++;
            }
        }
        public void makeSavingsDir(string[] line)
        {
            j = 1;
            while (j < line.Length-1)
            {
                savings.Add(line[j], line[j+1]);
                j += 2;
            }
            Console.WriteLine("Savings:");
            foreach (KeyValuePair<string, string> kvp in savings)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
        public void makeSpendingDir(string[] line)
        {
            j = 1;
            while (j < line.Length - 1)
            {
                spending.Add(line[j], line[j + 1]);
                j += 2;
            }
            Console.WriteLine("Spending:");
            foreach (KeyValuePair<string, string> kvp in spending)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
        public void makeTithDir(string[] line)
        {
            j = 1;
            while (j < line.Length - 1)
            {
                tith.Add(line[j], line[j + 1]);
                j += 2;
            }
            Console.WriteLine("Tith:");
            foreach (KeyValuePair<string, string> kvp in tith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
        public void makeSpentDir(string[] line)
        {
            j = 1;
            while (j < line.Length - 1)
            {
                spent.Add(line[j], line[j + 1]);
                j += 2;
            }
            Console.WriteLine("Spent:");
            foreach (KeyValuePair<string, string> kvp in spent)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
        public void makeTithTypes(string[] line)
        {
            j = 1;
            while (j < line.Length - 1)
            {
                tithTypes.Add(line[j], line[j + 1]);
                j += 2;
            }
            Console.WriteLine("TithTypes:");
            foreach (KeyValuePair<string, string> kvp in tithTypes)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
        public void makeSpentTypes(string[] line)
        {
            j = 1;
            while (j < line.Length - 1)
            {
                spentTypes.Add(line[j], line[j + 1]);
                j += 2;
            }
            Console.WriteLine("SpentTypes:");
            foreach (KeyValuePair<string, string> kvp in spentTypes)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
        public void makeContributorsArray(string[] line)
        {
            j = 1;
            while (j < line.Length-1)
            {
                contributors.Add(line[j]);
                j += 1;
            }
            Console.WriteLine("Contributor:");
            foreach (string kvp in contributors)
            {
                Console.WriteLine(kvp);
            }
        }
        public void makeChildArray(string[] line)
        {
            j = 1;
            while (j < line.Length-1)
            {
                child.Add(line[j]);
                j += 1;
            }
            Console.WriteLine("Child:");
            foreach (string kvp in child)
            {
                Console.WriteLine(kvp);
            }
        }
        public void createFile()
        {
            clearFile();
            writeFile("Savings,");
            foreach (KeyValuePair<string, string> kvp in savings)
            {
                writeFile(kvp.Key);
                writeFile(",");
                writeFile(kvp.Value);
                writeFile(",");
            }
            writeFile("\nSpending,");
            foreach (KeyValuePair<string, string> kvp in spending)
            {
                writeFile(kvp.Key);
                writeFile(",");
                writeFile(kvp.Value);
                writeFile(",");
            }
            writeFile("\nTith,");
            foreach (KeyValuePair<string, string> kvp in tith)
            {
                writeFile(kvp.Key);
                writeFile(",");
                writeFile(kvp.Value);
                writeFile(",");
            }
            writeFile("\nSpent,");
            foreach (KeyValuePair<string, string> kvp in spent)
            {
                writeFile(kvp.Key);
                writeFile(",");
                writeFile(kvp.Value);
                writeFile(",");
            }
            writeFile("\nSpentTypes,");
            foreach (KeyValuePair<string, string> kvp in spentTypes)
            {
                writeFile(kvp.Key);
                writeFile(",");
                writeFile(kvp.Value);
                writeFile(",");
            }
            writeFile("\nTithTypes,");
            foreach (KeyValuePair<string, string> kvp in tithTypes)
            {
                writeFile(kvp.Key);
                writeFile(",");
                writeFile(kvp.Value);
                writeFile(",");
            }
            writeFile("\nChild,");
            foreach (string kvp in child)
            {
                writeFile(kvp);
                writeFile(",");
            }
            writeFile("\nContributor,");
            foreach (string kvp in contributors)
            {
                writeFile(kvp);
                writeFile(",");
            }
        }
        public void alterSavings(string account, int amount)
        {
            tmpDouble = Convert.ToDouble(savings[account]);
            savings[account] = (tmpDouble + amount).ToString();
        }
        public void alterSpending(string account, int amount)
        {
            tmpDouble = Convert.ToDouble(spending[account]);
            spending[account] = (tmpDouble + amount).ToString();
        }
        public void alterTith(string account, int amount)
        {
            tmpDouble = Convert.ToDouble(tith[account]);
            tith[account] = (tmpDouble + amount).ToString();
        }
        public void alterSpent(string account, int amount)
        {
            tmpDouble = Convert.ToDouble(spent[account]);
            spent[account] = (tmpDouble + amount).ToString();
        }
        public void addTithType(string name, double amount)
        {
            tithTypes.Add(name, amount.ToString());
        }
        public void addSpentType(string name, double amount)
        {
            spentTypes.Add(name, amount.ToString());
        }
        public void increaseTithType(string name, double amount)
        {
            tmpDouble = Convert.ToDouble(tithTypes[name]);
            savings[name] = (tmpDouble + amount).ToString();
        }
        public void increaseSpentType(string name, double amount)
        {
            tmpDouble = Convert.ToDouble(spentTypes[name]);
            savings[name] = (tmpDouble + amount).ToString();
        }
        public void makeChild()
        {
            if (child.Count > 0) 
            {
                Child firstChild = new Child(child[0].ToString(), Convert.ToDouble(child[1]));
                firstChild.toString();
                if (child.Count > 2)
                {
                    Child secondChild = new Child(child[2].ToString(), Convert.ToDouble(child[3]));
                    secondChild.toString();
                    if (child.Count > 4)
                    {
                        Child thirdChild = new Child(child[4].ToString(), Convert.ToDouble(child[5]));
                        thirdChild.toString();

                        if (child.Count > 6)
                        {
                            Child fourthChild = new Child(child[6].ToString(), Convert.ToDouble(child[7]));
                            fourthChild.toString();
                            if (child.Count > 8)
                            {
                                Child fifthChild = new Child(child[8].ToString(), Convert.ToDouble(child[9]));
                                fifthChild.toString();
                                if (child.Count > 10)
                                {
                                    Child sixthChild = new Child(child[10].ToString(), Convert.ToDouble(child[11]));
                                    sixthChild.toString();
                                }
                            }
                        }
                    }
                }
            }
        }
        public void makeContributor()
        {
            //read arraylist and make like 3 peeps if they there
            if (contributors.Count > 0)
            {
                Contributor firstContributor = new Contributor(contributors[0].ToString(), Convert.ToDouble(contributors[1]), Convert.ToDouble(contributors[2]), Convert.ToDouble(contributors[3]));
                firstContributor.toString();
                if (contributors.Count > 6)
                {
                    Contributor secondContributor = new Contributor(contributors[4].ToString(), Convert.ToDouble(contributors[5]), Convert.ToDouble(contributors[6]), Convert.ToDouble(contributors[7]));
                    secondContributor.toString();
                }
            }
        }
        */

        //ButtonClick Functions
        private void overviewClick(object sender, RoutedEventArgs e)
        {
            Overview overviewPage = new Overview();
            overviewPage.Show();
        }

        private void addFundsClick(object sender, RoutedEventArgs e)
        {
            if (functions.numConts == 2)
            {
                Contr contrPage = new Contr();
                contrPage.Show();
            }
            else
            {
                AddFunds addFundsPage = new AddFunds();
                addFundsPage.Show();
            }
        }

        private void purchaseClick(object sender, RoutedEventArgs e)
        {
            Purchase purchasePage = new Purchase();
            purchasePage.Show();
        }

        private void optionsClick(object sender, RoutedEventArgs e)
        {
            Options optionPage = new Options();
            optionPage.Show();
        }

        private void closeClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}