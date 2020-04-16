package Server;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;

public interface IServerSocketHandler {
    String decodeMessage(InputStream inputStream);

    void sendMessage(OutputStream outputStream, String message)throws IOException;

    byte[] removeTheElement(byte[] arr, int index);


}
