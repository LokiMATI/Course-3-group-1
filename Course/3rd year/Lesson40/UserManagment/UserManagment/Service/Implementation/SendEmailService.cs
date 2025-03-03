using UserManagment.Service.Interface;

namespace UserManagment.Service.Implementation;

public class SendEmailService : ISendEmailService
{
    public void SendWelcomeEmail(string email)
    {
        // Логика отправки email
        Console.WriteLine($"Sending welcome email to {email}");
    }
}