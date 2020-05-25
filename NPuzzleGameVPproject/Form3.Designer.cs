namespace NPuzzleGameVPproject
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNovaIgra = new System.Windows.Forms.Button();
            this.btnPocetnoMeni = new System.Windows.Forms.Button();
            this.btnIzlez = new System.Windows.Forms.Button();
            this.lbNumberMoves = new System.Windows.Forms.Label();
            this.lbPreostanatoVreme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbBrojPomestuvanja = new System.Windows.Forms.ProgressBar();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "4x4 Puzzle game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Број на направени поместувања:";
            // 
            // pnl4
            // 
            this.pnl4.Controls.Add(this.button16);
            this.pnl4.Controls.Add(this.button15);
            this.pnl4.Controls.Add(this.button14);
            this.pnl4.Controls.Add(this.button13);
            this.pnl4.Controls.Add(this.button12);
            this.pnl4.Controls.Add(this.button11);
            this.pnl4.Controls.Add(this.button10);
            this.pnl4.Controls.Add(this.button9);
            this.pnl4.Controls.Add(this.button8);
            this.pnl4.Controls.Add(this.button7);
            this.pnl4.Controls.Add(this.button6);
            this.pnl4.Controls.Add(this.button5);
            this.pnl4.Controls.Add(this.button4);
            this.pnl4.Controls.Add(this.button3);
            this.pnl4.Controls.Add(this.button2);
            this.pnl4.Controls.Add(this.button1);
            this.pnl4.Location = new System.Drawing.Point(62, 112);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(383, 349);
            this.pnl4.TabIndex = 2;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(263, 229);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(68, 59);
            this.button16.TabIndex = 15;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(189, 229);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(68, 59);
            this.button15.TabIndex = 14;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(115, 229);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(68, 59);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(41, 229);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(68, 59);
            this.button13.TabIndex = 12;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(263, 164);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(68, 59);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(189, 164);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(68, 59);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(115, 164);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 59);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(41, 164);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 59);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(263, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 59);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(189, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 59);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(115, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 59);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 59);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 59);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 59);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 59);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.swapPlaces);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 59);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.swapPlaces);
            // 
            // btnNovaIgra
            // 
            this.btnNovaIgra.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaIgra.Location = new System.Drawing.Point(547, 157);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(192, 48);
            this.btnNovaIgra.TabIndex = 3;
            this.btnNovaIgra.Text = "Нова игра";
            this.btnNovaIgra.UseVisualStyleBackColor = true;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
            // 
            // btnPocetnoMeni
            // 
            this.btnPocetnoMeni.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPocetnoMeni.Location = new System.Drawing.Point(547, 223);
            this.btnPocetnoMeni.Name = "btnPocetnoMeni";
            this.btnPocetnoMeni.Size = new System.Drawing.Size(192, 46);
            this.btnPocetnoMeni.TabIndex = 4;
            this.btnPocetnoMeni.Text = "Почетно мени";
            this.btnPocetnoMeni.UseVisualStyleBackColor = true;
            this.btnPocetnoMeni.Click += new System.EventHandler(this.btnPocetnoMeni_Click);
            // 
            // btnIzlez
            // 
            this.btnIzlez.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlez.Location = new System.Drawing.Point(547, 285);
            this.btnIzlez.Name = "btnIzlez";
            this.btnIzlez.Size = new System.Drawing.Size(192, 50);
            this.btnIzlez.TabIndex = 5;
            this.btnIzlez.Text = "Излез";
            this.btnIzlez.UseVisualStyleBackColor = true;
            this.btnIzlez.Click += new System.EventHandler(this.btnIzlez_Click);
            // 
            // lbNumberMoves
            // 
            this.lbNumberMoves.AutoSize = true;
            this.lbNumberMoves.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberMoves.Location = new System.Drawing.Point(452, 557);
            this.lbNumberMoves.Name = "lbNumberMoves";
            this.lbNumberMoves.Size = new System.Drawing.Size(64, 30);
            this.lbNumberMoves.TabIndex = 6;
            this.lbNumberMoves.Text = "label3";
            // 
            // lbPreostanatoVreme
            // 
            this.lbPreostanatoVreme.AutoSize = true;
            this.lbPreostanatoVreme.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreostanatoVreme.Location = new System.Drawing.Point(452, 631);
            this.lbPreostanatoVreme.Name = "lbPreostanatoVreme";
            this.lbPreostanatoVreme.Size = new System.Drawing.Size(64, 30);
            this.lbPreostanatoVreme.TabIndex = 7;
            this.lbPreostanatoVreme.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 631);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Преостанато време:";
            // 
            // pbBrojPomestuvanja
            // 
            this.pbBrojPomestuvanja.Location = new System.Drawing.Point(62, 590);
            this.pbBrojPomestuvanja.Name = "pbBrojPomestuvanja";
            this.pbBrojPomestuvanja.Size = new System.Drawing.Size(612, 23);
            this.pbBrojPomestuvanja.TabIndex = 9;
            // 
            // pbTime
            // 
            this.pbTime.Location = new System.Drawing.Point(62, 669);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(612, 23);
            this.pbTime.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 750);
            this.Controls.Add(this.pbTime);
            this.Controls.Add(this.pbBrojPomestuvanja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbPreostanatoVreme);
            this.Controls.Add(this.lbNumberMoves);
            this.Controls.Add(this.btnIzlez);
            this.Controls.Add(this.btnPocetnoMeni);
            this.Controls.Add(this.btnNovaIgra);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "4x4 Puzzle game";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnl4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNovaIgra;
        private System.Windows.Forms.Button btnPocetnoMeni;
        private System.Windows.Forms.Button btnIzlez;
        private System.Windows.Forms.Label lbNumberMoves;
        private System.Windows.Forms.Label lbPreostanatoVreme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbBrojPomestuvanja;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.Timer timer1;
    }
}