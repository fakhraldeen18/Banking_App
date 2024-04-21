using sda_onsite_2_temperature_converter.src.Entity;

namespace sda_onsite_2_temperature_converter.src
{
    internal class Program
    {
        private static void Main()
        {
            var arizonaBank = new Bank("Arizona");

            var westBranch = new Branch("West Branch");
            var sunBranch = new Branch("sun Branch");

            var customer1 = new Customer("John");
            var customer2 = new Customer("Anna");

            arizonaBank.AddBranch(westBranch);
            arizonaBank.AddBranch(sunBranch);

            // westBranch.AddCustomer(customer1);
            // westBranch.AddCustomer(customer2);

            arizonaBank.AddCustomer(westBranch, customer1);
            arizonaBank.AddCustomer(westBranch, customer2);


            // westBranch.AddCustomerTransaction(customer1.GetId(), 1000);
            // westBranch.AddCustomerTransaction(customer1.GetId(), -500);
            // westBranch.AddCustomerTransaction(customer1.GetId(), 100);

            arizonaBank.AddCustomerTransaction(westBranch,customer1,1000);
            arizonaBank.AddCustomerTransaction(westBranch,customer1,-500);
            arizonaBank.AddCustomerTransaction(westBranch,customer1,100);

            // westBranch.AddCustomerTransaction(customer1.GetId(),-1000);

            // westBranch.AddCustomerTransaction(customer2.GetId(),100);

            
            var getBranches = arizonaBank.GetBranches();
            getBranches.ForEach(branch=>Console.WriteLine($"{branch.GetName()}"));

            var printCustomers = westBranch.GetCustomers();
            printCustomers.ForEach(customer => Console.WriteLine($"{customer.GetName()}"));

            var customerTransaction = customer1.GetTransactions();
            customerTransaction.ForEach(transaction => Console.WriteLine(transaction.GetAmount()));

            Console.WriteLine($"the Balance is {customer1.GetBalance()}");

            var findBranch = arizonaBank.FindBranchByName("sun Branch");
            findBranch.ForEach(branch => Console.WriteLine($"Name: {branch.GetName()}"));
            arizonaBank.CheckBranch(sunBranch);


            arizonaBank.ListCustomers(westBranch,true);

        }
    }

}