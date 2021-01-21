using ChatService.Context;
using ChatService.Models;
using ChatService.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatService.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly DataContext _context;

        public MessageRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Message>> GetMessagesByChatHubId(int id)
        {
            return await _context.Messages.Where(x => x.ChatHubId == id).ToListAsync();
        }
    }
}
