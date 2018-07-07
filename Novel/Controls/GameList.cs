using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novel.Logeck;

namespace Novel.Control
{
    public partial class GameList : UserControl
    {
        public GameList()
        {
            InitializeComponent();
            SetUI.gamelist = this.panel1;
        }

        private void GameList_Load(object sender, EventArgs e)
        {
            
        }

        private void GameList_Click(object sender, EventArgs e)
        {
        }

        private void contextMenue1_Load(object sender, EventArgs e)
        {

        }
    }
}