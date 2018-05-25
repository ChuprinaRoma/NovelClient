using Novel.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novel.Logeck.Model
{
    public static class NovelManager
    {
        public static System.Windows.Forms.Control control { get; set; }
        public static string login { get; set; }
        public static void Registration(string data)
        {

            if (data == "true")
            {
                MessageBox.Show("Вы успешно зарегистровались");
                SetUI.SetRAControl(new Avtorisation(), control);
            }
            else if (data == "false")
            {
                MessageBox.Show("С таким Логином пользователь уже есть");
            }
            control = null;
        }

        public static void Avtorization(string data)
        {

            if (data == "true")
            {
                SetUI.SetManyControl(new ManyPanel(), control);
            }
            else if (data == "false")
            {
                MessageBox.Show("Такого акаунта нет, пароль или логин были не правильными");
            }
            control = null;
        }
    }
}
