using DemoApp.Chat.Interfaces.Services;
using DemoApp.Chat.Persistence;
using DemoApp.Chat.Persistence.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoApp.Chat.Services
{
    public class ChatAgent : IChatAgent
    {
        private readonly ChatDbContext _chatDbContext;
        public ChatAgent(ChatDbContext chatDbContext)
        {
            _chatDbContext = chatDbContext;
        }
        public void SendMessage(string user, string message)
        {
            try
            {
                _chatDbContext.Interactions.Add(new MSGHIST
                {
                    User = user,
                    Message = message,
                    SendOn = DateTime.Now
                });

                _chatDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public List<MSGHIST> UpdateContext()
        {
            try
            {
                List<MSGHIST> context = _chatDbContext.Interactions.ToList();
                return context;
            }
            catch
            {
                throw;
            }
        }
    }
}
