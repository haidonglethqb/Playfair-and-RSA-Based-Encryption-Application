namespace NT101
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            btnLearnAboutRsa = new Button();
            btnLearnAboutPlayFair = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(96, 78);
            button1.Name = "button1";
            button1.Size = new Size(190, 197);
            button1.TabIndex = 0;
            button1.Text = "PlayFair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(413, 78);
            button2.Name = "button2";
            button2.Size = new Size(165, 197);
            button2.TabIndex = 1;
            button2.Text = "RSA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnLearnAboutRsa
            // 
            btnLearnAboutRsa.Location = new Point(412, 302);
            btnLearnAboutRsa.Name = "btnLearnAboutRsa";
            btnLearnAboutRsa.Size = new Size(166, 55);
            btnLearnAboutRsa.TabIndex = 2;
            btnLearnAboutRsa.Text = "Learn About Rsa";
            btnLearnAboutRsa.UseVisualStyleBackColor = true;
            btnLearnAboutRsa.Click += btnLearnAboutRsa_Click;
            // 
            // btnLearnAboutPlayFair
            // 
            btnLearnAboutPlayFair.Location = new Point(99, 302);
            btnLearnAboutPlayFair.Name = "btnLearnAboutPlayFair";
            btnLearnAboutPlayFair.Size = new Size(187, 55);
            btnLearnAboutPlayFair.TabIndex = 3;
            btnLearnAboutPlayFair.Text = "Learn About PlayFair";
            btnLearnAboutPlayFair.UseVisualStyleBackColor = true;
            btnLearnAboutPlayFair.Click += btnLearnAboutPlayFair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLearnAboutPlayFair);
            Controls.Add(btnLearnAboutRsa);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnLearnAboutRsa;
        private Button btnLearnAboutPlayFair;
    }
}
