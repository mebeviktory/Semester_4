namespace Hash
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.NumberOfCollisions = new System.Windows.Forms.TabPage();
            this.NumberOfCollisionsTextBox = new System.Windows.Forms.RichTextBox();
            this.ListOfWords = new System.Windows.Forms.TabPage();
            this.ListOfWordsTextBox = new System.Windows.Forms.RichTextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.NumberOfCollisions.SuspendLayout();
            this.ListOfWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hash function 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hash function 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(396, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hash function 3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(396, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Open text";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.NumberOfCollisions);
            this.tabControl1.Controls.Add(this.ListOfWords);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(378, 285);
            this.tabControl1.TabIndex = 5;
            // 
            // NumberOfCollisions
            // 
            this.NumberOfCollisions.Controls.Add(this.NumberOfCollisionsTextBox);
            this.NumberOfCollisions.Location = new System.Drawing.Point(4, 22);
            this.NumberOfCollisions.Name = "NumberOfCollisions";
            this.NumberOfCollisions.Padding = new System.Windows.Forms.Padding(3);
            this.NumberOfCollisions.Size = new System.Drawing.Size(370, 259);
            this.NumberOfCollisions.TabIndex = 0;
            this.NumberOfCollisions.Text = "NumberOfCollisions";
            this.NumberOfCollisions.UseVisualStyleBackColor = true;
            // 
            // NumberOfCollisionsTextBox
            // 
            this.NumberOfCollisionsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberOfCollisionsTextBox.Location = new System.Drawing.Point(3, 3);
            this.NumberOfCollisionsTextBox.Name = "NumberOfCollisionsTextBox";
            this.NumberOfCollisionsTextBox.Size = new System.Drawing.Size(364, 253);
            this.NumberOfCollisionsTextBox.TabIndex = 0;
            this.NumberOfCollisionsTextBox.Text = "";
            // 
            // ListOfWords
            // 
            this.ListOfWords.Controls.Add(this.ListOfWordsTextBox);
            this.ListOfWords.Location = new System.Drawing.Point(4, 22);
            this.ListOfWords.Name = "ListOfWords";
            this.ListOfWords.Padding = new System.Windows.Forms.Padding(3);
            this.ListOfWords.Size = new System.Drawing.Size(370, 259);
            this.ListOfWords.TabIndex = 1;
            this.ListOfWords.Text = "ListOfWords";
            this.ListOfWords.UseVisualStyleBackColor = true;
            // 
            // ListOfWordsTextBox
            // 
            this.ListOfWordsTextBox.Location = new System.Drawing.Point(0, 0);
            this.ListOfWordsTextBox.Name = "ListOfWordsTextBox";
            this.ListOfWordsTextBox.Size = new System.Drawing.Size(370, 259);
            this.ListOfWordsTextBox.TabIndex = 0;
            this.ListOfWordsTextBox.Text = "";
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(399, 176);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(63, 20);
            this.max.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "min";
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(399, 225);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(63, 20);
            this.min.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 310);
            this.Controls.Add(this.min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.max);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.NumberOfCollisions.ResumeLayout(false);
            this.ListOfWords.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage NumberOfCollisions;
        private System.Windows.Forms.TabPage ListOfWords;
        private System.Windows.Forms.RichTextBox NumberOfCollisionsTextBox;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.RichTextBox ListOfWordsTextBox;
    }
}

