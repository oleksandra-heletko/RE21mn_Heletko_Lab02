namespace Heletko_Lab02
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
            this.clearButton = new System.Windows.Forms.Button();
            this.xorButton = new System.Windows.Forms.Button();
            this.pEncLabel = new System.Windows.Forms.Label();
            this.pEncTextBox = new System.Windows.Forms.TextBox();
            this.keyEncTextBox = new System.Windows.Forms.TextBox();
            this.cEncTextBox = new System.Windows.Forms.TextBox();
            this.keyEncLabel = new System.Windows.Forms.Label();
            this.cEncLabel = new System.Windows.Forms.Label();
            this.cDecLabel = new System.Windows.Forms.Label();
            this.keyDecLabel = new System.Windows.Forms.Label();
            this.pDecTextBox = new System.Windows.Forms.TextBox();
            this.keyDecTextBox = new System.Windows.Forms.TextBox();
            this.cDecTextBox = new System.Windows.Forms.TextBox();
            this.pDecLabel = new System.Windows.Forms.Label();
            this.encodeLabel = new System.Windows.Forms.Label();
            this.decodeLabel = new System.Windows.Forms.Label();
            this.binLabel = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.decLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(312, 68);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 29);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Очистити";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // xorButton
            // 
            this.xorButton.Location = new System.Drawing.Point(312, 25);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(75, 27);
            this.xorButton.TabIndex = 1;
            this.xorButton.Text = "XOR";
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Click += new System.EventHandler(this.xorButton_Click);
            // 
            // pEncLabel
            // 
            this.pEncLabel.AutoSize = true;
            this.pEncLabel.Location = new System.Drawing.Point(23, 28);
            this.pEncLabel.Name = "pEncLabel";
            this.pEncLabel.Size = new System.Drawing.Size(26, 13);
            this.pEncLabel.TabIndex = 2;
            this.pEncLabel.Text = "P = ";
            // 
            // pEncTextBox
            // 
            this.pEncTextBox.Location = new System.Drawing.Point(55, 25);
            this.pEncTextBox.Name = "pEncTextBox";
            this.pEncTextBox.Size = new System.Drawing.Size(100, 20);
            this.pEncTextBox.TabIndex = 3;
            // 
            // keyEncTextBox
            // 
            this.keyEncTextBox.Location = new System.Drawing.Point(55, 51);
            this.keyEncTextBox.Name = "keyEncTextBox";
            this.keyEncTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyEncTextBox.TabIndex = 4;
            // 
            // cEncTextBox
            // 
            this.cEncTextBox.Location = new System.Drawing.Point(55, 77);
            this.cEncTextBox.Name = "cEncTextBox";
            this.cEncTextBox.Size = new System.Drawing.Size(100, 20);
            this.cEncTextBox.TabIndex = 5;
            // 
            // keyEncLabel
            // 
            this.keyEncLabel.AutoSize = true;
            this.keyEncLabel.Location = new System.Drawing.Point(9, 54);
            this.keyEncLabel.Name = "keyEncLabel";
            this.keyEncLabel.Size = new System.Drawing.Size(40, 13);
            this.keyEncLabel.TabIndex = 6;
            this.keyEncLabel.Text = "KEY = ";
            // 
            // cEncLabel
            // 
            this.cEncLabel.AutoSize = true;
            this.cEncLabel.Location = new System.Drawing.Point(23, 80);
            this.cEncLabel.Name = "cEncLabel";
            this.cEncLabel.Size = new System.Drawing.Size(26, 13);
            this.cEncLabel.TabIndex = 7;
            this.cEncLabel.Text = "C = ";
            // 
            // cDecLabel
            // 
            this.cDecLabel.AutoSize = true;
            this.cDecLabel.Location = new System.Drawing.Point(174, 28);
            this.cDecLabel.Name = "cDecLabel";
            this.cDecLabel.Size = new System.Drawing.Size(26, 13);
            this.cDecLabel.TabIndex = 13;
            this.cDecLabel.Text = "C = ";
            // 
            // keyDecLabel
            // 
            this.keyDecLabel.AutoSize = true;
            this.keyDecLabel.Location = new System.Drawing.Point(160, 54);
            this.keyDecLabel.Name = "keyDecLabel";
            this.keyDecLabel.Size = new System.Drawing.Size(40, 13);
            this.keyDecLabel.TabIndex = 12;
            this.keyDecLabel.Text = "KEY = ";
            // 
            // pDecTextBox
            // 
            this.pDecTextBox.Location = new System.Drawing.Point(206, 77);
            this.pDecTextBox.Name = "pDecTextBox";
            this.pDecTextBox.Size = new System.Drawing.Size(100, 20);
            this.pDecTextBox.TabIndex = 11;
            // 
            // keyDecTextBox
            // 
            this.keyDecTextBox.Location = new System.Drawing.Point(206, 51);
            this.keyDecTextBox.Name = "keyDecTextBox";
            this.keyDecTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyDecTextBox.TabIndex = 10;
            // 
            // cDecTextBox
            // 
            this.cDecTextBox.Location = new System.Drawing.Point(206, 25);
            this.cDecTextBox.Name = "cDecTextBox";
            this.cDecTextBox.Size = new System.Drawing.Size(100, 20);
            this.cDecTextBox.TabIndex = 9;
            // 
            // pDecLabel
            // 
            this.pDecLabel.AutoSize = true;
            this.pDecLabel.Location = new System.Drawing.Point(174, 80);
            this.pDecLabel.Name = "pDecLabel";
            this.pDecLabel.Size = new System.Drawing.Size(26, 13);
            this.pDecLabel.TabIndex = 8;
            this.pDecLabel.Text = "P = ";
            // 
            // encodeLabel
            // 
            this.encodeLabel.AutoSize = true;
            this.encodeLabel.Location = new System.Drawing.Point(65, 9);
            this.encodeLabel.Name = "encodeLabel";
            this.encodeLabel.Size = new System.Drawing.Size(76, 13);
            this.encodeLabel.TabIndex = 14;
            this.encodeLabel.Text = "Зашифрувати";
            // 
            // decodeLabel
            // 
            this.decodeLabel.AutoSize = true;
            this.decodeLabel.Location = new System.Drawing.Point(217, 9);
            this.decodeLabel.Name = "decodeLabel";
            this.decodeLabel.Size = new System.Drawing.Size(82, 13);
            this.decodeLabel.TabIndex = 15;
            this.decodeLabel.Text = "Розшифрувати";
            // 
            // binLabel
            // 
            this.binLabel.AutoSize = true;
            this.binLabel.Location = new System.Drawing.Point(23, 110);
            this.binLabel.Name = "binLabel";
            this.binLabel.Size = new System.Drawing.Size(58, 13);
            this.binLabel.TabIndex = 16;
            this.binLabel.Text = "2 формат:";
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(23, 156);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(67, 13);
            this.hexLabel.TabIndex = 17;
            this.hexLabel.Text = "16 формат: ";
            // 
            // decLabel
            // 
            this.decLabel.AutoSize = true;
            this.decLabel.Location = new System.Drawing.Point(23, 132);
            this.decLabel.Name = "decLabel";
            this.decLabel.Size = new System.Drawing.Size(67, 13);
            this.decLabel.TabIndex = 18;
            this.decLabel.Text = "10 формат: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 180);
            this.Controls.Add(this.decLabel);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.binLabel);
            this.Controls.Add(this.decodeLabel);
            this.Controls.Add(this.encodeLabel);
            this.Controls.Add(this.cDecLabel);
            this.Controls.Add(this.keyDecLabel);
            this.Controls.Add(this.pDecTextBox);
            this.Controls.Add(this.keyDecTextBox);
            this.Controls.Add(this.cDecTextBox);
            this.Controls.Add(this.pDecLabel);
            this.Controls.Add(this.cEncLabel);
            this.Controls.Add(this.keyEncLabel);
            this.Controls.Add(this.cEncTextBox);
            this.Controls.Add(this.keyEncTextBox);
            this.Controls.Add(this.pEncTextBox);
            this.Controls.Add(this.pEncLabel);
            this.Controls.Add(this.xorButton);
            this.Controls.Add(this.clearButton);
            this.Name = "Form1";
            this.Text = "XOR шифратор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button xorButton;
        private System.Windows.Forms.Label pEncLabel;
        private System.Windows.Forms.TextBox pEncTextBox;
        private System.Windows.Forms.TextBox keyEncTextBox;
        private System.Windows.Forms.TextBox cEncTextBox;
        private System.Windows.Forms.Label keyEncLabel;
        private System.Windows.Forms.Label cEncLabel;
        private System.Windows.Forms.Label cDecLabel;
        private System.Windows.Forms.Label keyDecLabel;
        private System.Windows.Forms.TextBox pDecTextBox;
        private System.Windows.Forms.TextBox keyDecTextBox;
        private System.Windows.Forms.TextBox cDecTextBox;
        private System.Windows.Forms.Label pDecLabel;
        private System.Windows.Forms.Label encodeLabel;
        private System.Windows.Forms.Label decodeLabel;
        private System.Windows.Forms.Label binLabel;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Label decLabel;
    }
}

