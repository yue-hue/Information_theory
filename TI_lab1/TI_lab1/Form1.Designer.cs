namespace TI_lab1
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
            this.label1 = new System.Windows.Forms.Label();
            this.openBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.plaintextTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.keyTB = new System.Windows.Forms.TextBox();
            this.encrypt = new System.Windows.Forms.Button();
            this.input_error = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.decrypt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.result_TB = new System.Windows.Forms.TextBox();
            this.VSGkey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.error_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input or";
            // 
            // openBTN
            // 
            this.openBTN.Location = new System.Drawing.Point(101, 74);
            this.openBTN.Name = "openBTN";
            this.openBTN.Size = new System.Drawing.Size(75, 33);
            this.openBTN.TabIndex = 1;
            this.openBTN.Text = "open";
            this.openBTN.UseVisualStyleBackColor = true;
            this.openBTN.Click += new System.EventHandler(this.openBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "plaintext:";
            // 
            // plaintextTB
            // 
            this.plaintextTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.plaintextTB.Location = new System.Drawing.Point(287, 80);
            this.plaintextTB.MaxLength = 40;
            this.plaintextTB.Name = "plaintextTB";
            this.plaintextTB.Size = new System.Drawing.Size(333, 27);
            this.plaintextTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input key:";
            // 
            // keyTB
            // 
            this.keyTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.keyTB.Location = new System.Drawing.Point(120, 43);
            this.keyTB.MaxLength = 40;
            this.keyTB.Name = "keyTB";
            this.keyTB.Size = new System.Drawing.Size(333, 27);
            this.keyTB.TabIndex = 5;
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(287, 116);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(151, 35);
            this.encrypt.TabIndex = 15;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click_1);
            // 
            // input_error
            // 
            this.input_error.AutoSize = true;
            this.input_error.ForeColor = System.Drawing.Color.Red;
            this.input_error.Location = new System.Drawing.Point(15, 123);
            this.input_error.Name = "input_error";
            this.input_error.Size = new System.Drawing.Size(252, 20);
            this.input_error.TabIndex = 16;
            this.input_error.Text = "*Please fill all the fields";
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Columnar transposition",
            "Vigenere cipher",
            "Playfair cipher"});
            this.type.Location = new System.Drawing.Point(200, 9);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(213, 28);
            this.type.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select cipher type:";
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(469, 116);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(151, 35);
            this.decrypt.TabIndex = 20;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Result:";
            // 
            // result_TB
            // 
            this.result_TB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.result_TB.Location = new System.Drawing.Point(287, 188);
            this.result_TB.MaxLength = 40;
            this.result_TB.Name = "result_TB";
            this.result_TB.Size = new System.Drawing.Size(333, 27);
            this.result_TB.TabIndex = 22;
            // 
            // VSGkey
            // 
            this.VSGkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.VSGkey.Location = new System.Drawing.Point(103, 221);
            this.VSGkey.MaxLength = 40;
            this.VSGkey.Name = "VSGkey";
            this.VSGkey.Size = new System.Drawing.Size(257, 27);
            this.VSGkey.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Self-generated Vigenere key:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_lbl.Location = new System.Drawing.Point(24, 123);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(135, 20);
            this.error_lbl.TabIndex = 25;
            this.error_lbl.Text = "*Check fields)";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(545, 221);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 33);
            this.save_btn.TabIndex = 26;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 259);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VSGkey);
            this.Controls.Add(this.result_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.type);
            this.Controls.Add(this.input_error);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.keyTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plaintextTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openBTN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "TI_lab1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox plaintextTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyTB;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Label input_error;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox result_TB;
        private System.Windows.Forms.TextBox VSGkey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label error_lbl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

