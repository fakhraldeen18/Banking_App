using sda_onsite_2_temperature_converter.src.Entity;

namespace sda_onsite_2_temperature_converter.src
{
    internal class Program
    {
        private static void Main()
        {
            var customer1 = new Customer("John");
            var customer2 = new Customer("Anna");
            var customer3 = new Customer("John");

            customer1.addTransactions(1000);
            customer1.addTransactions(-500);
            customer1.addTransactions(100);
            Console.WriteLine(customer1.GetBalance());
            Console.WriteLine(customer1.GetName());
            var customerTransaction=customer1.GetTransactions();
            customerTransaction.ForEach(transaction => Console.WriteLine(transaction.GetAmount()));
        }
    }

}