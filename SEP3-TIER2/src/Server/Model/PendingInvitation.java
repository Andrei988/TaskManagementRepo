package Server.Model;

public class PendingInvitation {

    private int projectid;
    private String username;

    public PendingInvitation(int projectId, String username) {
        this.projectid = projectId;
        this.username = username;
    }

    public PendingInvitation() {
    }

    public int getProjectId() {
        return projectid;
    }

    public void setProjectId(int projectId) {
        this.projectid = projectId;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    @Override
    public String toString() {
        return "PendingInvitation{" +
                "projectId=" + projectid +
                ", username='" + username + '\'' +
                '}';
    }
}
