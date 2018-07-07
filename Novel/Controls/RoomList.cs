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
    public partial class RoomList : UserControl
    {
        public string NameP { get; set; }

        public RoomList()
        {
            InitializeComponent();
            SetUI.roomList = this.panel1;
            NameP = "RoomList";
        }
    }
}
