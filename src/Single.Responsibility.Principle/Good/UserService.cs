using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Single.Responsibility.Principle.Good
{
    public class UserService
    {
        EmailService _emailService;

        public UserService(EmailService  emailService)
        {
            _emailService = emailService;
        }

        /// <summary>
        /// Entidade user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <exception cref="ValidationException"></exception>
        public void AddUser(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");

            var user = new { email = email, password = password };

            // implementation save user
            Console.WriteLine(" Save user ..........");

            _emailService.SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
        }
    }
}
