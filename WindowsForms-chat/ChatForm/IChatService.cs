using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using winforms_chat.ChatForm;

namespace WindowsForms_chat.ChatForm
{
    public interface IChatService
    {
        string Name { get; }  // The responder's display name
        Task<string> SendAsync(
            string message,
            byte[]? attachment,
            CancellationToken token,
            Action<string>? onPartial = null);
    }
}
