using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Adi = "Recep";
            customer1.Soyadi = "Şahin";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Adi = "Özge";
            customer2.Soyadi = "Yılmaz";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Adi = "Elif";
            customer3.Soyadi = "Polat";

            Customer[] customers = new Customer[] {customer1,customer2,customer3};


            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine("Ekleme Methodu Çalıştı.");
            customerManager.CustomerAdd(customer1);
            customerManager.CustomerAdd(customer2);
            customerManager.CustomerAdd(customer3);

            Console.WriteLine("Silme Methodu Çalıştı.");
            customerManager.CustomerDelete(customer1);
            customerManager.CustomerDelete(customer2);
            customerManager.CustomerDelete(customer3);

            Console.WriteLine("Listeleme Methodu Çalıştı.");
            customerManager.CustomerList(customers);
            
        }
    }
}
