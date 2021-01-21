using ChatService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatService.Repositories.Interfaces
{
    interface IMessageRepository
    {
        Task<List<Message>> GetMessagesByChatHubId(int id);
    }
}
