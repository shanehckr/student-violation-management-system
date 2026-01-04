using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentViolationSystem
{
    internal class EmailService
    {
        public async Task SendParentNotification(
            string guardianEmail,
            string guardianName,
            string studentName,
            string offense,
            string actionTaken)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    mail.From = new MailAddress(EmailConfig.SenderEmail);
                    mail.To.Add(guardianEmail);
                    mail.Subject = "Student Violation Notification";

                    mail.Body =
                        $"Good day {guardianName},\n\n" +
                        $"This is to inform you that your child, {studentName}, has committed the following offense:\n\n" +
                        $"Offense: {offense}\n" +
                        $"Action Taken: {actionTaken}\n\n" +
                        $"Please coordinate with the school administration.\n\n" +
                        $"— Student Violation Monitoring System";

                    smtp.Credentials = new NetworkCredential(
                        EmailConfig.SenderEmail,
                        EmailConfig.AppPassword
                    );
                    smtp.EnableSsl = true;

                    await smtp.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Email Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
        




