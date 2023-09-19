using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
        public static bool RegexHumanName(string name)
        {
            if(!Regex.IsMatch(name, @"^[\w\s]{5,50}$"))
            {
                return false;
            }
            return true;
        }
        public static string NameConvention(string name)
        {
            string[] splitName = name.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splitName.Length; i++)
            {
                string word = splitName[i].Trim();
                word = word.ToLower();
                char[] arrWord = word.ToCharArray();
                arrWord[0] = char.ToUpper(word[0]);
                string newWord = new string(arrWord);
                splitName[i] = newWord;
            }
            name = string.Join(" ", splitName);
            name = name.Trim();
            return name;
        }
        public static bool RegexNumberDecimal(string number)
        {
            if (!Regex.IsMatch(number, @"^[\d]+\,?[\d]*$"))
            {
                return false;
            }
            return true;
        }
        public static bool RegexNumberInterger(string number)
        {
            if (!Regex.IsMatch(number, @"^[\d]+$"))
            {
                return false;
            }
            return true;
        }
        public static bool RegexEmail(string email)
        {
            if(!Regex.IsMatch(email, @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z\d]+$"))
            {
                return false;
            }
            else if(email.Length > 50)
            {
                return false;
            }
            return true;
        }
        public static bool RegexPhoneNumber(string number)
        {
            if(!Regex.IsMatch(number, @"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})$"))
            {
                return false;
            }
            return true;
        }
    }
}
