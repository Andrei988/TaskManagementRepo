package Server;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class SocketServer implements ISocketServer {
    private final int SERVER_PORT = 2910;

    public SocketServer() {
    }

    public void runServer() throws IOException {
        ServerSocket welcomeSocket = new ServerSocket(SERVER_PORT);
        System.out.println("[*] Server started on port (" + SERVER_PORT + ")...");

        while (true) {
            Socket socket = welcomeSocket.accept();
            System.out.println("Client connected: " + socket.getInetAddress().getHostAddress());
            ServerSocketHandler ssh = new ServerSocketHandler(socket);
            Thread t = new Thread(ssh);
            t.start();
        }
    }

    public static void main(String[] args) {
        ISocketServer server = new SocketServer();

        try {
            server.runServer();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
