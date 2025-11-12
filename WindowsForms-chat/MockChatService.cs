using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsForms_chat.ChatForm;
using winforms_chat.ChatForm;

namespace WindowsForms_chat
{
    public class MockChatService : IChatService
    {
        public async Task<IChatModel?> SendAsync(string message, byte[]? attachment, CancellationToken token)
        {
            await Task.Delay(2000, token);
            return new TextChatModel
            {
                Author = "Bot",
                Body = $"Echo: {message}",
                Inbound = true,
                Time = DateTime.Now
            };
        }
    }

}
