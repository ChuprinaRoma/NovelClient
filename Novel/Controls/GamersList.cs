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
    public partial class GamersList : UserControl
    {
        public string NameP { get; set; }

        public GamersList()
        {
            InitializeComponent();
            SetUI.gamerslist = this.panel1;
            panel2.MouseMove += Event.BtnUser_MouseMove;
            panel2.MouseLeave += Event.BtnUser_MouseLeave;
            NameP = "GamersList";
        }
       
    }
}
