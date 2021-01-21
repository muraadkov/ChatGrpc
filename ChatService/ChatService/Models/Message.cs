using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatService.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Text { get; set; }

        public int ChatHubId { get; set; }
        public ChatHub Chat { get; set; }


    }
}
