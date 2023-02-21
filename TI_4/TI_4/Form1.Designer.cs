namespace TI_4
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
            this.open_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p_tb = new System.Windows.Forms.TextBox();
            this.q_tb = new System.Windows.Forms.TextBox();
            this.d_tb = new System.Windows.Forms.TextBox();
            this.r_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.h_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EDS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cipher_btn = new System.Windows.Forms.Button();
            this.r_Kc_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fr_tb = new System.Windows.Forms.TextBox();
            this.e_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Ko_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.plaintext_tb = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.coded_tb = new System.Windows.Forms.RichTextBox();
            this.check_tb = new System.Windows.Forms.TextBox();
            this.result_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(14, 14);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(129, 47);
            this.open_btn.TabIndex = 0;
            this.open_btn.Text = "Open file";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "q:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kc:";
            // 
            // p_tb
            // 
            this.p_tb.Location = new System.Drawing.Point(51, 64);
            this.p_tb.Name = "p_tb";
            this.p_tb.Size = new System.Drawing.Size(136, 26);
            this.p_tb.TabIndex = 2;
            this.p_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p_tb_KeyPress);
            // 
            // q_tb
            // 
            this.q_tb.Location = new System.Drawing.Point(51, 96);
            this.q_tb.Name = "q_tb";
            this.q_tb.Size = new System.Drawing.Size(136, 26);
            this.q_tb.TabIndex = 3;
            this.q_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.q_tb_KeyPress);
            // 
            // d_tb
            // 
            this.d_tb.Location = new System.Drawing.Point(51, 128);
            this.d_tb.Name = "d_tb";
            this.d_tb.Size = new System.Drawing.Size(65, 26);
            this.d_tb.TabIndex = 4;
            this.d_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kc_tb_KeyPress);
            // 
            // r_tb
            // 
            this.r_tb.Enabled = false;
            this.r_tb.Location = new System.Drawing.Point(266, 67);
            this.r_tb.Name = "r_tb";
            this.r_tb.Size = new System.Drawing.Size(136, 26);
            this.r_tb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "r:";
            // 
            // h_tb
            // 
            this.h_tb.Enabled = false;
            this.h_tb.Location = new System.Drawing.Point(267, 195);
            this.h_tb.Name = "h_tb";
            this.h_tb.Size = new System.Drawing.Size(136, 26);
            this.h_tb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "h(M):";
            // 
            // EDS
            // 
            this.EDS.Enabled = false;
            this.EDS.Location = new System.Drawing.Point(267, 227);
            this.EDS.Name = "EDS";
            this.EDS.Size = new System.Drawing.Size(136, 26);
            this.EDS.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "EDS:";
            // 
            // cipher_btn
            // 
            this.cipher_btn.Location = new System.Drawing.Point(14, 169);
            this.cipher_btn.Name = "cipher_btn";
            this.cipher_btn.Size = new System.Drawing.Size(151, 47);
            this.cipher_btn.TabIndex = 6;
            this.cipher_btn.Text = "Cipher";
            this.cipher_btn.UseVisualStyleBackColor = true;
            this.cipher_btn.Click += new System.EventHandler(this.cipher_btn_Click);
            // 
            // r_Kc_tb
            // 
            this.r_Kc_tb.Location = new System.Drawing.Point(122, 128);
            this.r_Kc_tb.Name = "r_Kc_tb";
            this.r_Kc_tb.Size = new System.Drawing.Size(65, 26);
            this.r_Kc_tb.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "φ(r):";
            // 
            // fr_tb
            // 
            this.fr_tb.Enabled = false;
            this.fr_tb.Location = new System.Drawing.Point(267, 99);
            this.fr_tb.Name = "fr_tb";
            this.fr_tb.Size = new System.Drawing.Size(136, 26);
            this.fr_tb.TabIndex = 16;
            // 
            // e_tb
            // 
            this.e_tb.Enabled = false;
            this.e_tb.Location = new System.Drawing.Point(267, 131);
            this.e_tb.Name = "e_tb";
            this.e_tb.Size = new System.Drawing.Size(136, 26);
            this.e_tb.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "e:";
            // 
            // Ko_tb
            // 
            this.Ko_tb.Enabled = false;
            this.Ko_tb.Location = new System.Drawing.Point(267, 163);
            this.Ko_tb.Name = "Ko_tb";
            this.Ko_tb.Size = new System.Drawing.Size(136, 26);
            this.Ko_tb.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ko:";
            // 
            // plaintext_tb
            // 
            this.plaintext_tb.Location = new System.Drawing.Point(149, 14);
            this.plaintext_tb.Name = "plaintext_tb";
            this.plaintext_tb.Size = new System.Drawing.Size(136, 47);
            this.plaintext_tb.TabIndex = 1;
            this.plaintext_tb.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // coded_tb
            // 
            this.coded_tb.Enabled = false;
            this.coded_tb.Location = new System.Drawing.Point(420, 69);
            this.coded_tb.Name = "coded_tb";
            this.coded_tb.Size = new System.Drawing.Size(178, 53);
            this.coded_tb.TabIndex = 22;
            this.coded_tb.Text = "";
            // 
            // check_tb
            // 
            this.check_tb.Enabled = false;
            this.check_tb.Location = new System.Drawing.Point(420, 166);
            this.check_tb.Name = "check_tb";
            this.check_tb.Size = new System.Drawing.Size(136, 26);
            this.check_tb.TabIndex = 23;
            // 
            // result_tb
            // 
            this.result_tb.Enabled = false;
            this.result_tb.Location = new System.Drawing.Point(420, 195);
            this.result_tb.Name = "result_tb";
            this.result_tb.Size = new System.Drawing.Size(136, 26);
            this.result_tb.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 370);
            this.Controls.Add(this.result_tb);
            this.Controls.Add(this.check_tb);
            this.Controls.Add(this.coded_tb);
            this.Controls.Add(this.plaintext_tb);
            this.Controls.Add(this.Ko_tb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.e_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fr_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.r_Kc_tb);
            this.Controls.Add(this.cipher_btn);
            this.Controls.Add(this.EDS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.h_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.r_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.d_tb);
            this.Controls.Add(this.q_tb);
            this.Controls.Add(this.p_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open_btn);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "TI_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox p_tb;
        private System.Windows.Forms.TextBox q_tb;
        private System.Windows.Forms.TextBox d_tb;
        private System.Windows.Forms.TextBox r_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox h_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EDS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cipher_btn;
        private System.Windows.Forms.TextBox r_Kc_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fr_tb;
        private System.Windows.Forms.TextBox e_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Ko_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox plaintext_tb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox coded_tb;
        private System.Windows.Forms.TextBox check_tb;
        private System.Windows.Forms.TextBox result_tb;
    }
}

