namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount newDeposite = new BankAccount();


            newDeposite.Deposit(2000.00);
            newDeposite.GetBalance();
            newDeposite.Withdraw(1000);
            newDeposite.GetBalance();

            Console.WriteLine("Enter withdraw amount: ");
            var withdraw = double.Parse(Console.ReadLine());
            newDeposite.Withdraw(withdraw);
            newDeposite.GetBalance();

            Console.WriteLine("Enter deposit amount: ");
            var deposit = double.Parse(Console.ReadLine());
            newDeposite.Deposit(withdraw);
            newDeposite.GetBalance();




        }
    }
}
