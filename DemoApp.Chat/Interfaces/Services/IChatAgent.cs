using DemoApp.Chat.Persistence.Model;
using System.Collections.Generic;

namespace DemoApp.Chat.Interfaces.Services
{
    public interface IChatAgent
    {
        void SendMessage(string user, string message);
        List<MSGHIST> UpdateContext();
    }
}
