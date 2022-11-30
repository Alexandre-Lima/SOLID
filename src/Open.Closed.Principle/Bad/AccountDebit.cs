namespace Open.Closed.Principle.Bad
{
    public class AccountDebit
    {
        public string Debit(decimal valor, string conta, AccountType tipoConta)
        {
            if (tipoConta == AccountType.Checking)
            {
                // Debita Conta Corrente                
                Console.WriteLine(" Débito Conta Corrente ..........");                
            }

            if (tipoConta == AccountType.Savings)
            {
                // Valida Aniversário da Conta
                Console.WriteLine(" Valida Aniversário da Conta ..........");

                // Debita Conta Poupança
                Console.WriteLine(" Débito Conta Poupança ..........");
            }

            if (tipoConta == AccountType.Payment)
            {
                // Debita Conta Pagamento
                Console.WriteLine(" Débito Conta Pagamento ..........");
            }

            ///... :-(
            ///E assim para cada tipo de conta têm se o problema de adicionar um novo 
            ///if alterando a classe AccountDebit e o médoto Debit.
            ///... :-(
            ///

            return FormatTransaction();
        }

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

