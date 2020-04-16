package Server.Handlers.Interfaces;

import Server.Model.Communication.Message;

import java.io.IOException;

public interface IHttpProjectHandler {
    String getUserPendingInvitations(String username) throws IOException;

    String deleteFromProject(Message message) throws IOException;

    String inviteToProject(Message message) throws IOException;

    String createProject(Message message) throws IOException;

    String getProjectUsers(int id) throws IOException;

    String getUserProjects(Message message) throws IOException;

    String getProjectInfo(Message message) throws IOException;

    String inviteDecline(Message message) throws IOException;

    String inviteAccept(Message message) throws IOException;
}
