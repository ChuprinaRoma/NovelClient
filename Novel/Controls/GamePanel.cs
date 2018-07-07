using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novel.Logeck.Model;

namespace Novel.Control
{
    public partial class GamePanel : UserControl
    {
        public GamePanel()
        {
            InitializeComponent();
            NovelManager.control = this;
        }

        private void GamePanel_Load(object sender, EventArgs e)
        {

                
        }

        private void KeyT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
