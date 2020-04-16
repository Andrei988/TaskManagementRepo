using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.Networking
{
    public class AsyncClient
    {
        private const int PORT = 2910;

        private IPHostEntry ipHostEntry;
        private IPAddress IP;
        private IPEndPoint ipEndPoint;

        private Socket socket;

        public AsyncClient()
        {
            ipHostEntry = Dns.GetHostEntry("172.17.14.97");
            IP = ipHostEntry.AddressList[0];
            ipEndPoint = new IPEndPoint(IP, PORT);
            socket = new Socket(IP.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
            socket.ConnectAsync(ipEndPoint).ConfigureAwait(false);
        }




        public async Task<string> SendAsync(String jsonData)
        {
            var bytes = Encoding.ASCII.GetBytes(jsonData);
            await SendAsync(socket, bytes, 0, bytes.Length, 0).ConfigureAwait(false);
            return await ReceiveAsync(socket);
        }

        public Task<int> SendAsync(Socket socket, byte[] buffer, int offset, int size, SocketFlags flags)
        {
            if (socket == null) throw new ArgumentNullException(nameof(socket));

            var tcs = new TaskCompletionSource<int>();
            socket.BeginSend(buffer, offset, size, flags, iar =>
            {
                try
                {
                    tcs.TrySetResult(socket.EndSend(iar));
                }
                catch (OperationCanceledException)
                {
                    tcs.TrySetCanceled();
                }
                catch (Exception exc)
                {
                    tcs.TrySetException(exc);
                }
            }, null);

            return tcs.Task;
        }

        private async Task<string> ReceiveAsync(Socket socket)
        {
            if (socket == null) throw new ArgumentNullException(nameof(socket));

            const int buffSize = 2048;
            var buffer = new byte[buffSize];

            var rs = new StringBuilder(buffSize);

            var completion = new TaskCompletionSource<int>();
            do
            {
                var size = Math.Min(buffSize, socket.Available);
                socket.BeginReceive(buffer, 0, size, SocketFlags.None, iar =>
                {
                    try
                    {
                        completion.TrySetResult(socket.EndReceive(iar));
                    }
                    catch (OperationCanceledException)
                    {
                        completion.TrySetCanceled();
                    }
                    catch (Exception exc)
                    {
                        completion.TrySetException(exc);
                    }
                }, null);

                await completion.Task;
                rs.Append(Encoding.ASCII.GetString(buffer, 0, size));
            } while (socket.Available > 0);


            return rs.ToString();
        }
    }
}