namespace MonteCarlo
{
    partial class Montecarlo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rVarias = new System.Windows.Forms.RadioButton();
            this.rUnica = new System.Windows.Forms.RadioButton();
            this.PVariasPruebas = new System.Windows.Forms.Panel();
            this.txtPruebas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtTotalPuntos = new System.Windows.Forms.TextBox();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.txtVarianza = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.dataCalculosMontecarlo = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.P_ResultUnico = new System.Windows.Forms.GroupBox();
            this.P_ResultVarios = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDesviaciónEstandar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PVariasPruebas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCalculosMontecarlo)).BeginInit();
            this.P_ResultUnico.SuspendLayout();
            this.P_ResultVarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = global::MonteCarlo.Properties.Resources.Ecuacion;
            this.pictureBox1.Location = new System.Drawing.Point(4, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "Ecuación a Calcular");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.rVarias);
            this.groupBox1.Controls.Add(this.rUnica);
            this.groupBox1.Controls.Add(this.PVariasPruebas);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(240, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Región de Variables";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Location = new System.Drawing.Point(490, 35);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(133, 33);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.toolTip.SetToolTip(this.btnCalcular, "Iniciar el Cálculo de la ecuación");
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rVarias
            // 
            this.rVarias.AutoSize = true;
            this.rVarias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rVarias.Location = new System.Drawing.Point(301, 43);
            this.rVarias.Name = "rVarias";
            this.rVarias.Size = new System.Drawing.Size(96, 17);
            this.rVarias.TabIndex = 12;
            this.rVarias.Text = "Varias Pruebas";
            this.rVarias.UseVisualStyleBackColor = true;
            this.rVarias.CheckedChanged += new System.EventHandler(this.rVarias_CheckedChanged);
            // 
            // rUnica
            // 
            this.rUnica.AutoSize = true;
            this.rUnica.Checked = true;
            this.rUnica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rUnica.Location = new System.Drawing.Point(301, 19);
            this.rUnica.Name = "rUnica";
            this.rUnica.Size = new System.Drawing.Size(104, 17);
            this.rUnica.TabIndex = 11;
            this.rUnica.TabStop = true;
            this.rUnica.Text = "Único Resultado";
            this.rUnica.UseVisualStyleBackColor = true;
            this.rUnica.CheckedChanged += new System.EventHandler(this.rUnica_CheckedChanged);
            // 
            // PVariasPruebas
            // 
            this.PVariasPruebas.Controls.Add(this.txtPruebas);
            this.PVariasPruebas.Controls.Add(this.label6);
            this.PVariasPruebas.Location = new System.Drawing.Point(246, 63);
            this.PVariasPruebas.Name = "PVariasPruebas";
            this.PVariasPruebas.Size = new System.Drawing.Size(241, 33);
            this.PVariasPruebas.TabIndex = 10;
            this.PVariasPruebas.Visible = false;
            // 
            // txtPruebas
            // 
            this.txtPruebas.Location = new System.Drawing.Point(104, 9);
            this.txtPruebas.Name = "txtPruebas";
            this.txtPruebas.Size = new System.Drawing.Size(100, 20);
            this.txtPruebas.TabIndex = 11;
            this.txtPruebas.Text = "10";
            this.toolTip.SetToolTip(this.txtPruebas, "Número de veces que se repetirá el cálculo");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Número Pruebas:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(127, 72);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 9;
            this.txtN.Text = "1000";
            this.toolTip.SetToolTip(this.txtN, "Cantidad de Pasos");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número Pasos:";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(184, 42);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(100, 20);
            this.txtD.TabIndex = 7;
            this.txtD.Text = "4";
            this.toolTip.SetToolTip(this.txtD, "Valor para D");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "d:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(184, 16);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 5;
            this.txtC.Text = "-5";
            this.toolTip.SetToolTip(this.txtC, "Valor para C");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "c:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(39, 42);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 3;
            this.txtB.Text = "10";
            this.toolTip.SetToolTip(this.txtB, "Valor para B");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "b:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(39, 16);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            this.txtA.TabStop = false;
            this.txtA.Text = "4";
            this.toolTip.SetToolTip(this.txtA, "Valor para A");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a:";
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 200;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 200;
            this.toolTip.ReshowDelay = 40;
            // 
            // txtTotalPuntos
            // 
            this.txtTotalPuntos.Location = new System.Drawing.Point(100, 30);
            this.txtTotalPuntos.Name = "txtTotalPuntos";
            this.txtTotalPuntos.ReadOnly = true;
            this.txtTotalPuntos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPuntos.TabIndex = 11;
            this.toolTip.SetToolTip(this.txtTotalPuntos, "Número de puntos dentro de la integral");
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(100, 57);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.ReadOnly = true;
            this.txtVolumen.Size = new System.Drawing.Size(100, 20);
            this.txtVolumen.TabIndex = 18;
            this.toolTip.SetToolTip(this.txtVolumen, "Volumén Obtenido");
            // 
            // txtVarianza
            // 
            this.txtVarianza.Location = new System.Drawing.Point(69, 60);
            this.txtVarianza.Name = "txtVarianza";
            this.txtVarianza.ReadOnly = true;
            this.txtVarianza.Size = new System.Drawing.Size(100, 20);
            this.txtVarianza.TabIndex = 18;
            this.toolTip.SetToolTip(this.txtVarianza, "Varianza del resultado");
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(69, 33);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtPromedio.TabIndex = 11;
            this.toolTip.SetToolTip(this.txtPromedio, "Promedio de Resultados");
            // 
            // dataCalculosMontecarlo
            // 
            this.dataCalculosMontecarlo.AllowUserToAddRows = false;
            this.dataCalculosMontecarlo.AllowUserToDeleteRows = false;
            this.dataCalculosMontecarlo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCalculosMontecarlo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCalculosMontecarlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCalculosMontecarlo.Location = new System.Drawing.Point(4, 132);
            this.dataCalculosMontecarlo.Name = "dataCalculosMontecarlo";
            this.dataCalculosMontecarlo.ReadOnly = true;
            this.dataCalculosMontecarlo.Size = new System.Drawing.Size(656, 318);
            this.dataCalculosMontecarlo.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Resultados:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Número Puntos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Volumen:";
            // 
            // P_ResultUnico
            // 
            this.P_ResultUnico.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.P_ResultUnico.Controls.Add(this.txtVolumen);
            this.P_ResultUnico.Controls.Add(this.label9);
            this.P_ResultUnico.Controls.Add(this.label8);
            this.P_ResultUnico.Controls.Add(this.txtTotalPuntos);
            this.P_ResultUnico.Location = new System.Drawing.Point(666, 143);
            this.P_ResultUnico.Name = "P_ResultUnico";
            this.P_ResultUnico.Size = new System.Drawing.Size(237, 100);
            this.P_ResultUnico.TabIndex = 20;
            this.P_ResultUnico.TabStop = false;
            this.P_ResultUnico.Text = "Resultados";
            // 
            // P_ResultVarios
            // 
            this.P_ResultVarios.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.P_ResultVarios.Controls.Add(this.txtDesviaciónEstandar);
            this.P_ResultVarios.Controls.Add(this.label12);
            this.P_ResultVarios.Controls.Add(this.txtVarianza);
            this.P_ResultVarios.Controls.Add(this.label10);
            this.P_ResultVarios.Controls.Add(this.label11);
            this.P_ResultVarios.Controls.Add(this.txtPromedio);
            this.P_ResultVarios.Location = new System.Drawing.Point(666, 249);
            this.P_ResultVarios.Name = "P_ResultVarios";
            this.P_ResultVarios.Size = new System.Drawing.Size(184, 117);
            this.P_ResultVarios.TabIndex = 21;
            this.P_ResultVarios.TabStop = false;
            this.P_ResultVarios.Text = "Resultados";
            this.P_ResultVarios.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Varianza:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Promedio:";
            // 
            // txtDesviaciónEstandar
            // 
            this.txtDesviaciónEstandar.Location = new System.Drawing.Point(69, 89);
            this.txtDesviaciónEstandar.Name = "txtDesviaciónEstandar";
            this.txtDesviaciónEstandar.ReadOnly = true;
            this.txtDesviaciónEstandar.Size = new System.Drawing.Size(100, 20);
            this.txtDesviaciónEstandar.TabIndex = 20;
            this.toolTip.SetToolTip(this.txtDesviaciónEstandar, "Desviación Estándar");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "D.E. :";
            // 
            // Montecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(915, 462);
            this.Controls.Add(this.P_ResultVarios);
            this.Controls.Add(this.P_ResultUnico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataCalculosMontecarlo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Montecarlo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Montecarlo Ecuación Taller";
            this.Load += new System.EventHandler(this.Montecarlo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PVariasPruebas.ResumeLayout(false);
            this.PVariasPruebas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCalculosMontecarlo)).EndInit();
            this.P_ResultUnico.ResumeLayout(false);
            this.P_ResultUnico.PerformLayout();
            this.P_ResultVarios.ResumeLayout(false);
            this.P_ResultVarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PVariasPruebas;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rVarias;
        private System.Windows.Forms.RadioButton rUnica;
        private System.Windows.Forms.TextBox txtPruebas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dataCalculosMontecarlo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalPuntos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox P_ResultUnico;
        private System.Windows.Forms.GroupBox P_ResultVarios;
        private System.Windows.Forms.TextBox txtVarianza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtDesviaciónEstandar;
        private System.Windows.Forms.Label label12;
    }
}

