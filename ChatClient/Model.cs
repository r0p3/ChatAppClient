using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient
{
    class Model
    {
        string ip = "";
        int port = 12345;

        LoginForm loginForm;
        ChatApp chatApp;

        NetworkStream networkStream;
        TcpClient tcpClient;

        public Model(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            connectToServer();
        }

        public void startChatApp(string username)
        {
            loginForm.Hide();
            chatApp = new ChatApp(username);
            chatApp.Show();
        }

        public void login(string packet)
        {
            loginForm.Update(Commands.LoginOK);
        }
        public void connectToServer()
        {
            if (tcpClient == null || !tcpClient.Connected)
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(new IPEndPoint(IPAddress.Loopback, 12345));
                networkStream = tcpClient.GetStream();
            }

        }
        public void sendToServer(string message)
        {
            if(tcpClient.Connected)
                networkStream.Write(Encoding.UTF8.GetBytes(message), 0, message.Length);
        }
    }
}
