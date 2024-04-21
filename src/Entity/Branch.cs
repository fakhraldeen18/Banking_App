using System.Reflection;

namespace sda_onsite_2_temperature_converter.src.Entity
{
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
                throw new Exception("Customer already exists in the branch.");
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