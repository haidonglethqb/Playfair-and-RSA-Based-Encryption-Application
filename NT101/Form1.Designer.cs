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
            button1.BackgroundImage = Properties.Resources._3;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(510, 180);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(325, 217);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources._2;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(64, 176);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(325, 224);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnLearnAboutRsa
            // 
            btnLearnAboutRsa.BackgroundImage = Properties.Resources._4;
            btnLearnAboutRsa.BackgroundImageLayout = ImageLayout.Stretch;
            btnLearnAboutRsa.FlatAppearance.BorderSize = 0;
            btnLearnAboutRsa.FlatStyle = FlatStyle.Flat;
            btnLearnAboutRsa.Location = new Point(133, 371);
            btnLearnAboutRsa.Margin = new Padding(3, 4, 3, 4);
            btnLearnAboutRsa.Name = "btnLearnAboutRsa";
            btnLearnAboutRsa.Size = new Size(154, 108);
            btnLearnAboutRsa.TabIndex = 2;
            btnLearnAboutRsa.UseVisualStyleBackColor = true;
            btnLearnAboutRsa.Click += btnLearnAboutRsa_Click;
            // 
            // btnLearnAboutPlayFair
            // 
            btnLearnAboutPlayFair.BackgroundImage = Properties.Resources._5;
            btnLearnAboutPlayFair.BackgroundImageLayout = ImageLayout.Stretch;
            btnLearnAboutPlayFair.FlatAppearance.BorderSize = 0;
            btnLearnAboutPlayFair.FlatStyle = FlatStyle.Flat;
            btnLearnAboutPlayFair.Location = new Point(582, 371);
            btnLearnAboutPlayFair.Margin = new Padding(3, 4, 3, 4);
            btnLearnAboutPlayFair.Name = "btnLearnAboutPlayFair";
            btnLearnAboutPlayFair.Size = new Size(177, 108);
            btnLearnAboutPlayFair.TabIndex = 3;
            btnLearnAboutPlayFair.UseVisualStyleBackColor = true;
            btnLearnAboutPlayFair.Click += btnLearnAboutPlayFair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(868, 535);
            Controls.Add(btnLearnAboutPlayFair);
            Controls.Add(btnLearnAboutRsa);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnLearnAboutRsa;
        private Button btnLearnAboutPlayFair;
    }
}
