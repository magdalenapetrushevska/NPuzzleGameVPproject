using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPuzzleGameVPproject
{
    public partial class Form2 : Form
    {
        private int elapsedTime;
        private int MAX_TIME = 60 * 1;
    
        public Form2()
        {
            InitializeComponent();
        }
        
        public void initialization()
        {
            elapsedTime = 0;
            pbBrojPomestuvanja.Maximum = 50;
            pbPreostanatoVreme.Maximum = MAX_TIME;
            pbBrojPomestuvanja.Value = 0;
            pbPreostanatoVreme.Value = MAX_TIME;
        }


        int numberMoves = 0, indexLabel = 0;
        private void shuffleNumbers()
        {
            initialization();

            List<int> listNumbers = new List<int>();

            Random rand = new Random();
            foreach(Button btn in this.pnl3.Controls)
            {
                while(listNumbers.Contains(indexLabel))
                {
                    indexLabel = rand.Next(9);
                }
                btn.Text = (indexLabel == 0) ? "" : indexLabel + "";
                btn.BackColor = (btn.Text == "") ? Color.White : Color.FromKnownColor(KnownColor.ControlLight);
                listNumbers.Add(indexLabel);
            }
            numberMoves = 0;
            lbBrojPomestuvanja.Text= numberMoves.ToString();

            timer1.Start();
        }

        private void swapPlaces(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Text == "")
            {
                return;
            }
            Button emptyButton = null;
            foreach(Button bt in this.pnl3.Controls)
            {
                if(bt.Text =="")
                {
                    emptyButton = bt;
                    break;
                }
            }
            if(btn.TabIndex ==(emptyButton.TabIndex -1) || btn.TabIndex ==(emptyButton.TabIndex -3) || btn.TabIndex ==(emptyButton.TabIndex +1) || btn.TabIndex ==(emptyButton.TabIndex +3))
            {
                emptyButton.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
                btn.BackColor = Color.White;
                emptyButton.Text = btn.Text;
                btn.Text = "";
                numberMoves++;
                if (numberMoves > 50)
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
            foreach(Button btn in this.pnl3.Controls)
            {
                if(btn.Text!="" && Convert.ToInt16(btn.Text)!=index)
                {
                    return;
                }
                index++;
            }

            MessageBox.Show("Браво! Успешно ја решивте сложувалката во " + numberMoves + " поместувања.");
        }


        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            shuffleNumbers();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            pbPreostanatoVreme.Value = MAX_TIME - elapsedTime;

            updateTimeRemaining();
            if(elapsedTime==MAX_TIME)
            {
                timer1.Stop();
                endGame("tim");
            }
        }

        //овој метод се повикува во случај кога времето за игра ќе истече или пак корисникот ќе направи
        //максимален број на поместувања кои му се дозволени и притоа сложувалката не е решена
        public void endGame(string reason)   
        {
            if(reason=="pom")     //ова е услов доколку е направен максимален број на поместувања
            {
                string name = Form1.ime.ToString();      //во променливата name, се чува името на играчот
                timer1.Stop();    //се стопира тајмерот

                //му се дава до знаење на корисникот дека играта е завршена и му се поставува прашање дали сака да започне нова игра
                string caption = String.Format("{0}, направивте максимум број на поместувања ({1}). Дали сакате да започнете нова игра?", name, numberMoves - 1);
                if(MessageBox.Show(caption,"Играта е завршена",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    shuffleNumbers();    //се започнува нова игра, доколку корисникот одговори ДА
                }
                else
                {
                    Application.Exit();    //апликацијата се исклучува, доколку корисникот одговори НЕ
                }
            }
            else if(reason=="tim")      //ова е услов доколку времето за игра истече
            {
                string name = Form1.ime.ToString();    //во променливата name, се чува името на играчот
                timer1.Stop();      //се стопира тајмерот, за да не јавува грешка

                //му се дава до знаење на корисникот дека играта е завршена и му се поставува прашање дали сака да започне нова игра
                string caption = String.Format("{0}, времето за игра истече. Дали сакате да започнете нова игра?", name);
                if(MessageBox.Show(caption,"Играта е завршена",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    shuffleNumbers();     //се започнува нова игра, доколку корисникот одговори ДА
                }
                else
                {
                    Application.Exit();    //апликацијата се исклучува, доколку корисникот одговори НЕ
                }
            }
        }

        public void updateTimeRemaining()
        {
            int value = pbPreostanatoVreme.Value;
            lbPreostnatoVreme.Text = String.Format("{0:00}:{1:00}", value / 60, value % 60);
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            shuffleNumbers();
        }
    }
}
