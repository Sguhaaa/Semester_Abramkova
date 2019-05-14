namespace Forest
{
    partial class Room1
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
            this.catState = new System.Windows.Forms.TextBox();
            this.eatState = new System.Windows.Forms.TextBox();
            this.eat = new System.Windows.Forms.Button();
            this.sleep = new System.Windows.Forms.Button();
            this.sleepState = new System.Windows.Forms.TextBox();
            this.funny = new System.Windows.Forms.Button();
            this.funnyState = new System.Windows.Forms.TextBox();
            this.timerState = new System.Windows.Forms.Timer(this.components);
            this.storyCat = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // catState
            // 
            this.catState.Location = new System.Drawing.Point(53, 52);
            this.catState.Margin = new System.Windows.Forms.Padding(4);
            this.catState.Multiline = true;
            this.catState.Name = "catState";
            this.catState.ReadOnly = true;
            this.catState.Size = new System.Drawing.Size(287, 22);
            this.catState.TabIndex = 0;
            this.catState.TabStop = false;
            this.catState.Text = "В этой комнате живёт котёнок";
            // 
            // eatState
            // 
            this.eatState.Location = new System.Drawing.Point(53, 134);
            this.eatState.Margin = new System.Windows.Forms.Padding(4);
            this.eatState.Name = "eatState";
            this.eatState.Size = new System.Drawing.Size(132, 22);
            this.eatState.TabIndex = 1;
            // 
            // eat
            // 
            this.eat.Location = new System.Drawing.Point(217, 134);
            this.eat.Margin = new System.Windows.Forms.Padding(4);
            this.eat.Name = "eat";
            this.eat.Size = new System.Drawing.Size(100, 25);
            this.eat.TabIndex = 2;
            this.eat.Text = "Сытость";
            this.eat.UseVisualStyleBackColor = true;
            this.eat.Click += new System.EventHandler(this.eat_Click);
            // 
            // sleep
            // 
            this.sleep.Location = new System.Drawing.Point(217, 178);
            this.sleep.Margin = new System.Windows.Forms.Padding(4);
            this.sleep.Name = "sleep";
            this.sleep.Size = new System.Drawing.Size(100, 25);
            this.sleep.TabIndex = 4;
            this.sleep.Text = "Энергия";
            this.sleep.UseVisualStyleBackColor = true;
            this.sleep.Click += new System.EventHandler(this.sleep_Click);
            // 
            // sleepState
            // 
            this.sleepState.Location = new System.Drawing.Point(53, 178);
            this.sleepState.Margin = new System.Windows.Forms.Padding(4);
            this.sleepState.Name = "sleepState";
            this.sleepState.Size = new System.Drawing.Size(132, 22);
            this.sleepState.TabIndex = 3;
            // 
            // funny
            // 
            this.funny.Location = new System.Drawing.Point(217, 226);
            this.funny.Margin = new System.Windows.Forms.Padding(4);
            this.funny.Name = "funny";
            this.funny.Size = new System.Drawing.Size(100, 25);
            this.funny.TabIndex = 6;
            this.funny.Text = "Веселье";
            this.funny.UseVisualStyleBackColor = true;
            this.funny.Click += new System.EventHandler(this.funny_Click);
            // 
            // funnyState
            // 
            this.funnyState.Location = new System.Drawing.Point(53, 226);
            this.funnyState.Margin = new System.Windows.Forms.Padding(4);
            this.funnyState.Name = "funnyState";
            this.funnyState.Size = new System.Drawing.Size(132, 22);
            this.funnyState.TabIndex = 5;
            // 
            // timerState
            // 
            this.timerState.Enabled = true;
            this.timerState.Interval = 1500;
            this.timerState.Tick += new System.EventHandler(this.timerState_Tick);
            // 
            // storyCat
            // 
            this.storyCat.Location = new System.Drawing.Point(53, 304);
            this.storyCat.Margin = new System.Windows.Forms.Padding(4);
            this.storyCat.Multiline = true;
            this.storyCat.Name = "storyCat";
            this.storyCat.ReadOnly = true;
            this.storyCat.Size = new System.Drawing.Size(287, 86);
            this.storyCat.TabIndex = 8;
            this.storyCat.TabStop = false;
            this.storyCat.Text = "Говорят, такой же был у тебя при жизни.\r\nА потом он умер.\r\nХочешь выбраться от сю" +
    "да?\r\nТы знаешь, что нужно сделать.\r\n\r\n\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forest.Properties.Resources.кошак;
            this.pictureBox1.Location = new System.Drawing.Point(453, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 202);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Room1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 422);
            this.Controls.Add(this.storyCat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.funny);
            this.Controls.Add(this.funnyState);
            this.Controls.Add(this.sleep);
            this.Controls.Add(this.sleepState);
            this.Controls.Add(this.eat);
            this.Controls.Add(this.eatState);
            this.Controls.Add(this.catState);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(857, 469);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(857, 469);
            this.Name = "Room1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комната 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox catState;
        private System.Windows.Forms.TextBox eatState;
        private System.Windows.Forms.Button eat;
        private System.Windows.Forms.Button sleep;
        private System.Windows.Forms.TextBox sleepState;
        private System.Windows.Forms.Button funny;
        private System.Windows.Forms.TextBox funnyState;
        private System.Windows.Forms.Timer timerState;
        private System.Windows.Forms.TextBox storyCat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}