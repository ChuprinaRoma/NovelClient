using Novel.Control;
using Novel.Logeck.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Novel.Logeck.Game
{
    public class GameConnector
    {
        private static HttpClient httpClient = null;
        private static void Init()
        {
            httpClient = new HttpClient();
        }

        public static void NewRoom(string url)
        {
            GamePanel cGame = null;
            string[] parse =  null;
            new Thread( async() =>
            {
                Init();
                string response = await httpClient.GetStringAsync($"http://127.0.0.1:8081/{url}/{NovelManager.login}");
                parse = response.Split('/');
                cGame = SwitchControlGame.GetGame(parse[0]);
                SetUI.SetGamePanelControl(cGame, parse[1], parse[2], parse[3]);
            }).Start();            
        }
    }
}
