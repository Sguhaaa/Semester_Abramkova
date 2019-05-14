namespace Forest
{
    partial class Room2
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
            this.familyBox = new System.Windows.Forms.TextBox();
            this.family1 = new System.Windows.Forms.Button();
            this.family2 = new System.Windows.Forms.Button();
            this.family3 = new System.Windows.Forms.Button();
            this.familyProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // familyBox
            // 
            this.familyBox.Location = new System.Drawing.Point(151, 46);
            this.familyBox.Margin = new System.Windows.Forms.Padding(4);
            this.familyBox.Multiline = true;
            this.familyBox.Name = "familyBox";
            this.familyBox.ReadOnly = true;
            this.familyBox.Size = new System.Drawing.Size(523, 118);
            this.familyBox.TabIndex = 0;
            this.familyBox.TabStop = false;
            this.familyBox.Text = "В этой комнате проходит семейный ужин.\r\nУ твоей семьи много вопросов и недовольст" +
    "в, но чтобы не поднимать бучу\r\nеще сильнее, ты можешь отвечать им лишь некоторым" +
    "и фразами.\r\n\r\nПопробуй отшить родню.";
            // 
            // family1
            // 
            this.family1.Location = new System.Drawing.Point(151, 245);
            this.family1.Margin = new System.Windows.Forms.Padding(4);
            this.family1.Name = "family1";
            this.family1.Size = new System.Drawing.Size(524, 39);
            this.family1.TabIndex = 1;
            this.family1.Text = "Огонь...";
            this.family1.UseVisualStyleBackColor = true;
            this.family1.Click += new System.EventHandler(this.family1_Click);
            // 
            // family2
            // 
            this.family2.Location = new System.Drawing.Point(151, 292);
            this.family2.Margin = new System.Windows.Forms.Padding(4);
            this.family2.Name = "family2";
            this.family2.Size = new System.Drawing.Size(524, 39);
            this.family2.TabIndex = 2;
            this.family2.Text = "Ну давай.";
            this.family2.UseVisualStyleBackColor = true;
            this.family2.Click += new System.EventHandler(this.family2_Click);
            // 
            // family3
            // 
            this.family3.Location = new System.Drawing.Point(151, 338);
            this.family3.Margin = new System.Windows.Forms.Padding(4);
            this.family3.Name = "family3";
            this.family3.Size = new System.Drawing.Size(524, 39);
            this.family3.TabIndex = 3;
            this.family3.Text = "Как мне этого не хватало.";
            this.family3.UseVisualStyleBackColor = true;
            this.family3.Click += new System.EventHandler(this.family3_Click);
            // 
            // familyProgressBar
            // 
            this.familyProgressBar.Location = new System.Drawing.Point(243, 191);
            this.familyProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.familyProgressBar.Name = "familyProgressBar";
            this.familyProgressBar.Size = new System.Drawing.Size(315, 28);
            this.familyProgressBar.Step = 1;
            this.familyProgressBar.TabIndex = 4;
            this.familyProgressBar.Value = 50;
            // 
            // Room2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(836, 412);
            this.Controls.Add(this.familyProgressBar);
            this.Controls.Add(this.family3);
            this.Controls.Add(this.family2);
            this.Controls.Add(this.family1);
            this.Controls.Add(this.familyBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(854, 459);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(854, 459);
            this.Name = "Room2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комната 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox familyBox;
        private System.Windows.Forms.Button family1;
        private System.Windows.Forms.Button family2;
        private System.Windows.Forms.Button family3;
        private System.Windows.Forms.ProgressBar familyProgressBar;
    }
}