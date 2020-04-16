package Server.Model;

public class Task {

    private int id;
    private boolean iscomplete;
    private String username;
    private int projectid;
    private String description;
    private String starttime;
    private String endtime;
    private String colorlabel;

    public Task() {
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public boolean isIscomplete() {
        return iscomplete;
    }

    public void setIscomplete(boolean iscomplete) {
        this.iscomplete = iscomplete;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public int getProjectid() {
        return projectid;
    }

    public void setProjectid(int projectid) {
        this.projectid = projectid;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getStarttime() {
        return starttime;
    }

    public void setStarttime(String starttime) {
        this.starttime = starttime;
    }

    public String getEndtime() {
        return endtime;
    }

    public void setEndtime(String endtime) {
        this.endtime = endtime;
    }

    public String getColorlabel() {
        return colorlabel;
    }

    public void setColorlabel(String colorlabel) {
        this.colorlabel = colorlabel;
    }

    @Override
    public String toString() {
        return "Task{" +
                "id=" + id +
                ", iscomplete=" + iscomplete +
                ", username='" + username + '\'' +
                ", projectid=" + projectid +
                ", description='" + description + '\'' +
                ", starttime=" + starttime +
                ", endtime=" + endtime +
                ", colorlabel='" + colorlabel + '\'' +
                '}';
    }
}
