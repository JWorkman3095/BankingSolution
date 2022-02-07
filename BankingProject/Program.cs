using System;

namespace BankingProject {
    class Program {
        static void Main(string[] args) {
            //an account instance that we can use
            Account acct1 = new Account();
            acct1.Deposit(500);
            acct1.Withdraw(200);
            acct1.Debug();
            //acct1.Withdraw(600);
            //acct1.Debug();

            Account acct2 = new Account();
            acct2.Description = "My 2nd Account";
            acct2.Deposit(1000);
            acct2.Withdraw(350);
            acct2.Debug();

            acct2.Transfer(100, acct1);
            acct1.Debug();  //checking the balance of account 1
            acct2.Debug();  //checking the balance of account 2




        }
    }
}
