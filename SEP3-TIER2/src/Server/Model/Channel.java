package Server.Model;

import java.util.List;

public class Channel {

    private int id;
    private String title;
    private List<User> users;
    private int projectid;

    public Channel(int id, String title, List<User> users, int projectid) {
        this.id = id;
        this.title = title;
        this.users = users;
        this.projectid = projectid;
    }

    public Channel() {
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

    public List<User> getUsers() {
        return users;
    }

    public void setUsers(List<User> users) {
        this.users = users;
    }

    public int getProjectid() {
        return projectid;
    }

    public void setProjectid(int projectid) {
        this.projectid = projectid;
    }

    @Override
    public String toString() {
        return "Channel{" +
                "id=" + id +
                ", title=" + title +
                ", users=" + users +
                ", projectid=" + projectid +
                '}';
    }
}
