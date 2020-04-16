package Server.Model.Communication;


import Server.Model.*;

import java.util.List;

public class Fields {

    private User user;
    private List<Project> projects;
    private PendingInvitation pendinginvitation;
    private List<Task> tasks;
    private List<SubTask> subtasks;
    private List<TaskComment> comments;
    private List<Channel> channels;
    private List<ChannelUser> channelusers;
    private List<CMessage> channelmessages;
    private String password;
    private int responsecode;
    private String responsedescription;

    public Fields() { }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }

    public List<Project> getProjects() {
        return projects;
    }

    public void setProjects(List<Project> projects) {
        this.projects = projects;
    }

    public PendingInvitation getPendinginvitation() {
        return pendinginvitation;
    }

    public void setPendinginvitation(PendingInvitation pendinginvitation) {
        this.pendinginvitation = pendinginvitation;
    }

    public int getResponsecode() {
        return responsecode;
    }

    public void setResponsecode(int responsecode) {
        this.responsecode = responsecode;
    }

    public String getResponsedescription() {
        return responsedescription;
    }

    public void setResponsedescription(String responsedescription) {
        this.responsedescription = responsedescription;
    }

    public List<Task> getTasks() {
        return tasks;
    }

    public void setTasks(List<Task> tasks) {
        this.tasks = tasks;
    }

    public List<TaskComment> getComments() {
        return comments;
    }

    public void setComments(List<TaskComment> comments) {
        this.comments = comments;
    }

    public List<Channel> getChannels() {
        return channels;
    }

    public void setChannels(List<Channel> channels) {
        this.channels = channels;
    }

    public List<ChannelUser> getChannelusers() {
        return channelusers;
    }

    public void setChannelusers(List<ChannelUser> channelusers) {
        this.channelusers = channelusers;
    }

    public List<CMessage> getChannelmessages() {
        return channelmessages;
    }

    public void setChannelmessages(List<CMessage> channelmessages) {
        this.channelmessages = channelmessages;
    }

    public List<SubTask> getSubtasks() {
        return subtasks;
    }

    public void setSubtasks(List<SubTask> subtasks) {
        this.subtasks = subtasks;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    @Override
    public String toString() {
        return "Fields{" +
                "user=" + user +
                ", projects=" + projects +
                ", pendinginvitation=" + pendinginvitation +
                ", tasks=" + tasks +
                ", subtasks=" + subtasks +
                ", comments=" + comments +
                ", channels=" + channels +
                ", channelusers=" + channelusers +
                ", channelmessages=" + channelmessages +
                ", password='" + password + '\'' +
                ", responsecode=" + responsecode +
                ", responsedescription='" + responsedescription + '\'' +
                '}';
    }
}
