package Server.Model;

import java.util.List;

public class Project {

    private int id;
    private String title;
    private String description;
    private List<Channel> channels;
    private String ownerusername;
    private List<ProjectUser> users;

    public Project(int id, String title, String description, List<Channel> channels, String ownerusername) {
        this.id = id;
        this.title = title;
        this.description = description;
        this.channels = channels;
        this.ownerusername = ownerusername;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public List<Channel> getChannels() {
        return channels;
    }

    public void setChannels(List<Channel> channels) {
        this.channels = channels;
    }

    public String getOwnerusername() {
        return ownerusername;
    }

    public void setOwnerusername(String ownerusername) {
        this.ownerusername = ownerusername;
    }

    public List<ProjectUser> getUsers() {
        return users;
    }

    public void setUsers(List<ProjectUser> users) {
        this.users = users;
    }

    @Override
    public String toString() {
        return "Project{" +
                "id=" + id +
                ", title='" + title + '\'' +
                ", description='" + description + '\'' +
                ", channels=" + channels +
                ", ownerusername='" + ownerusername + '\'' +
                ", users=" + users +
                '}';
    }
}
