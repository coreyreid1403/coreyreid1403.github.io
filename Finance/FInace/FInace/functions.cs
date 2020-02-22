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
 * Holds Globals
 ***********************************/
namespace FInace
{
    static class functions
    {

        static string path = Directory.GetCurrentDirectory();
        static string txtpath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\..\txts"));
        static public string file = txtpath + "/try.txt";
        static string line;
        static int blank = 0;
        static double tmpDouble = 0;
        static int i;
        static int j;
        static DateTime date1 = DateTime.Now;
        static public Dictionary<string, string> savings = new Dictionary<string, string>();
        static public Dictionary<string, string> savingsTypes = new Dictionary<string, string>();
        static public Dictionary<string, string> spending = new Dictionary<string, string>();
        static public Dictionary<string, string> tith = new Dictionary<string, string>();
        static public Dictionary<string, string> spent = new Dictionary<string, string>();
        static public Dictionary<string, string> tithTypes = new Dictionary<string, string>();
        static public Dictionary<string, string> spentTypes = new Dictionary<string, string>();
        static public Dictionary<string, string> monthly = new Dictionary<string, string>();
        static StreamReader fr;
        static StreamWriter fw;
        static ArrayList fileLines = new ArrayList();
        static public ArrayList child = new ArrayList();
        static public ArrayList contributors = new ArrayList();
        static public Contributor firstContributor;
        static public Contributor secondContributor;
        static public Child firstChild;
        static public Child secondChild;
        static public Child thirdChild;
        static public Child fourthChild;
        static public Child fifthChild;
        static public Child sixthChild;
        static public int currentCont = 0;
        static public int numConts = 0;

