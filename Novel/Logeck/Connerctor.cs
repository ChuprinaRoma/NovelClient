

using Novel.Control;
using Novel.Logeck.Model;
using System.Threading;
using System.Windows.Forms;
using WebSocketSharp;

namespace Novel.Logeck
{
    public class Connerctor
    {
        public static WebSocket wsc = null;
        

        public static void Registration(string logIn, string password)
        {
            wsc = new WebSocket($"ws://127.0.0.1:8080?Registartion/{logIn}/{password}");
            wsc.OnMessage += Mesage;
            wsc.OnClose += Close;
            wsc.Connect();
            
        }
        public static void Avtorization(string logIn, string password)
        {
            wsc = new WebSocket($"ws://localhost:8080?Avtorization/{logIn}/{password}");
            wsc.OnMessage += Mesage;
            wsc.OnClose += Close;
            wsc.Connect();
        }

        private static void Mesage(object s, MessageEventArgs e)
        {
            string[] parser = e.Data.Split('/');
            if (parser[0] == "Avtorization")
            {
                NovelManager.Avtorization(parser[1]);
            }
            else if (parser[0] == "Registartion")
            {
                NovelManager.Registration(parser[1]);
            }
            else if(parser[0] == "UpdateUser")
            {
                SetUI.AddControlGamers(parser[1], parser[2]);
            }
            else if(parser[0] == "RemoveUser")
            {
                SetUI.removeUser(parser[1]);
            }
            else if(parser[0] == "UpdateGame")
            {
                SetUI.AddControlGame(parser[1]);
            }
            else if(parser[0]  == "NewRoom")
            {
                SetUI.AddControlRoom(parser[1],parser[2], "1 из 2");
            }
        }

        


        private static void Close(object s, CloseEventArgs e)
        {
            NovelManager.Disconnect();
        }
    }
}
