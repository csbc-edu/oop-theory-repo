using System;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        // дані рівня екземпляру
        public double currBalance;
        // статичний елемент даних - депозитний %
        public static double currInterestRate;

        public SavingsAccount(double balance)
        {
            currInterestRate = 0.04;
            currBalance = balance;
        }

        // статичні члени для встановлення/отримання %ї ставки
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount s1 = new SavingsAccount(50);
            Console.WriteLine("Відсоткова ставка: {0}", 
                        SavingsAccount.GetInterestRate());
            
            // спробуємо змінити відсоткову ставку
            SavingsAccount.SetInterestRate(0.08);

            SavingsAccount s2 = new SavingsAccount(100);
            Console.WriteLine("Відсоткова ставка: {0}",
                        SavingsAccount.GetInterestRate());
            // SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.ReadKey();
        }
    }
}
