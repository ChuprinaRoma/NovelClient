using Novel.Control;
using Novel.Logeck;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetUI.form = this;
            IsAvtorization();
            
        }

        private void IsAvtorization()
        {
            if(File.Exists("./LogIn/LogIn.txt"))
            {
                string[] infoUser = File.ReadAllLines("./LogIn/LogIn.txt");
            }
            else
            {
                System.Windows.Forms.Control form = this;
                SetUI.SetRAControl(new Avtorisation(), null);
            }
        }     
    }
}
