using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using W101RLauncher.Forms;

namespace W101RLauncher.Methods
{
    public static class Authentication
    {
        public static bool ServerAuthentication(string ip, string port, string username, string password, string alphaKey)
        {
            var flag = false;
            try {
                var tcpClient = new TcpClient();
                
                tcpClient.Connect(ip,int.Parse(port));
                Stream stm = tcpClient.GetStream();
                        
                var asen= new ASCIIEncoding();
                var usernameByte=asen.GetBytes(username + "\r" + password + "\r" + alphaKey);
                
                stm.Write(usernameByte,0,usernameByte.Length);
            
                var receivedByte = new byte[100];
                var k= stm.Read(receivedByte,0,100);
                var receivedMessage = "";

                for (var i = 0; i < k; i++)
                {
                    receivedMessage += Convert.ToChar(receivedByte[i]);
                }

                tcpClient.Close();
                
                if (receivedMessage.Equals("Authenticated"))
                {
                    flag = true;
                }
                else if (receivedMessage.Equals("Incorrect credentials"))
                {
                    var errorCredentials = new PopupForm(Properties.Resources.error_credentials);
                    errorCredentials.ShowDialog();
                    GC.Collect();
                }
                else if (receivedMessage.Equals("Banned"))
                {
                    var errorBanned = new PopupForm(Properties.Resources.error_banned);
                    errorBanned.ShowDialog();
                    GC.Collect();
                }
            }
        
            catch (Exception)
            {
                var errorUnreachable = new PopupForm(Properties.Resources.error_unreachable);
                errorUnreachable.ShowDialog();
                GC.Collect();
            }
            return flag;
        }
    }
}