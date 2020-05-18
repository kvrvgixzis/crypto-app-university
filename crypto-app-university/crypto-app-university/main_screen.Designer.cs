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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.pqInput = new System.Windows.Forms.TextBox();
            this.pqLabel = new System.Windows.Forms.Label();
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.privteKeyLabel = new System.Windows.Forms.Label();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.privateKeyTextBox = new System.Windows.Forms.TextBox();
            this.encryptMsgTextBox = new System.Windows.Forms.TextBox();
            this.outputBtn = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
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
            this.openFileBtn.Location = new System.Drawing.Point(13, 73);
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
            this.pqInput.Location = new System.Drawing.Point(13, 38);
            this.pqInput.Name = "pqInput";
            this.pqInput.Size = new System.Drawing.Size(283, 29);
            this.pqInput.TabIndex = 1;
            // 
            // pqLabel
            // 
            this.pqLabel.AutoSize = true;
            this.pqLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pqLabel.Location = new System.Drawing.Point(9, 9);
            this.pqLabel.Name = "pqLabel";
            this.pqLabel.Size = new System.Drawing.Size(296, 21);
            this.pqLabel.TabIndex = 2;
            this.pqLabel.Text = "Введите простые p и q через пробел:";
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publicKeyLabel.Location = new System.Drawing.Point(9, 115);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(92, 21);
            this.publicKeyLabel.TabIndex = 3;
            this.publicKeyLabel.Text = "public key: ";
            // 
            // privteKeyLabel
            // 
            this.privteKeyLabel.AutoSize = true;
            this.privteKeyLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privteKeyLabel.Location = new System.Drawing.Point(9, 150);
            this.privteKeyLabel.Name = "privteKeyLabel";
            this.privteKeyLabel.Size = new System.Drawing.Size(94, 21);
            this.privteKeyLabel.TabIndex = 4;
            this.privteKeyLabel.Text = "private key:";
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.BackColor = System.Drawing.Color.White;
            this.publicKeyTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publicKeyTextBox.Location = new System.Drawing.Point(142, 112);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.Size = new System.Drawing.Size(154, 29);
            this.publicKeyTextBox.TabIndex = 5;
            // 
            // privateKeyTextBox
            // 
            this.privateKeyTextBox.BackColor = System.Drawing.Color.White;
            this.privateKeyTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateKeyTextBox.Location = new System.Drawing.Point(142, 147);
            this.privateKeyTextBox.Name = "privateKeyTextBox";
            this.privateKeyTextBox.Size = new System.Drawing.Size(154, 29);
            this.privateKeyTextBox.TabIndex = 6;
            // 
            // encryptMsgTextBox
            // 
            this.encryptMsgTextBox.BackColor = System.Drawing.Color.White;
            this.encryptMsgTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryptMsgTextBox.Location = new System.Drawing.Point(13, 182);
            this.encryptMsgTextBox.Multiline = true;
            this.encryptMsgTextBox.Name = "encryptMsgTextBox";
            this.encryptMsgTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptMsgTextBox.Size = new System.Drawing.Size(282, 89);
            this.encryptMsgTextBox.TabIndex = 7;
            // 
            // outputBtn
            // 
            this.outputBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBtn.Location = new System.Drawing.Point(13, 297);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(283, 32);
            this.outputBtn.TabIndex = 8;
            this.outputBtn.Text = "Сохранить в файл";
            this.outputBtn.UseVisualStyleBackColor = true;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(12, 274);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 13);
            this.progressLabel.TabIndex = 9;
            // 
            // main_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(307, 341);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.outputBtn);
            this.Controls.Add(this.encryptMsgTextBox);
            this.Controls.Add(this.privateKeyTextBox);
            this.Controls.Add(this.publicKeyTextBox);
            this.Controls.Add(this.privteKeyLabel);
            this.Controls.Add(this.publicKeyLabel);
            this.Controls.Add(this.pqLabel);
            this.Controls.Add(this.pqInput);
            this.Controls.Add(this.openFileBtn);
            this.Name = "main_screen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox pqInput;
        private System.Windows.Forms.Label pqLabel;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.Label privteKeyLabel;
        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.TextBox privateKeyTextBox;
        private System.Windows.Forms.TextBox encryptMsgTextBox;
        private System.Windows.Forms.Button outputBtn;
        private System.Windows.Forms.Label progressLabel;
    }
}

