using Grpc.Core;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FIT5032_AssignmentPortfolio_Ver1._1.Util
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "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";

        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@localhost.com", "FIT5032 Example Email User");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }

    }
}