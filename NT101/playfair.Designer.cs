namespace NT101
{
    partial class playfair
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
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            txtInput = new TextBox();
            txtKey = new TextBox();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(44, 37);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(75, 23);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(44, 107);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(75, 23);
            btnDecrypt.TabIndex = 1;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(221, 38);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(178, 23);
            txtInput.TabIndex = 2;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(518, 38);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(221, 23);
            txtKey.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 40);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 4;
            label1.Text = "KEY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 42);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Input";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(69, 188);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(591, 220);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // playfair
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKey);
            Controls.Add(txtInput);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Name = "playfair";
            Text = "playfair";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncrypt;
        private Button btnDecrypt;
        private TextBox txtInput;
        private TextBox txtKey;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
    }
}