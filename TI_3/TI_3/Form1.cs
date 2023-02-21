using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace TI_3
{
    public partial class Form1 : Form
    {
        string plaintext;
        int g;
        //static BigInteger a;

        public Form1()
        {
            InitializeComponent();
            p_error.Visible = false;
            x_error.Visible = false;
            k_error.Visible = false;
        }

        bool check_p(int p) 
        {
            bool is_correct = true;
            for (int i = 2; i <= p / 2; i++)
            {
                if (p % i == 0)
                {
                    is_correct = false;
                    p_error.Visible = true;
                    break;
                }
            }
            return is_correct;
        }

        bool check_x(int x)
        {
            if (x > 1)
            {
                return true;
            }
            else
            {
                x_error.Visible = true;
                return false;
            }
        }

        bool check_k(int k, int p)
        {
            bool is_correct = false;
            int NOD = 0;
            p = p - 1;
            for (int i = p; i > 0; i--)
            {
                if (k % i == 0)
                {
                    if (p % i == 0)
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
                k_error.Visible = true;
                is_correct = false;
            }
            return is_correct;
        }

        int[] create_m()
        {
            int [] m = new int[plaintext.Length];
            for (int i = 0; i < plaintext.Length; i++)
            {
                m[i] = (int)plaintext[i];
            }
            return m;
        }

        int calculate_y(int g, int x, int p)
        { // y = g^x mod p
            ulong y = (ulong)g;
            for (int i = 1; i < x; i++)
            {
                y *= (ulong)g;
            }
            y = y % (ulong)p;
            int result = (int)y;

            return result;
        }

        int calculate_a(int g, int k, int p)
        { //a = g^k mod p
            ulong a = (ulong)g;
            for (int i = 1; i < k; i++)
            {
                a = a * (ulong)g;
            }
            a = a % (ulong)p;
            int result = (int)a;
            
            return result;
        }

        int calculate_b(int y, int k, int m, int p)
        { //b = y^k *m mod p
            ulong b = (ulong)y;
            for (int i = 1; i < k; i++)
            {
                b *= (ulong)y;
            }
            b *= (ulong)m; //выход за ulong. 18446744073709551615
            b %= (ulong)p;
            int result = (int)b;

            return result;
        }

        string decode(int b, int a, int x, int p, int y, string m)
        { //m = ba^(p-1-x) mod p
            ulong result = (ulong)a;
            int loop = p - 1 - x;
            for (int i = 1; i < loop; i++)
            {
                result *= (ulong)a; //не хватает ulong
            }
            result *= (ulong)b;
            result %= (ulong)p;
            m += result.ToString() + " ";
            return m;         
        }

        public int GetPRoot(int p)
        {
            for (int i = 0; i < p; i++)
                if (IsPRoot(p, i))
                    return i;
            return 0;
        }

        public bool IsPRoot(int p, int a)
        {
            if (a == 0 || a == 1)
                return false;
            int last = 1;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < p - 1; i++)
            {
                last = (last * a) % p;
                if (set.Contains(last)) // Если повтор
                    return false;
                set.Add(last);
                g_cb.Items.Add(last);   
            }
            return true;
        }

        private void cipher_btn_Click(object sender, EventArgs e)
        {
            bool is_p, is_x, is_k;
            int[] m = create_m();
            string result = "";
            plaintext = plaintext_tb.Text;

            int p = 0;
            Int32.TryParse(p_tb.Text, out p);
            is_p = check_p(p);

            int x = 0;
            Int32.TryParse(x_tb.Text, out x);
            is_x = check_x(x);

            int k = 0;
            Int32.TryParse(k_tb.Text, out k);
            is_k = check_k(k, p);

            string g_str = g_cb.SelectedItem.ToString();
            g = 0;
            Int32.TryParse(g_str, out g);

            if (is_p && is_x && is_k)
            {
                int y = calculate_y(g, x, p);
                open_key_tb.Text = p.ToString() + ", " + g.ToString() + ", " + y.ToString();
                close_key_tb.Text = x.ToString();

                int a = calculate_a(g, k, p);
                for (int i = 0; i < m.Length; i++)
                {                    
                    int b = calculate_b(y, k, m[i], p);
                    chipertext.Text = chipertext.Text + a.ToString() + "," + b.ToString() + " ";
                    result = decode(b, a, x, p, y, result);
                }
              
                decryptedtext.Text = result;
            }
        }

        private void p_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            p_error.Visible = false;
            x_error.Visible = false;
            k_error.Visible = false;
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

        private void x_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            p_error.Visible = false;
            x_error.Visible = false;
            k_error.Visible = false;
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

        private void k_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            p_error.Visible = false;
            x_error.Visible = false;
            k_error.Visible = false;
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
            e.Handled = true;
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string file_name = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(file_name);
            plaintext_tb.Text = fileText;
            plaintext = plaintext_tb.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = 0;
            Int32.TryParse(p_tb.Text, out p);
            int variable = GetPRoot(p);
            g_cb.SelectedIndex = 0;
            string g_str = g_cb.SelectedItem.ToString();
            g = 0;
            Int32.TryParse(g_str, out g);
        }
    }
}
