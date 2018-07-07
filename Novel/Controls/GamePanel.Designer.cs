namespace Novel.Control
{
    partial class GamePanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.KeyL = new System.Windows.Forms.Label();
            this.KeyT = new System.Windows.Forms.TextBox();
            this.idT = new System.Windows.Forms.TextBox();
            this.idL = new System.Windows.Forms.Label();
            this.typeRoomT = new System.Windows.Forms.TextBox();
            this.typeRoomL = new System.Windows.Forms.Label();
            this.CloseRoomB = new System.Windows.Forms.Button();
            this.tic_tac_toeControl1 = new Novel.Logeck.Game.Tic_tac_toe_control.Tic_tac_toeControl();
            this.anyListUser1 = new Novel.Logeck.Game.AnyListUser();
            this.SuspendLayout();
            // 
            // KeyL
            // 
            this.KeyL.AutoSize = true;
            this.KeyL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.KeyL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.KeyL.Location = new System.Drawing.Point(516, 3);
            this.KeyL.Name = "KeyL";
            this.KeyL.Size = new System.Drawing.Size(81, 31);
            this.KeyL.TabIndex = 3;
            this.KeyL.Text = "Ключ";
            // 
            // KeyT
            // 
            this.KeyT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.KeyT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyT.Enabled = false;
            this.KeyT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.KeyT.Location = new System.Drawing.Point(593, 6);
            this.KeyT.Multiline = true;
            this.KeyT.Name = "KeyT";
            this.KeyT.Size = new System.Drawing.Size(75, 25);
            this.KeyT.TabIndex = 19;
            this.KeyT.TextChanged += new System.EventHandler(this.KeyT_TextChanged);
            // 
            // idT
            // 
            this.idT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.idT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idT.Enabled = false;
            this.idT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.idT.Location = new System.Drawing.Point(435, 6);
            this.idT.Multiline = true;
            this.idT.Name = "idT";
            this.idT.Size = new System.Drawing.Size(75, 25);
            this.idT.TabIndex = 21;
            // 
            // idL
            // 
            this.idL.AutoSize = true;
            this.idL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.idL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.idL.Location = new System.Drawing.Point(404, 3);
            this.idL.Name = "idL";
            this.idL.Size = new System.Drawing.Size(35, 31);
            this.idL.TabIndex = 20;
            this.idL.Text = "id";
            // 
            // typeRoomT
            // 
            this.typeRoomT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.typeRoomT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeRoomT.Enabled = false;
            this.typeRoomT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeRoomT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.typeRoomT.Location = new System.Drawing.Point(313, 6);
            this.typeRoomT.Multiline = true;
            this.typeRoomT.Name = "typeRoomT";
            this.typeRoomT.Size = new System.Drawing.Size(75, 25);
            this.typeRoomT.TabIndex = 23;
            // 
            // typeRoomL
            // 
            this.typeRoomL.AutoSize = true;
            this.typeRoomL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.typeRoomL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeRoomL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.typeRoomL.Location = new System.Drawing.Point(144, 0);
            this.typeRoomL.Name = "typeRoomL";
            this.typeRoomL.Size = new System.Drawing.Size(172, 31);
            this.typeRoomL.TabIndex = 22;
            this.typeRoomL.Text = "тип комнаты";
            // 
            // CloseRoomB
            // 
            this.CloseRoomB.FlatAppearance.BorderSize = 2;
            this.CloseRoomB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseRoomB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseRoomB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CloseRoomB.Location = new System.Drawing.Point(3, 3);
            this.CloseRoomB.Name = "CloseRoomB";
            this.CloseRoomB.Size = new System.Drawing.Size(123, 31);
            this.CloseRoomB.TabIndex = 24;
            this.CloseRoomB.Text = "Выйти";
            this.CloseRoomB.UseVisualStyleBackColor = true;
            // 
            // tic_tac_toeControl1
            // 
            this.tic_tac_toeControl1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tic_tac_toeControl1.Location = new System.Drawing.Point(258, 42);
            this.tic_tac_toeControl1.MaximumSize = new System.Drawing.Size(410, 470);
            this.tic_tac_toeControl1.MinimumSize = new System.Drawing.Size(410, 470);
            this.tic_tac_toeControl1.Name = "tic_tac_toeControl1";
            this.tic_tac_toeControl1.Size = new System.Drawing.Size(410, 470);
            this.tic_tac_toeControl1.TabIndex = 26;
            // 
            // anyListUser1
            // 
            this.anyListUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.anyListUser1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anyListUser1.Location = new System.Drawing.Point(3, 42);
            this.anyListUser1.Name = "anyListUser1";
            this.anyListUser1.Size = new System.Drawing.Size(236, 470);
            this.anyListUser1.TabIndex = 25;
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.tic_tac_toeControl1);
            this.Controls.Add(this.anyListUser1);
            this.Controls.Add(this.CloseRoomB);
            this.Controls.Add(this.typeRoomT);
            this.Controls.Add(this.typeRoomL);
            this.Controls.Add(this.idT);
            this.Controls.Add(this.idL);
            this.Controls.Add(this.KeyT);
            this.Controls.Add(this.KeyL);
            this.Name = "GamePanel";
            this.Size = new System.Drawing.Size(678, 519);
            this.Load += new System.EventHandler(this.GamePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KeyL;
        private System.Windows.Forms.Label idL;
        private System.Windows.Forms.Label typeRoomL;
        private System.Windows.Forms.Button CloseRoomB;
        public Logeck.Game.AnyListUser anyListUser1;
        public System.Windows.Forms.TextBox KeyT;
        public System.Windows.Forms.TextBox idT;
        public System.Windows.Forms.TextBox typeRoomT;
        private Logeck.Game.Tic_tac_toe_control.Tic_tac_toeControl tic_tac_toeControl1;
    }
}
