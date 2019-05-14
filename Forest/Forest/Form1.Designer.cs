namespace Forest
{
    partial class Hello
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.helloBox = new System.Windows.Forms.TextBox();
            this.yes1 = new System.Windows.Forms.Button();
            this.yes2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloBox
            // 
            this.helloBox.Location = new System.Drawing.Point(100, 106);
            this.helloBox.Margin = new System.Windows.Forms.Padding(4);
            this.helloBox.Name = "helloBox";
            this.helloBox.ReadOnly = true;
            this.helloBox.Size = new System.Drawing.Size(560, 22);
            this.helloBox.TabIndex = 0;
            this.helloBox.TabStop = false;
            this.helloBox.Text = "Можешь говорить?";
            // 
            // yes1
            // 
            this.yes1.Location = new System.Drawing.Point(168, 193);
            this.yes1.Margin = new System.Windows.Forms.Padding(4);
            this.yes1.Name = "yes1";
            this.yes1.Size = new System.Drawing.Size(164, 33);
            this.yes1.TabIndex = 1;
            this.yes1.Text = "Да";
            this.yes1.UseVisualStyleBackColor = true;
            this.yes1.Click += new System.EventHandler(this.yes1_Click);
            // 
            // yes2
            // 
            this.yes2.Location = new System.Drawing.Point(415, 193);
            this.yes2.Margin = new System.Windows.Forms.Padding(4);
            this.yes2.Name = "yes2";
            this.yes2.Size = new System.Drawing.Size(164, 33);
            this.yes2.TabIndex = 2;
            this.yes2.Text = "Да";
            this.yes2.UseVisualStyleBackColor = true;
            this.yes2.Click += new System.EventHandler(this.yes2_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Forest.Properties.Resources.Берег;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(776, 311);
            this.Controls.Add(this.yes2);
            this.Controls.Add(this.yes1);
            this.Controls.Add(this.helloBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(794, 358);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(794, 358);
            this.Name = "Hello";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кто к нам пришёл?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox helloBox;
        private System.Windows.Forms.Button yes1;
        private System.Windows.Forms.Button yes2;
    }
}

