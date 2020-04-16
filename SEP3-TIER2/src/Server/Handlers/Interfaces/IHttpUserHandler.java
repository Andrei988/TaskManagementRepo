package Server.Handlers.Interfaces;

import Server.Model.Communication.Message;

import java.io.IOException;

public interface IHttpUserHandler {
    String login(Message message) throws IOException;

    String getUserInfo(Message message)throws IOException;

    String changePassword(Message message) throws IOException;

    String register(Message message)throws IOException;

}
