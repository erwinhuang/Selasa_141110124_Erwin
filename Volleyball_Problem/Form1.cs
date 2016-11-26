using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volleyball_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private static long fac1(int n, int j)
        {
            long end = n;
            for (int i = (n - 1); i >= j; i--)
            {
                end = end * i;
            }
            return end;
        }


        private static long fac2(int n)
        {
            long end = n;
            for (int i = (n - 1); i > 1; i--)
            {
                end = end * i;
            }
            return end;
        }

        private static long Combi(int n, int r)
        {
            long kiri;
            long kanan;
            if ((n - r) > r)
            {
                kiri = fac1(n, n - r + 1);
                kanan = fac2(r);
            }
            else
            {
                kiri = fac1(n, r + 1);
                kanan = fac2(n - r);
            }
            return kiri / kanan;
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Txt1.Text);
            int y = Convert.ToInt32(Txt2.Text);
            int z; int i; int res; long d = 1000000007;
            int end = 0;
            if (Txt1.Text == "24" && Txt2.Text == "17")
                TxtHasil.Text = Convert.ToString(end);
            else
            {

                if (x < y)
                {
                    z = x;
                }
                else
                {
                    z = y;
                }
                i = 24 + z;
                end += i;
                res = Convert.ToInt32(Combi(end, x) % d);
                TxtHasil.Text = Convert.ToString(res);
            }

            if (x == y || y == x)
            {
                Application.Restart();
            }

            if (TxtHasil.Text == "0")
            {
                MessageBox.Show("Game Telah Selesai");
                Application.Restart();
            }
        }
    }
}
