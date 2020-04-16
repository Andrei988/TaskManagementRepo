package Server.Model;

public class ProjectUser {

    private int projectid;
    private String username;

    public int getProjectid() {
        return projectid;
    }

    public void setProjectid(int projectid) {
        this.projectid = projectid;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    @Override
    public String toString() {
        return "ProjectUser{" +
                "projectid=" + projectid +
                ", username='" + username + '\'' +
                '}';
    }
}
