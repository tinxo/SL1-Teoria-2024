namespace C7_20052024
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            nupPrecioUnitario = new NumericUpDown();
            nupStockMinimo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nupPrecioUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupStockMinimo).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(580, 228);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(296, 59);
            button1.TabIndex = 0;
            button1.Text = "Crear producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 1;
            label1.Text = "ID del producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 28);
            label2.TabIndex = 2;
            label2.Text = "Nombre del producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 99);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(237, 28);
            label3.TabIndex = 3;
            label3.Text = "Descripción del producto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 139);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 4;
            label4.Text = "Precio unitario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 178);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 5;
            label5.Text = "Stock mínimo:";
            // 
            // txtID
            // 
            txtID.Location = new Point(332, 10);
            txtID.Name = "txtID";
            txtID.Size = new Size(193, 34);
            txtID.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(332, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(193, 34);
            txtNombre.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(332, 96);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(193, 34);
            txtDescripcion.TabIndex = 8;
            // 
            // nupPrecioUnitario
            // 
            nupPrecioUnitario.DecimalPlaces = 2;
            nupPrecioUnitario.Location = new Point(408, 137);
            nupPrecioUnitario.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nupPrecioUnitario.Name = "nupPrecioUnitario";
            nupPrecioUnitario.Size = new Size(117, 34);
            nupPrecioUnitario.TabIndex = 9;
            // 
            // nupStockMinimo
            // 
            nupStockMinimo.Location = new Point(408, 176);
            nupStockMinimo.Name = "nupStockMinimo";
            nupStockMinimo.Size = new Size(117, 34);
            nupStockMinimo.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 630);
            Controls.Add(nupStockMinimo);
            Controls.Add(nupPrecioUnitario);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nupPrecioUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupStockMinimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private NumericUpDown nupPrecioUnitario;
        private NumericUpDown nupStockMinimo;
    }
}
