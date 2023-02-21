using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_4
{
    public partial class Form1 : Form
    {
        string plaintext;// = "БГУИР";
        string symbols_eng1 = "abcdefghijklmnopqrstuvwxyz";
        string symbols_eng2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string symbols_rus1 = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string symbols_rus2 = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public Form1()
        {
            InitializeComponent();
        }

        private void p_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == '0') return;
            if ((char)e.KeyChar == '1') return;
            if ((char)e.KeyChar == '2') return;
            if ((char)e.KeyChar == '3') return;
            if ((char)e.KeyChar == '4') return;
            if ((char)e.KeyChar == '5') return;
            if ((char)e.KeyChar == '6') return;
            if ((char)e.KeyChar == '7') return;
            if ((char)e.KeyChar == '8') return;
            if ((char)e.KeyChar == '9') return;
            if ((char)e.KeyChar == (char)8) return;
            e.Handled = true;
        }

        private void q_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == '0') return;
            if ((char)e.KeyChar == '1') return;
            if ((char)e.KeyChar == '2') return;
            if ((char)e.KeyChar == '3') return;
            if ((char)e.KeyChar == '4') return;
            if ((char)e.KeyChar == '5') return;
            if ((char)e.KeyChar == '6') return;
            if ((char)e.KeyChar == '7') return;
            if ((char)e.KeyChar == '8') return;
            if ((char)e.KeyChar == '9') return;
            if ((char)e.KeyChar == (char)8) return;
            e.Handled = true;
        }

        private void Kc_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == '0') return;
            if ((char)e.KeyChar == '1') return;
            if ((char)e.KeyChar == '2') return;
            if ((char)e.KeyChar == '3') return;
            if ((char)e.KeyChar == '4') return;
            if ((char)e.KeyChar == '5') return;
            if ((char)e.KeyChar == '6') return;
            if ((char)e.KeyChar == '7') return;
            if ((char)e.KeyChar == '8') return;
            if ((char)e.KeyChar == '9') return;
            if ((char)e.KeyChar == (char)8) return;
            e.Handled = true;
        }

        bool check_num(int p)
        {
            bool isCorrect = true;
            return isCorrect;
        }

        bool find_e(int e, int fr)
        {
            bool is_correct = false;
            int NOD = 0;
            for (int i = fr; i > 0; i--)
            {
                if (e % i == 0)
                {
                    if (fr % i == 0)
                    {
                        NOD = i;
                        break;
                    }
                }
            }
            if (NOD == 1)
            {
                is_correct = true;
            }
            else
            {
                is_correct = false;
            }
            return is_correct;
        }

        int calculate_d(int r)
        {
            int d = r - 1;

            for (long i = 2; i <= r; i++)
                if ((r % i == 0) && (d % i == 0)) //если имеют общие делители
                {
                    d--;
                    i = 1;
                }
            return d;
        }

        int calculate_hash(int n)
        { //Hi = (Hi-1 + Mi)^2 mod n
            int hM = 0;
            int Hi = 100;
            int Mi = 0;
            for (int i = 0; i < plaintext.Length; i++)
            {
                for (int j = 0; j < symbols_rus1.Length; j++)
                {
                    if (/*plaintext[i] == symbols_eng1[i] || plaintext[i] == symbols_eng2[i] ||*/ plaintext[i] == symbols_rus1[j] || plaintext[i] == symbols_rus2[j])
                    {
                        Mi = j + 1;
                        hM = ((Hi + Mi) * (Hi + Mi)) % n;
                        Hi = hM;
                    }
                }
            }
            return hM;
        }

        int calculate_EDS(int m, int d, int r) //biginteger
        { //S = m^d mod r
            int S = 0;
            int pow = m;
            for (int i = 0; i < d; i++)
            {
                pow *= m;
            }
            S = pow % r;
            return S;
        }

        int decode_m(int S, int exp, int r)
        {
            int hM = 0;
            int pow = S;
            for (int i = 0; i < exp; i++)
            {
                pow *= S;
            }
            hM = pow % r;
            return hM;
        }

        void decode(int S, int exp, int r)
        {

            int hM1 = decode_m(S, exp, r);
            int hM2 = calculate_hash(r);

            if (hM1 == hM2)
            {
                check_tb.Text = hM1.ToString() + " == " + hM2.ToString();
                result_tb.Text = "Valid EDS";
            }
            else
            {
                check_tb.Text = hM1.ToString() + " != " + hM2.ToString();
                result_tb.Text = "Invalid EDS";
            }            
        }

        private void cipher_btn_Click(object sender, EventArgs e)
        {
            bool is_p, is_q, is_d, is_r;
            plaintext = plaintext_tb.Text;

            int p = 0;
            Int32.TryParse(p_tb.Text, out p);
            //is_p = check_num(p);

            int q = 0;
            Int32.TryParse(q_tb.Text, out q);
            //is_q = check_num(q);

            //int d = calculate_d();
            //Int32.TryParse(q_tb.Text, out d);
            //is_d = check_num(d);

            int r = p * q;

            int fr = (p - 1) * (q - 1);

            int d = calculate_d(fr);

            //int exp = 0;
            int exp = 10;
            while (true)
            {
                if ((exp * d) % fr == 1)
                    break;
                else
                    exp++;
            }
            //exp = 43;

            int hM = calculate_hash(r);

            int S = calculate_EDS(hM, d, r);

            r_tb.Text = r.ToString();
            fr_tb.Text = fr.ToString();
            e_tb.Text = exp.ToString();
            Ko_tb.Text = exp.ToString() + ", " + r.ToString();
            h_tb.Text = hM.ToString();
            EDS.Text = S.ToString();

            coded_tb.Text = plaintext + ", " + S.ToString();

            decode(S, exp, r);
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string file_name = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(file_name);
            plaintext_tb.Text = fileText;
        }
    }
}
