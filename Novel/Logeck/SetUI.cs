using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novel.Logeck
{
    public static class SetUI
    {
        public static System.Windows.Forms.Control form { get; set; }
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
            else{ control1.Dock = System.Windows.Forms.DockStyle.Fill;}
        }

        public static void SetManyControl(System.Windows.Forms.Control controlM, System.Windows.Forms.Control contro)
        {
            if (form.InvokeRequired)
            {
                form.Invoke(new Action(() =>
                {
                    if (contro != null)
                    {
                        form.Controls.Remove(contro);
                    }
                    form.Size = controlM.Size;
                    form.MaximumSize = new System.Drawing.Size(controlM.MaximumSize.Width, 4000);
                    form.MinimumSize = new System.Drawing.Size(controlM.MinimumSize.Width, 0);
                    form.Controls.Add(controlM);
                }));
            }
            else
            {
                if (contro != null)
                {
                    form.Controls.Remove(contro);
                }
                form.Size = controlM.Size;
                form.MaximumSize = new System.Drawing.Size(controlM.MaximumSize.Width, 4000);
                form.MinimumSize = new System.Drawing.Size(controlM.MinimumSize.Width, 0);
                form.Controls.Add(controlM);
            }

            if (controlM.InvokeRequired) { controlM.Invoke(new Action(() => { controlM.Dock = System.Windows.Forms.DockStyle.Fill; })); }
            else { controlM.Dock = System.Windows.Forms.DockStyle.Fill; }
        }
    }
}
