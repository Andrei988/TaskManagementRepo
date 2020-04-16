package Server.Helpers;

import Server.Model.Communication.Message;

import java.io.IOException;

public interface IHttpClientHelper {
    String processMessage(Message message) throws IOException;
}
