using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectInitilization obj = new ObjectInitilization();
            obj.Name = "l";
            var obj1 = new ObjectInitilization();
            {
                Name = "kamal";
                RollNo = 01;
            };

            Console.WriteLine(obj1.Name);
            Account account = new Account();
            account.Name = "karim";
            account.Balance = 5000;
            account.AccountNo = 11001;
            Console.WriteLine(account.Deposit(500));
            account.Withdraw(1000);



            SavingsAccount svAccount = new SavingsAccount();
            svAccount.InterestAmount = 100;
            CheekingAccount cheekingAccount = new CheekingAccount();
            cheekingAccount.ServiceCharge = 20;

            svAccount.Name = "kamal";
            cheekingAccount.AccountNo = 1102;
            svAccount.InterestAmount = 300;

            Console.ReadKey();
            Account chk = new SavingsAccount();// upcasting
            SavingsAccount sv = (SavingsAccount)chk;// downcasting



        }



        public static int RollNo { get; set; }

        public static string Name { get; set; }
    }

    public class Account
    {
        public int AccountNo { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;

        }

        public double Withdraw(double amount)
        {
            Balance -= amount;
            return Balance;

        }


    }


    public class SavingsAccount:Account{


        public double InterestAmount { get; set; }

    }

    public class CheekingAccount:Account
    {
        public double  ServiceCharge { get; set; }

    }
    
}
