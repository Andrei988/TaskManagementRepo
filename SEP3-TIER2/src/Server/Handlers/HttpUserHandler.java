package Server.Handlers;

import Server.Handlers.Interfaces.IHttpUserHandler;
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

public class HttpUserHandler implements IHttpUserHandler {

    public HttpUserHandler() {
    }

    @Override
    public String changePassword(Message message) throws IOException {

        Gson jsonBuilder = new GsonBuilder().create();
        String messageJson = jsonBuilder.toJson(message);

        URL url = new URL("https://localhost:5001/api/User/password/");
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
    public String register(Message message) throws IOException {

        String response = "";

        Gson jsonBuilder = new GsonBuilder().create();
        String messageJson = jsonBuilder.toJson(message);

        URL url = new URL("https://localhost:5001/api/User/register");
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

            response = FirstAndLast(res.toString());

        } else {
            System.out.println("PUT request not worked");
        }

        return response;

    }

    @Override
    public String login(Message message) throws IOException {

        Gson jsonBuilder = new GsonBuilder().create();
        String messageJson = jsonBuilder.toJson(message);

        URL url = new URL("https://localhost:5001/api/User/login");
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

                System.out.println(FilterJson(res.toString()));

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
    public String getUserInfo(Message message) throws IOException {
        StringBuilder result = new StringBuilder();
        URL url = new URL("https://localhost:5001/api/User/" + message.getFields().getUser().getUsername());
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
