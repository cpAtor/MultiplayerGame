using System.Threading.Tasks;
using Game.Hubs.Clients;
using Game.Models;
using Microsoft.AspNetCore.SignalR;

namespace Game.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.ReceiveMessage(message);
        }
    }
}