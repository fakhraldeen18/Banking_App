using System.Reflection;

namespace sda_onsite_2_temperature_converter.src.Entity
{

    //     Properties:
    // - name(string)
    // - customers(array of Customer[])

    // Constructor:
    // - Parameters: name(string)

    // Methods:
    // - getName() : string
    // - getCustomers() : Customer[]
    // - addCustomer(customer: Customer) : boolean
    //   Description: Adds the customer to the customers array.Each customer should only be added once.

    // - addCustomerTransaction(customerId: string, amount: number) : boolean
    //   Description: Adds a transaction of the amount for the customer with the specified customerId.
    public class Branch
    {

        private string _name;
        private List<Customer> _customers;

        public Branch(string name)
        {
            _customers = [];
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        public void AddCustomer(Customer NewCustomer)
        {
            var findCustomer = _customers.Find(customer => customer.GetId() == NewCustomer.GetId());
            if (findCustomer != null)
            {
                throw new Exception("Customer is expected");
            }
            else
            {
            _customers.Add(NewCustomer);
            }
        }

        public void AddCustomerTransaction(Guid CustomerId, int amount)
        {
            var findCustomer = _customers.Find(customer => customer.GetId() == CustomerId);
            if (findCustomer != null)
            {
                findCustomer.AddTransactions(amount);
            }
            else
            {
                throw new Exception("Customer not found");
            }

        }
    }
}