namespace NPuzzleGameVPproject
{
    partial class Form1
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
            this.btn3x3 = new System.Windows.Forms.Button();
            this.btn4x4 = new System.Windows.Forms.Button();
            this.btn5x5 = new System.Windows.Forms.Button();
            this.btnPomos = new System.Windows.Forms.Button();
            this.btnIzlez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImeNaIgrac = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn3x3
            // 
            this.btn3x3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3x3.Location = new System.Drawing.Point(367, 326);
            this.btn3x3.Name = "btn3x3";
            this.btn3x3.Size = new System.Drawing.Size(102, 41);
            this.btn3x3.TabIndex = 0;
            this.btn3x3.Text = "3x3";
            this.btn3x3.UseVisualStyleBackColor = true;
            this.btn3x3.Click += new System.EventHandler(this.btn3x3_Click);
            // 
            // btn4x4
            // 
            this.btn4x4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4x4.Location = new System.Drawing.Point(367, 386);
            this.btn4x4.Name = "btn4x4";
            this.btn4x4.Size = new System.Drawing.Size(102, 41);
            this.btn4x4.TabIndex = 1;
            this.btn4x4.Text = "4x4";
            this.btn4x4.UseVisualStyleBackColor = true;
            this.btn4x4.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn5x5
            // 
            this.btn5x5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5x5.Location = new System.Drawing.Point(367, 442);
            this.btn5x5.Name = "btn5x5";
            this.btn5x5.Size = new System.Drawing.Size(102, 44);
            this.btn5x5.TabIndex = 2;
            this.btn5x5.Text = "5x5";
            this.btn5x5.UseVisualStyleBackColor = true;
            this.btn5x5.Click += new System.EventHandler(this.btn5x5_Click);
            // 
            // btnPomos
            // 
            this.btnPomos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomos.Location = new System.Drawing.Point(65, 507);
            this.btnPomos.Name = "btnPomos";
            this.btnPomos.Size = new System.Drawing.Size(90, 43);
            this.btnPomos.TabIndex = 3;
            this.btnPomos.Text = "Помош";
            this.btnPomos.UseVisualStyleBackColor = true;
            this.btnPomos.Click += new System.EventHandler(this.btnPomos_Click);
            // 
            // btnIzlez
            // 
            this.btnIzlez.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlez.Location = new System.Drawing.Point(654, 507);
            this.btnIzlez.Name = "btnIzlez";
            this.btnIzlez.Size = new System.Drawing.Size(93, 43);
            this.btnIzlez.TabIndex = 4;
            this.btnIzlez.Text = "Излез";
            this.btnIzlez.UseVisualStyleBackColor = true;
            this.btnIzlez.Click += new System.EventHandler(this.btnIzlez_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Изберете големина на сложувалка за решавање:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 52);
            this.label2.TabIndex = 6;
            this.label2.Text = "N Puzzle game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Име на играчот:";
            // 
            // txtImeNaIgrac
            // 
            this.txtImeNaIgrac.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeNaIgrac.Location = new System.Drawing.Point(358, 172);
            this.txtImeNaIgrac.Multiline = true;
            this.txtImeNaIgrac.Name = "txtImeNaIgrac";
            this.txtImeNaIgrac.Size = new System.Drawing.Size(198, 36);
            this.txtImeNaIgrac.TabIndex = 8;
            this.txtImeNaIgrac.Validating += new System.ComponentModel.CancelEventHandler(this.txtImeNaIgrac_Validating);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(604, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Внеси име";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 637);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtImeNaIgrac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzlez);
            this.Controls.Add(this.btnPomos);
            this.Controls.Add(this.btn5x5);
            this.Controls.Add(this.btn4x4);
            this.Controls.Add(this.btn3x3);
            this.Name = "Form1";
            this.Text = "N Puzzle game";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn3x3;
        private System.Windows.Forms.Button btn4x4;
        private System.Windows.Forms.Button btn5x5;
        private System.Windows.Forms.Button btnPomos;
        private System.Windows.Forms.Button btnIzlez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImeNaIgrac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

