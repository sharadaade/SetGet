using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGet
{
    class Account
    {
        private string name;
        private int acbal;
        
        public string Name
        {
            set
            {
                name = value;
            }

            get
            {
                return name;
            }
        }

        public int AcBal
        {

            set
            {
                if(value >= 0)
                {
                    acbal = value;
                }
                else
                {
                    Console.WriteLine("Enter valid amount");
                }
            }

            get
            {
                return acbal;
            }
        }

        public int FormattedBalance
        {
            get
            {
                return acbal;
            }
        }
    }

    internal class BankAccount
    {
        static void Main(string[] args)
        {
            Account a = new Account();

            a.Name = "Sharad";
            a.AcBal = 50000;
            int b = a.FormattedBalance;
            Console.WriteLine("Name : {0}",a.Name);
            Console.WriteLine("Balance : {0} $",a.AcBal);
            //Console.WriteLine("Banance from FormattedBalance {0}",b);
        }
    }
}
