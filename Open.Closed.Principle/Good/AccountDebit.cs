namespace Open.Closed.Principle.Good
{
    public abstract class AccountDebit
    {
        public abstract string Debit(decimal valor, string conta);

        public string FormatTransaction()
        {
            const string chars = "ABCasDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var transactionNumber = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            // Numero de transacao formatado
            Console.WriteLine(" Gerar Número de transacao formatado ..........");

            return transactionNumber;
        }
    }
}

