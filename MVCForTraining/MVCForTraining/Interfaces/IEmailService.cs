using MVCForTraining.Models;

namespace MVCForTraining.Interfaces
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
