using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Single.Responsibility.Principle.Bad
{
    public class UserService
    {
        readonly SmtpClient _smtpClient;

        public UserService(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        /// <summary>
        /// Entidade user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <exception cref="ValidationException"></exception>
        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Email is not an email");

            var user = new { email = email, password = password };
            // implementation save user
            Console.WriteLine(" Save user ..........");            

            SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
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

