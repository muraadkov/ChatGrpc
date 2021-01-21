using ChatService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatService.Repositories.Interfaces
{
    interface IChatHubRepository
    {
        Task<ChatHub> GetChatHubById(int id);
    }
}
