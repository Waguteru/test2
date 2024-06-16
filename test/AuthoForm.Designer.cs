namespace test
{
    partial class AuthoForm
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
            this.register_bt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.login_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // register_bt
            // 
            this.register_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_bt.Location = new System.Drawing.Point(55, 202);
            this.register_bt.Name = "register_bt";
            this.register_bt.Size = new System.Drawing.Size(198, 23);
            this.register_bt.TabIndex = 9;
            this.register_bt.Text = "войти";
            this.register_bt.UseVisualStyleBackColor = true;
            this.register_bt.Click += new System.EventHandler(this.register_bt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "логин";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(55, 138);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(198, 20);
            this.password_tb.TabIndex = 6;
            // 
            // login_tb
            // 
            this.login_tb.Location = new System.Drawing.Point(55, 67);
            this.login_tb.Name = "login_tb";
            this.login_tb.Size = new System.Drawing.Size(198, 20);
            this.login_tb.TabIndex = 5;
            // 
            // AuthoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(307, 271);
            this.Controls.Add(this.register_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.login_tb);
            this.Name = "AuthoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox login_tb;
    }
}