using System;
using System.Collections.Generic;

namespace oop_assign_5
{
    class Check: Payment
    {
        string Bank;
        string custName;
        string accNum;
//100,"Chase","John Doe","111111","01/01/2019"
        public Check (float amount, string b, string cname, string acnum, string date):base(amount,date)
        {
            Bank = b;
            custName = cname;
            accNum = acnum;

        }
           public override string getPaymentType(){
             return "Check";
        }
        public override bool verify(){
            Console.WriteLine("Signature and Account Balance verified");
            return true;

        }
    }
}