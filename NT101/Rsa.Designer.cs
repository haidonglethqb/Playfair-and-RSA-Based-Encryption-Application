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
            btnSaveKey = new Button();
            progressBar1 = new ProgressBar();
            btnuploadkey = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackgroundImage = Properties.Resources._5_encrypt;
            btnEncrypt.BackgroundImageLayout = ImageLayout.Stretch;
            btnEncrypt.FlatAppearance.BorderSize = 0;
            btnEncrypt.FlatStyle = FlatStyle.Flat;
            btnEncrypt.Location = new Point(558, 367);
            btnEncrypt.Margin = new Padding(3, 4, 3, 4);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(167, 107);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // richTextBoxInput
            // 
            richTextBoxInput.Location = new Point(546, 563);
            richTextBoxInput.Margin = new Padding(3, 4, 3, 4);
            richTextBoxInput.Name = "richTextBoxInput";
            richTextBoxInput.Size = new Size(389, 281);
            richTextBoxInput.TabIndex = 1;
            richTextBoxInput.Text = "";
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.Location = new Point(959, 563);
            richTextBoxOutput.Margin = new Padding(3, 4, 3, 4);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.Size = new Size(385, 281);
            richTextBoxOutput.TabIndex = 2;
            richTextBoxOutput.Text = "";
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.BackgroundImage = Properties.Resources._3_create;
            btnGenerateKey.BackgroundImageLayout = ImageLayout.Stretch;
            btnGenerateKey.FlatAppearance.BorderSize = 0;
            btnGenerateKey.FlatStyle = FlatStyle.Flat;
            btnGenerateKey.Location = new Point(72, 302);
            btnGenerateKey.Margin = new Padding(3, 4, 3, 4);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new Size(169, 88);
            btnGenerateKey.TabIndex = 3;
            btnGenerateKey.UseVisualStyleBackColor = true;
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // checkBox1024
            // 
            checkBox1024.AutoSize = true;
            checkBox1024.BackColor = Color.Transparent;
            checkBox1024.Location = new Point(321, 335);
            checkBox1024.Margin = new Padding(3, 4, 3, 4);
            checkBox1024.Name = "checkBox1024";
            checkBox1024.Size = new Size(63, 24);
            checkBox1024.TabIndex = 4;
            checkBox1024.Text = "1024";
            checkBox1024.UseVisualStyleBackColor = false;
            // 
            // checkBox2048
            // 
            checkBox2048.AutoSize = true;
            checkBox2048.BackColor = Color.Transparent;
            checkBox2048.Location = new Point(390, 335);
            checkBox2048.Margin = new Padding(3, 4, 3, 4);
            checkBox2048.Name = "checkBox2048";
            checkBox2048.Size = new Size(63, 24);
            checkBox2048.TabIndex = 5;
            checkBox2048.Text = "2048";
            checkBox2048.UseVisualStyleBackColor = false;
            // 
            // richTextBoxKeyDisplay
            // 
            richTextBoxKeyDisplay.Location = new Point(25, 396);
            richTextBoxKeyDisplay.Margin = new Padding(3, 4, 3, 4);
            richTextBoxKeyDisplay.Name = "richTextBoxKeyDisplay";
            richTextBoxKeyDisplay.Size = new Size(365, 209);
            richTextBoxKeyDisplay.TabIndex = 6;
            richTextBoxKeyDisplay.Text = "";
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackgroundImage = Properties.Resources._6_decrypt;
            btnDecrypt.BackgroundImageLayout = ImageLayout.Stretch;
            btnDecrypt.FlatAppearance.BorderSize = 0;
            btnDecrypt.FlatStyle = FlatStyle.Flat;
            btnDecrypt.Location = new Point(770, 367);
            btnDecrypt.Margin = new Padding(3, 4, 3, 4);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(165, 107);
            btnDecrypt.TabIndex = 7;
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
            checkBox512.BackColor = Color.Transparent;
            checkBox512.Location = new Point(260, 335);
            checkBox512.Margin = new Padding(3, 4, 3, 4);
            checkBox512.Name = "checkBox512";
            checkBox512.Size = new Size(55, 24);
            checkBox512.TabIndex = 9;
            checkBox512.Text = "512";
            checkBox512.UseVisualStyleBackColor = false;
            // 
            // btnUploadfile
            // 
            btnUploadfile.BackgroundImage = Properties.Resources._8_upload;
            btnUploadfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnUploadfile.FlatAppearance.BorderSize = 0;
            btnUploadfile.FlatStyle = FlatStyle.Flat;
            btnUploadfile.Location = new Point(867, 165);
            btnUploadfile.Margin = new Padding(3, 4, 3, 4);
            btnUploadfile.Name = "btnUploadfile";
            btnUploadfile.Size = new Size(226, 129);
            btnUploadfile.TabIndex = 11;
            btnUploadfile.UseVisualStyleBackColor = true;
            btnUploadfile.Click += btnUploadfile_Click;
            // 
            // btnStart
            // 
            btnStart.BackgroundImage = Properties.Resources._9_start1;
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Location = new Point(992, 382);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(145, 77);
            btnStart.TabIndex = 12;
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources._4_clear;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(284, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(63, 64);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = Properties.Resources._10_save1;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(1190, 382);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 83);
            btnSave.TabIndex = 14;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSaveKey
            // 
            btnSaveKey.Location = new Point(46, 641);
            btnSaveKey.Margin = new Padding(3, 4, 3, 4);
            btnSaveKey.Name = "btnSaveKey";
            btnSaveKey.Size = new Size(134, 72);
            btnSaveKey.TabIndex = 15;
            btnSaveKey.Text = "Save Private Key";
            btnSaveKey.UseVisualStyleBackColor = true;
            btnSaveKey.Click += btnSaveKey_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 852);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1350, 31);
            progressBar1.TabIndex = 16;
            // 
            // btnuploadkey
            // 
            btnuploadkey.BackgroundImage = Properties.Resources._2_upload;
            btnuploadkey.BackgroundImageLayout = ImageLayout.Stretch;
            btnuploadkey.FlatAppearance.BorderSize = 0;
            btnuploadkey.FlatStyle = FlatStyle.Flat;
            btnuploadkey.Location = new Point(96, 213);
            btnuploadkey.Margin = new Padding(3, 4, 3, 4);
            btnuploadkey.Name = "btnuploadkey";
            btnuploadkey.Size = new Size(126, 81);
            btnuploadkey.TabIndex = 17;
            btnuploadkey.UseVisualStyleBackColor = true;
            btnuploadkey.Click += btnuploadkey_Click;
            // 
            // button2
            // 
            button2.Location = new Point(237, 641);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(134, 72);
            button2.TabIndex = 18;
            button2.Text = "Save Public Key";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Rsa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1_rsa_new3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1379, 839);
            Controls.Add(button2);
            Controls.Add(btnuploadkey);
            Controls.Add(progressBar1);
            Controls.Add(btnSaveKey);
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
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
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
        private Button btnSaveKey;
        private ProgressBar progressBar1;
        private Button btnuploadkey;
        private Button button2;
    }
}