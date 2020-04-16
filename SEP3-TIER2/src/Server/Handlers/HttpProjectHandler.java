package Server.Handlers;

import Server.Handlers.Interfaces.IHttpProjectHandler;
import Server.Model.Communication.Message;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import javax.net.ssl.HttpsURLConnection;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLConnection;

public class HttpProjectHandler implements IHttpProjectHandler {

    public HttpProjectHandler() {
    }

    @Override
    public String getUserPendingInvitations(String username) throws IOException {

        StringBuilder result = new StringBuilder();
        URL url = new URL("https://localhost:5001/api/Project/Invitations/" + username);
        HttpsURLConnection conn = (HttpsURLConnection) url.openConnection();
        conn.setRequestMethod("GET");
        BufferedReader rd = new BufferedReader(new InputStreamReader(conn.getInputStream()));
        String line;
        while ((line = rd.readLine()) != null) {
            result.append(line);
        }
        rd.close();

        return result.toString();


    }

    @Override
    public String deleteFromProject(Message message) throws IOException {
        StringBuilder result = new StringBuilder();
        URL url = new URL("https://localhost:5001/api/Project/Delete/" + message.getFields().getUser().getUsername() + "/" + message.getFields().getProjects().get(0).getId());
        HttpsURLConnection conn = (HttpsURLConnection) url.openConnection();
        conn.setRequestMethod("DELETE");
        BufferedReader rd = new BufferedReader(new InputStreamReader(conn.getInputStream()));
        String line;
        while ((line = rd.readLine()) != null) {
            result.append(line);
        }
        rd.close();

        return result.toString();
    }

    @Override
    public String inviteToProject(Message message) throws IOException {

        Gson jsonBuilder = new GsonBuilder().create();
        String messageJson = jsonBuilder.toJson(message);

        URL url = new URL("https://localhost:5001/api/Project/Invite");
        URLConnection connection = url.openConnection();
        HttpsURLConnection https = (HttpsURLConnection) connection;

        https.setRequestMethod("POST");
        connection.setRequestProperty("Content-Type", "application/json; charset=UTF-8");
        connection.setRequestProperty("Accept", "application/json");
        connection.setRequestProperty("Content-Length", String.valueOf(messageJson.length()));
        connection.setDoOutput(true);

        OutputStream os = connection.getOutputStream();
        os.write(messageJson.getBytes("UTF-8"));

        os.close();

        try {
            if (https.getResponseCode() == HttpURLConnection.HTTP_OK) {
                BufferedReader in = new BufferedReader(new InputStreamReader(
                        connection.getInputStream()));
                String inputLine;
                StringBuffer res = new StringBuffer();

                while ((inputLine = in.readLine()) != null) {
                    res.append(inputLine);
                }
                in.close();

                Message m = jsonBuilder.fromJson(FilterJson(res.toString()), Message.class);
                return m.getFields().getResponsedescription();
            }
        } catch (Exception e) {
            System.out.println("POST request error");
            e.printStackTrace();
        }
        return "Server error";

    }

