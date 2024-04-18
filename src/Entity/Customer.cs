namespace sda_onsite_2_temperature_converter.src.Entity
{
    public class Customer
    {
        private string _name;
        private Guid _id;
        private List<Transaction> _transactions;

        public Customer(string name)
        {
            _name = name;
            _id = Guid.NewGuid();
            _transactions = [];
        }

        public string GetName()
        {
            return _name;
        }
        public Guid GetId()
        {
            return _id;
        }

        public List<Transaction> GetTransactions()
        {
            return _transactions;
        }

        public int GetBalance()
        {
            int balance = 0;
            _transactions.ForEach(transaction =>
            balance += transaction.GetAmount()
            );
            if (balance < 0)
            {
                throw new Exception("Balance Cannot be negative");
            }
            else
            {
                return balance;
            }
        }

        public void addTransactions(int amount)
        {
            var transaction = new Transaction(amount);
            _transactions.Add(transaction);
        }
    }
}