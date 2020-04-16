package Server.Handlers.Interfaces;

import Server.Model.Communication.Message;

import java.io.IOException;

public interface IHttpSubTaskHandler {
    String createSubTask(Message message) throws IOException;

    String deleteSubTask(int id) throws IOException;

    String setComplete(int id) throws IOException;

    String getSubTasks(int id) throws IOException;
}
