using Novel.Control;
using Novel.Logeck.Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novel.Logeck
{
    public class Event
    {
        private static Color colorPanel = Color.FromArgb(20, 255, 255, 255);
        public static void BtnUser_MouseMove(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        public static void BtnUser_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = colorPanel;
        }

        public static void ClickOnGame(object sender, MouseEventArgs e)
        {
            string NameGame = "";
            if (((System.Windows.Forms.Control)sender) as Label != null)
            {
                NameGame = ((Label)sender).Text;
            }
            else if(((System.Windows.Forms.Control)sender) as Panel != null)
            {
                NameGame = ((Panel)sender).Controls.Find("nameGame", true)[0].Text;
            }

            if (MouseButtons.Right == e.Button)
            {
                MenuItem[] menuItem = new MenuItem[2];
                menuItem[0] = new MenuItem("Создать публичную комнату", ClickMenuItem);
                menuItem[1] = new MenuItem("Создать приватную комнату", ClickMenuItem);
                menuItem[0].Name = $"{NameGame}/public";
                menuItem[1].Name = $"{NameGame}/privat";
                ContextMenu contextMenu = new ContextMenu(menuItem);
                contextMenu.Show(((System.Windows.Forms.Control)sender), e.Location);
            }
        }

        public static void ClickMenuItem(object s, EventArgs e)
        {
            GameConnector.NewRoom(((MenuItem)s).Name);
            
        }
    }
}
