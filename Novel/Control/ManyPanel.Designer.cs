namespace Novel.Control
{
    partial class ManyPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomList1 = new Novel.Control.RoomList();
            this.gamersList1 = new Novel.Control.GamersList();
            this.gameList1 = new Novel.Control.GameList();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LogIn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(159, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Рейтинг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(234, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "---";
            // 
            // roomList1
            // 
            this.roomList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.roomList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.roomList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomList1.Location = new System.Drawing.Point(454, 50);
            this.roomList1.Name = "roomList1";
            this.roomList1.Size = new System.Drawing.Size(228, 359);
            this.roomList1.TabIndex = 5;
            this.roomList1.Load += new System.EventHandler(this.roomList1_Load);
            // 
            // gamersList1
            // 
            this.gamersList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gamersList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gamersList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamersList1.Location = new System.Drawing.Point(227, 50);
            this.gamersList1.Name = "gamersList1";
            this.gamersList1.Size = new System.Drawing.Size(228, 359);
            this.gamersList1.TabIndex = 4;
            this.gamersList1.Load += new System.EventHandler(this.gamersList1_Load);
            // 
            // gameList1
            // 
            this.gameList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gameList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.gameList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameList1.Location = new System.Drawing.Point(0, 50);
            this.gameList1.Name = "gameList1";
            this.gameList1.Size = new System.Drawing.Size(228, 359);
            this.gameList1.TabIndex = 3;
            // 
            // ManyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.roomList1);
            this.Controls.Add(this.gamersList1);
            this.Controls.Add(this.gameList1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(685, 4000);
            this.MinimumSize = new System.Drawing.Size(685, 0);
            this.Name = "ManyPanel";
            this.Size = new System.Drawing.Size(685, 414);
            this.Load += new System.EventHandler(this.ManyPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private RoomList roomList1;
        private GamersList gamersList1;
        private GameList gameList1;
    }
}
