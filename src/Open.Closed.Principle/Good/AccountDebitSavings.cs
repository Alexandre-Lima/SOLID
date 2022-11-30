namespace Open.Closed.Principle.Good
{
    public class AccountDebitSavings : AccountDebit
    {
        public override string Debit(decimal valor, string conta)
        {
            // Valida Aniversário da Conta
            Console.WriteLine(" Valida Aniversário da Conta ..........");

            // Debita Conta Poupança
            Console.WriteLine(" Débito Conta Poupança ..........");

            return FormatTransaction();
        }
    }
}
