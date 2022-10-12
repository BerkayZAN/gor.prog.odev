using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vizefinalhesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double vize, final, ort;
        private void button1_Click(object sender, EventArgs e)
        {
            vize = Convert.ToDouble(numericUpDown1.Value);
            final = Convert.ToDouble(numericUpDown2.Value);
            ort = vize * 0.4 + final * 0.6;
            label3.Text = ort.ToString();
            
            if (final > 50) {
                if (final >= 50 && ort >= 50)
                {
                    label4.Text = "Geçtiniz";
                }
            }
            else
            {
                label4.Text = "Kaldınız";
            }
        }
    }
}
