namespace test
{
    partial class RegisterFrom
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
            this.login_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.register_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(49, 89);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(198, 20);
            this.login_tb.TabIndex = 0;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(49, 160);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(198, 20);
            this.password_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "пароль";
            // 
            // register_bt
            // 
            this.register_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_bt.Location = new System.Drawing.Point(49, 224);
            this.register_bt.Name = "register_bt";
            this.register_bt.Size = new System.Drawing.Size(198, 23);
            this.register_bt.TabIndex = 4;
            this.register_bt.Text = "Зарегистрироваться";
            this.register_bt.UseVisualStyleBackColor = true;
            this.register_bt.Click += new System.EventHandler(this.register_bt_Click);
            // 
            // RegisterFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(301, 291);
            this.Controls.Add(this.register_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.login_tb);
            this.Name = "RegisterFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button register_bt;
    }
}