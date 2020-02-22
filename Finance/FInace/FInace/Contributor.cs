using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInace
{
    class Contributor
    {
        private string name;
        private double fourK;
        private double fourKMatch;
        private double payCheck;
        private double percentSavings;
        private double percentTith;
        public Contributor(string n, double f, double fm, double p, double psave, double ptith)
        {
            this.name = n;
            this.fourK = f;
            this.fourKMatch = fm;
            this.payCheck = p;
            this.percentSavings = psave;
            this.percentTith = ptith;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public double FourK
        {
            get
            {
                return this.fourK;
            }
            set
            {
                this.fourK = value;
            }
        }
        public double FourKMatch
        {
            get
            {
                return this.fourKMatch;
            }
            set
            {
                this.fourKMatch = value;
            }
        }
        public double PayCheck
        {
            get
            {
                return this.payCheck;
            }
            set
            {
                this.payCheck = value;
            }
        }
        public double PercentSavings
        {
            get
            {
                return this.percentSavings;
            }
            set
            {
                this.percentSavings = value;
            }
        }
        public double PercentTith
        {
            get
            {
                return this.percentTith;
            }
            set
            {
                this.percentTith = value;
            }
        }
        public void toString()
        {
            Console.WriteLine(this.name + " has average paycheck of " + this.payCheck + 
                ", contributes " + this.fourK + " to 401k with a " + this.fourKMatch 
                + " match.");
        }
    }
}
