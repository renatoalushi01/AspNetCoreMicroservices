using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Ordering.Application.Contracts.Infrastructure;
using Ordering.Application.Models;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Mail
{
    public class EmailService : IEmailService
    {
        //public EmailSettings _emailSettings { get; }
        public ILogger<EmailService> _logger { get; }
        private readonly string _apiKey;
        private readonly string _fromEmail;
        private readonly string _fromName;

        public EmailService(ILogger<EmailService> logger)
        {
            _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            _apiKey = "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";
            _fromEmail = "renato-alushi@outlook.com";
            _fromName = "Renato";
        }

        public async Task<bool> SendEmail(Email email)
        {
            var client = new SendGridClient(_apiKey);

            var subject = email.Subject;
            var to = new EmailAddress(email.To);
            var emailBody = email.Body;

            var from = new EmailAddress
            {
                Email = _fromEmail,
                Name = _fromName
            };

            var sendGridMessage = MailHelper.CreateSingleEmail(from, to, subject, emailBody, emailBody);
            var response = await client.SendEmailAsync(sendGridMessage);

            if (response.IsSuccessStatusCode)
            {
                _logger.LogInformation("Email sent.");
                return true;
            }

            _logger.LogError("Email sending failed.");
            return false;
        }
    }
}
