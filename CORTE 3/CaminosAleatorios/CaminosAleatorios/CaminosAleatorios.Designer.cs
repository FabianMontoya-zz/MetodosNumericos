namespace CaminosAleatorios
{
    partial class CaminosAleatorios
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
            this.txtExperimentos = new System.Windows.Forms.TextBox();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.dataGridDatos = new System.Windows.Forms.DataGridView();
            this.btnDowload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExperimentos
            // 
            this.txtExperimentos.Location = new System.Drawing.Point(131, 25);
            this.txtExperimentos.Name = "txtExperimentos";
            this.txtExperimentos.Size = new System.Drawing.Size(100, 20);
            this.txtExperimentos.TabIndex = 0;
            this.txtExperimentos.Text = "5";
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(360, 25);
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.Size = new System.Drawing.Size(100, 20);
            this.txtPasos.TabIndex = 1;
            this.txtPasos.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número Experimentos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número Pasos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "por experimento:";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjecutar.Location = new System.Drawing.Point(529, 23);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(139, 23);
            this.btnEjecutar.TabIndex = 5;
            this.btnEjecutar.Text = "Ejecutar Experimentos";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // dataGridDatos
            // 
            this.dataGridDatos.AllowUserToAddRows = false;
            this.dataGridDatos.AllowUserToDeleteRows = false;
            this.dataGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDatos.Location = new System.Drawing.Point(12, 70);
            this.dataGridDatos.Name = "dataGridDatos";
            this.dataGridDatos.ReadOnly = true;
            this.dataGridDatos.Size = new System.Drawing.Size(517, 260);
            this.dataGridDatos.TabIndex = 6;
            // 
            // btnDowload
            // 
            this.btnDowload.Location = new System.Drawing.Point(568, 164);
            this.btnDowload.Name = "btnDowload";
            this.btnDowload.Size = new System.Drawing.Size(144, 34);
            this.btnDowload.TabIndex = 7;
            this.btnDowload.Text = "Descargar Datos";
            this.btnDowload.UseVisualStyleBackColor = true;
            this.btnDowload.Click += new System.EventHandler(this.btnDowload_Click);
            // 
            // CaminosAleatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 342);
            this.Controls.Add(this.btnDowload);
            this.Controls.Add(this.dataGridDatos);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.txtExperimentos);
            this.Controls.Add(this.label3);
            this.Name = "CaminosAleatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caminos Aleatorios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExperimentos;
        private System.Windows.Forms.TextBox txtPasos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DataGridView dataGridDatos;
        private System.Windows.Forms.Button btnDowload;
    }
}

