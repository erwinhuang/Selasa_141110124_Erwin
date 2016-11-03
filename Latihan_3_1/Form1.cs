using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name);
            }
            comboBox2.Items.Add("8");
            comboBox2.Items.Add("9");
            comboBox2.Items.Add("10");
            comboBox2.Items.Add("10.5");
            comboBox2.Items.Add("11");
            comboBox2.Items.Add("12");
            comboBox2.Items.Add("14");
            comboBox2.Items.Add("16");
            comboBox2.Items.Add("18");
            comboBox2.Items.Add("20");
            comboBox2.Items.Add("24");
            comboBox2.Items.Add("28");
            comboBox2.Items.Add("32");
            comboBox2.Items.Add("36");
            comboBox2.Items.Add("40");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(comboBox1.SelectedItem.ToString(), richTextBox1.SelectionFont.SizeInPoints);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, Convert.ToInt32(comboBox2.SelectedItem), richTextBox1.Font.Style);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }

            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;

            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }

            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;

            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }

            FontStyle style = richTextBox1.SelectionFont.Style;

            if (richTextBox1.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult warna = colorDialog1.ShowDialog();

            if (warna == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
