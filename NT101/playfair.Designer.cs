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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackgroundImage = Properties.Resources._2_playfair;
            btnEncrypt.BackgroundImageLayout = ImageLayout.Stretch;
            btnEncrypt.FlatAppearance.BorderSize = 0;
            btnEncrypt.FlatStyle = FlatStyle.Flat;
            btnEncrypt.ForeColor = SystemColors.ControlDarkDark;
            btnEncrypt.Location = new Point(426, 466);
            btnEncrypt.Margin = new Padding(3, 4, 3, 4);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(136, 80);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackgroundImage = Properties.Resources._3_playfair;
            btnDecrypt.BackgroundImageLayout = ImageLayout.Stretch;
            btnDecrypt.FlatAppearance.BorderSize = 0;
            btnDecrypt.FlatStyle = FlatStyle.Flat;
            btnDecrypt.Location = new Point(426, 554);
            btnDecrypt.Margin = new Padding(3, 4, 3, 4);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(136, 84);
            btnDecrypt.TabIndex = 1;
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(67, 359);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(287, 194);
            txtInput.TabIndex = 2;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(387, 422);
            txtKey.Margin = new Padding(3, 4, 3, 4);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(241, 27);
            txtKey.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(661, 359);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(286, 194);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // playfair
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1_playfair;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1015, 651);
            Controls.Add(richTextBox1);
            Controls.Add(txtKey);
            Controls.Add(txtInput);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Margin = new Padding(3, 4, 3, 4);
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
        private RichTextBox richTextBox1;
    }
}