package Server.Handlers.Interfaces;

import Server.Model.Communication.Message;

import java.io.IOException;

public interface IHttpTaskHandler {
    String createTask(Message message) throws IOException;

    String deleteTask(int id) throws IOException;

    String getProjectTasks(int id) throws IOException;

    String getUserProjectTasks(String username, int id) throws IOException;

    String setTaskComplete(int id) throws IOException;

    String createComment(Message message) throws IOException;

    String deleteComment(int id) throws IOException;

    String getComments(int id) throws IOException;

}
