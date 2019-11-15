namespace TP_Mat_Superior_2C
{
    partial class Form1
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblLaGrange = new System.Windows.Forms.Button();
            this.lblNGProg = new System.Windows.Forms.Button();
            this.lblNGReg = new System.Windows.Forms.Button();
            this.lblXY = new System.Windows.Forms.Label();
            this.lblPolinomio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbResul = new System.Windows.Forms.GroupBox();
            this.lblEquidistante = new System.Windows.Forms.Label();
            this.btbK = new System.Windows.Forms.Button();
            this.lblResulK = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btbAgregar = new System.Windows.Forms.Button();
            this.btbEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.grbResul.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(22, 81);
            this.txtX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(220, 20);
            this.txtX.TabIndex = 0;
            this.txtX.TextChanged += new System.EventHandler(this.TxtX_TextChanged);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(22, 160);
            this.txtY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(220, 20);
            this.txtY.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese valores X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese valores Y:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(20, 206);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(301, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Escoja el metodo con el cual obtener el polinomio interpolador!";
            // 
            // lblLaGrange
            // 
            this.lblLaGrange.Location = new System.Drawing.Point(22, 237);
            this.lblLaGrange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblLaGrange.Name = "lblLaGrange";
            this.lblLaGrange.Size = new System.Drawing.Size(104, 41);
            this.lblLaGrange.TabIndex = 5;
            this.lblLaGrange.Text = "LaGrange";
            this.lblLaGrange.UseVisualStyleBackColor = true;
            this.lblLaGrange.Click += new System.EventHandler(this.LblLaGrange_Click);
            // 
            // lblNGProg
            // 
            this.lblNGProg.Location = new System.Drawing.Point(131, 237);
            this.lblNGProg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblNGProg.Name = "lblNGProg";
            this.lblNGProg.Size = new System.Drawing.Size(104, 41);
            this.lblNGProg.TabIndex = 6;
            this.lblNGProg.Text = "Newton-Gregory Progresivo";
            this.lblNGProg.UseVisualStyleBackColor = true;
            this.lblNGProg.Click += new System.EventHandler(this.LblNGProg_Click);
            // 
            // lblNGReg
            // 
            this.lblNGReg.Location = new System.Drawing.Point(240, 237);
            this.lblNGReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblNGReg.Name = "lblNGReg";
            this.lblNGReg.Size = new System.Drawing.Size(104, 41);
            this.lblNGReg.TabIndex = 7;
            this.lblNGReg.Text = "Newton-Gregory Regresivo";
            this.lblNGReg.UseVisualStyleBackColor = true;
            this.lblNGReg.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblXY
            // 
            this.lblXY.AutoSize = true;
            this.lblXY.Location = new System.Drawing.Point(19, 27);
            this.lblXY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXY.Name = "lblXY";
            this.lblXY.Size = new System.Drawing.Size(0, 13);
            this.lblXY.TabIndex = 8;
            // 
            // lblPolinomio
            // 
            this.lblPolinomio.AutoSize = true;
            this.lblPolinomio.Location = new System.Drawing.Point(36, 341);
            this.lblPolinomio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPolinomio.Name = "lblPolinomio";
            this.lblPolinomio.Size = new System.Drawing.Size(0, 13);
            this.lblPolinomio.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Polinomio Obtenido:";
            // 
            // grbResul
            // 
            this.grbResul.Controls.Add(this.lblEquidistante);
            this.grbResul.Controls.Add(this.btbK);
            this.grbResul.Controls.Add(this.lblResulK);
            this.grbResul.Controls.Add(this.txtK);
            this.grbResul.Controls.Add(this.label5);
            this.grbResul.Controls.Add(this.label4);
            this.grbResul.Controls.Add(this.label3);
            this.grbResul.Controls.Add(this.lblPolinomio);
            this.grbResul.Controls.Add(this.lblXY);
            this.grbResul.Location = new System.Drawing.Point(379, 20);
            this.grbResul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbResul.Name = "grbResul";
            this.grbResul.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbResul.Size = new System.Drawing.Size(644, 456);
            this.grbResul.TabIndex = 11;
            this.grbResul.TabStop = false;
            this.grbResul.Text = "Resultados";
            // 
            // lblEquidistante
            // 
            this.lblEquidistante.AutoSize = true;
            this.lblEquidistante.Location = new System.Drawing.Point(304, 303);
            this.lblEquidistante.Name = "lblEquidistante";
            this.lblEquidistante.Size = new System.Drawing.Size(86, 13);
            this.lblEquidistante.TabIndex = 16;
            this.lblEquidistante.Text = "Es Equidistante?";
            this.lblEquidistante.Click += new System.EventHandler(this.LblEquidistante_Click);
            // 
            // btbK
            // 
            this.btbK.Location = new System.Drawing.Point(224, 384);
            this.btbK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btbK.Name = "btbK";
            this.btbK.Size = new System.Drawing.Size(56, 25);
            this.btbK.TabIndex = 15;
            this.btbK.Text = "Calcular";
            this.btbK.UseVisualStyleBackColor = true;
            this.btbK.Click += new System.EventHandler(this.BtbK_Click);
            // 
            // lblResulK
            // 
            this.lblResulK.AutoSize = true;
            this.lblResulK.Location = new System.Drawing.Point(26, 416);
            this.lblResulK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResulK.Name = "lblResulK";
            this.lblResulK.Size = new System.Drawing.Size(0, 13);
            this.lblResulK.TabIndex = 14;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(122, 387);
            this.txtK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(69, 20);
            this.txtK.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ingrese un valor K:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Especializar Polinomio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "FINTER";
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(25, 325);
            this.txtAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(82, 20);
            this.txtAgregar.TabIndex = 13;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(25, 371);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(82, 20);
            this.txtEliminar.TabIndex = 14;
            // 
            // btbAgregar
            // 
            this.btbAgregar.Location = new System.Drawing.Point(144, 323);
            this.btbAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btbAgregar.Name = "btbAgregar";
            this.btbAgregar.Size = new System.Drawing.Size(68, 21);
            this.btbAgregar.TabIndex = 15;
            this.btbAgregar.Text = "Agregar";
            this.btbAgregar.UseVisualStyleBackColor = true;
            this.btbAgregar.Click += new System.EventHandler(this.BtbAgregar_Click);
            // 
            // btbEliminar
            // 
            this.btbEliminar.Location = new System.Drawing.Point(144, 370);
            this.btbEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btbEliminar.Name = "btbEliminar";
            this.btbEliminar.Size = new System.Drawing.Size(66, 20);
            this.btbEliminar.TabIndex = 16;
            this.btbEliminar.Text = "Eliminar";
            this.btbEliminar.UseVisualStyleBackColor = true;
            this.btbEliminar.Click += new System.EventHandler(this.BtbEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ingrese tupla a agregar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ingrese coordenada a eliminar:";
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.Location = new System.Drawing.Point(27, 410);
            this.lblCoordenadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(0, 13);
            this.lblCoordenadas.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 572);
            this.Controls.Add(this.lblCoordenadas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btbEliminar);
            this.Controls.Add(this.btbAgregar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grbResul);
            this.Controls.Add(this.lblNGReg);
            this.Controls.Add(this.lblNGProg);
            this.Controls.Add(this.lblLaGrange);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "FINTER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbResul.ResumeLayout(false);
            this.grbResul.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button lblLaGrange;
        private System.Windows.Forms.Button lblNGProg;
        private System.Windows.Forms.Button lblNGReg;
        private System.Windows.Forms.Label lblXY;
        private System.Windows.Forms.Label lblPolinomio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbResul;
        private System.Windows.Forms.Label lblResulK;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btbK;
        private System.Windows.Forms.Label lblEquidistante;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btbAgregar;
        private System.Windows.Forms.Button btbEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCoordenadas;
    }
}

