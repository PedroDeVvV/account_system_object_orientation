using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int numberAccount = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular: ");
            string name = Console.ReadLine();
            char dep = 'n';
            double initialValue = 0;
            Console.Write("Haverá depósito inicial ?(s/n) ");
            UserAccount user1;

            dep = char.Parse(Console.ReadLine());
            if (dep == 's' || dep == 'S')
            {
                Console.Write("Entre com valor inicial: ");
                initialValue = double.Parse(Console.ReadLine());
                user1 = new UserAccount(numberAccount, name, initialValue);
            }
            else
            {
                user1 = new UserAccount(numberAccount, name);
            }


            Console.WriteLine(user1);

            Console.Write("Entre com um valor para depósito: ");
            double value = double.Parse(Console.ReadLine());
            user1.Deposito(value);
            Console.WriteLine(user1);

            Console.Write("Entre com um valor para saque: ");
            value = double.Parse(Console.ReadLine());
            user1.Saque(value);
            Console.WriteLine(user1);
        }
    }
}