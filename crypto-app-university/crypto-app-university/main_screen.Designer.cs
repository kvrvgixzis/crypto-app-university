namespace crypto_app_university
{
    partial class main_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_screen));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.pqInput = new System.Windows.Forms.TextBox();
            this.pqLabel = new System.Windows.Forms.Label();
            this.privteKeyLabel = new System.Windows.Forms.Label();
            this.privateKeyTextBox = new System.Windows.Forms.TextBox();
            this.encryptMsgTextBox = new System.Windows.Forms.TextBox();
            this.saveFileBtn_encrypt = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.dnInput = new System.Windows.Forms.TextBox();
            this.dnLabel = new System.Windows.Forms.Label();
            this.openFileBtn2 = new System.Windows.Forms.Button();
            this.decryptMsgTextBox = new System.Windows.Forms.TextBox();
            this.saveFileBtn_decrypt = new System.Windows.Forms.Button();
            this.progressLabel2 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // openFileBtn
            // 
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileBtn.Location = new System.Drawing.Point(15, 102);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(283, 32);
            this.openFileBtn.TabIndex = 0;
            this.openFileBtn.Text = "Выберите файл .txt";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // pqInput
            // 
            this.pqInput.BackColor = System.Drawing.Color.White;
            this.pqInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pqInput.Location = new System.Drawing.Point(15, 67);
            this.pqInput.Name = "pqInput";
            this.pqInput.Size = new System.Drawing.Size(283, 29);
            this.pqInput.TabIndex = 1;
            this.pqInput.Text = "113 7";
            // 
            // pqLabel
            // 
            this.pqLabel.AutoSize = true;
            this.pqLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pqLabel.Location = new System.Drawing.Point(11, 38);
            this.pqLabel.Name = "pqLabel";
            this.pqLabel.Size = new System.Drawing.Size(296, 21);
            this.pqLabel.TabIndex = 2;
            this.pqLabel.Text = "Введите простые p и q через пробел:";
            // 
            // privteKeyLabel
            // 
            this.privteKeyLabel.AutoSize = true;
            this.privteKeyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privteKeyLabel.Location = new System.Drawing.Point(14, 143);
            this.privteKeyLabel.Name = "privteKeyLabel";
            this.privteKeyLabel.Size = new System.Drawing.Size(37, 21);
            this.privteKeyLabel.TabIndex = 4;
            this.privteKeyLabel.Text = "d n:";
            // 
            // privateKeyTextBox
            // 
            this.privateKeyTextBox.BackColor = System.Drawing.Color.White;
            this.privateKeyTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateKeyTextBox.Location = new System.Drawing.Point(143, 140);
            this.privateKeyTextBox.Name = "privateKeyTextBox";
            this.privateKeyTextBox.Size = new System.Drawing.Size(154, 29);
            this.privateKeyTextBox.TabIndex = 6;
            // 
            // encryptMsgTextBox
            // 
            this.encryptMsgTextBox.BackColor = System.Drawing.Color.White;
            this.encryptMsgTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptMsgTextBox.Location = new System.Drawing.Point(15, 175);
            this.encryptMsgTextBox.Multiline = true;
            this.encryptMsgTextBox.Name = "encryptMsgTextBox";
            this.encryptMsgTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptMsgTextBox.Size = new System.Drawing.Size(282, 89);
            this.encryptMsgTextBox.TabIndex = 7;
            // 
            // saveFileBtn_encrypt
            // 
            this.saveFileBtn_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFileBtn_encrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileBtn_encrypt.Location = new System.Drawing.Point(14, 297);
            this.saveFileBtn_encrypt.Name = "saveFileBtn_encrypt";
            this.saveFileBtn_encrypt.Size = new System.Drawing.Size(283, 32);
            this.saveFileBtn_encrypt.TabIndex = 8;
            this.saveFileBtn_encrypt.Text = "Сохранить в файл";
            this.saveFileBtn_encrypt.UseVisualStyleBackColor = true;
            this.saveFileBtn_encrypt.Click += new System.EventHandler(this.saveFileBtn_encrypt_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(11, 245);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 13);
            this.progressLabel.TabIndex = 9;
            // 
            // dnInput
            // 
            this.dnInput.BackColor = System.Drawing.Color.White;
            this.dnInput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dnInput.Location = new System.Drawing.Point(326, 67);
            this.dnInput.Name = "dnInput";
            this.dnInput.Size = new System.Drawing.Size(283, 29);
            this.dnInput.TabIndex = 10;
            // 
            // dnLabel
            // 
            this.dnLabel.AutoSize = true;
            this.dnLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dnLabel.Location = new System.Drawing.Point(322, 38);
            this.dnLabel.Name = "dnLabel";
            this.dnLabel.Size = new System.Drawing.Size(37, 21);
            this.dnLabel.TabIndex = 11;
            this.dnLabel.Text = "d n:";
            // 
            // openFileBtn2
            // 
            this.openFileBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileBtn2.Location = new System.Drawing.Point(326, 102);
            this.openFileBtn2.Name = "openFileBtn2";
            this.openFileBtn2.Size = new System.Drawing.Size(283, 32);
            this.openFileBtn2.TabIndex = 12;
            this.openFileBtn2.Text = "Выберите файл .txt";
            this.openFileBtn2.UseVisualStyleBackColor = true;
            this.openFileBtn2.Click += new System.EventHandler(this.openFileBtn2_Click);
            // 
            // decryptMsgTextBox
            // 
            this.decryptMsgTextBox.BackColor = System.Drawing.Color.White;
            this.decryptMsgTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptMsgTextBox.Location = new System.Drawing.Point(326, 140);
            this.decryptMsgTextBox.Multiline = true;
            this.decryptMsgTextBox.Name = "decryptMsgTextBox";
            this.decryptMsgTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decryptMsgTextBox.Size = new System.Drawing.Size(282, 124);
            this.decryptMsgTextBox.TabIndex = 13;
            // 
            // saveFileBtn_decrypt
            // 
            this.saveFileBtn_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFileBtn_decrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileBtn_decrypt.Location = new System.Drawing.Point(326, 297);
            this.saveFileBtn_decrypt.Name = "saveFileBtn_decrypt";
            this.saveFileBtn_decrypt.Size = new System.Drawing.Size(283, 32);
            this.saveFileBtn_decrypt.TabIndex = 14;
            this.saveFileBtn_decrypt.Text = "Сохранить в файл";
            this.saveFileBtn_decrypt.UseVisualStyleBackColor = true;
            this.saveFileBtn_decrypt.Click += new System.EventHandler(this.saveFileBtn_decrypt_Click);
            // 
            // progressLabel2
            // 
            this.progressLabel2.AutoSize = true;
            this.progressLabel2.Location = new System.Drawing.Point(323, 274);
            this.progressLabel2.Name = "progressLabel2";
            this.progressLabel2.Size = new System.Drawing.Size(0, 13);
            this.progressLabel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "ENCRYPT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(438, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "DECRYPT";
            // 
            // main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressLabel2);
            this.Controls.Add(this.saveFileBtn_decrypt);
            this.Controls.Add(this.decryptMsgTextBox);
            this.Controls.Add(this.openFileBtn2);
            this.Controls.Add(this.dnLabel);
            this.Controls.Add(this.dnInput);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.saveFileBtn_encrypt);
            this.Controls.Add(this.encryptMsgTextBox);
            this.Controls.Add(this.privateKeyTextBox);
            this.Controls.Add(this.privteKeyLabel);
            this.Controls.Add(this.pqLabel);
            this.Controls.Add(this.pqInput);
            this.Controls.Add(this.openFileBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(637, 371);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(637, 371);
            this.Name = "main_screen";
            this.Text = "RSA Парфенов ИТк-301";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox pqInput;
        private System.Windows.Forms.Label pqLabel;
        private System.Windows.Forms.Label privteKeyLabel;
        private System.Windows.Forms.TextBox privateKeyTextBox;
        private System.Windows.Forms.TextBox encryptMsgTextBox;
        private System.Windows.Forms.Button saveFileBtn_encrypt;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.TextBox dnInput;
        private System.Windows.Forms.Label dnLabel;
        private System.Windows.Forms.Button openFileBtn2;
        private System.Windows.Forms.TextBox decryptMsgTextBox;
        private System.Windows.Forms.Button saveFileBtn_decrypt;
        private System.Windows.Forms.Label progressLabel2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

