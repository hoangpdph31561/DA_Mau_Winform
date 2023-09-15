using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DA_mau_Utilities.Common_Use
{
    public static class CommonUnitilyUse
    {
        public static string RandomPassword(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if(lowerCase)
            {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }
        public static void SendMail(string email, string password)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com",587);
                client.UseDefaultCredentials = false;
                NetworkCredential cred = new NetworkCredential("hoang23577@gmail.com", "jypi ddrw gkpt nwjp");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("hoang23577@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Bạn đã sử dụng chức năng quên mật khẩu";
                mail.Body = "Chào đây là mật khẩu mới của bạn " + password;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(mail);
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                
            }
        }
    }
}
