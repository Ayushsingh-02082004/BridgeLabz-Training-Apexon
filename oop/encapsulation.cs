using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{

    //Encapsualtion in oop is used for binding the data into single unit and for data hiding.
    //Encapsulation sets data members as private so that it can not be accessed out of the class directly.
    //Encapsulation and makes methord getters and setters to access  them.
    public class bank
    {
        private double balance;

        public double getBalance()
        {
            return balance;
        }
        public void setBalance(double balance)
        {
            this.balance = balance;
        }
    }
}
