using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tanggal, bulan;

        private void button2_Click(object sender, EventArgs e)
        {
            tanggal = domainUpDown1.SelectedIndex + 1;
            bulan = domainUpDown2.SelectedIndex + 1;
            DateTime terpilih = new DateTime(2016, bulan, tanggal);
            monthCalendar1.RemoveAnnuallyBoldedDate(terpilih);
            monthCalendar1.UpdateBoldedDates();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime ultah = new DateTime(1996, 11, 28);
            DateTime sabming = new DateTime(2016, 1, 1);
            while (sabming.Year == 2016)
            {
                if (sabming.DayOfWeek == DayOfWeek.Saturday || sabming.DayOfWeek == DayOfWeek.Sunday)
                    monthCalendar1.AddBoldedDate(sabming);
                sabming = sabming.AddDays(1);
            }
            monthCalendar1.AddAnnuallyBoldedDate(ultah);
            monthCalendar1.UpdateBoldedDates();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tanggal = domainUpDown1.SelectedIndex + 1;
            bulan = domainUpDown2.SelectedIndex + 1;
            DateTime terpilih = new DateTime(2016, bulan, tanggal);
            monthCalendar1.AddAnnuallyBoldedDate(terpilih);
            monthCalendar1.UpdateBoldedDates();
        }

        
    }
}
