using Microsoft.AspNetCore.Identity.UI.Services;

namespace ProyectoFinal_GarroFernando.Models
{
    public class FakeEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            System.Diagnostics.Debug.WriteLine($"Email to: {email}, Subject: {subject}, Messaje: {htmlMessage}");
            return Task.CompletedTask;
        }
    }
}
