using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPuzzleGameVPproject
{
    public partial class Form1 : Form
    {
        public static string ime { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ime!=null)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Задолжителен внес на име на играч");
            }
        }

        private void btn3x3_Click(object sender, EventArgs e)
        {
            if (ime!=null)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Задолжителен внес на име на играч");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtImeNaIgrac.Text.Length != 0)
            {
                ime = txtImeNaIgrac.Text.ToString();
            }
            else
            {
                MessageBox.Show("Задолжителен внес на име");
            }
            
        }

        private void txtImeNaIgrac_Validating(object sender, CancelEventArgs e)
        {
            if(txtImeNaIgrac.Text.Trim().Length ==0)
            {
                errorProvider1.SetError(txtImeNaIgrac, "Задолжителен внес на име на играч");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtImeNaIgrac, null);
                e.Cancel = false;
            }
        }

        private void btnIzlez_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPomos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Целта на оваа игра е да се подредат дадените броеви редоследно. За различна големина на сложувалка, имате дадено различно максимално време за кое треба да " +
                "реши дадената сложувалка. Исто така имате и дефинирано различен број на можни поместувања што може да ги направите. Со среќа ! :)", "Упатство за игра");
        }

        private void btn5x5_Click(object sender, EventArgs e)
        {
            if(ime!=null)
            {
                Form4 f4 = new Form4();
                f4.ShowDialog();
            }
            else
            {
                MessageBox.Show("Задолжителен внес на име на играч");
            }
        }
    }
}
