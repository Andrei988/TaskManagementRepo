package Server.Model;

public class SubTask {
    private int taskid;
    private int id;
    private boolean iscomplete;
    private String description;
    private String starttime;
    private String endtime;
    private String colorlabel;

    public SubTask() {
    }

    public int getTaskid() {
        return taskid;
    }

    public void setTaskid(int taskid) {
        this.taskid = taskid;
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
        return "SubTask{" +
                "taskid=" + taskid +
                ", id=" + id +
                ", iscomplete=" + iscomplete +
                ", description='" + description + '\'' +
                ", starttime='" + starttime + '\'' +
                ", endtime='" + endtime + '\'' +
                ", colorlabel='" + colorlabel + '\'' +
                '}';
    }
}
