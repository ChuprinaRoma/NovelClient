using Novel.Control;
using Novel.Logeck.Game.Tic_tac_toe_control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novel.Logeck.Game
{
    public class SwitchControlGame
    {
        public static GamePanel GetGame(string nameGame)
        {
            GamePanel pGame = null;
            switch (nameGame)
            {
                case "Tic_tac_toe":
                    {
                        
                        Tic_tac_toeControl cGame = new Tic_tac_toeControl();
                        pGame = SetUI.SetGameOnGamaeOamel(cGame);
                        break;
                    }
            }
            return pGame;
        }
    }
}
