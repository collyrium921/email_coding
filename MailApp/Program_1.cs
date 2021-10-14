using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace MailApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(new MailAddress("kajusinghal921@gmail.com", "sasd", Encoding.UTF8));
                mail.To.Add(new MailAddress("kajal.singhal@onebanc.ai", "sasd", Encoding.UTF8));
                mail.From = new MailAddress("kajusingh921@gmail.com", "Demo Milewr", Encoding.UTF8);
                mail.Subject = "Test Mail";
                mail.SubjectEncoding = Encoding.UTF8;
                mail.Body = "<html><head><meta charset='UTF-8' /><meta name='viewport' content='width=device-width, initial-scale=1.0' /><title>Eureka</title><style>body{margin:0;padding:0}@media only screen and (min-width: 661px){table.container{width:100% !important}}@media only screen and (max-width: 660px){table.container{width:100% !important}.image img{width:250px;height:200px}}@media only screen and (max-width: 510px){table.container{width:100% !important}table.container td{border:none !important}.image img{width:250px;height:200px}}</style></head><body><table id='mailer' runat='server' width='100%' border='0' cellspacing='0' cellpadding='0' align='center'><tr><td><table class='container' width='540' align='center' border='0' cellspacing='0' cellpadding='0'><tr><td valign='top' class='image' align='center' width='100%' style='padding:1% 15%; background-color:#d5fdb9;'> <a align='center' target='_blank' href='https://forms.office.com/Pages/ResponsePage.aspx?id=O1d5F6W-EE2CwNlNapJBf_QRlYlJQChEhb9DHv4V1G9UREtBUjdXWUI2N1VaNk5ZRk1ETEw3MUxRUi4u&utm_medium=email&_hsmi=2&_hsenc=p2ANqtz-_1nUvhWVgLPk0u0wPmymQojQCYKVgekY7JNdVQiv6HB3GAg0GLktZlWrhQzr9_Xp2L7KpAOz2c8fH5V7jt0iI22jHCmQ&utm_content=2&utm_source=hs_email'><img width='250' height='200' alt='Eureka' src='https://dev.onebanc.ai/images/eurekamailer.png'></a></td></tr><tr><td style='font-family: Lato,Tahoma,sans-serif; font-weight: lighter; font-size:15px; color: #23496d; padding: 30px 0;' align='center'><h3>We found a way to do more with your money!</h3></td></tr><tr><td class='cbutton' align='center' style='font-family: Lato,Tahoma,sans-serif;'> <a href='https://forms.office.com/Pages/ResponsePage.aspx?id=O1d5F6W-EE2CwNlNapJBf_QRlYlJQChEhb9DHv4V1G9UREtBUjdXWUI2N1VaNk5ZRk1ETEw3MUxRUi4u&utm_medium=email&_hsmi=2&_hsenc=p2ANqtz-_1nUvhWVgLPk0u0wPmymQojQCYKVgekY7JNdVQiv6HB3GAg0GLktZlWrhQzr9_Xp2L7KpAOz2c8fH5V7jt0iI22jHCmQ&utm_content=2&utm_source=hs_email'> <img src='cid:eureka' width='225' height='55' alt='Break New Ground' /></a></td></tr><tr><td align='center' style='padding-top: 40px; font-family: Lato,Tahoma,sans-serif;'> <span style='color:#5c7893; font-size: 11px; '>OB, WFH, Gurgaon, HR</span><br> <span><a style='color: #1baec4; font-size: 9px;' href='https://www.google.com/'>Unsubscribe</a></span> <span><a style='color: #1baec4; font-size: 9px;' href='https://www.google.com/'>Manage</a></span> <span><a style='color: #1baec4; font-size: 9px;' href='https://www.google.com/'>Preferences</a></span></td></tr><tr style='height: 40px; background-color: white;'></tr></table></td></tr></table></body></html>";
                mail.BodyEncoding = Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                var obLogo = new Attachment("D:\\git\\emailers\\eureka\\images\\CTA.png");
                obLogo.ContentId = "eureka";
                obLogo.ContentDisposition.Inline = true;
                obLogo.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
                obLogo.ContentType = new ContentType("image/png");
                mail.Attachments.Add(obLogo);
                using (SmtpClient client = new SmtpClient())
                {
                    client.Timeout = 20000;
                     client.EnableSsl = true;
                      client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("kajusingh921@gmail.com", "Kaju@1234");
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";

                    client.Send(mail);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
