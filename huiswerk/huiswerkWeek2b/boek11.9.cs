using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huiswerkWeek2b
{
    class boek119
    {
        /*static void Main(string[] args)
        {
            Account ac1 = new Account(150);
            ac1.Credit(50);
            ac1.Debit(50);

            SavingsAccount sa1 = new SavingsAccount(150, 15);
            sa1.Credit(25);
            sa1.Debit(25);
            sa1.CalculateInterest();

            CheckingsAccount ca1 = new CheckingsAccount(150, 5);
            ca1.Credit(75);
            ca1.Debit(75);
        }*/
    }

    class Account
    {
        public decimal balance;

        public Account(decimal initilizeBalance)
        {
            if (initilizeBalance > 0.0m)
            {
                balance = initilizeBalance;
            }
            else
            {
                throw new Exception("Het bedrag moet groter zijn dan 0.0!");
            }
        }

        public void Credit(decimal creditAmount)
        {
            balance = balance + creditAmount;
            Console.WriteLine($"Nieuwe balans is: {balance}");
        }

        public bool Debit(decimal withdrawAmount)
        {
            if (Balance - withdrawAmount > 0.0m)
            {
                balance = balance - withdrawAmount;
                Console.WriteLine($"Nieuwe balans is: {balance}");
                return true;
            }
            else
            {
                Console.WriteLine("Debit amount exceeded account balance!");
                return false;
            }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }
    }

    class SavingsAccount : Account
    {
        private decimal InterestRate;
        public decimal TotalInterestRate;

        public SavingsAccount(int balans, decimal interestRate) : base(balans)
        {
            InterestRate = interestRate;
        }

        public decimal CalculateInterest()
        {
            TotalInterestRate = Balance / 100 * InterestRate;
            return TotalInterestRate;
        }
    }

    class CheckingsAccount : Account
    {
        private decimal FeeCharghed;

        public CheckingsAccount(decimal balans, decimal feeCharged) : base(balans)
        {
            FeeCharghed = feeCharged;
        }

        public void Credit(decimal creditAmount)
        {
            balance = balance + creditAmount - (balance / 100 * FeeCharghed);
            Console.WriteLine($"Nieuwe balans met extra kosten is: {balance}");
        }

        public void Debit(decimal withdrawAmount)
        {
            if (base.Debit(withdrawAmount))
            {
                Console.WriteLine($"Uw balans met extra kosten is: {(balance - withdrawAmount) - (balance / 100 * FeeCharghed)}");
            }
            else
            {
                Console.WriteLine("Debit amount exceeded account balance!");
            }
        }
    }
}