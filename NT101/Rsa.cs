using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;

namespace NT101
{
    public partial class Rsa : Form
    {
        public Rsa()
        {
            InitializeComponent();
        }
        string filepath;
        string pbkey = "";
        string filepathdecrypt;
        string prvkey = "";
        string datatosave;
        private void btnGenerateKey_Click(object sender, EventArgs e)
        {

            int value = 0;
            string publicKey = "";
            string privateKey = "";

            if (checkBox1024.Checked && checkBox2048.Checked)
            {
                MessageBox.Show("Please select only one key size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBox1024.Checked && checkBox512.Checked)
            {
                MessageBox.Show("Please select only one key size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBox2048.Checked && checkBox512.Checked)
            {
                MessageBox.Show("Please select only one key size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkBox512.Checked)
            {
                value = 512;
            }
            if (checkBox1024.Checked)
            {
                value = 1024;
            }
            else if (checkBox2048.Checked)
            { value = 2048; }

            if (value == 0)
            {
                MessageBox.Show("Please select a key size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(value))
            {


                publicKey = Convert.ToBase64String(rsa.ExportRSAPublicKey());

                privateKey = Convert.ToBase64String(rsa.ExportRSAPrivateKey());

                richTextBoxKeyDisplay.Text = $"Your Key Size is {value} \n\nPublic Key: {publicKey}\n\nPrivate Key: {privateKey}";
                publicKey = rsa.ToXmlString(false);
                privateKey = rsa.ToXmlString(true);
            }
            pbkey = publicKey;
            prvkey = privateKey;
        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (richTextBoxKeyDisplay.Text == "")
            {
                MessageBox.Show("Please generate key first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string text1 = richTextBoxInput.Text;

            byte[] filedata = System.IO.File.ReadAllBytes(filepath);

            string text = System.Text.Encoding.UTF8.GetString(filedata);

            string encryptedText = "";
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(pbkey);

                using (Aes aes = Aes.Create())
                {
                    aes.GenerateKey();
                    byte[] encryptedData;
                    using (ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                            {
                                byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
                                cs.Write(data, 0, data.Length);
                                cs.FlushFinalBlock();
                                encryptedData = ms.ToArray();
                            }
                        }
                    }

                    byte[] encryptedKey = rsa.Encrypt(aes.Key, false);

                    byte[] combinedData = new byte[encryptedKey.Length + aes.IV.Length + encryptedData.Length];
                    Buffer.BlockCopy(encryptedKey, 0, combinedData, 0, encryptedKey.Length);
                    Buffer.BlockCopy(aes.IV, 0, combinedData, encryptedKey.Length, aes.IV.Length);
                    Buffer.BlockCopy(encryptedData, 0, combinedData, encryptedKey.Length + aes.IV.Length, encryptedData.Length);

                    encryptedText = Convert.ToBase64String(combinedData);
                }
            }
            richTextBoxOutput.Text = encryptedText;
            richTextBoxKeyDisplay.Clear();
            richTextBoxKeyDisplay.Text += prvkey;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Encrypted File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, encryptedText);
                }
            }
            MessageBox.Show("Save this private key to later decrypted your file");
        }



        private void btnUploadfile_Click(object sender, EventArgs e)
        {
            string content = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;
                content = System.IO.File.ReadAllText(filepath);
                richTextBoxInput.Text = "Your file has been uploaded successfully\n Your File Contain: \n  ";
                richTextBoxInput.Text += content;
            }


        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            richTextBoxKeyDisplay.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepathdecrypt = openFileDialog1.FileName;
                richTextBoxInput.Text = "Your has uploaded the decrypted file successfully";
                btnStart.Visible = true;
            }
        }

        private void Rsa_Load(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnSave.Visible = false;
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            if (richTextBoxKeyDisplay.Text == "")
            {
                MessageBox.Show("Please enter your private key in XML Format <3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string text = System.IO.File.ReadAllText(filepathdecrypt);
            string decryptedText = "";
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(richTextBoxKeyDisplay.Text);

                byte[] combinedData = Convert.FromBase64String(text);

                byte[] encryptedKey = new byte[rsa.KeySize / 8];
                byte[] iv = new byte[16];
                byte[] encryptedData = new byte[combinedData.Length - encryptedKey.Length - iv.Length];

                Buffer.BlockCopy(combinedData, 0, encryptedKey, 0, encryptedKey.Length);
                Buffer.BlockCopy(combinedData, encryptedKey.Length, iv, 0, iv.Length);
                Buffer.BlockCopy(combinedData, encryptedKey.Length + iv.Length, encryptedData, 0, encryptedData.Length);

                byte[] key = rsa.Decrypt(encryptedKey, false);

                using (Aes aes = Aes.Create())
                {
                    using (ICryptoTransform decryptor = aes.CreateDecryptor(key, iv))
                    {
                        using (MemoryStream ms = new MemoryStream(encryptedData))
                        {
                            using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                            {
                                using (StreamReader reader = new StreamReader(cs))
                                {
                                    decryptedText = reader.ReadToEnd();
                                }
                            }
                        }
                    }
                }
            }
            richTextBoxOutput.Text = decryptedText;
            btnSave.Visible = true;
            datatosave = decryptedText;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxInput.Clear();
            richTextBoxOutput.Clear();
            richTextBoxKeyDisplay.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Encrypted File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, datatosave);
                }
            }
        }
    }
}
