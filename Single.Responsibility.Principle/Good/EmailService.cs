using System.Net.Mail;

namespace Single.Responsibility.Principle.Good
{
    public class EmailService
    {
        readonly SmtpClient _smtpClient;

        public EmailService(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        /// <summary>
        /// Entidade Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public virtual bool ValidateEmail(string email)
        {
            Console.WriteLine(" Validate Email ..........");

            return email.Contains("@");
        }

        /// <summary>
        /// Entidade Email
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool SendEmail(MailMessage message)
        {
            Console.WriteLine(" Send Email ..........");

            _smtpClient.Send(message);
            return true;
        }
    }
}
