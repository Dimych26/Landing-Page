using DAL.Entities;
using DAL.Interfaces;
using DAL.MailSender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAL.QuestionSender
{
    public class QuestionSender : IQuestionSender
    {
        MailSettings mail = new MailSettings();
        public void AskQuestion(Question question)
        {
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.EnableSsl = mail.UseSsl;
                smtpClient.Host = mail.HostName;
                smtpClient.Port = mail.ServerPort;
                smtpClient.Credentials = new NetworkCredential(mail.Username, mail.Password);

                StringBuilder builder = new StringBuilder();


                builder.AppendLine("Пользователь:")
                   .AppendLine(question.Name)

                   .AppendLine()
                   .AppendLine("Вопрос:")
                   .AppendLine()
                   .AppendLine(question.Message ?? "Не указано")
                   .Append("Телефон: ")
                   .AppendLine(question.Phone ?? "Не указано");

                MailMessage message = new MailMessage(mail.MailFromAddress, mail.MailToAddress, "Вопрос", builder.ToString());

                smtpClient.Send(message);
            }
        }
    }
}
