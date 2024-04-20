using sda_onsite_2_temperature_converter.src.Entity;

namespace sda_onsite_2_temperature_converter.src
{
    internal class Program
    {
        private static void Main()
        {
            var westBranch = new Branch("West Branch");

            var customer1 = new Customer("John");
            var customer2 = new Customer("Anna");
            var customer3 = new Customer("John");

            westBranch.AddCustomer(customer1);
            westBranch.AddCustomer(customer3);

            westBranch.AddCustomerTransaction(customer1.GetId(),1000);
            westBranch.AddCustomerTransaction(customer1.GetId(),-500);
            westBranch.AddCustomerTransaction(customer1.GetId(),100);
            
            westBranch.AddCustomerTransaction(customer1.GetId(),-1000);

            westBranch.AddCustomerTransaction(customer2.GetId(),100);

            Console.WriteLine(customer1.GetBalance());
            var customerTransaction = customer1.GetTransactions();
            customerTransaction.ForEach(transaction => Console.WriteLine(transaction.GetAmount()));
        }
    }

}