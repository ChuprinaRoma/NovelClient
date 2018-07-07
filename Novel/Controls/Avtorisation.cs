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
using Novel.Logeck.Model;

namespace Novel.Control
{
    public partial class Avtorisation : UserControl
    {
        public Avtorisation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Control control = this;
            SetUI.SetRAControl(new Registration(), control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                NovelManager.login = textBox1.Text;
                NovelManager.control = this;
                Connerctor.Avtorization(textBox1.Text, textBox2.Text);                
            }
        }
    }
}