    @Override
    public String createProject(Message message) throws IOException {

        try {
            String response = "";

            Gson jsonBuilder = new GsonBuilder().create();
            String messageJson = jsonBuilder.toJson(message);

            URL url = new URL("https://localhost:5001/api/Project/create");
            URLConnection connection = url.openConnection();
            HttpsURLConnection https = (HttpsURLConnection) connection;

            https.setRequestMethod("PUT");
            connection.setRequestProperty("Content-Type", "application/json; charset=UTF-8");
            connection.setRequestProperty("Accept", "application/json");
            connection.setRequestProperty("Content-Length", String.valueOf(messageJson.length()));
            connection.setDoOutput(true);

            OutputStream os = connection.getOutputStream();
            os.write(messageJson.getBytes("UTF-8"));

            os.close();

            if (https.getResponseCode() == HttpURLConnection.HTTP_OK) {
                BufferedReader in = new BufferedReader(new InputStreamReader(
                        connection.getInputStream()));
                String inputLine;
                StringBuffer res = new StringBuffer();

                while ((inputLine = in.readLine()) != null) {
                    res.append(inputLine);
                }
                in.close();

            } else {
                System.out.println("PUT request not worked");
            }
            return response;
        } catch (Exception e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public String getProjectUsers(int id) throws IOException {
        StringBuilder result = new StringBuilder();
        URL url = new URL("https://localhost:5001/api/Project/Users/" + id);
        HttpsURLConnection conn = (HttpsURLConnection) url.openConnection();
        conn.setRequestMethod("GET");
        BufferedReader rd = new BufferedReader(new InputStreamReader(conn.getInputStream()));
        String line;
        while ((line = rd.readLine()) != null) {
            result.append(line);
        }
        rd.close();

        return result.toString();
    }

    @Override
    public String getUserProjects(Message message) throws IOException {

        StringBuilder result = new StringBuilder();
        URL url = new URL("https://localhost:5001/api/Project/" + message.getFields().getUser().getUsername());
        HttpsURLConnection conn = (HttpsURLConnection) url.openConnection();
        conn.setRequestMethod("GET");
        BufferedReader rd = new BufferedReader(new InputStreamReader(conn.getInputStream()));
        String line;
        while ((line = rd.readLine()) != null) {
            result.append(line);
        }
        rd.close();

        return FirstAndLast(result.toString());


    }

    @Override
    public String getProjectInfo(Message message) throws IOException {

        StringBuilder result = new StringBuilder();
        URL url = new URL("https://localhost:5001/api/Project/Info/" + message.getFields().getProjects().get(0).getId());
        HttpsURLConnection conn = (HttpsURLConnection) url.openConnection();
        conn.setRequestMethod("GET");
        BufferedReader rd = new BufferedReader(new InputStreamReader(conn.getInputStream()));
        String line;
        while ((line = rd.readLine()) != null) {
            result.append(line);
        }
        rd.close();

        return FirstAndLast(result.toString());
    }

    @Override
    public String inviteDecline(Message message) throws IOException {

        Gson jsonBuilder = new GsonBuilder().create();
        String messageJson = jsonBuilder.toJson(message);

        URL url = new URL("https://localhost:5001/api/Project/InviteDecline/");
        URLConnection connection = url.openConnection();
        HttpsURLConnection https = (HttpsURLConnection) connection;

        https.setRequestMethod("POST");
        connection.setRequestProperty("Content-Type", "application/json; charset=UTF-8");
        connection.setRequestProperty("Accept", "application/json");
        connection.setRequestProperty("Content-Length", String.valueOf(messageJson.length()));
        connection.setDoOutput(true);

        OutputStream os = connection.getOutputStream();
        os.write(messageJson.getBytes("UTF-8"));

        os.close();

        try {
            if (https.getResponseCode() == HttpURLConnection.HTTP_OK) {
                BufferedReader in = new BufferedReader(new InputStreamReader(
                        connection.getInputStream()));
                String inputLine;
                StringBuffer res = new StringBuffer();

                while ((inputLine = in.readLine()) != null) {
                    res.append(inputLine);
                }
                in.close();

                Message m = jsonBuilder.fromJson(res.toString(), Message.class);
                return m.getFields().getResponsedescription();
            }
        } catch (Exception e) {
            System.out.println("POST request error");
            e.printStackTrace();
        }
        return "Server error";

    }

    @Override
    public String inviteAccept(Message message) throws IOException {
        Gson jsonBuilder = new GsonBuilder().create();
        String messageJson = jsonBuilder.toJson(message);

        URL url = new URL("https://localhost:5001/api/Project/InviteAccept/");
        URLConnection connection = url.openConnection();
        HttpsURLConnection https = (HttpsURLConnection) connection;

        https.setRequestMethod("POST");
        connection.setRequestProperty("Content-Type", "application/json; charset=UTF-8");
        connection.setRequestProperty("Accept", "application/json");
        connection.setRequestProperty("Content-Length", String.valueOf(messageJson.length()));
        connection.setDoOutput(true);

        OutputStream os = connection.getOutputStream();
        os.write(messageJson.getBytes("UTF-8"));

        os.close();

        try {
            if (https.getResponseCode() == HttpURLConnection.HTTP_OK) {
                BufferedReader in = new BufferedReader(new InputStreamReader(
                        connection.getInputStream()));
                String inputLine;
                StringBuffer res = new StringBuffer();

                while ((inputLine = in.readLine()) != null) {
                    res.append(inputLine);
                }
                in.close();

                Message m = jsonBuilder.fromJson(res.toString(), Message.class);
                return m.getFields().getResponsedescription();
            }
        } catch (Exception e) {
            System.out.println("POST request error");
            e.printStackTrace();
        }
        return "Server error";
    }


    private String FirstAndLast(String str) {
        str = str.substring(1, str.length() - 1);
        return str;
    }

    private String FilterJson(String json) {
        String x = json.replaceAll("\\\\", "");
        x = FirstAndLast(x);
        return x;
    }


}
