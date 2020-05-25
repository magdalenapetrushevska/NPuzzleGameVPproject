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
    public partial class Form4 : Form
    {
        private int elapsedTime;
        private int MAX_TIME = 60 * 5;

        public Form4()
        {
            InitializeComponent();
        }

        public void initialization()
        {
            elapsedTime = 0;
            pbBrojPomestuvanja.Maximum = 150;
            pbTime.Maximum = MAX_TIME;
            pbBrojPomestuvanja.Value = 0;
            pbTime.Value = MAX_TIME;
        }

        int numberMoves = 0, indexLabel = 0;
        private void shuffleNumbers()
        {
            initialization();

            List<int> listNumbers = new List<int>();

            Random rand = new Random();
            foreach(Button btn in this.pnl5.Controls)
            {
                while(listNumbers.Contains(indexLabel))
                {
                    indexLabel = rand.Next(25);
                }
                btn.Text = (indexLabel == 0) ? "" : indexLabel + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                listNumbers.Add(indexLabel);
            }
            numberMoves = 0;
            lbBrojPomestuvanja.Text = numberMoves.ToString();

            timer1.Start();

        }

        private void swapPlaces(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Text=="")
            {
                return;
            }
            Button emptyButton = null;
            foreach(Button bt in this.pnl5.Controls)
            {
                if(bt.Text=="")
                {
                    emptyButton = bt;
                    break;
                }
            }
            if(btn.TabIndex==(emptyButton.TabIndex -1) || btn.TabIndex ==(emptyButton.TabIndex -5) || btn.TabIndex==(emptyButton.TabIndex +1) || btn.TabIndex==(emptyButton.TabIndex +5))
            {
                emptyButton.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                btn.BackColor = Color.White;
                emptyButton.Text = btn.Text;
                btn.Text = "";
                numberMoves++;
                if(numberMoves > 150)
                {
                    endGame("pom");
                }
                else
                {
                    pbBrojPomestuvanja.Value = numberMoves;
                    lbBrojPomestuvanja.Text = numberMoves.ToString();
                }
            }

            checkOrder();

        }

        private void checkOrder()
        {
            int index = 0;
            foreach(Button btn in this.pnl5.Controls)
            {
                if(btn.Text!="" && Convert.ToInt16(btn.Text)!=index)
                {
                    return;
                }
                index++;
            }
            MessageBox.Show("Браво! Успешно ја завршивте сложувалката во " + numberMoves + " поместувања.");
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            shuffleNumbers();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Close();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            pbTime.Value = MAX_TIME - elapsedTime;

            updateTimeRemaining();
            if(elapsedTime==MAX_TIME)
            {
                timer1.Stop();
                endGame("tim");
            }
        }

        public void endGame(string reason)
        {
            if(reason=="pom")
            {
                string name = Form1.ime.ToString();
                timer1.Stop();
                string caption = String.Format("{0}, направивте максимум број на поместувања ({1}). Дали сакате да започенете нова игра?", name, numberMoves - 1);
                if(MessageBox.Show(caption,"Играта е завршена",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    shuffleNumbers();
                }
                else
                {
                    Application.Exit();
                }
            }
            else if(reason=="tim")
            {
                string name = Form1.ime.ToString();
                timer1.Stop();
                string caption = String.Format("{0}, времето за игра истече. Дали сакате да започнете нова игра?", name);
                if(MessageBox.Show(caption,"Играта е завршена",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    shuffleNumbers();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        public void updateTimeRemaining()
        {
            int value = pbTime.Value;
            lbTime.Text = String.Format("{0:00}:{1:00}", value / 60, value % 60);
        }




        private void Form4_Load(object sender, EventArgs e)
        {
            shuffleNumbers();
        }
    }
}