        static public void readFileToConsel()
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
        static public void errorMessage(string i)
        {
            MessageBoxResult dialogResult = MessageBox.Show(i, "Error", MessageBoxButton.OK);
        }
        static public bool errorMessageOkCancel(string i)
        {
            MessageBoxResult dialogResult = MessageBox.Show(i, "You Sure?", MessageBoxButton.OKCancel);
            return (dialogResult.ToString() == "OK");
        }
        static public bool errorMessageYesNo(string i)
        {
            MessageBoxResult dialogResult = MessageBox.Show(i, "You Sure?", MessageBoxButton.YesNo);
            return (dialogResult.ToString() == "OK");
        }
        static public void readFileToArray()
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
        static public void writeFile(string word)
        {
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
        static public void clearFile()
        {
            fw = new StreamWriter(file);
            fw.WriteLine("");
            fw.Close();
        }
        static public void makeDir()
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
                else if (lineSplit[0] == "Monthly")
                {
                    makeMonthly(lineSplit);
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
                    if (blank != 1)
                    {
                        Console.WriteLine("There is more thank one blank Line");
                    }
                }
                i++;
            }
        }
        static public void makeSavingsDir(string[] line)
        {
            j = 1;
            while (j < line.Length - 1)
            {
                savings.Add(line[j], line[j + 1]);
                j += 2;
            }
            Console.WriteLine("Savings:");
            foreach (KeyValuePair<string, string> kvp in savings)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
        static public void makeSpendingDir(string[] line)
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
        static public void makeTithDir(string[] line)
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
        static public void makeSpentDir(string[] line)
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
        static public void makeTithTypes(string[] line)
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
        static public void makeSpentTypes(string[] line)
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
        static public void makeMonthly(string[] line)
        {
            j = 1;
            while (j < line.Length - 1)
            {
                monthly.Add(line[j], line[j + 1]);
                j += 2;
            }
            Console.WriteLine("Monthly:");
            foreach (KeyValuePair<string, string> kvp in monthly)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
        static public void makeContributorsArray(string[] line)
        {
            j = 1;
            while (j < line.Length - 1)
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
        static public void makeChildArray(string[] line)
        {
            j = 1;
            while (j < line.Length - 1)
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
        static public void createFile()
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
            writeFile("\nMonthly,");
            foreach (KeyValuePair<string, string> kvp in monthly)
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
        static public void alterSavings(string account, double amount)
        {
            tmpDouble = Convert.ToDouble(savings[account]);
            savings[account] = (tmpDouble + amount).ToString();
        }
        static public void alterSpending(string account, double amount)
        {
            tmpDouble = Convert.ToDouble(spending[account]);
            spending[account] = (tmpDouble + amount).ToString();
        }
        static public void alterTith(string account, double amount)
        {
            tmpDouble = Convert.ToDouble(tith[account]);
            tith[account] = (tmpDouble + amount).ToString();
        }
        static public void alterSpent(string account, double amount)
        {
            tmpDouble = Convert.ToDouble(spent[account]);
            spent[account] = (tmpDouble + amount).ToString();
        }
        static public void addTithType(string name, double amount)
        {
            tithTypes.Add(name, amount.ToString());
        }
        static public void addSpentType(string name, double amount)
        {
            spentTypes.Add(name, amount.ToString());
        }
        static public void addMonthlyType(string name, double amount)
        {
            monthly.Add(name, amount.ToString());
        }
        static public void increaseTithType(string name, double amount)
        {
            tmpDouble = Convert.ToDouble(tithTypes[name]);
            tithTypes[name] = (tmpDouble + amount).ToString();
        }
        static public void increaseSpentType(string name, double amount)
        {
            tmpDouble = Convert.ToDouble(spentTypes[name]);
            spentTypes[name] = (tmpDouble + amount).ToString();
        }
        static public void increaseMonthly(string name, double amount)
        {
            tmpDouble = Convert.ToDouble(monthly[name]);
            monthly[name] = (tmpDouble + amount).ToString();
        }
        static public void makeChild()
        {
            if (child.Count > 0)
            {
                firstChild = new Child(child[0].ToString(), Convert.ToDouble(child[1]), Convert.ToDouble(child[2]));
                Console.WriteLine(firstChild.toString());
                if (child.Count > 3)
                {
                    secondChild = new Child(child[3].ToString(), Convert.ToDouble(child[4]), Convert.ToDouble(child[5]));
                    Console.WriteLine(secondChild.toString());
                    if (child.Count > 6)
                    {
                        thirdChild = new Child(child[6].ToString(), Convert.ToDouble(child[7]), Convert.ToDouble(child[8]));
                        Console.WriteLine(thirdChild.toString());

                        if (child.Count > 9)
                        {
                            fourthChild = new Child(child[9].ToString(), Convert.ToDouble(child[10]), Convert.ToDouble(child[11]));
                            Console.WriteLine(fourthChild.toString());
                            if (child.Count > 12)
                            {
                                fifthChild = new Child(child[12].ToString(), Convert.ToDouble(child[13]), Convert.ToDouble(child[14]));
                                Console.WriteLine(fifthChild.toString());
                                if (child.Count > 15)
                                {
                                    sixthChild = new Child(child[15].ToString(), Convert.ToDouble(child[16]), Convert.ToDouble(child[17]));
                                    Console.WriteLine(sixthChild.toString());
                                }
                            }
                        }
                    }
                }
            }
        }
        static public void makeContributor()
        {
            //read arraylist and make like 2 peeps if they there
            if (contributors.Count > 0)
            {
                firstContributor = new Contributor(contributors[0].ToString(), Convert.ToDouble(contributors[1]), Convert.ToDouble(contributors[2]), Convert.ToDouble(contributors[3]), Convert.ToDouble(contributors[4]), Convert.ToDouble(contributors[5]));
                firstContributor.toString();
                if (contributors.Count > 8)
                {
                    numConts = 2;
                    secondContributor = new Contributor(contributors[6].ToString(), Convert.ToDouble(contributors[7]), Convert.ToDouble(contributors[8]), Convert.ToDouble(contributors[9]), Convert.ToDouble(contributors[10]), Convert.ToDouble(contributors[11]));
                    secondContributor.toString();
                }
            }
        }
    }
}
