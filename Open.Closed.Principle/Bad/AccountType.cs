using System.ComponentModel;

namespace Open.Closed.Principle.Bad
{
    public enum AccountType
    {
        [Description("Conta Corrente")]
        Checking = 1,

        [Description("Conta Poupança")]
        Savings = 2,

        [Description("Conta Pagamento")]
        Payment = 3,
    }
}
