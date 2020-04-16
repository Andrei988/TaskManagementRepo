package Server.Handlers.Interfaces;

import Server.Model.Communication.Message;

import java.io.IOException;

public interface IHttpChannelHandler {
    String sendMessage(Message message) throws IOException;

    String getChannelMessages(int id) throws IOException;

    String getChannelUsers(int id) throws IOException;

    String deleteChannel(int id) throws IOException;

    String getChannels(int id) throws IOException;

    String createChannel(Message message) throws IOException;

    String addUserToChannel(int id, String username) throws IOException;

    String deleteUserFromChannel(int id, String username) throws IOException;
}
