using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string d { get; private set; }
        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            char[] D = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю' , 'Я' };
            foreach (char ch in str)
            {
                if (Array.IndexOf(D, ch) >= 0)
                    textBox1.Text += (ch);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
