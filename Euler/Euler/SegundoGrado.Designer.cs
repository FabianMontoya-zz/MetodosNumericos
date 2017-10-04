namespace Euler
{
    partial class SegundoGrado
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridAdelante = new System.Windows.Forms.DataGridView();
            this.dataGrid_Atras = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTx0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTy0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTRangFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTRangInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPrimeraDerivada = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdelante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Atras)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(645, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Hacia Adelante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(184, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hacia Atrás";
            // 
            // dataGridAdelante
            // 
            this.dataGridAdelante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdelante.Location = new System.Drawing.Point(485, 134);
            this.dataGridAdelante.Name = "dataGridAdelante";
            this.dataGridAdelante.Size = new System.Drawing.Size(460, 243);
            this.dataGridAdelante.TabIndex = 18;
            // 
            // dataGrid_Atras
            // 
            this.dataGrid_Atras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Atras.Location = new System.Drawing.Point(6, 133);
            this.dataGrid_Atras.Name = "dataGrid_Atras";
            this.dataGrid_Atras.Size = new System.Drawing.Size(468, 244);
            this.dataGrid_Atras.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrimeraDerivada);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXTx0);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXTy0);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXTRangFinal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXTRangInicial);
            this.groupBox1.Location = new System.Drawing.Point(287, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros cálculo";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(550, 72);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(386, 74);
            this.txtN.MaxLength = 6;
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 5;
            this.txtN.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Número Pasos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Variables:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "x0:";
            // 
            // TXTx0
            // 
            this.TXTx0.Location = new System.Drawing.Point(472, 39);
            this.TXTx0.MaxLength = 6;
            this.TXTx0.Name = "TXTx0";
            this.TXTx0.Size = new System.Drawing.Size(100, 20);
            this.TXTx0.TabIndex = 3;
            this.TXTx0.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "y0:";
            // 
            // TXTy0
            // 
            this.TXTy0.Location = new System.Drawing.Point(350, 39);
            this.TXTy0.MaxLength = 6;
            this.TXTy0.Name = "TXTy0";
            this.TXTy0.Size = new System.Drawing.Size(100, 20);
            this.TXTy0.TabIndex = 2;
            this.TXTy0.Text = "-1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Final:";
            // 
            // TXTRangFinal
            // 
            this.TXTRangFinal.Location = new System.Drawing.Point(190, 37);
            this.TXTRangFinal.MaxLength = 6;
            this.TXTRangFinal.Name = "TXTRangFinal";
            this.TXTRangFinal.Size = new System.Drawing.Size(100, 20);
            this.TXTRangFinal.TabIndex = 1;
            this.TXTRangFinal.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rangos:";
            // 
            // TXTRangInicial
            // 
            this.TXTRangInicial.Location = new System.Drawing.Point(47, 37);
            this.TXTRangInicial.MaxLength = 6;
            this.TXTRangInicial.Name = "TXTRangInicial";
            this.TXTRangInicial.Size = new System.Drawing.Size(100, 20);
            this.TXTRangInicial.TabIndex = 0;
            this.TXTRangInicial.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Función:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Euler.Properties.Resources.FuncionSegundoGradoDespejada;
            this.pictureBox2.Location = new System.Drawing.Point(72, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 55);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Euler.Properties.Resources.FuncionSegundoGrado;
            this.pictureBox1.Location = new System.Drawing.Point(47, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 55);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtPrimeraDerivada
            // 
            this.txtPrimeraDerivada.Location = new System.Drawing.Point(129, 74);
            this.txtPrimeraDerivada.MaxLength = 6;
            this.txtPrimeraDerivada.Name = "txtPrimeraDerivada";
            this.txtPrimeraDerivada.Size = new System.Drawing.Size(100, 20);
            this.txtPrimeraDerivada.TabIndex = 4;
            this.txtPrimeraDerivada.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Primera Derivada:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-1, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Despejando:";
            // 
            // SegundoGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 383);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridAdelante);
            this.Controls.Add(this.dataGrid_Atras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SegundoGrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SegundoGrado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdelante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Atras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridAdelante;
        private System.Windows.Forms.DataGridView dataGrid_Atras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTx0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTy0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTRangFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTRangInicial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPrimeraDerivada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}