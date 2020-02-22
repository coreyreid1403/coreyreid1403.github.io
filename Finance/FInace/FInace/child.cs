using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInace
{
    class Child
    {
        private string name;
        private double college;
        private double amount;
        public Child(string n, double c, double a)
        {
            this.name = n;
            this.college = c;
            this.amount = a;
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
        public double College
        {
            get
            {
                return this.college;
            }
            set
            {
                this.college = value;
            }

        }
        public double Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.college = value;
            }

        }
        public string toString()
        {
            return this.name + " has " + this.college + " in College Fund.";
        }
    }
}
