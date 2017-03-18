using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page_130
{
    class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0) //amount must not exceed total cash, and must be positive integer
            {
                Cash -= amount;
                return amount;
            }
            else //or gives error message
            {
                MessageBox.Show("I don't have enough cash to give to you " + amount,
                    Name + " says...");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0) // Must be a positive integer
            {
                Cash += amount;
                return amount;
            }
            else //or gives error message
            {
                MessageBox.Show(amount + " isn't an amount I'll take",
                    Name + " says...");
                return 0;
            }
        }
    }
}
