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
    public partial class ManyPanel : UserControl
    {
        public ManyPanel()
        {
            InitializeComponent();
        }

        private void ManyPanel_Load(object sender, EventArgs e)
        {
            label1.Text = NovelManager.login;
        }
    }
}
