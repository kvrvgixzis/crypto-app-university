using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto_app_university
{
    public partial class main_screen : Form
    {
        /* [A-Z][a-z][А-Я][а-я][0-9] */
        char[] alphabet = createAlphabet();

        public main_screen()
        {
            InitializeComponent();
        }

        private List<string> encryptRSA(string msg, long e, long n)
        {
            MessageBox.Show("Start Encrypt!");
            int msgLen = msg.Length;
            progressLabel.Text = $"Progress ({0}/{msgLen})";
            List<string> result = new List<string>();
            BigInteger bi;
            for (int i = 0; i < msgLen; i++) {
                int index = Array.IndexOf(alphabet, msg[i]);
                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);
                BigInteger n_ = new BigInteger((int)n);
                bi %= n_;
                result.Add(bi.ToString());
                progressLabel.Text = $"Progress ({i+1}/{msgLen})";
            }
            return result;
        }

        private string decryptRSA(List<string> input, long d, long n)
        {
            string result = "";
            BigInteger bi;
            foreach (string item in input) {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);
                BigInteger n_ = new BigInteger((int)n);
                bi %= n_;
                int i = Convert.ToInt32(bi.ToString());
                result += alphabet[i].ToString();
            }
            return result;
        }


        private long getD(long m)
        {
            long d = m - 1;
            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0)) {
                    d--;
                    i = 1;
                }
            return d;
        }

        private long getE(long d, long m)
        {
            long e = 10;    
            while (true) {
                if ((e * d) % m == 1) break;
                else e++;
            }
            return e;
        }

        private bool isPrime(long n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            for (long i = 2; i < n; i++)
                if (n % i == 0) return false;
            return true;
        }

        private bool isValidInput(string input)
        {
            if (input.Length > 0 && input.Split(' ').Length == 2)
            {
                long first, second;
                string[] pq = pqInput.Text.Split(' ');
                first = Convert.ToInt64(pq[0]);
                second = Convert.ToInt64(pq[1]);
                if (isPrime(first) && isPrime(second))
                {
                    return true;
                }
            }
            return false;
        }

        public static char[] createAlphabet()
        {
            /* [A-Z][a-z][А-Я][а-я][0-9] */
            char[] alphabet_en = Enumerable.Range('A', 58).Select(x => (char)x).ToArray();
            char[] alphabet_ru = Enumerable.Range('А', 64).Select(x => (char)x).ToArray();
            char[] alphabet_sumbols = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'Е', 'Ё', '#', ' ', '\r', '\n' };
            char[] alphabet = new char[alphabet_ru.Length + alphabet_en.Length + alphabet_sumbols.Length];
            alphabet_en.CopyTo(alphabet, 0);
            alphabet_ru.CopyTo(alphabet, alphabet_en.Length);
            alphabet_sumbols.CopyTo(alphabet, alphabet_en.Length + alphabet_ru.Length);
            return alphabet;
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (isValidInput(pqInput.Text))
            {
                MessageBox.Show("Is Valid!");
                long p_, q_;
                string[] pq = pqInput.Text.Split(' ');
                p_ = Convert.ToInt64(pq[0]);
                q_ = Convert.ToInt64(pq[1]);
                
                string inputText = "";
                string inputFilePath = "";

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        inputFilePath = openFileDialog.FileName;
                        Stream inputFileStream = openFileDialog.OpenFile();
                        using (StreamReader reader = new StreamReader(inputFileStream))
                        {
                            inputText = reader.ReadToEnd();
                        }
                    }
                }
                long n_ = p_ * q_;
                long m_ = (p_ - 1) * (q_ - 1);
                MessageBox.Show("N M!");

                long d_ = getD(m_);
                MessageBox.Show("D!");

                long e_ = getE(d_, m_);
                MessageBox.Show("E!");


                publicKeyTextBox.Text = $"{e_} {n_}";
                privateKeyTextBox.Text = $"{d_} {n_}";

                List<string> encryptMsg = encryptRSA(inputText, e_, n_);
                foreach (var line in encryptMsg)
                {
                    encryptMsgTextBox.Text += $"{line}\r\n";
                }
            }
            else
            {
                pqLabel.ForeColor = Color.Red;
            }
        }
    }
}
