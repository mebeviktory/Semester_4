namespace RSA
{
    partial class Form1
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
            this.TextToEncrypt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EncryptedText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DecryptedText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eKey = new System.Windows.Forms.RichTextBox();
            this.nKey = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextToEncrypt
            // 
            this.TextToEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextToEncrypt.Location = new System.Drawing.Point(12, 98);
            this.TextToEncrypt.Name = "TextToEncrypt";
            this.TextToEncrypt.Size = new System.Drawing.Size(575, 92);
            this.TextToEncrypt.TabIndex = 0;
            this.TextToEncrypt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text to encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypted text";
            // 
            // EncryptedText
            // 
            this.EncryptedText.Location = new System.Drawing.Point(12, 213);
            this.EncryptedText.Name = "EncryptedText";
            this.EncryptedText.Size = new System.Drawing.Size(575, 93);
            this.EncryptedText.TabIndex = 3;
            this.EncryptedText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Decrypted text";
            // 
            // DecryptedText
            // 
            this.DecryptedText.Location = new System.Drawing.Point(12, 329);
            this.DecryptedText.Name = "DecryptedText";
            this.DecryptedText.Size = new System.Drawing.Size(575, 97);
            this.DecryptedText.TabIndex = 5;
            this.DecryptedText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Open key";
            // 
            // eKey
            // 
            this.eKey.Location = new System.Drawing.Point(75, 13);
            this.eKey.Name = "eKey";
            this.eKey.Size = new System.Drawing.Size(100, 19);
            this.eKey.TabIndex = 7;
            this.eKey.Text = "";
            // 
            // nKey
            // 
            this.nKey.Location = new System.Drawing.Point(75, 39);
            this.nKey.Name = "nKey";
            this.nKey.Size = new System.Drawing.Size(100, 19);
            this.nKey.TabIndex = 8;
            this.nKey.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(599, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nKey);
            this.Controls.Add(this.eKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DecryptedText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EncryptedText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextToEncrypt);
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextToEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox EncryptedText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox DecryptedText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox eKey;
        private System.Windows.Forms.RichTextBox nKey;
        private System.Windows.Forms.Button button1;
    }
}

