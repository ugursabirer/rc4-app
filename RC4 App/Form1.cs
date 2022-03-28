using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC4_App
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string RC4(string plaintext, string key)
        {
            StringBuilder result = new StringBuilder();
            int x, y, j = 0;
            int[] box = new int[256];

            for (int i = 0; i < 256; i++)
            {
                box[i] = i;
            }

            // Key-scheduling algorithm(KSA)
            for (int i = 0; i < 256; i++)
            {
                j = (key[i % key.Length] + box[i] + j) % 256;
                x = box[i];
                box[i] = box[j];
                box[j] = x;
            }

            // Pseudo-random generation algorithm (PRGA)
            for (int i = 0; i < plaintext.Length; i++)
            {
                y = i % 256;
                j = (box[y] + j) % 256;
                x = box[y];
                box[y] = box[j];
                box[j] = x;
                result.Append((char)(plaintext[i] ^ box[(box[y] + box[j]) % 256]));
            }
            return result.ToString();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            String key = keyArea.Text;
            String plaintext = plaintextArea.Text;
            if(key == "" || plaintext == "")
            {
                MessageBox.Show("Key veya Plaintext boş, lütfen doldurup tekrar deneyin.", "Hata!", MessageBoxButtons.OK);
            }
            else
            {
                String ciphertext = RC4(plaintext, key);
                ciphertextArea.Text = ciphertext;
            }
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            String key = keyArea.Text;
            String ciphertext = ciphertextArea.Text;
            if (key == "" || ciphertext == "")
            {
                MessageBox.Show("Key veya Plaintext boş, lütfen doldurup tekrar deneyin.", "Hata!", MessageBoxButtons.OK);
            }
            else
            {
                String maintext = RC4(ciphertext, key);
                maintextArea.Text = maintext;
            }
        }
    }
}
