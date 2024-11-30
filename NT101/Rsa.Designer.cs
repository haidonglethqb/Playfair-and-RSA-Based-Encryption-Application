namespace NT101
{
    partial class Rsa
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
            richTextBoxInput = new RichTextBox();
            richTextBoxOutput = new RichTextBox();
            btnGenerateKey = new Button();
            checkBox1024 = new CheckBox();
            checkBox2048 = new CheckBox();
            richTextBoxKeyDisplay = new RichTextBox();
            btnDecrypt = new Button();
            openFileDialog1 = new OpenFileDialog();
            checkBox512 = new CheckBox();
            btnUploadfile = new Button();
            btnStart = new Button();
            button1 = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(370, 288);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(134, 64);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // richTextBoxInput
            // 
            richTextBoxInput.Location = new Point(40, 288);
            richTextBoxInput.Name = "richTextBoxInput";
            richTextBoxInput.Size = new Size(291, 315);
            richTextBoxInput.TabIndex = 1;
            richTextBoxInput.Text = "";
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.Location = new Point(560, 288);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.Size = new Size(345, 315);
            richTextBoxOutput.TabIndex = 2;
            richTextBoxOutput.Text = "";
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.Location = new Point(40, 76);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new Size(133, 69);
            btnGenerateKey.TabIndex = 3;
            btnGenerateKey.Text = "Generate Key";
            btnGenerateKey.UseVisualStyleBackColor = true;
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // checkBox1024
            // 
            checkBox1024.AutoSize = true;
            checkBox1024.Location = new Point(190, 101);
            checkBox1024.Name = "checkBox1024";
            checkBox1024.Size = new Size(50, 19);
            checkBox1024.TabIndex = 4;
            checkBox1024.Text = "1024";
            checkBox1024.UseVisualStyleBackColor = true;
            // 
            // checkBox2048
            // 
            checkBox2048.AutoSize = true;
            checkBox2048.Location = new Point(190, 126);
            checkBox2048.Name = "checkBox2048";
            checkBox2048.Size = new Size(50, 19);
            checkBox2048.TabIndex = 5;
            checkBox2048.Text = "2048";
            checkBox2048.UseVisualStyleBackColor = true;
            // 
            // richTextBoxKeyDisplay
            // 
            richTextBoxKeyDisplay.Location = new Point(357, 29);
            richTextBoxKeyDisplay.Name = "richTextBoxKeyDisplay";
            richTextBoxKeyDisplay.Size = new Size(162, 158);
            richTextBoxKeyDisplay.TabIndex = 6;
            richTextBoxKeyDisplay.Text = "";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(370, 437);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(134, 69);
            btnDecrypt.TabIndex = 7;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox512
            // 
            checkBox512.AutoSize = true;
            checkBox512.Location = new Point(190, 76);
            checkBox512.Name = "checkBox512";
            checkBox512.Size = new Size(44, 19);
            checkBox512.TabIndex = 9;
            checkBox512.Text = "512";
            checkBox512.UseVisualStyleBackColor = true;
            // 
            // btnUploadfile
            // 
            btnUploadfile.Location = new Point(370, 369);
            btnUploadfile.Name = "btnUploadfile";
            btnUploadfile.Size = new Size(134, 62);
            btnUploadfile.TabIndex = 11;
            btnUploadfile.Text = "Upload File";
            btnUploadfile.UseVisualStyleBackColor = true;
            btnUploadfile.Click += btnUploadfile_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(371, 514);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(133, 63);
            btnStart.TabIndex = 12;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1, -1);
            button1.Name = "button1";
            button1.Size = new Size(73, 46);
            button1.TabIndex = 13;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(911, 288);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 63);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Rsa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 658);
            Controls.Add(btnSave);
            Controls.Add(button1);
            Controls.Add(btnStart);
            Controls.Add(btnUploadfile);
            Controls.Add(checkBox512);
            Controls.Add(btnDecrypt);
            Controls.Add(richTextBoxKeyDisplay);
            Controls.Add(checkBox2048);
            Controls.Add(checkBox1024);
            Controls.Add(btnGenerateKey);
            Controls.Add(richTextBoxOutput);
            Controls.Add(richTextBoxInput);
            Controls.Add(btnEncrypt);
            Name = "Rsa";
            Text = "Rsa";
            Load += Rsa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncrypt;
        private RichTextBox richTextBoxInput;
        private RichTextBox richTextBoxOutput;
        private Button btnGenerateKey;
        private CheckBox checkBox1024;
        private CheckBox checkBox2048;
        private RichTextBox richTextBoxKeyDisplay;
        private Button btnDecrypt;
        private OpenFileDialog openFileDialog1;
        private CheckBox checkBox512;
        private Button btnUploadfile;
        private Button btnStart;
        private Button button1;
        private Button btnSave;
    }
}