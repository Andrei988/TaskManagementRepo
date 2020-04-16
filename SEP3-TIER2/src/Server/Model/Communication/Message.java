package Server.Model.Communication;

public class Message {

    private String resource;
    private String method;
    private Fields fields;

    public void setResource(String resource) {
        this.resource = resource;
    }

    public void setMethod(String method) {
        this.method = method;
    }

    public String getResource() {
        return resource;
    }

    public String getMethod() {
        return method;
    }

    public Fields getFields() {
        return fields;
    }

    public void setFields(Fields fields) {
        this.fields = fields;
    }

    @Override
    public String toString() {
        return "Message{" +
                "resource='" + resource + '\'' +
                ", method='" + method + '\'' +
                ", fields=" + fields +
                '}';
    }
}
