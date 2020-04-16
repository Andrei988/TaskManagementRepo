package Server.Model;

public class CMessage {
    private int channelid;
    private String sender;
    private String content;
    private String timesent;

    public CMessage() {
    }

    public int getChannelid() {
        return channelid;
    }

    public void setChannelid(int channelid) {
        this.channelid = channelid;
    }

    public String getSender() {
        return sender;
    }

    public void setSender(String sender) {
        this.sender = sender;
    }

    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }

    public String getTimesent() {
        return timesent;
    }

    public void setTimesent(String timesent) {
        this.timesent = timesent;
    }

    @Override
    public String toString() {
        return "CMessage{" +
                "channelid=" + channelid +
                ", sender='" + sender + '\'' +
                ", content='" + content + '\'' +
                ", timesent='" + timesent + '\'' +
                '}';
    }
}
