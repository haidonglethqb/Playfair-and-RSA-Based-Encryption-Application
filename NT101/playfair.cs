using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT101
{
    public partial class playfair : Form
    {
        public playfair()
        {
            InitializeComponent();
        }


        public class PlayFairCipher
        {
            private char[,] keyMatrix = new char[5, 5];

            public PlayFairCipher(string key)
            {
                Builematrix(key);
            }

            private void Builematrix(string key)
            {
                string adjustedKey = "";
                bool[] exists = new bool[26];

                foreach (char c in key.ToUpper())
                {
                    if (c == 'J') continue;
                    if (!exists[c - 'A'])
                    {
                        adjustedKey += c;
                        exists[c - 'A'] = true;
                    }
                }

                for (char c = 'A'; c <= 'Z'; c++)
                {
                    if (c == 'J') continue;
                    if (!exists[c - 'A'])
                    {
                        adjustedKey += c;
                        exists[c - 'A'] = true;
                    }
                }

                int index = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        keyMatrix[i, j] = adjustedKey[index++];
                    }
                }
            }

            private (int, int) FindPosition(char ch)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (keyMatrix[i, j] == ch)
                            return (i, j);
                    }
                }
                return (-1, -1);
            }

            public string Encrypt(string input)
            {
                input = PrepareText(input);
                string result = "";

                for (int i = 0; i < input.Length; i += 2)
                {
                    var pos1 = FindPosition(input[i]);
                    var pos2 = FindPosition(input[i + 1]);

                    if (pos1.Item1 == pos2.Item1)
                    {
                        result += keyMatrix[pos1.Item1, (pos1.Item2 + 1) % 5];
                        result += keyMatrix[pos2.Item1, (pos2.Item2 + 1) % 5];
                    }
                    else if (pos1.Item2 == pos2.Item2)
                    {
                        result += keyMatrix[(pos1.Item1 + 1) % 5, pos1.Item2];
                        result += keyMatrix[(pos2.Item1 + 1) % 5, pos2.Item2];
                    }
                    else
                    {
                        result += keyMatrix[pos1.Item1, pos2.Item2];
                        result += keyMatrix[pos2.Item1, pos1.Item2];
                    }
                }

                return result;
            }

            public string Decrypt(string input)
            {
                string result = "";

                for (int i = 0; i < input.Length; i += 2)
                {
                    var pos1 = FindPosition(input[i]);
                    var pos2 = FindPosition(input[i + 1]);

                    if (pos1.Item1 == pos2.Item1)
                    {
                        // Cùng hàng
                        result += keyMatrix[pos1.Item1, (pos1.Item2 - 1 + 5) % 5];
                        result += keyMatrix[pos2.Item1, (pos2.Item2 - 1 + 5) % 5];
                    }
                    else if (pos1.Item2 == pos2.Item2)
                    {
                        // Cùng cột
                        result += keyMatrix[(pos1.Item1 - 1 + 5) % 5, pos1.Item2];
                        result += keyMatrix[(pos2.Item1 - 1 + 5) % 5, pos2.Item2];
                    }
                    else
                    {
                        // Hình chữ nhật
                        result += keyMatrix[pos1.Item1, pos2.Item2];
                        result += keyMatrix[pos2.Item1, pos1.Item2];
                    }
                }

                return result;
            }

            private string PrepareText(string input)
            {
                input = input.ToUpper().Replace("J", "I").Replace(" ", "");
                string result = "";

                for (int i = 0; i < input.Length; i++)
                {
                    result += input[i];
                    if (i + 1 < input.Length && input[i] == input[i + 1])
                        result += 'X';
                }

                if (result.Length % 2 != 0)
                    result += 'X';

                return result;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "" || txtKey.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            string inputText = txtInput.Text;
            string key = txtKey.Text;

            PlayFairCipher cipher = new PlayFairCipher(key);
            string encryptedText = cipher.Encrypt(inputText);
            richTextBox1.Text = "Văn bản đã mã hoá: " + encryptedText;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "" || txtKey.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            string encryptedText = txtInput.Text;
            string key = txtKey.Text;

            PlayFairCipher cipher = new PlayFairCipher(key);
            string decryptedText = cipher.Decrypt(encryptedText);
            richTextBox1.Text = "Văn bản đã giải mã: " + decryptedText;
        }
    }
}