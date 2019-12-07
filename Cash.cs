//Phelps Merrell
//Haley Smith
//Mekkala Bourapa
//CIDM 4360
using System;
using System.Collections.Generic;

namespace oop_assign_5
{
        class Cash: Payment
    {
        double tenderdCash;
        double change;

        public Cash (double t, string date, double c):base(t,date)
        {
            tenderdCash = c;
            
        }

        public double calChange()
        {
            change = tenderdCash - getAmount();
            if(change < 0){
                change = 0;
            }
            return change;

        }

        public override string getPaymentType(){
            return "Cash";
        }
        public override bool verify(){
            Console.WriteLine("Payment Verified...");
            return true;
        }
    }
}