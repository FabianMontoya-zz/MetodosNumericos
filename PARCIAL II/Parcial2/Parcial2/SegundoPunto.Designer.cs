namespace Parcial2
{
    partial class SegundoPunto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempInicial = new System.Windows.Forms.TextBox();
            this.txtConcInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridTemperatura = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTiempoInicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridConcentración = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTiempoFin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConcentración)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Concentración Inicial:";
            // 
            // txtTempInicial
            // 
            this.txtTempInicial.Location = new System.Drawing.Point(113, 6);
            this.txtTempInicial.MaxLength = 10;
            this.txtTempInicial.Name = "txtTempInicial";
            this.txtTempInicial.Size = new System.Drawing.Size(69, 20);
            this.txtTempInicial.TabIndex = 2;
            this.txtTempInicial.Text = "15";
            // 
            // txtConcInicial
            // 
            this.txtConcInicial.Location = new System.Drawing.Point(333, 6);
            this.txtConcInicial.MaxLength = 10;
            this.txtConcInicial.Name = "txtConcInicial";
            this.txtConcInicial.Size = new System.Drawing.Size(69, 20);
            this.txtConcInicial.TabIndex = 3;
            this.txtConcInicial.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "°C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "gMol/L";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(479, 7);
            this.txtH.MaxLength = 6;
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(69, 20);
            this.txtH.TabIndex = 7;
            this.txtH.Text = "0,0001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "H:";
            // 
            // dataGridTemperatura
            // 
            this.dataGridTemperatura.AllowUserToAddRows = false;
            this.dataGridTemperatura.AllowUserToDeleteRows = false;
            this.dataGridTemperatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTemperatura.Location = new System.Drawing.Point(12, 98);
            this.dataGridTemperatura.Name = "dataGridTemperatura";
            this.dataGridTemperatura.ReadOnly = true;
            this.dataGridTemperatura.Size = new System.Drawing.Size(298, 291);
            this.dataGridTemperatura.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTiempoInicio
            // 
            this.txtTiempoInicio.Location = new System.Drawing.Point(618, 23);
            this.txtTiempoInicio.MaxLength = 9;
            this.txtTiempoInicio.Name = "txtTiempoInicio";
            this.txtTiempoInicio.Size = new System.Drawing.Size(69, 20);
            this.txtTiempoInicio.TabIndex = 11;
            this.txtTiempoInicio.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Intervalo tiempo:";
            // 
            // dataGridConcentración
            // 
            this.dataGridConcentración.AllowUserToAddRows = false;
            this.dataGridConcentración.AllowUserToDeleteRows = false;
            this.dataGridConcentración.AllowUserToOrderColumns = true;
            this.dataGridConcentración.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConcentración.Location = new System.Drawing.Point(417, 98);
            this.dataGridConcentración.Name = "dataGridConcentración";
            this.dataGridConcentración.ReadOnly = true;
            this.dataGridConcentración.Size = new System.Drawing.Size(281, 291);
            this.dataGridConcentración.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Temperatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Concentración";
            // 
            // txtTiempoFin
            // 
            this.txtTiempoFin.Location = new System.Drawing.Point(618, 43);
            this.txtTiempoFin.MaxLength = 9;
            this.txtTiempoFin.Name = "txtTiempoFin";
            this.txtTiempoFin.Size = new System.Drawing.Size(69, 20);
            this.txtTiempoFin.TabIndex = 15;
            this.txtTiempoFin.Text = "1,2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(579, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Final:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Inicial:";
            // 
            // SegundoPunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 392);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTiempoFin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridConcentración);
            this.Controls.Add(this.txtTiempoInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridTemperatura);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConcInicial);
            this.Controls.Add(this.txtTempInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SegundoPunto";
            this.Text = "SegundoPunto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConcentración)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTempInicial;
        private System.Windows.Forms.TextBox txtConcInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridTemperatura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTiempoInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridConcentración;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTiempoFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}