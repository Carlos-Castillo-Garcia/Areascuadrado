using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areascuadrado
{
    public partial class Form1 : Form
    {

        int arista_cubo;
        int basecuad;
        int alturacuad;
        int radiocirculo;
        int radioesfera;
        int aristatetra;
        int triangulobase;
        int trianguloaltura;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lado1_TextChanged(object sender, EventArgs e)
        {
            arista_cubo = Convert.ToInt32(lado1.Text);
        }

        private void base1_TextChanged(object sender, EventArgs e)
        {
            basecuad = Convert.ToInt32(base1.Text);
        }

        private void altura_TextChanged(object sender, EventArgs e)
        {
            alturacuad = Convert.ToInt32(altura.Text);
        }

        private void radio1_TextChanged(object sender, EventArgs e)
        {
            radiocirculo = Convert.ToInt32(radio1.Text);
        }

        private void radio2_TextChanged(object sender, EventArgs e)
        {
            radioesfera = Convert.ToInt32(radio2.Text);
        }

        private void arista_TextChanged(object sender, EventArgs e)
        {
            aristatetra = Convert.ToInt32(arista.Text);
        }

        private void basetriangulo_TextChanged(object sender, EventArgs e)
        {
            triangulobase = Convert.ToInt32(basetriangulo.Text);
        }

        private void alturatriangulo_TextChanged(object sender, EventArgs e)
        {
            trianguloaltura = Convert.ToInt32(alturatriangulo.Text);
        }

        private void calcular1_Click(object sender, EventArgs e)
        {
            if (volumencubo.Checked && !areacuadrado.Checked){

                resultadovolumencubo.Text = "Volumen = " + Convert.ToString(arista_cubo * arista_cubo * arista_cubo);

            }else if(!volumencubo.Checked && areacuadrado.Checked){

                resultadoareacuadrado.Text = "Area = " + Convert.ToString(basecuad*alturacuad);

            }
        }

        private void calcular2_Click(object sender, EventArgs e)
        {
            if (volumenesfera.Checked && !areacirculo.Checked){

                resultadovolumenesfera.Text = "Volumen = " + Convert.ToString(4 / 3 * 3.1416 * (radioesfera * radioesfera * radioesfera));

            }
            else if (!volumenesfera.Checked && areacirculo.Checked){

                resultadoareacirculo.Text = "Area = " + Convert.ToString(3.1416 * (radiocirculo * radiocirculo));

            }
        }

        private void calcular3_Click(object sender, EventArgs e)
        {
            if (volumentetra.Checked && !areatriangulo.Checked){

                resultadovolumentetraedro.Text = "Volumen = " + Convert.ToString((1.41/12)*(aristatetra*aristatetra*aristatetra));

            }
            else if (!volumentetra.Checked && areatriangulo.Checked){

                resultadoareatriangulo.Text = "Area = " + Convert.ToString((triangulobase*trianguloaltura)/2);

            }
        }
    }
}
