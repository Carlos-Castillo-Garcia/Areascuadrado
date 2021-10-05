
namespace Areascuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calcular1 = new System.Windows.Forms.Button();
            this.volumencubo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.areacuadrado = new System.Windows.Forms.RadioButton();
            this.volumenesfera = new System.Windows.Forms.RadioButton();
            this.areacirculo = new System.Windows.Forms.RadioButton();
            this.volumentetra = new System.Windows.Forms.RadioButton();
            this.areatriangulo = new System.Windows.Forms.RadioButton();
            this.calcular2 = new System.Windows.Forms.Button();
            this.calcular3 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lado1 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultadovolumencubo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.base1 = new System.Windows.Forms.TextBox();
            this.resultadoareacuadrado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radio2 = new System.Windows.Forms.TextBox();
            this.resultadovolumenesfera = new System.Windows.Forms.Label();
            this.resultadoareacirculo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.arista = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.alturatriangulo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.basetriangulo = new System.Windows.Forms.TextBox();
            this.resultadoareatriangulo = new System.Windows.Forms.Label();
            this.resultadovolumentetraedro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // calcular1
            // 
            this.calcular1.Location = new System.Drawing.Point(232, 523);
            this.calcular1.Name = "calcular1";
            this.calcular1.Size = new System.Drawing.Size(75, 23);
            this.calcular1.TabIndex = 1;
            this.calcular1.Text = "Calcular";
            this.calcular1.UseVisualStyleBackColor = true;
            this.calcular1.Click += new System.EventHandler(this.calcular1_Click);
            // 
            // volumencubo
            // 
            this.volumencubo.AutoSize = true;
            this.volumencubo.Location = new System.Drawing.Point(113, 275);
            this.volumencubo.Name = "volumencubo";
            this.volumencubo.Size = new System.Drawing.Size(66, 17);
            this.volumencubo.TabIndex = 2;
            this.volumencubo.TabStop = true;
            this.volumencubo.Text = "Volumen";
            this.volumencubo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "CALCULADORA DE AREAS Y VOLUMENES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(590, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(309, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1225, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(236, 190);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // areacuadrado
            // 
            this.areacuadrado.AutoSize = true;
            this.areacuadrado.Location = new System.Drawing.Point(370, 275);
            this.areacuadrado.Name = "areacuadrado";
            this.areacuadrado.Size = new System.Drawing.Size(47, 17);
            this.areacuadrado.TabIndex = 7;
            this.areacuadrado.TabStop = true;
            this.areacuadrado.Text = "Area";
            this.areacuadrado.UseVisualStyleBackColor = true;
            // 
            // volumenesfera
            // 
            this.volumenesfera.AutoSize = true;
            this.volumenesfera.Location = new System.Drawing.Point(803, 275);
            this.volumenesfera.Name = "volumenesfera";
            this.volumenesfera.Size = new System.Drawing.Size(66, 17);
            this.volumenesfera.TabIndex = 8;
            this.volumenesfera.TabStop = true;
            this.volumenesfera.Text = "Volumen";
            this.volumenesfera.UseVisualStyleBackColor = true;
            // 
            // areacirculo
            // 
            this.areacirculo.AutoSize = true;
            this.areacirculo.Location = new System.Drawing.Point(624, 275);
            this.areacirculo.Name = "areacirculo";
            this.areacirculo.Size = new System.Drawing.Size(47, 17);
            this.areacirculo.TabIndex = 9;
            this.areacirculo.TabStop = true;
            this.areacirculo.Text = "Area";
            this.areacirculo.UseVisualStyleBackColor = true;
            // 
            // volumentetra
            // 
            this.volumentetra.AutoSize = true;
            this.volumentetra.Location = new System.Drawing.Point(1031, 275);
            this.volumentetra.Name = "volumentetra";
            this.volumentetra.Size = new System.Drawing.Size(66, 17);
            this.volumentetra.TabIndex = 10;
            this.volumentetra.TabStop = true;
            this.volumentetra.Text = "Volumen";
            this.volumentetra.UseVisualStyleBackColor = true;
            // 
            // areatriangulo
            // 
            this.areatriangulo.AutoSize = true;
            this.areatriangulo.Location = new System.Drawing.Point(1313, 275);
            this.areatriangulo.Name = "areatriangulo";
            this.areatriangulo.Size = new System.Drawing.Size(47, 17);
            this.areatriangulo.TabIndex = 11;
            this.areatriangulo.TabStop = true;
            this.areatriangulo.Text = "Area";
            this.areatriangulo.UseVisualStyleBackColor = true;
            // 
            // calcular2
            // 
            this.calcular2.Location = new System.Drawing.Point(713, 523);
            this.calcular2.Name = "calcular2";
            this.calcular2.Size = new System.Drawing.Size(75, 23);
            this.calcular2.TabIndex = 12;
            this.calcular2.Text = "Calcular";
            this.calcular2.UseVisualStyleBackColor = true;
            this.calcular2.Click += new System.EventHandler(this.calcular2_Click);
            // 
            // calcular3
            // 
            this.calcular3.Location = new System.Drawing.Point(1170, 523);
            this.calcular3.Name = "calcular3";
            this.calcular3.Size = new System.Drawing.Size(75, 23);
            this.calcular3.TabIndex = 13;
            this.calcular3.Text = "Calcular";
            this.calcular3.UseVisualStyleBackColor = true;
            this.calcular3.Click += new System.EventHandler(this.calcular3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(283, 65);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(234, 190);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // lado1
            // 
            this.lado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lado1.Location = new System.Drawing.Point(113, 353);
            this.lado1.Name = "lado1";
            this.lado1.Size = new System.Drawing.Size(100, 26);
            this.lado1.TabIndex = 15;
            this.lado1.TextChanged += new System.EventHandler(this.lado1_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(970, 65);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(228, 190);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Arista";
            // 
            // resultadovolumencubo
            // 
            this.resultadovolumencubo.AutoSize = true;
            this.resultadovolumencubo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadovolumencubo.Location = new System.Drawing.Point(74, 460);
            this.resultadovolumencubo.Name = "resultadovolumencubo";
            this.resultadovolumencubo.Size = new System.Drawing.Size(110, 26);
            this.resultadovolumencubo.TabIndex = 22;
            this.resultadovolumencubo.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Altura";
            // 
            // altura
            // 
            this.altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.Location = new System.Drawing.Point(370, 368);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(100, 26);
            this.altura.TabIndex = 25;
            this.altura.TextChanged += new System.EventHandler(this.altura_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Base";
            // 
            // base1
            // 
            this.base1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.base1.Location = new System.Drawing.Point(370, 336);
            this.base1.Name = "base1";
            this.base1.Size = new System.Drawing.Size(100, 26);
            this.base1.TabIndex = 23;
            this.base1.TextChanged += new System.EventHandler(this.base1_TextChanged);
            // 
            // resultadoareacuadrado
            // 
            this.resultadoareacuadrado.AutoSize = true;
            this.resultadoareacuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoareacuadrado.Location = new System.Drawing.Point(338, 460);
            this.resultadoareacuadrado.Name = "resultadoareacuadrado";
            this.resultadoareacuadrado.Size = new System.Drawing.Size(110, 26);
            this.resultadoareacuadrado.TabIndex = 27;
            this.resultadoareacuadrado.Text = "Resultado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Radio";
            // 
            // radio1
            // 
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.Location = new System.Drawing.Point(624, 353);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(100, 26);
            this.radio1.TabIndex = 28;
            this.radio1.TextChanged += new System.EventHandler(this.radio1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(773, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Radio";
            // 
            // radio2
            // 
            this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2.Location = new System.Drawing.Point(831, 350);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(100, 26);
            this.radio2.TabIndex = 30;
            this.radio2.TextChanged += new System.EventHandler(this.radio2_TextChanged);
            // 
            // resultadovolumenesfera
            // 
            this.resultadovolumenesfera.AutoSize = true;
            this.resultadovolumenesfera.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadovolumenesfera.Location = new System.Drawing.Point(759, 460);
            this.resultadovolumenesfera.Name = "resultadovolumenesfera";
            this.resultadovolumenesfera.Size = new System.Drawing.Size(110, 26);
            this.resultadovolumenesfera.TabIndex = 33;
            this.resultadovolumenesfera.Text = "Resultado";
            // 
            // resultadoareacirculo
            // 
            this.resultadoareacirculo.AutoSize = true;
            this.resultadoareacirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoareacirculo.Location = new System.Drawing.Point(565, 460);
            this.resultadoareacirculo.Name = "resultadoareacirculo";
            this.resultadoareacirculo.Size = new System.Drawing.Size(110, 26);
            this.resultadoareacirculo.TabIndex = 32;
            this.resultadoareacirculo.Text = "Resultado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1007, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Arista";
            // 
            // arista
            // 
            this.arista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arista.Location = new System.Drawing.Point(1065, 350);
            this.arista.Name = "arista";
            this.arista.Size = new System.Drawing.Size(100, 26);
            this.arista.TabIndex = 34;
            this.arista.TextChanged += new System.EventHandler(this.arista_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1259, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Altura";
            // 
            // alturatriangulo
            // 
            this.alturatriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturatriangulo.Location = new System.Drawing.Point(1317, 362);
            this.alturatriangulo.Name = "alturatriangulo";
            this.alturatriangulo.Size = new System.Drawing.Size(100, 26);
            this.alturatriangulo.TabIndex = 40;
            this.alturatriangulo.TextChanged += new System.EventHandler(this.alturatriangulo_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1259, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Base";
            // 
            // basetriangulo
            // 
            this.basetriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basetriangulo.Location = new System.Drawing.Point(1317, 330);
            this.basetriangulo.Name = "basetriangulo";
            this.basetriangulo.Size = new System.Drawing.Size(100, 26);
            this.basetriangulo.TabIndex = 38;
            this.basetriangulo.TextChanged += new System.EventHandler(this.basetriangulo_TextChanged);
            // 
            // resultadoareatriangulo
            // 
            this.resultadoareatriangulo.AutoSize = true;
            this.resultadoareatriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoareatriangulo.Location = new System.Drawing.Point(1295, 460);
            this.resultadoareatriangulo.Name = "resultadoareatriangulo";
            this.resultadoareatriangulo.Size = new System.Drawing.Size(110, 26);
            this.resultadoareatriangulo.TabIndex = 43;
            this.resultadoareatriangulo.Text = "Resultado";
            // 
            // resultadovolumentetraedro
            // 
            this.resultadovolumentetraedro.AutoSize = true;
            this.resultadovolumentetraedro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadovolumentetraedro.Location = new System.Drawing.Point(1031, 460);
            this.resultadovolumentetraedro.Name = "resultadovolumentetraedro";
            this.resultadovolumentetraedro.Size = new System.Drawing.Size(110, 26);
            this.resultadovolumentetraedro.TabIndex = 42;
            this.resultadovolumentetraedro.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 644);
            this.Controls.Add(this.resultadoareatriangulo);
            this.Controls.Add(this.resultadovolumentetraedro);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.alturatriangulo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.basetriangulo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.arista);
            this.Controls.Add(this.resultadovolumenesfera);
            this.Controls.Add(this.resultadoareacirculo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.resultadoareacuadrado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.base1);
            this.Controls.Add(this.resultadovolumencubo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lado1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.calcular3);
            this.Controls.Add(this.calcular2);
            this.Controls.Add(this.areatriangulo);
            this.Controls.Add(this.volumentetra);
            this.Controls.Add(this.areacirculo);
            this.Controls.Add(this.volumenesfera);
            this.Controls.Add(this.areacuadrado);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volumencubo);
            this.Controls.Add(this.calcular1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcular1;
        private System.Windows.Forms.RadioButton volumencubo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton areacuadrado;
        private System.Windows.Forms.RadioButton volumenesfera;
        private System.Windows.Forms.RadioButton areacirculo;
        private System.Windows.Forms.RadioButton volumentetra;
        private System.Windows.Forms.RadioButton areatriangulo;
        private System.Windows.Forms.Button calcular2;
        private System.Windows.Forms.Button calcular3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox lado1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultadovolumencubo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox base1;
        private System.Windows.Forms.Label resultadoareacuadrado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox radio1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox radio2;
        private System.Windows.Forms.Label resultadovolumenesfera;
        private System.Windows.Forms.Label resultadoareacirculo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox arista;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox alturatriangulo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox basetriangulo;
        private System.Windows.Forms.Label resultadoareatriangulo;
        private System.Windows.Forms.Label resultadovolumentetraedro;
    }
}

