using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_lab1
{
    public partial class Form1 : Form
    {
        string vigenere_key;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            input_error.Visible = false;
            error_lbl.Visible = false;
            label6.Visible = false;
            VSGkey.Visible = false;
            type.SelectedIndex = 2;
        }

        public string check_string_CV(string text)
        {
            int length = text.Length;
            int i = 0;
            do
            {
                if ((int)text[i] == 1025)
                {
                    i = i;
                }
                else if (((int)text[i] > 1071 || (int)text[i] < 1040))
                {
                    text = text.Remove(i, 1);
                    length--;
                    i--;
                }
                i++;
            } while (i < length);

            return text;
        }

        public string check_string_P(string text)
        {
            int length = text.Length;
            int i = 0;
            do
            {
                if (((int)text[i] > 90 || (int)text[i] < 65))
                {
                    text = text.Remove(i, 1);
                    length--;
                    i--;
                }
                i++;
            } while (i < length);

            return text;
        }

        public void columnar_transposition_cipher(string key, string plaintext)
        {
            string answer = "";
            int pt_length = plaintext.Length;
            int key_length = key.Length;
            int rowcount = pt_length / key_length + 2;
            int[,] matrix = new int[rowcount, key_length];

            for (int i = 0; i < key_length; i++)
            {
                matrix[0, i] = key[i];
            }

            int k = 0;
            int character_count = pt_length + key_length;
            while (character_count < key_length * rowcount)
            {
                plaintext += "0";
                character_count++;
            }
            for (int i = 1; i < rowcount; i++)
            {
                for (int j = 0; j < key_length; j++)
                {
                    matrix[i, j] = plaintext[k];
                    k++;
                }
            }

            int pos = 1040;
            do
            {
                for (int i = 0; i < key_length; i++)
                {
                    if ((pos == (int)key[i]) || ((int)key[i] == 1025))
                    {
                        for (int j = 1; j < rowcount; j++)
                        {
                            answer += (char)matrix[j, i];
                        }
                    }
                }
                pos++;
            } while (pos < 1072);
            answer = check_string_CV(answer);
            result_TB.Text = answer;
        }

        public void columnar_transposition_decode(string key, string plaintext)
        {
            string answer = "";
            int pt_length = plaintext.Length;
            int key_length = key.Length;
            int rowcount = pt_length / key_length + 2;
            int[,] matrix = new int[rowcount, key_length];

            for (int i = 0; i < key_length; i++)
            {
                for (int j = 0; j < rowcount; j++)
                {
                    matrix[j, i] = 1;
                }
                matrix[0, i] = key[i];
            }

            int count_empty = ((rowcount - 1) * key_length) - pt_length;
            for (int i = key_length - count_empty; i < key_length; i++)
            {
                matrix[rowcount - 1, i] = 0;
            }

            int k = 0;
            int pos = 1040;
            do
            {
                for (int i = 0; i < key_length; i++)
                {
                    if ((pos == (int)key[i]) || ((int)key[i] == 1025))
                    {
                        for (int j = 1; j < rowcount; j++)
                        {
                            if (matrix[j, i] == 1)
                            {
                                matrix[j, i] = plaintext[k];
                                k++;
                            }
                        }
                    }                    
                }              
                pos++;
            } while (pos < 1072);

            for (int i = 1; i < rowcount; i++)
            {
                for (int j = 0; j < key_length; j++)
                {
                    answer += (char)matrix[i, j];
                }
            }

            answer = check_string_CV(answer);
            result_TB.Text = answer;
        }

        string create_Vigenere_key(string key, string plaintext)
        {
            int pt_length = plaintext.Length;
            int key_length = key.Length;
            if (key_length < pt_length)
            {
                int i = 0;
                while (key_length < pt_length)
                {
                    key += plaintext[i];
                    i++;
                    key_length++;
                    if (i == pt_length) i = 0;
                }
            }
            else if (key_length > pt_length)
            {
                while (key_length > pt_length)
                {
                    key = key.Substring(0, pt_length);
                    key_length = pt_length;
                }
            }

            label6.Visible = true;
            VSGkey.Visible = true;

            VSGkey.Text = key;
            return key;
        }


        //c = (p + k) mod n
        public void vigenere_cipher(string Vkey, string plaintext)
        {
            int pt_length = plaintext.Length;
            int key_length = Vkey.Length;
            string symbols = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string answer = "";           

            for (int i = 0; i < pt_length; i++) {
                int sum = 0;
                for (int j = 0; j < symbols.Length; j++)
                {                    
                    if (plaintext[i] == symbols[j])
                    {
                        sum += j;
                    }
                    if (Vkey[i] == symbols[j])
                    {
                        sum += j;
                    }
                    if (sum > 32) sum -= 33;                    
                }
                answer += symbols[sum];
            }
            result_TB.Text = answer;    
        }

        public void vigenere_decode(string key, string plaintext)
        {
            int pt_length = plaintext.Length;
            int key_length = key.Length;
            string symbols = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string answer = "";

            for (int i = 0; i < pt_length; i++)
            {
                int sum = 0;
                for (int j = 0; j < symbols.Length; j++)
                {
                    if (plaintext[i] == symbols[j])
                    {
                        sum += j;
                    }
                    if (key[i] == symbols[j])
                    {
                        sum -= j;
                    }
                    if (sum < 0) sum += 33;
                    else if (sum > 32) sum -= 33;
                }
                answer += symbols[sum];
            }
            result_TB.Text = answer;
        }

        public string remove_duplicates(string key)
        {
            string alphabet = "";
            string symbols = "ABCDEFGHIKLMNOPQRSTUVWXYZ";

            char [] str_carr = key.ToCharArray();
            for (int i = 0; i < key.Length; i++)
            {
                if (str_carr[i] == 74) //J
                {
                    str_carr[i] = (char)73;
                }
            }

            key = new string(str_carr);

            int counter = 0;
            for (int i = 0; i < key.Length; i++)
            {
                for (int j = i + 1; j < key.Length; j++)
                {
                    if (key[i] == key[j])
                    {
                        key = key.Remove(j, 1);
                    }
                    if ((key[i] == symbols[8]) && counter == 0)
                    {
                        symbols = symbols.Remove(9, 1);
                        counter++;
                    }
                    else if ((key[i] == symbols[9]) && counter == 0)
                    {
                        symbols = symbols.Remove(8, 1);
                        counter++;
                    }
                }
            }

            alphabet += key;

            for (int i = 0; i < key.Length; i++)
            {
                for (int j = i + 1; j < symbols.Length; j++)
                {
                    if (symbols[j] == key[i])
                    {
                        symbols = symbols.Remove(j, 1); 
                    }

                }
            }

            alphabet += symbols;

            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = i + 1; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == alphabet[i])
                    {
                        alphabet = alphabet.Remove(j, 1);
                    }
                }
            }
            return alphabet;
        }

        public void playfair_cipher(string key, string plaintext)
        {
            int pt_length = plaintext.Length;            
            string answer = "";
            int[,] cipher_table = new int[5, 5];

            string alphabet = remove_duplicates(key);

            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    cipher_table[i, j] = alphabet[k];
                    k++;
                }
            }

            char[] str_carr = plaintext.ToCharArray();
            k = 0;
            do
            {
                if (str_carr[k] == 74) //J -> I
                {
                    str_carr[k] = (char)73;
                }
                if (str_carr[k] == str_carr[k + 1])
                {              
                    pt_length++;
                    Array.Resize(ref str_carr, pt_length);
                    for (int j = k + 1; j < pt_length - 1; j++)
                    {                        
                        str_carr[j + 1] = plaintext[j];
                    }                    
                    str_carr[k + 1] = (char)88;                    
                    k++;
                }
                k++;
            } while (k < pt_length - 1);

            plaintext = new string(str_carr);


            //xx
            if (pt_length % 2 != 0)
            {
                //k = 0;
                str_carr = plaintext.ToCharArray();
   
                pt_length++;
                Array.Resize(ref str_carr, pt_length);                
                str_carr[pt_length - 1] = (char)88;
                plaintext = new string(str_carr);
            }

            /*for (int i = 0; i < plaintext.Length; i++) {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (plaintext[i] == plaintext[i + 1] && plaintext[i] == alphabet[j])
                    {
                        answer += alphabet[j + 1];
                    }
                }
            }*/


            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            k = 0;
            do
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (plaintext[k] == cipher_table[i, j])
                        {
                            x1 = i;
                            y1 = j;
                        }

                        if (plaintext[k + 1] == cipher_table[i, j])
                        {
                            x2 = i;
                            y2 = j;
                        }

                        if (plaintext[k] == plaintext[k + 1] && plaintext[k] == cipher_table[i, j])
                        {
                            x1 = x2 = i;
                            y1 = y2 = j;
                        }

                    }
                }

                if (x1 == x2 && y1 == y2)
                {
                    answer += (char)cipher_table[x1, y1 + 1];
                    answer += (char)cipher_table[x1, y1 + 1];
                }
                else
                {

                    // Если буквы находятся в одной строке
                    if (x1 == x2)
                    {
                        if (y1 == 4)
                        {
                            answer += (char)cipher_table[x1, 0];
                            answer += (char)cipher_table[x2, y2 + 1];
                        }
                        else if (y2 == 4)
                        {
                            answer += (char)cipher_table[x1, y1 + 1];
                            answer += (char)cipher_table[x2, 0];
                        }
                        else
                        {
                            answer += (char)cipher_table[x1, y1 + 1];
                            answer += (char)cipher_table[x2, y2 + 1];
                        }
                    }

                    // Если буквы находятся в одном столбце
                    if (y1 == y2)
                    {
                        if (x1 == 4)
                        {
                            answer += (char)cipher_table[0, y1];
                            answer += (char)cipher_table[x2 + 1, y2];
                        }
                        else if (x2 == 4)
                        {
                            answer += (char)cipher_table[x1 + 1, y1];
                            answer += (char)cipher_table[0, y2];
                        }
                        else
                        {
                            answer += (char)cipher_table[x1 + 1, y1];
                            answer += (char)cipher_table[x2 + 1, y2];
                        }
                    }

                    // Если буквы находятся в разных строках и разных столбцах
                    if ((x1 != x2) && (y1 != y2))
                    {
                        answer += (char)cipher_table[x1, y2];
                        answer += (char)cipher_table[x2, y1];
                    }
                }

                k += 2; ;
            } while (k < plaintext.Length);

            result_TB.Text = answer;
        }

        public void playfair_decode(string key, string plaintext)
        {
            string answer = "";
            int[,] cipher_table = new int[5, 5];

            string alphabet = remove_duplicates(key);

            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    cipher_table[i, j] = alphabet[k];
                    k++;
                }
            }

            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;

            k = 0;
            do
            {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                        if (plaintext[k] == cipher_table[i, j])
                        {
                            x1 = i;
                            y1 = j;
                        }

                        if (plaintext[k + 1] == cipher_table[i, j])
                        {
                            x2 = i;
                            y2 = j;
                        }

                        if (plaintext[k] == plaintext[k + 1] && plaintext[k] == cipher_table[i, j])
                        {
                            x1 = x2 = i;
                            y1 = y2 = j;
                        }
                    }

                if (x1 == x2 && y1 == y2)
                {
                    answer += (char)cipher_table[x1, y1 - 1];
                    answer += (char)cipher_table[x1, y1 - 1];
                }
                else
                {
                    // Если буквы находятся в одной строке
                    if (x1 == x2)
                    {
                        if (y1 == 0)
                        {
                            answer += (char)cipher_table[x1, 4];
                            answer += (char)cipher_table[x2, y2 - 1];
                        }
                        else
                        if (y2 == 0)
                        {
                            answer += (char)cipher_table[x1, y1 - 1];
                            answer += (char)cipher_table[x2, 4];
                        }
                        else
                        {
                            answer += (char)cipher_table[x1, y1 - 1];
                            answer += (char)cipher_table[x2, y2 - 1];
                        }
                    }

                    // Если буквы находятся в одном столбце
                    if (y1 == y2)
                    {
                        if (x1 == 0)
                        {
                            answer += (char)cipher_table[4, y1];
                            answer += (char)cipher_table[x2 - 1, y2];
                        }
                        else
                        if (x2 == 0)
                        {
                            answer += (char)cipher_table[x1 - 1, y1];
                            answer += (char)cipher_table[4, y2];
                        }
                        else
                        {
                            answer += (char)cipher_table[x1 - 1, y1];
                            answer += (char)cipher_table[x2 - 1, y2];
                        }
                    }

                    // Если буквы находятся в разных строках и разных столбцах
                    if ((x1 != x2) && (y1 != y2))
                    {
                        answer += (char)cipher_table[x1, y2];
                        answer += (char)cipher_table[x2, y1];
                    }
                }

                k += 2;
            } while (k < plaintext.Length);

            result_TB.Text = answer;
        }

        private void plaintextTB_TextChanged(object sender, EventArgs e)
        {
            input_error.Visible = false;
            error_lbl.Visible = false;
            result_TB.Text = "";
        }

        private void keyTB_TextChanged(object sender, EventArgs e)
        {
            input_error.Visible = false;
            error_lbl.Visible = false;
            result_TB.Text = "";
        }

        private void encrypt_Click_1(object sender, EventArgs e)
        {
            string plaintext = plaintextTB.Text;
            string key = keyTB.Text;
            string type_of_cipher = type.SelectedItem.ToString();

            if ((plaintextTB.TextLength < 1) || (keyTB.TextLength < 1))
            {
                input_error.Visible = true;
            }
            else
            {
                switch (type_of_cipher)
                {
                    case "Columnar transposition":
                        label6.Visible = false;
                        VSGkey.Visible = false;

                        plaintext = check_string_CV(plaintext);
                        key = check_string_CV(key);
                        if ((key.Length < 1) || (plaintext.Length < 1))
                        {
                            error_lbl.Visible = true;
                            break;
                        }
                        else
                        {
                            error_lbl.Visible = false;
                            columnar_transposition_cipher(key, plaintext);
                        }
                        break;
                    case "Vigenere cipher":
                        label6.Visible = true;
                        VSGkey.Visible = true;

                        plaintext = check_string_CV(plaintext);
                        key = check_string_CV(key);                        
                        if ((key.Length < 1) || (plaintext.Length < 1))
                        {
                            error_lbl.Visible = true;
                            break;
                        }
                        else
                        {
                            error_lbl.Visible = false;
                            string Vkey = create_Vigenere_key(key, plaintext);
                            vigenere_key = Vkey;
                            vigenere_cipher(Vkey, plaintext);
                        }                        
                        break;
                    case "Playfair cipher":
                        label6.Visible = false;
                        VSGkey.Visible = false;
                        
                        plaintext = check_string_P(plaintext);
                        key = check_string_P(key);
                        if ((key.Length < 1) || (plaintext.Length < 1))
                        {
                            error_lbl.Visible = true;
                            break;
                        }
                        else
                        {
                            error_lbl.Visible = false;
                            playfair_cipher(key, plaintext);
                        }
                        break;
                }
            }
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            string plaintext = plaintextTB.Text;
            string key = keyTB.Text;
            string type_of_cipher = type.SelectedItem.ToString();            

            if ((plaintextTB.TextLength < 1) || (keyTB.TextLength < 1))
            {
                input_error.Visible = true;
            }
            else
            {
                switch (type_of_cipher)
                {
                    case "Columnar transposition":
                        label6.Visible = false;
                        VSGkey.Visible = false;

                        plaintext = check_string_CV(plaintext);
                        key = check_string_CV(key);
                        if ((key.Length < 1) || (plaintext.Length < 1))
                        {
                            error_lbl.Visible = true;
                            break;
                        }
                        else
                        {
                            error_lbl.Visible = false;
                            columnar_transposition_decode(key, plaintext); 
                        }
                        break;
                    case "Vigenere cipher":
                        label6.Visible = true;
                        VSGkey.Visible = true;
                        plaintext = check_string_CV(plaintext);
                        key = check_string_CV(key);
                        if ((key.Length < 1) || (plaintext.Length < 1))
                        {
                            error_lbl.Visible = true;
                            break;
                        }
                        else
                        {
                            error_lbl.Visible = false;
                            string Vkey = vigenere_key;//create_Vigenere_key(key, plaintext);
                            vigenere_decode(Vkey, plaintext);
                        }                        
                        break;
                    case "Playfair cipher":
                        label6.Visible = false;
                        VSGkey.Visible = false;
                        
                        plaintext = check_string_P(plaintext);
                        key = check_string_P(key);
                        if ((key.Length < 1) || (plaintext.Length < 1))
                        {
                            error_lbl.Visible = true;
                            break;
                        }
                        else
                        {
                            error_lbl.Visible = false;
                            playfair_decode(key, plaintext);
                        }
                        break;
                }
            }
        }

        private void openBTN_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string file_name = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(file_name);
            plaintextTB.Text = fileText;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, result_TB.Text);
        }
    }
}