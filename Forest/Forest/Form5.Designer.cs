namespace Forest
{
    partial class Room0
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.end1 = new System.Windows.Forms.Button();
            this.end2 = new System.Windows.Forms.Button();
            this.Text_Timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(480, 237);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Кто я такой? \r\nКакое-то странное место, здесь много комнат. Две из них открыты. \r" +
    "\n\r\nНужно зайти и посмотреть.\r\n\r\nА еще здесь есть три кнопки, такие надписи меня " +
    "пугают. \r\nСначала комнаты.\r\n";
            // 
            // end1
            // 
            this.end1.Location = new System.Drawing.Point(616, 127);
            this.end1.Margin = new System.Windows.Forms.Padding(4);
            this.end1.Name = "end1";
            this.end1.Size = new System.Drawing.Size(195, 48);
            this.end1.TabIndex = 1;
            this.end1.Text = "Умереть";
            this.end1.UseVisualStyleBackColor = true;
            this.end1.Click += new System.EventHandler(this.end1_Click);
            // 
            // end2
            // 
            this.end2.Location = new System.Drawing.Point(616, 196);
            this.end2.Margin = new System.Windows.Forms.Padding(4);
            this.end2.Name = "end2";
            this.end2.Size = new System.Drawing.Size(195, 48);
            this.end2.TabIndex = 2;
            this.end2.Text = "Жить";
            this.end2.UseVisualStyleBackColor = true;
            this.end2.Click += new System.EventHandler(this.end2_Click);
            // 
            // Text_Timer
            // 
            this.Text_Timer.Enabled = true;
            this.Text_Timer.Tick += new System.EventHandler(this.Text_Timer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 265);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Room0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forest.Properties.Resources.НочнойЛес;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.end2);
            this.Controls.Add(this.end1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(911, 486);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(911, 486);
            this.Name = "Room0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кто я?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button end1;
        private System.Windows.Forms.Button end2;
        private System.Windows.Forms.Timer Text_Timer;
        private System.Windows.Forms.Button button1;
    }
}