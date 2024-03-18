using System.Globalization;

namespace Bank
{
    internal class UserAccount
    {
        public int NumberAccount { get; private set; }
        public string Name { get; private set; }
        public double Value { get; private set; }

        public UserAccount(int numberAccount, string name)
        {
            this.NumberAccount = numberAccount;
            this.Name = name;
        }

        public UserAccount(int numberAccount, string name, double value) : this(numberAccount, name)
        {
            this.Value = value;
        }

        public void Deposito(double valorDeposito)
        {
            this.Value += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            double tax = ((this.Value * 5) / 100) + valorSaque;
            this.Value -= tax;
        }

        public override string ToString()
        {
            return "Dados atualizados da conta:  Nome: " + this.Name + " | Número da conta: " + this.NumberAccount.ToString() + " | Valor: R$" + this.Value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
