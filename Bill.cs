using System;
using System.Collections.Generic;

namespace oop_assign_5
{
    class Bill
    {
        string billDate;
        string description;
        double amount;
        List<Payment> payments;
        public Bill(string date, string description,double amount){
            billDate =date;
            this.description =description;
            this.amount = amount;
            payments = new List<Payment>();

        }
        public string getBillInfo(){
            string paymentInfo = $"Date: {billDate} \nDescription: {description} \nAmount: {amount}\n";
            foreach(Payment payment in payments){
                string addToPaymentInfo = $"On {payment.getPaymentDate()} payment with {payment.getPaymentType()} the amount {payment.getAmount()} was processed \n";
            paymentInfo += addToPaymentInfo;
            }
            
            
            return paymentInfo;
        }
        public bool addPayment(Payment p){
            p.verify();
            payments.Add(p);
            return true;
        }
    }
}