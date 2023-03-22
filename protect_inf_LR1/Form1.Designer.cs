namespace protect_inf_LR1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecipher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEncodeKeyWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDecodeKeyWord = new System.Windows.Forms.TextBox();
            this.EncryptBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DecryptBox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(15, 224);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(95, 23);
            this.buttonEncrypt.TabIndex = 1;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecipher
            // 
            this.buttonDecipher.Location = new System.Drawing.Point(367, 224);
            this.buttonDecipher.Name = "buttonDecipher";
            this.buttonDecipher.Size = new System.Drawing.Size(112, 23);
            this.buttonDecipher.TabIndex = 2;
            this.buttonDecipher.Text = "Расшифровать";
            this.buttonDecipher.UseVisualStyleBackColor = true;
            this.buttonDecipher.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ключевое слово:";
            // 
            // textBoxEncodeKeyWord
            // 
            this.textBoxEncodeKeyWord.Location = new System.Drawing.Point(15, 38);
            this.textBoxEncodeKeyWord.Name = "textBoxEncodeKeyWord";
            this.textBoxEncodeKeyWord.Size = new System.Drawing.Size(112, 20);
            this.textBoxEncodeKeyWord.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ключевое слово:";
            // 
            // textBoxDecodeKeyWord
            // 
            this.textBoxDecodeKeyWord.Location = new System.Drawing.Point(367, 38);
            this.textBoxDecodeKeyWord.Name = "textBoxDecodeKeyWord";
            this.textBoxDecodeKeyWord.Size = new System.Drawing.Size(112, 20);
            this.textBoxDecodeKeyWord.TabIndex = 6;
            // 
            // EncryptBox
            // 
            this.EncryptBox.Location = new System.Drawing.Point(15, 83);
            this.EncryptBox.Multiline = true;
            this.EncryptBox.Name = "EncryptBox";
            this.EncryptBox.Size = new System.Drawing.Size(316, 135);
            this.EncryptBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Сообщение для зашифровки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сообщение для расшифровки";
            // 
            // DecryptBox
            // 
            this.DecryptBox.Location = new System.Drawing.Point(367, 83);
            this.DecryptBox.Multiline = true;
            this.DecryptBox.Name = "DecryptBox";
            this.DecryptBox.Size = new System.Drawing.Size(316, 135);
            this.DecryptBox.TabIndex = 9;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(609, 273);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 308);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DecryptBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EncryptBox);
            this.Controls.Add(this.textBoxDecodeKeyWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEncodeKeyWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDecipher);
            this.Controls.Add(this.buttonEncrypt);
            this.Name = "Form1";
            this.Text = "Алгоритм DES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecipher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEncodeKeyWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDecodeKeyWord;
        private System.Windows.Forms.TextBox EncryptBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DecryptBox;
        private System.Windows.Forms.Button ExitBtn;
    }
}

