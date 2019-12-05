using System;
using System.Collections.Generic;

namespace oop_assign_5
{
    public abstract class Payment
    {
        private double amount; 
        private string paymentDate;
        public double getAmount(){
            return amount;
        }
        public string getPaymentDate(){
            return paymentDate;
        }
        public abstract string getPaymentType();
        public virtual bool verify(){
            Console.WriteLine("Payment Verified");
            return true;

        }

    }
}