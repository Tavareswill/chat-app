using DemoApp.Chat.Hubs;
using DemoApp.Chat.Interfaces.Services;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using DemoApp.Chat.Persistence.Model;
using System.Collections.Generic;

namespace DemoApp.Chat.Services
{
    public class ChatAgentServiceBackgroundCaller : BackgroundService
    {
        private readonly IChatAgent _chatAgent;
        private readonly IHubContext<ChatHub> _hubContext;

        public ChatAgentServiceBackgroundCaller(IChatAgent chatAgent, IHubContext<ChatHub> hubContext)
        {
            _chatAgent = chatAgent;
            _hubContext = hubContext;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    List<MSGHIST> response = _chatAgent.UpdateContext();
                    await _hubContext.Clients.All.SendAsync("async", JsonSerializer.Serialize(response));

                    await Task.Delay(2000);
                }
            }
            catch
            {

                throw;
            }
        }
    }
}
