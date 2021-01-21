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
    public class ChatHubRepository : IChatHubRepository
    {
        private readonly DataContext _context;

        public ChatHubRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ChatHub> GetChatHubById(int id)
        {
            return await _context.ChatHubs.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

    }
}
