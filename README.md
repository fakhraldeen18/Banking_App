# C# Banking Application - OOP Practice

This project aims to build C# classes for a banking application to practice Object-Oriented Programming (OOP) concepts.

## Level 1: Basic Requirements

### Implement the following classes:

#### Bank Class:

Properties:
- name (string)
- branches (Branch[])

Constructor:
- Parameters: name (string)

Methods:
- addBranch(branch: Branch): boolean
  Description: Adds the branch to the branches array. Each branch should only be added once.
  
- addCustomer(branch: Branch, customer: Customer): boolean
  Description: Adds the customer to the branch of the bank. Each customer can only be added once to a branch.
  
- addCustomerTransaction(branch: Branch, customerId: string, amount: number): boolean
  Description: Adds a transaction of the amount for the customer with the specified customerId in the given branch.
  
- findBranchByName(branchName: string): Branch[] | null
  Description: Returns a list of matched branches with the specified branchName or null if no matches were found.
  
- checkBranch(branch: Branch): boolean
  Description: Returns true if the branch belongs to the bank or false otherwise.
  
- listCustomers(branch: Branch, includeTransactions: boolean): void
  Description: Prints out a list of customers with their transaction details if includeTransactions is true.

#### Branch Class:

Properties:
- name (string)
- customers (array of Customer[])

Constructor:
- Parameters: name (string)

Methods:
- getName(): string
- getCustomers(): Customer[]
- addCustomer(customer: Customer): boolean
  Description: Adds the customer to the customers array. Each customer should only be added once.
  
- addCustomerTransaction(customerId: string, amount: number): boolean
  Description: Adds a transaction of the amount for the customer with the specified customerId.

#### Customer Class:

Properties:
- name (string)
- id (number)
- transactions (array of Transaction[])

Constructor:
- Parameters: name, id

Methods:
- getName(): string
- getId(): number
- getTransactions(): Transaction[]
- getBalance(): number
  Note: The balance cannot be negative.

- addTransactions(amount: number): boolean
  Description: Adds a successful transaction of the amount to the transactions array.

#### Transaction Class:

Properties:
- amount (number)
- date (Date)

Constructor:
- Parameters: amount, date

## Level 2: Additional Requirements

In addition to the basic requirements, enhance the application with the following features:

- Add validation checks to ensure that the data meets certain criteria before performing create or update operations. For example, validate required fields and data format.



```
var arizonaBank = new Bank("Arizona")
var westBranch = new Branch("West Branch")
var sunBranch = new Branch("Sun Branch")
var customer1 = new Customer("John", 1)
var customer2 = new Customer("Anna", 2)
var customer3 = new Customer("John", 3)

arizonaBank.addBranch(westBranch)
arizonaBank.addBranch(sunBranch)
arizonaBank.addBranch(westBranch) 

arizonaBank.findBranchByName("bank")
arizonaBank.findBranchByName("sun")

arizonaBank.addCustomer(westBranch, customer1)
arizonaBank.addCustomer(westBranch, customer3)
arizonaBank.addCustomer(sunBranch, customer1)
arizonaBank.addCustomer(sunBranch, customer2)

arizonaBank.addCustomerTransaction(westBranch, customer1.getId, 3000)
arizonaBank.addCustomerTransaction(westBranch, customer1.getId, 2000)
arizonaBank.addCustomerTransaction(westBranch, customer2.getId, 3000)

customer1.addTransactions(-1000)
Console.WriteLine(customer1.getBalance())
Console.WriteLine(arizonaBank.listCustomers(westBranch, true))
Console.WriteLine(arizonaBank.listCustomers(sunBranch,true))
```

You can add more codes to check the functionality and secrity of your banking system

## Level 3: Bonus Requirements (Optional)
- Add search functionality to allow users to search for specific customers based on keywords or specific fields, such as by name or Id
- Peer review: 
- Review the code and implementation of 2 assignments from other participants.
- Provide constructive feedback and suggestions for improvement.
`Please note that the bonus requirements and reviews are optional and can be completed if you have additional time and advanced skills.`

### Notes

- Ensure to apply proper type annotations for variables, function parameters, and return types to enhance type safety.
- Leverage interfaces and custom types wherever appropriate to improve code maintainability and reusability.

Happy coding!

### Deadline: 3th March 2024

