using System.IO.Compression;
using Microsoft.VisualBasic;

namespace sda_onsite_2_temperature_converter.src.Entity
{
    // - listCustomers(branch: Branch, includeTransactions: boolean) : void
    //   Description: Prints out a list of customers with their transaction details if includeTransactions is true.

    public class Bank
    {
        private string _name;
        private List<Branch> _branches;

        public Bank(string name)
        {
            _branches = [];
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public List<Branch> GetBranches()
        {
            return _branches;
        }

        public void AddBranch(Branch NweBranch)
        {
            var findBranchByName = _branches.Find(branch => branch.GetName() == NweBranch.GetName());
            if (findBranchByName != null)
            {
                throw new Exception("Branch already exists in the bank.");
            }
            else
            {
                _branches.Add(NweBranch);
            }
        }

        public void AddCustomer(Branch branch, Customer customer)
        {

            var getCustomer = branch.GetCustomers();
            var findBranchByName = getCustomer.Find(findCustomer => findCustomer.GetName() == customer.GetName());
            if (findBranchByName != null)
            {
                throw new Exception("Customer already exists in the branch.");
            }
            else
            {
                branch.AddCustomer(customer);
            }
        }


        public void AddCustomerTransaction(Branch branch, Customer customer, int amount)
        {
            branch.AddCustomerTransaction(customer.GetId(), amount);
        }

        public List<Branch> FindBranchByName(string BranchName)
        {
            var findBranches = new List<Branch>();
            var findBranch = _branches.Find(branch => branch.GetName() == BranchName);
            if (findBranch == null)
            {
                throw new Exception("Branch does not exist in the bank.");
            }
            else
            {
                findBranches.Add(findBranch);
                return findBranches;
            }
        }

        public bool CheckBranch(Branch FindBranch)
        {
            var CheckBranch = _branches.Find(branch => branch.GetName() == FindBranch.GetName());
            if (CheckBranch == null)
            {
                Console.WriteLine("The branch does not found in the bank");
                return false;
            }
            else
            {
                Console.WriteLine("The branch found in the bank");
                return true;
            }
        }

        public void ListCustomers(Branch branch, bool includeTransactions)
        {
            var getCustomer = branch.GetCustomers();
            if (includeTransactions == true)
            {
                getCustomer.ForEach(customerWithTransactions =>
               Console.WriteLine($" the name is {customerWithTransactions.GetName()} and the transactions is {customerWithTransactions.GetTransactions()}")
               );
            }
            else
            {
                getCustomer.ForEach(customer => Console.WriteLine($"the name is {customer.GetName()}"));
            }
        }
    }
}
