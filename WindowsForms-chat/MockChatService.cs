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
        public string Name => "Mock Bot";

        public async Task<string> SendAsync(
            string message,
            byte[]? attachment,
            CancellationToken token,
            Action<string>? onPartial = null)
        {
            var sb = new StringBuilder();

            // Simulate partial streaming of the echo reply
            string reply = $"Echo: {message}";
            for (int i = 0; i < reply.Length; i++)
            {
                token.ThrowIfCancellationRequested();
                sb.Append(reply[i]);

                if (i % 3 == 0) // every few characters, push an update
                    onPartial?.Invoke(sb.ToString());

                await Task.Delay(50, token); // simulate typing delay
            }

            // Final output
            return sb.ToString();
        }
    }
}
