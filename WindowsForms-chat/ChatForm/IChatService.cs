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
        Task<IChatModel?> SendAsync(string message, byte[]? attachment, CancellationToken token);
    }
}
