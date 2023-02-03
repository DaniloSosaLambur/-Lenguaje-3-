namespace EjerciciosLenguage
{
    partial class Ejercicio2
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
            this.Calcular = new System.Windows.Forms.Button();
            this.Numero2textBox2 = new System.Windows.Forms.TextBox();
            this.Numero1textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OperacionescomboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Resultadolabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(122, 192);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 9;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Numero2textBox2
            // 
            this.Numero2textBox2.Location = new System.Drawing.Point(173, 110);
            this.Numero2textBox2.Name = "Numero2textBox2";
            this.Numero2textBox2.Size = new System.Drawing.Size(100, 20);
            this.Numero2textBox2.TabIndex = 8;
            // 
            // Numero1textBox1
            // 
            this.Numero1textBox1.Location = new System.Drawing.Point(173, 67);
            this.Numero1textBox1.Name = "Numero1textBox1";
            this.Numero1textBox1.Size = new System.Drawing.Size(100, 20);
            this.Numero1textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero 1:";
            // 
            // OperacionescomboBox1
            // 
            this.OperacionescomboBox1.FormattingEnabled = true;
            this.OperacionescomboBox1.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.OperacionescomboBox1.Location = new System.Drawing.Point(173, 154);
            this.OperacionescomboBox1.Name = "OperacionescomboBox1";
            this.OperacionescomboBox1.Size = new System.Drawing.Size(121, 21);
            this.OperacionescomboBox1.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Resultadolabel
            // 
            this.Resultadolabel.AutoSize = true;
            this.Resultadolabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Resultadolabel.Location = new System.Drawing.Point(335, 161);
            this.Resultadolabel.Name = "Resultadolabel";
            this.Resultadolabel.Size = new System.Drawing.Size(35, 13);
            this.Resultadolabel.TabIndex = 11;
            this.Resultadolabel.Text = "label3";
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultadolabel);
            this.Controls.Add(this.OperacionescomboBox1);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Numero2textBox2);
            this.Controls.Add(this.Numero1textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox Numero2textBox2;
        private System.Windows.Forms.TextBox Numero1textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OperacionescomboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Resultadolabel;
    }
}