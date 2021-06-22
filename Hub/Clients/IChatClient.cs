using System.Threading.Tasks;
using Game.Models;

namespace Game.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}