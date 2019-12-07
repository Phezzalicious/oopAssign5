//Phelps Merrell
//Haley Smith
//Mekkala Bourapa
//CIDM 4360
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
            billDate = date;
            this.description = description;
            this.amount = amount;
            payments = new List<Payment>();

        }
        public string getBillInfo(){
            string paymentInfo = $"Date: {billDate} \nDescription: {description} \nAmount: {amount}\n";
            foreach(Payment payment in payments){
                string addToPaymentInfo = $"On {payment.getPaymentDate()} payment with {payment.getPaymentType()} the amount {payment.getAmount()} was processed \n";
                paymentInfo += addToPaymentInfo;
            }
            paymentInfo += $"Total Paid: {totalPaid()}\nRemaining Balance: {getBalance()}";
            return paymentInfo;
        }
        public bool addPayment(Payment p){
            p.verify();
            payments.Add(p);
            return true;
        }
        public double totalPaid()
        {
            double total = 0;
            foreach(Payment payment in payments)
            {
            total = total + payment.getAmount(); 
            }
            return total;
        }

        public double getBalance()
        {
          double btotal = 0; 
          foreach(var payment in payments)
          {
          	btotal = btotal + payment.getAmount();
          }
          return amount - totalPaid();
        }
    }
}