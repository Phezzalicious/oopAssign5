using System;
using System.Collections.Generic;

namespace oop_assign_5
{
    class CreditCard: Payment
    {
        string CCNum;
        string expDate;
        string CHolderName;
        string CType;

//100,"1234-5678-9012-3456","Visa","01/01/2022","John Doe","01/01/2019"
        public CreditCard (float amount, string CCNum, string CType, string expDate, string CHolderName, string otherDate)
        {
            this.CCNum = CCNum;
            this.expDate = expDate;
            this.CHolderName = CHolderName;
            this.CType = CType;
        }
      

           public override string getPaymentType(){
             return "Credit Card";
        }
        public override bool verify(){
            return true;

        }
    }
}