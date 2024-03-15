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

        public UserAccount(int numberAccount, string name, double value)
        {
            this.NumberAccount = numberAccount;
            this.Name = name;
            this.Value = value;
        }

        public void Deposito(double valorDeposito)
        {
            this.Value += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            this.Value -= valorSaque;
        }
    }
}
