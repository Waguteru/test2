namespace test
{
    partial class WorkersApplication
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.status_cb = new System.Windows.Forms.ComboBox();
            this.updateApplication_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fio_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(594, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(413, 293);
            this.id_tb.Name = "id_tb";
            this.id_tb.ReadOnly = true;
            this.id_tb.Size = new System.Drawing.Size(81, 20);
            this.id_tb.TabIndex = 1;
            // 
            // status_cb
            // 
            this.status_cb.FormattingEnabled = true;
            this.status_cb.Items.AddRange(new object[] {
            "выполнено",
            "отказано",
            "невозможно починить"});
            this.status_cb.Location = new System.Drawing.Point(12, 296);
            this.status_cb.Name = "status_cb";
            this.status_cb.Size = new System.Drawing.Size(190, 21);
            this.status_cb.TabIndex = 2;
            // 
            // updateApplication_bt
            // 
            this.updateApplication_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateApplication_bt.Location = new System.Drawing.Point(12, 333);
            this.updateApplication_bt.Name = "updateApplication_bt";
            this.updateApplication_bt.Size = new System.Drawing.Size(190, 23);
            this.updateApplication_bt.TabIndex = 3;
            this.updateApplication_bt.Text = "Изменить";
            this.updateApplication_bt.UseVisualStyleBackColor = true;
            this.updateApplication_bt.Click += new System.EventHandler(this.updateApplication_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "смена статуса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "номер заявки";
            // 
            // fio_tb
            // 
            this.fio_tb.Location = new System.Drawing.Point(413, 345);
            this.fio_tb.Name = "fio_tb";
            this.fio_tb.ReadOnly = true;
            this.fio_tb.Size = new System.Drawing.Size(190, 20);
            this.fio_tb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "фио";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(416, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WorkersApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fio_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateApplication_bt);
            this.Controls.Add(this.status_cb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WorkersApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с заявками";
            this.Load += new System.EventHandler(this.WorkersApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.ComboBox status_cb;
        private System.Windows.Forms.Button updateApplication_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fio_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}