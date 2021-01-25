using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine(customer.Id+" no'lu ID'ye sahip "+customer.Adi+" "+customer.Soyadi+" için hesap oluşturuldu.");
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.Id + " no'lu ID'ye sahip " + customer.Adi + " " + customer.Soyadi + " hesabı silinmiştir.");
        }
        public void CustomerList(Customer[] customers)
        {
            foreach (var i in customers)
            {
                Console.WriteLine("ID: "+i.Id + ", Adı Soyadı: " + i.Adi + " " + i.Soyadi);
            }

        }
    }
}
