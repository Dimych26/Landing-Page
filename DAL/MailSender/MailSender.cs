using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MailSender
{
    public class MailSettings
    {
        public readonly string MailToAddress = "biznessyk@gmail.com";
        public readonly string MailFromAddress = "biznessyk@gmail.com";
        public readonly bool UseSsl = true;
        public readonly string Username = "biznessyk@gmail.com";
        public readonly string Password = "Km3377123";
        public readonly string HostName = "smtp.gmail.com";
        public readonly int ServerPort = 587;
    }
    public class MailSender : IOrderService
    {
        MailSettings mail = new MailSettings();

        public void MakeOrder(Order order, Product product)
        {
            using (var smtpClient = new SmtpClient())
            {

                smtpClient.EnableSsl = mail.UseSsl;
                smtpClient.Host = mail.HostName;
                smtpClient.Port = mail.ServerPort;
                smtpClient.Credentials = new NetworkCredential(mail.Username, mail.Password);

                StringBuilder builder = new StringBuilder();
                

                builder.AppendLine("Товар:")
                   .AppendLine(product.Name)
                   .AppendLine("Цена: " + product.Price)
                   .AppendLine("Цвет: " + product.Color)
                   .AppendLine("Количество: " + order.Count)
                   .AppendLine()
                   .AppendLine("Покупатель:")
                   .AppendLine("Имя: " + order.Name)
                   .AppendLine("Фамилия: " + order.Surname)
                   .AppendLine("Отчество: " + order.Patronymic)
                   .Append("Новая Почта: ")
                   .AppendLine(order.MailNumber ?? "Не указано")
                   .AppendLine("Город: " + order.City)
                   .Append("Телефон: ")
                   .AppendLine(order.Phone ?? "Не указано")
                   .Append("Instagram: ")
                   .AppendLine(order.Instagram ?? "Не указано")
                   .Append("Комментарий: ")
                   .AppendLine(order.Comment ?? "Не указано");




                MailMessage message = new MailMessage(mail.MailFromAddress, mail.MailToAddress, "Заказ", builder.ToString());

                smtpClient.Send(message);
            }
        }

        

       
    }
}
