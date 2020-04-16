package Server;

import Server.Helpers.HttpClientHelper;
import Server.Helpers.IHttpClientHelper;
import Server.Model.Communication.Message;
import com.google.gson.*;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.Socket;

public class ServerSocketHandler implements Runnable, IServerSocketHandler {

    private OutputStream outToClient;
    private InputStream inFromClient;
    private Socket socket;

    public ServerSocketHandler(Socket socket) throws IOException {
        this.socket = socket;
        inFromClient = socket.getInputStream();
        outToClient = socket.getOutputStream();
    }

    @Override
    public void run() {

        while (true) {
            try {

                String receivedMessage = decodeMessage(inFromClient);

                System.out.println("JSON STRING FROM TIER1: " + receivedMessage);

                Message message = new Gson().fromJson(receivedMessage, Message.class);

                System.out.println("JSON STRING FROM TIER1: " + receivedMessage);
                System.out.println("MESSAGE OBJECT FROM TIER1: " + message.toString());

                IHttpClientHelper httpClient = new HttpClientHelper();
                sendMessage(outToClient, httpClient.processMessage(message));

            } catch (IOException e) {
                e.printStackTrace();
                System.out.println("Client disconnected.");
                break;
            }

        }
    }

    @Override
    public String decodeMessage(InputStream inputStream) {

        byte[] receivedMessage = new byte[2048];

        try {
            inputStream.read(receivedMessage, 0, 2048);
        } catch (Exception e) {
            e.printStackTrace();
        }


        int i = receivedMessage.length - 1;

        while (receivedMessage[i] != 125) {
            receivedMessage = removeTheElement(receivedMessage, i);
            i--;
        }

        return new String(receivedMessage, 0, receivedMessage.length);
    }

    @Override
    public void sendMessage(OutputStream outputStream, String message)
            throws IOException {
        byte[] toSendBytes = message.getBytes();
        System.out.println("FROM TIER 3 " + message);
        outputStream.write(toSendBytes);
    }

    public byte[] removeTheElement(byte[] arr,
                                   int index) {
        if (arr == null
                || index < 0
                || index >= arr.length) {

            return arr;
        }

        byte[] anotherArray = new byte[arr.length - 1];

        for (int i = 0, k = 0; i < arr.length; i++) {

            if (i == index) {
                continue;
            }

            anotherArray[k++] = arr[i];
        }

        return anotherArray;
    }
}
