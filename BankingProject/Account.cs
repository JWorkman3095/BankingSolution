using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject {
    public class Account {
        //Static Properties
        private static int NextAccountNumber { get; set; } = 1;
        //Instance Properties
        public decimal Balance { get; set; }
        public int AccountNumber { get; set; }
        public string Description { get; set; }
        //Methods
        public bool Deposit(decimal Amount) {
            if(Amount <= 0) {
                throw new Exception("Amount must be positive.");
            }
            Balance = Balance + Amount;
            return true;
        }
        public bool Withdraw(decimal Amount) {
            if (Amount <= 0) {
                throw new Exception("Amount must be positive.");
            }
            if (Amount > Balance) {
                throw new Exception("Insuffient funds!");
            }
            Balance = Balance - Amount;
            return true; 
        }
        public bool Transfer(decimal Amount, Account ToAccount) {
            try {
                Withdraw(Amount);
            }catch (Exception) {
                throw new Exception("Withdram failed in Transfer");
            }
            ToAccount.Deposit(Amount);
            return true;
        }

        public void Debug() {
            Console.WriteLine($"{AccountNumber} | {Description} | {Balance:c}");
        }
        // Constructors - the name is always the same as a class and has no return type.
        public Account() { // default constructor 
            AccountNumber = NextAccountNumber;
            NextAccountNumber++;
            Description = "New Account";
            Balance = 0;

        }

    }
}
