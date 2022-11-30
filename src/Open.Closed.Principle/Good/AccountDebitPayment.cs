namespace Open.Closed.Principle.Good
{
    public class AccountDebitPayment : AccountDebit
    {
        public override string Debit(decimal valor, string conta)
        {
            // Debita Conta Pagamento
            Console.WriteLine(" Débito Conta Pagamento ..........");

            return FormatTransaction();
        }
    }
}
