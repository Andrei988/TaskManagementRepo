package Server.Helpers;

import Server.Handlers.*;
import Server.Handlers.Interfaces.*;
import Server.Model.Communication.Message;

import java.io.IOException;

public class HttpClientHelper implements IHttpClientHelper{

    private IHttpProjectHandler projectHandler;
    private IHttpUserHandler userHandler;
    private IHttpTaskHandler taskHandler;
    private IHttpChannelHandler channelHandler;
    private IHttpSubTaskHandler subTaskHandler;

    public HttpClientHelper() {
        String certificatesTrustStorePath = "C:\\Program Files\\Java\\jdk1.8.0_211\\jre\\lib\\security\\cacerts";
        System.setProperty("javax.net.ssl.trustStore", certificatesTrustStorePath);

        projectHandler = new HttpProjectHandler();
        userHandler = new HttpUserHandler();
        taskHandler = new HttpTaskHandler();
        channelHandler = new HttpChannelHandler();
        subTaskHandler = new HttpSubTaskHandler();
    }

    @Override
    public String processMessage(Message message) throws IOException {

        switch (message.getResource()) {
            case "user": {

                switch (message.getMethod()) {
                    case "login": {
                        return userHandler.login(message);
                    }
                    case "register": {
                        return userHandler.register(message);
                    }
                    case "getinfo": {
                        return userHandler.getUserInfo(message);
                    }
                    case "changepassword": {
                        return userHandler.changePassword(message);
                    }
                }
            }
            case "project": {

                switch (message.getMethod()) {
                    case "getinfo": {
                        return projectHandler.getProjectInfo(message);
                    }
                    case "create": {
                        return projectHandler.createProject(message);
                    }
                    case "userprojects": {
                        return projectHandler.getUserProjects(message);
                    }
                    case "getprojectusers": {
                        return projectHandler.getProjectUsers(message.getFields().getProjects().get(0).getId());
                    }
                    case "getpendinginvitations": {
                        return projectHandler.getUserPendingInvitations(message.getFields().getUser().getUsername());
                    }
                    case "inviteaccept": {
                        return projectHandler.inviteAccept(message);
                    }
                    case "invitedecline": {
                        return projectHandler.inviteDecline(message);
                    }
                    case "invite": {
                        return projectHandler.inviteToProject(message);
                    }
                    case "deleteuser": {
                        return projectHandler.deleteFromProject(message);
                    }
                }
            }

            case "task": {
                switch (message.getMethod()) {
                    case "create": {
                        return taskHandler.createTask(message);
                    }
                    case "delete": {
                        return taskHandler.deleteTask(message.getFields().getTasks().get(0).getId());
                    }
                    case "projecttasks": {
                        return taskHandler.getProjectTasks(message.getFields().getProjects().get(0).getId());
                    }
                    case "userprojecttasks": {
                        System.out.println(message);
                        return taskHandler.getUserProjectTasks(message.getFields().getUser().getUsername(), message.getFields().getProjects().get(0).getId());
                    }
                    case "setcomplete": {
                        return taskHandler.setTaskComplete(message.getFields().getTasks().get(0).getId());
                    }
                }
            }
            case "channel": {
                switch (message.getMethod()) {
                    case "create": {
                        return channelHandler.createChannel(message);
                    }
                    case "adduser": {
                        return channelHandler.addUserToChannel(message.getFields().getChannels().get(0).getId(), message.getFields().getUser().getUsername());
                    }
                    case "deleteuser": {
                        return channelHandler.deleteUserFromChannel(message.getFields().getChannels().get(0).getId(), message.getFields().getUser().getUsername());
                    }
                    case "getchannels": {
                        return channelHandler.getChannels(message.getFields().getProjects().get(0).getId());
                    }
                    case "sendmessage": {
                        return channelHandler.sendMessage(message);
                    }
                    case "initchat": {
                        return channelHandler.getChannelMessages(message.getFields().getChannels().get(0).getId());
                    }
                    case "getchannelusers": {
                        return channelHandler.getChannelUsers(message.getFields().getChannels().get(0).getId());
                    }
                    case "delete": {
                        return channelHandler.deleteChannel(message.getFields().getChannels().get(0).getId());
                    }
                }
            }
            case "subtask": {
                switch (message.getMethod()) {
                    case "create": {
                        return subTaskHandler.createSubTask(message);
                    }
                    case "delete": {
                        return subTaskHandler.deleteSubTask(message.getFields().getSubtasks().get(0).getId());
                    }
                    case "setcomplete": {
                        return subTaskHandler.setComplete(message.getFields().getSubtasks().get(0).getId());
                    }
                    case "getsubtasks": {
                        return subTaskHandler.getSubTasks(message.getFields().getSubtasks().get(0).getId());
                    }
                }
            }
            case "comment": {
                switch (message.getMethod()) {
                    case "create": {
                        return taskHandler.createComment(message);
                    }
                    case "delete": {
                        return taskHandler.deleteComment(message.getFields().getComments().get(0).getId());
                    }
                    case "getcomments": {
                        return taskHandler.getComments(message.getFields().getTasks().get(0).getId());
                    }
                }
            }
        }
        return "Method or resource unknown";
    }
}