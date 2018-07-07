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
using System.Threading;
using Novel.Logeck.Model;

namespace Novel.Control
{
    public partial class Registration : UserControl
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                NovelManager.control = this;
                Connerctor.Registration(textBox1.Text, textBox2.Text);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Control control = this;
            SetUI.SetRAControl(new Avtorisation(), control);
        }
    }
}
