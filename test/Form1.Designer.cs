namespace test
{
    partial class Form1
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
            this.fio_user = new System.Windows.Forms.TextBox();
            this.pribor_repair = new System.Windows.Forms.TextBox();
            this.addAplli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.problema_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fio_user
            // 
            this.fio_user.Location = new System.Drawing.Point(96, 93);
            this.fio_user.Name = "fio_user";
            this.fio_user.Size = new System.Drawing.Size(251, 20);
            this.fio_user.TabIndex = 0;
            // 
            // pribor_repair
            // 
            this.pribor_repair.Location = new System.Drawing.Point(96, 171);
            this.pribor_repair.Name = "pribor_repair";
            this.pribor_repair.Size = new System.Drawing.Size(251, 20);
            this.pribor_repair.TabIndex = 1;
            // 
            // addAplli
            // 
            this.addAplli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAplli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAplli.Location = new System.Drawing.Point(96, 296);
            this.addAplli.Name = "addAplli";
            this.addAplli.Size = new System.Drawing.Size(251, 42);
            this.addAplli.TabIndex = 3;
            this.addAplli.Text = "отправить заявку";
            this.addAplli.UseVisualStyleBackColor = true;
            this.addAplli.Click += new System.EventHandler(this.addAplli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(93, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "прибор на ремонт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(93, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "проблема";
            // 
            // problema_cb
            // 
            this.problema_cb.FormattingEnabled = true;
            this.problema_cb.Items.AddRange(new object[] {
            "не включается",
            "не заряжается",
            "не выполняет свои задачи"});
            this.problema_cb.Location = new System.Drawing.Point(96, 244);
            this.problema_cb.Name = "problema_cb";
            this.problema_cb.Size = new System.Drawing.Size(251, 21);
            this.problema_cb.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 372);
            this.Controls.Add(this.problema_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAplli);
            this.Controls.Add(this.pribor_repair);
            this.Controls.Add(this.fio_user);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fio_user;
        private System.Windows.Forms.TextBox pribor_repair;
        private System.Windows.Forms.Button addAplli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox problema_cb;
    }
}

