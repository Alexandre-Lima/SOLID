namespace Open.Closed.Principle.Good
{
    public class AccountDebitChecking : AccountDebit
    {
        public override string Debit(decimal valor, string conta) 
        {
            // Debita Conta Corrente     
            Console.WriteLine(" Débito Conta Corrente ..........");

            return FormatTransaction();
        }
    }
}
