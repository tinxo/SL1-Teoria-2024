namespace C3_230424_V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombreApellido = new TextBox();
            txtDocumento = new TextBox();
            nupAnioIngreso = new NumericUpDown();
            nupMateriasAprobadas = new NumericUpDown();
            nupPromedio = new NumericUpDown();
            btnProcesar = new Button();
            label7 = new Label();
            lblResultados = new Label();
            ((System.ComponentModel.ISupportInitialize)nupAnioIngreso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupMateriasAprobadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPromedio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(302, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los datos de una persona:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 1;
            label2.Text = "Nombre y apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(187, 28);
            label3.TabIndex = 2;
            label3.Text = "Nro. de documento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 188);
            label4.Name = "label4";
            label4.Size = new Size(299, 28);
            label4.TabIndex = 4;
            label4.Text = "Cantidad de materias aprobadas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 149);
            label5.Name = "label5";
            label5.Size = new Size(249, 28);
            label5.TabIndex = 3;
            label5.Text = "Año de ingreso a la carrera:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 228);
            label6.Name = "label6";
            label6.Size = new Size(202, 28);
            label6.TabIndex = 5;
            label6.Text = "Promedio sin aplazos:";
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(317, 66);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(265, 34);
            txtNombreApellido.TabIndex = 6;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(317, 105);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(265, 34);
            txtDocumento.TabIndex = 7;
            // 
            // nupAnioIngreso
            // 
            nupAnioIngreso.Location = new Point(432, 147);
            nupAnioIngreso.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            nupAnioIngreso.Minimum = new decimal(new int[] { 1994, 0, 0, 0 });
            nupAnioIngreso.Name = "nupAnioIngreso";
            nupAnioIngreso.Size = new Size(150, 34);
            nupAnioIngreso.TabIndex = 8;
            nupAnioIngreso.Value = new decimal(new int[] { 1994, 0, 0, 0 });
            // 
            // nupMateriasAprobadas
            // 
            nupMateriasAprobadas.Location = new Point(432, 186);
            nupMateriasAprobadas.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            nupMateriasAprobadas.Name = "nupMateriasAprobadas";
            nupMateriasAprobadas.Size = new Size(150, 34);
            nupMateriasAprobadas.TabIndex = 9;
            // 
            // nupPromedio
            // 
            nupPromedio.DecimalPlaces = 2;
            nupPromedio.Location = new Point(432, 226);
            nupPromedio.Name = "nupPromedio";
            nupPromedio.Size = new Size(150, 34);
            nupPromedio.TabIndex = 10;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(404, 282);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(178, 56);
            btnProcesar.TabIndex = 11;
            btnProcesar.Text = "Procesar datos";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 373);
            label7.Name = "label7";
            label7.Size = new Size(102, 28);
            label7.TabIndex = 12;
            label7.Text = "Resultado:";
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(12, 401);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(28, 28);
            lblResultados.TabIndex = 13;
            lblResultados.Text = "....";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 630);
            Controls.Add(lblResultados);
            Controls.Add(label7);
            Controls.Add(btnProcesar);
            Controls.Add(nupPromedio);
            Controls.Add(nupMateriasAprobadas);
            Controls.Add(nupAnioIngreso);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombreApellido);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Procesamiento de datos de estudiantes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nupAnioIngreso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupMateriasAprobadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPromedio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombreApellido;
        private TextBox txtDocumento;
        private NumericUpDown nupAnioIngreso;
        private NumericUpDown nupMateriasAprobadas;
        private NumericUpDown nupPromedio;
        private Button btnProcesar;
        private Label label7;
        private Label lblResultados;
    }
}
