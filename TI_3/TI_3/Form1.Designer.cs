namespace TI_3
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_tb = new System.Windows.Forms.TextBox();
            this.x_tb = new System.Windows.Forms.TextBox();
            this.k_tb = new System.Windows.Forms.TextBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.chipertext = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.decryptedtext = new System.Windows.Forms.RichTextBox();
            this.cipher_btn = new System.Windows.Forms.Button();
            this.p_error = new System.Windows.Forms.Label();
            this.k_error = new System.Windows.Forms.Label();
            this.x_error = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.open_key_tb = new System.Windows.Forms.TextBox();
            this.close_key_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.plaintext_tb = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.g_cb = new System.Windows.Forms.ComboBox();
            this.g_calculate_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "k:";
            // 
            // p_tb
            // 
            this.p_tb.Location = new System.Drawing.Point(40, 66);
            this.p_tb.Name = "p_tb";
            this.p_tb.Size = new System.Drawing.Size(100, 26);
            this.p_tb.TabIndex = 2;
            this.p_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p_tb_KeyPress);
            // 
            // x_tb
            // 
            this.x_tb.Location = new System.Drawing.Point(40, 99);
            this.x_tb.Name = "x_tb";
            this.x_tb.Size = new System.Drawing.Size(100, 26);
            this.x_tb.TabIndex = 3;
            this.x_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_tb_KeyPress);
            // 
            // k_tb
            // 
            this.k_tb.Location = new System.Drawing.Point(40, 132);
            this.k_tb.Name = "k_tb";
            this.k_tb.Size = new System.Drawing.Size(100, 26);
            this.k_tb.TabIndex = 4;
            this.k_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.k_tb_KeyPress);
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(12, 15);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(125, 38);
            this.open_btn.TabIndex = 1;
            this.open_btn.Text = "Open file";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // chipertext
            // 
            this.chipertext.Location = new System.Drawing.Point(158, 115);
            this.chipertext.Name = "chipertext";
            this.chipertext.Size = new System.Drawing.Size(216, 55);
            this.chipertext.TabIndex = 7;
            this.chipertext.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cipher text:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "g:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Decrypted text:";
            // 
            // decryptedtext
            // 
            this.decryptedtext.Location = new System.Drawing.Point(158, 192);
            this.decryptedtext.Name = "decryptedtext";
            this.decryptedtext.Size = new System.Drawing.Size(216, 55);
            this.decryptedtext.TabIndex = 12;
            this.decryptedtext.Text = "";
            // 
            // cipher_btn
            // 
            this.cipher_btn.Location = new System.Drawing.Point(12, 224);
            this.cipher_btn.Name = "cipher_btn";
            this.cipher_btn.Size = new System.Drawing.Size(125, 38);
            this.cipher_btn.TabIndex = 5;
            this.cipher_btn.Text = "Cipher";
            this.cipher_btn.UseVisualStyleBackColor = true;
            this.cipher_btn.Click += new System.EventHandler(this.cipher_btn_Click);
            // 
            // p_error
            // 
            this.p_error.AutoSize = true;
            this.p_error.ForeColor = System.Drawing.Color.Red;
            this.p_error.Location = new System.Drawing.Point(394, 94);
            this.p_error.Name = "p_error";
            this.p_error.Size = new System.Drawing.Size(167, 18);
            this.p_error.TabIndex = 14;
            this.p_error.Text = "p isn\'t a prime number";
            // 
            // k_error
            // 
            this.k_error.AutoSize = true;
            this.k_error.ForeColor = System.Drawing.Color.Red;
            this.k_error.Location = new System.Drawing.Point(394, 140);
            this.k_error.Name = "k_error";
            this.k_error.Size = new System.Drawing.Size(193, 18);
            this.k_error.TabIndex = 15;
            this.k_error.Text = "k is not coprime with (p-1)";
            // 
            // x_error
            // 
            this.x_error.AutoSize = true;
            this.x_error.ForeColor = System.Drawing.Color.Red;
            this.x_error.Location = new System.Drawing.Point(394, 118);
            this.x_error.Name = "x_error";
            this.x_error.Size = new System.Drawing.Size(100, 18);
            this.x_error.TabIndex = 16;
            this.x_error.Text = "x must be > 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ko:";
            // 
            // open_key_tb
            // 
            this.open_key_tb.Location = new System.Drawing.Point(442, 15);
            this.open_key_tb.Name = "open_key_tb";
            this.open_key_tb.Size = new System.Drawing.Size(162, 26);
            this.open_key_tb.TabIndex = 18;
            // 
            // close_key_tb
            // 
            this.close_key_tb.Location = new System.Drawing.Point(442, 48);
            this.close_key_tb.Name = "close_key_tb";
            this.close_key_tb.Size = new System.Drawing.Size(162, 26);
            this.close_key_tb.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kc:";
            // 
            // plaintext_tb
            // 
            this.plaintext_tb.Location = new System.Drawing.Point(158, 36);
            this.plaintext_tb.Name = "plaintext_tb";
            this.plaintext_tb.Size = new System.Drawing.Size(216, 55);
            this.plaintext_tb.TabIndex = 21;
            this.plaintext_tb.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Plaintext:";
            // 
            // g_cb
            // 
            this.g_cb.FormattingEnabled = true;
            this.g_cb.Location = new System.Drawing.Point(40, 192);
            this.g_cb.Name = "g_cb";
            this.g_cb.Size = new System.Drawing.Size(100, 26);
            this.g_cb.TabIndex = 23;
            // 
            // g_calculate_btn
            // 
            this.g_calculate_btn.Location = new System.Drawing.Point(12, 164);
            this.g_calculate_btn.Name = "g_calculate_btn";
            this.g_calculate_btn.Size = new System.Drawing.Size(125, 26);
            this.g_calculate_btn.TabIndex = 24;
            this.g_calculate_btn.Text = "Calculate g";
            this.g_calculate_btn.UseVisualStyleBackColor = true;
            this.g_calculate_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 274);
            this.Controls.Add(this.g_calculate_btn);
            this.Controls.Add(this.g_cb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.plaintext_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.close_key_tb);
            this.Controls.Add(this.open_key_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.x_error);
            this.Controls.Add(this.k_error);
            this.Controls.Add(this.p_error);
            this.Controls.Add(this.cipher_btn);
            this.Controls.Add(this.decryptedtext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chipertext);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.k_tb);
            this.Controls.Add(this.x_tb);
            this.Controls.Add(this.p_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "TI_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox p_tb;
        private System.Windows.Forms.TextBox x_tb;
        private System.Windows.Forms.TextBox k_tb;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.RichTextBox chipertext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox decryptedtext;
        private System.Windows.Forms.Button cipher_btn;
        private System.Windows.Forms.Label p_error;
        private System.Windows.Forms.Label k_error;
        private System.Windows.Forms.Label x_error;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox open_key_tb;
        private System.Windows.Forms.TextBox close_key_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox plaintext_tb;
        private System.Windows.Forms.ComboBox g_cb;
        private System.Windows.Forms.Button g_calculate_btn;
    }
}

