using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Conversor
{
    public partial class VentanaPersonalizar : Form
    {
        public VentanaPersonalizar()
        {
            InitializeComponent();
        }

        private void VentanaPersonalizar_Load(object sender, EventArgs e)
        {

        }

        //BOTON REGISTRAR UNIDADES
        private void button1_Click(object sender, EventArgs e)
        {          
            label8.Text = "Observacion: Las unidades han sido registradas con éxito";
            //Representacion de las unidades en los labels
            label4.Text = textUnidad1.Text;
            label5.Text = textUnidad2.Text;
            label6.Text = textUnidad2.Text;
            label7.Text = textUnidad1.Text;
        }

        //Boton para la escritura del factor de converisión en el archivo correspondiente
        //BOTON REGISTRAR FACTORES
        private void button2_Click(object sender, EventArgs e)
        {
            String nuevaunidad1 = textUnidad1.Text.ToString().TrimEnd();
            String nuevaunidad2 = textUnidad2.Text.ToString().TrimEnd();
            String combinacion1 = nuevaunidad1 + "-" + nuevaunidad2;//combinaciones (cambio de orden)
            String combinacion2 = nuevaunidad2 + "-" + nuevaunidad1;
            String factor1 = textFactor1.Text.ToString().TrimEnd();
            string factor2 = textFactor2.Text.ToString().TrimEnd();
            escribirCombinaciones(combinacion1, combinacion2, factor1, factor2);//llamada a funcion que escribe en archivo PERSONALIZADO
            MessageBox.Show("Los factores de conversión fueron registrados con exito");
            this.Close();
        }

        //Funcion para escribir los factores en el archivo correspondiente
        private void escribirCombinaciones(String comb1, String comb2, string fact1, string fact2) {
            StreamWriter wri = null;
            wri = File.AppendText("Personalizado.txt");
            wri.WriteLine(comb1.TrimEnd()+"\t"+fact1);
            wri.WriteLine(comb2.TrimEnd()+"\t"+fact2);
            wri.Flush();
            wri.Close();
        }
    }   
}
