using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace server{
    public class Player : Hub
    {
        public Task MarkPosition(string playerName, string position)
        {
            return Clients.All.InvokeAsync("OnMarked", playerName, position);
        }
    }
}
