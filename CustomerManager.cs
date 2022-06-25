using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
    public void Add(Customer customer)
        {
            Console.WriteLine("Customer with id number : " + customer.Id + " added : " + customer.Name +" "+ customer.Surname);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer with id number : " + customer.Id + " deleted : " + customer.Name +" "+ customer.Surname);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Customer with id number : " + customer.Id + " updated : " + customer.Name + " " + customer.Surname);
        }
    }
}
