package Server.Model;

public class ChannelUser {

    private int channelid;
    private String username;

    public ChannelUser() {
    }

    public int getChannelid() {
        return channelid;
    }

    public void setChannelid(int channelid) {
        this.channelid = channelid;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    @Override
    public String toString() {
        return "ChannelUser{" +
                "channelid=" + channelid +
                ", username='" + username + '\'' +
                '}';
    }
}
