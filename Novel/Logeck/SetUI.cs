using Novel.Control;
using Novel.Logeck.Game.Tic_tac_toe_control;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novel.Logeck
{
    public class SetUI
    {
        public static System.Windows.Forms.Control form { get; set; }
        public static System.Windows.Forms.Panel gamelist { get; set; }
        public static System.Windows.Forms.Panel gamerslist { get; set; }
        public static System.Windows.Forms.Panel roomList { get; set; }
        public static System.Windows.Forms.Control manyPanel { get; set; }
        public static ContextMenue contextMenue { get; set; }

        public static void SetRAControl(System.Windows.Forms.Control control1, System.Windows.Forms.Control contro2)
        {
            if (form.InvokeRequired)
            {
                form.Invoke(new Action(() =>
                {
                    if (contro2 != null)
                    {
                        form.Controls.Remove(contro2);
                    }
                    form.Size = control1.Size;
                    form.MaximumSize = control1.MaximumSize;
                    form.MinimumSize = control1.MinimumSize;
                    form.Controls.Add(control1);
                }));
            }
            else
            {
                if (contro2 != null)
                {
                    form.Controls.Remove(contro2);
                }
                form.Size = control1.Size;
                form.MaximumSize = control1.MaximumSize;
                form.MinimumSize = control1.MinimumSize;
                form.Controls.Add(control1);
            }

            if (control1.InvokeRequired) { control1.Invoke(new Action(() => { control1.Dock = System.Windows.Forms.DockStyle.Fill; })); }
            else { control1.Dock = System.Windows.Forms.DockStyle.Fill; }
        }

        public static void SetManyControl(System.Windows.Forms.Control controlM, System.Windows.Forms.Control contro2)
        {
            if (form.InvokeRequired)
            {
                form.Invoke(new Action(() =>
                {
                    if (contro2 != null)
                    {
                        form.Controls.Remove(contro2);
                    }
                    form.Size = controlM.Size;
                    form.MaximumSize = new System.Drawing.Size(controlM.MaximumSize.Width, 4000);
                    form.MinimumSize = new System.Drawing.Size(controlM.MinimumSize.Width, 0);
                    controlM.Name = "ManyPanel";
                    form.Controls.Add(controlM);
                }));
            }
            else
            {
                if (contro2 != null)
                {
                    form.Controls.Remove(contro2);
                }
                form.Size = controlM.Size;
                form.MaximumSize = new System.Drawing.Size(controlM.MaximumSize.Width, 4000);
                form.MinimumSize = new System.Drawing.Size(controlM.MinimumSize.Width, 0);
                form.Controls.Add(controlM);
            }

            if (controlM.InvokeRequired) { controlM.Invoke(new Action(() => { controlM.Dock = System.Windows.Forms.DockStyle.Fill; })); }
            else { controlM.Dock = System.Windows.Forms.DockStyle.Fill; }
        }


        public static void SetGamePanelControl(GamePanel control1, string id, string key, string typeRoom)
        {
            if (form.InvokeRequired)
            {
                form.Invoke(new Action(() =>
                {
                    manyPanel = form.Controls.Find("ManyPanel", true)[0];
                    form.Controls.Remove(manyPanel);
                    form.MaximumSize = new Size(control1.Width+10, control1.Height + 40);
                    form.MinimumSize = new Size(control1.Width+10, control1.Height + 40);
                    control1.idT.Text = id;
                    control1.KeyT.Text = key;
                    control1.typeRoomT.Text = typeRoom;
                    form.Controls.Add(control1);
                }));
            }
            else
            {
                manyPanel = form.Controls.Find("ManyPanel", true)[0];
                form.Controls.Remove(manyPanel);
                form.MaximumSize = new Size(control1.Width - 100, control1.Height + 40);
                form.MinimumSize = new Size(control1.Width - 100, control1.Height + 40);
                control1.idT.Text = id;
                control1.KeyT.Text = key;
                control1.typeRoomT.Text = typeRoom;
                form.Controls.Add(control1);
            }
        }

        //Создается GamaPanel, и на GamePanel добавляется поле игры
        public static GamePanel SetGameOnGamaeOamel(System.Windows.Forms.Control cGame)
        {
            GamePanel gamePanel = new GamePanel();
            cGame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            cGame.Location = new System.Drawing.Point(258, 42);
            cGame.MaximumSize = new System.Drawing.Size(410, 470);
            cGame.MinimumSize = new System.Drawing.Size(410, 470);
            cGame.Name = "tic_tac_toeControl1";
            cGame.Size = new System.Drawing.Size(410, 470);
            cGame.TabIndex = 26;
            gamePanel.anyListUser1.Width = cGame.Location.X - 10;
            gamePanel.Controls.Add(cGame);

            return gamePanel;
        }

        public static void AddControlGamers(string logIn, string stateUser)
        {
            Panel panel1 = SetPanel(logIn);
            Label label1 = SetLabel(12.75F, new Point(28, 10), new Size(44, 25), logIn, "logIn");
            Label label2 = SetLabel(8F, new Point(30, 35), new Size(85, 15), stateUser, "stateUser");
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.MouseMove += Event.BtnUser_MouseMove;
            panel1.MouseLeave += Event.BtnUser_MouseLeave;
            gamerslist.Invoke(new Action(() =>
            {
                gamerslist.Controls.Add(panel1);
            }));
        }

        public static void AddControlGame(string nameGame)
        {
            Panel panel1 = SetPanel(nameGame);
            Label label1 = SetLabel(17.75F, new Point(28, 10), new Size(44, 25), nameGame, "nameGame");
            panel1.Controls.Add(label1);
            panel1.MouseMove += Event.BtnUser_MouseMove;
            panel1.MouseLeave += Event.BtnUser_MouseLeave;
            panel1.MouseUp += Event.ClickOnGame;
            label1.MouseUp += Event.ClickOnGame;
            gamerslist.Invoke(new Action(() =>
            {
                gamelist.Controls.Add(panel1);
            }));
        }

        public static void AddControlRoom(string nameGame, string CountUserInRoom, string idRoom)
        {
            Panel panel1 = SetPanel(nameGame);
            Label label1 = SetLabel(12.75F, new Point(28, 10), new Size(44, 25), nameGame, "nameGame");
            Label label2 = SetLabel(8F, new Point(30, 35), new Size(85, 15), CountUserInRoom, "stateRoom");
            Label label3 = SetLabel(8F, new Point(label2.Width + 10, 35), new Size(85, 15), idRoom, "idRoom");
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.MouseMove += Event.BtnUser_MouseMove;
            panel1.MouseLeave += Event.BtnUser_MouseLeave;
            gamerslist.Invoke(new Action(() =>
            {
                roomList.Controls.Add(panel1);
            }));
        }

        private static Label SetLabel(Single font, Point location, Size size, string text, string nameL)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", font, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            label.Location = location;
            label.Name = nameL;
            label.Size = size;
            label.TabIndex = 0;
            label.Text = text;
            return label;
        }

        private static Panel SetPanel(string text)
        {
            Panel panel1 = new Panel();

            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Size = new System.Drawing.Size(306, 57);
            panel1.Name = text + "P";
            return panel1;
        }

        public static void removeGame(string nameGame)
        {
            gamerslist.Invoke(new Action(() =>
            {
                gamerslist.Controls.Remove(gamerslist.Controls.Find(nameGame + "P", true)[0]);
            }));
        }

        public static void removeUser(string logIn)
        {
            gamerslist.Invoke(new Action(() =>
            {
                gamerslist.Controls.Remove(gamerslist.Controls.Find(logIn + "P", true)[0]);
            }));
        }


    }
}
