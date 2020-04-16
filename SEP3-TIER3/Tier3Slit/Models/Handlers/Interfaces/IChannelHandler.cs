using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier3Slit.Communication;

namespace Tier3Slit.Models.Handlers
{
    interface IChannelHandler
    {
        string CreateChannel(Message message);
        string AddUserToChannel(int channelId, string username);
        string DeleteUserFromChannel(int channelId, string username);
        string GetChannels(int Id);
        string GetChannelUsers(int Id);
        string GetChannelMessages(int Id);
        string SendMessage(Message Message);
        string DeleteChannel(int Id);
    }
}
