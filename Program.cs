
using ClassMethodDemo;

Customer customer1 = new Customer();
customer1.Id = 001;
customer1.Name = "Ceyhun";
customer1.Surname = "ONAC";
customer1.BirthYear = 2001;

Customer customer2 = new Customer();
customer2.Id = 002;
customer2.Name = "Sefa";
customer2.Surname = "ONAC";
customer2.BirthYear = 1981;

Customer customer3 = new Customer();
customer3.Id = 003;
customer3.Name = "Ediz";
customer3.Surname = "ONAC";
customer3.BirthYear = 2012;


CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Delete(customer2);
customerManager.Update(customer3);

Customer[] customers = new Customer[] {customer1,customer2,customer3};

foreach (var customer in customers)
{
    Console.WriteLine("-----------------------------------------------------");

    Console.WriteLine("Customer Information");

    Console.WriteLine("Customer Id : "+ customer.Id);
    Console.WriteLine("Customer Name : " + customer.Name);
    Console.WriteLine("Customer Surname : " + customer.Surname);
    Console.WriteLine("Customer Birth Year : " + customer.BirthYear);

    Console.WriteLine("-----------------------------------------------------");
}