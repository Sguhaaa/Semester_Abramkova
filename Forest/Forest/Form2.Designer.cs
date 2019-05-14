namespace Forest
{
    partial class Main
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
            this.mainBox = new System.Windows.Forms.TextBox();
            this.rooms = new System.Windows.Forms.ComboBox();
            this.okeyMain = new System.Windows.Forms.Button();
            this.who = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Location = new System.Drawing.Point(108, 116);
            this.mainBox.Multiline = true;
            this.mainBox.Name = "mainBox";
            this.mainBox.ReadOnly = true;
            this.mainBox.TabStop = false;
            this.mainBox.Size = new System.Drawing.Size(455, 51);
            this.mainBox.TabIndex = 0;
            this.mainBox.Text = "Давай вместе поймем кто ты и за что сюда попал";
            // 
            // rooms
            // 
            this.rooms.FormattingEnabled = true;
            this.rooms.Items.AddRange(new object[] {
            "1 комната",
            "2 комната",
            "3 комната"});
            this.rooms.Location = new System.Drawing.Point(125, 196);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(234, 21);
            this.rooms.TabIndex = 1;
            this.rooms.TabStop = false;
            this.rooms.Text = "Выбери комнату";
 
            // 
            // okeyMain
            // 
            this.okeyMain.Location = new System.Drawing.Point(384, 196);
            this.okeyMain.Name = "okeyMain";
            this.okeyMain.Size = new System.Drawing.Size(75, 23);
            this.okeyMain.TabIndex = 2;
            this.okeyMain.Text = "Ок";
            this.okeyMain.UseVisualStyleBackColor = true;
            this.okeyMain.Click += new System.EventHandler(this.okeyMain_Click);
            // 
            // who
            // 
            this.who.Location = new System.Drawing.Point(478, 196);
            this.who.Name = "who";
            this.who.Size = new System.Drawing.Size(75, 23);
            this.who.TabIndex = 3;
            this.who.Text = "Кто я?";
            this.who.UseVisualStyleBackColor = true;
            this.who.Click += new System.EventHandler(this.who_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forest.Properties.Resources.Берег;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 365);
            this.Controls.Add(this.who);
            this.Controls.Add(this.okeyMain);
            this.Controls.Add(this.rooms);
            this.Controls.Add(this.mainBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(688, 404);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(688, 404);
            this.Name = "Main";
            this.Text = "Куда идти?";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainBox;
        private System.Windows.Forms.ComboBox rooms;
        private System.Windows.Forms.Button okeyMain;
        private System.Windows.Forms.Button who;
    }
}