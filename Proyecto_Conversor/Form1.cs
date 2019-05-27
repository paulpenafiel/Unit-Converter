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
    public partial class Form1 : Form
    {
        public Form1()
        {           
            InitializeComponent();
            //Mensaje dentro del textbox que indica el caracter para decimales
        textEntrada.ForeColor = Color.Black;
        textEntrada.Text = "En caso de decimal utilice ' , ' ";
        this.textEntrada.Leave += new System.EventHandler(this.textEntrada_Leave);
        this.textEntrada.Enter += new System.EventHandler(this.textEntrada_Enter);
    }

        

        //ACCION DEL CLIC SOBRE BOTON <DESPLEGAR UNIDADES>
        private void button1_Click(object sender, EventArgs e)
        {          
         String categoria=comboCategoria.Text;
            int numunidades=0;
            if(categoria.CompareTo("Personalizado")==0){//si la categoria corresponde al archivo Personalizado el proceso es diferente
                label3.Text = "Conversiones Personalizadas";
                label4.Text = " ";
                listEntrada.Items.Clear();
                listSalida.Items.Clear();
                listSalida.BackColor = Color.Yellow;
                String[] lines = leerDimension(comboCategoria.Text.TrimEnd());//llamada a funcion que lee archivo
                for (int j = 0; j < lines.Length; j++)
                {
                    String combinacion = separador1(lines[j])[0];
                    listEntrada.Items.Add(combinacion);
                }
                
                //string line;
                listSalida.Items.Add("ESCOJER UNA DE LAS CONVERSIONES");
                listSalida.Items.Add("PERSONALIZADAS POR EL USUARIO");
            }
                else{
                    listSalida.BackColor = Color.White;
                    label3.Text = "Unidad Entrada";
                    label4.Text = "Unidad Salida";
                    switch (categoria) { 
                    case "Masa": case "Moneda": case "Tiempo": case "Velocidad": case "Presion": case "Densidad":
                    numunidades = 12;
                    break;
                    case "Longitud": case "Fuerza":
                    numunidades = 10;
                    break;
                    case "Volumen":
                    numunidades = 16;
                    break;
                    case "Temperatura":
                    numunidades = 8;
                    break;    
                    case "Angulos": case "Area":
                    numunidades = 6;
                    break;
                    }

                    String[] lines = leerDimension(comboCategoria.Text.TrimEnd());//lectura del archivo de determinada categoria
                    listEntrada.Items.Clear();
                    listSalida.Items.Clear();
                    for (int i = 0; i < numunidades;i++ )
                    {
                    listEntrada.Items.Add(lines[i]);
                    listSalida.Items.Add(lines[i]);
                    }
                }
        }

        //ACCIONDES PARA EL CLIC SOBRE EL BOTON <CONVERTIR>
        private void buttonConvertir_Click(object sender, EventArgs e)
        {                      
                String[] lines = leerDimension(comboCategoria.Text.TrimEnd());//LLama a la funcion que lee el archivo
                string[] palabras = separador1(lines[lines.Length - 1]);
                //fin lectura y separacion de palabras
                String inc = listEntrada.Text.ToString();
                String outp = listSalida.Text.ToString();
                String a = inc.TrimEnd() + "-";
                String b = a + (outp.TrimEnd());//formacion de la cadena de combinaciones
                String combinacion = "", factor = "";
                float Entrada = float.Parse(textEntrada.Text);
                double salida;
                String[] m = inc.Split('-');
                
            //comparacion de las unidades con el archivo  
                for (int i = 0; i < palabras.Length; i++)
                {
                    for (int j = 0; j < lines.Length; j++)
                    {
                        combinacion = separador1(lines[j])[0];
                        if ((comboCategoria.Text.TrimEnd()).CompareTo("Personalizado") == 0)
                        {
                            if ((combinacion.CompareTo(inc)) == 0)
                            {
                                factor = separador1(lines[j])[1];//si coincide devuelve el indice [1] del vector de palabras separadas
                                salida = (Entrada * (float.Parse(factor)));//multiplicacion
                                textSalida.Text = ""+salida;                                                                
                                break;                              
                            }                           
                        }
                        else
                        {
                            if ((combinacion.CompareTo(b)) == 0)
                            {
                                factor = separador1(lines[j])[1];
                                salida = (Entrada * (Double.Parse(factor)));
                                textSalida.Text = salida.ToString();                                
                                break;                                
                            }                           
                        }
                    }
                }
            ////
                if ((comboCategoria.Text.TrimEnd()).CompareTo("Personalizado") == 0)
                {
                    Escribiereporte(Entrada.ToString(), m[0], m[1], textSalida.Text.ToString().TrimEnd());
                }
                else {
                    Escribiereporte(Entrada.ToString(), inc, outp, textSalida.Text.ToString().TrimEnd());
                }

        }

        //seleccion sobre la lista de entrada cambia la label de unidad1 
        private void listEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {       

            if ((comboCategoria.Text.ToString().TrimEnd()).CompareTo("Personalizado") == 0)
            {
                String combinacion = listEntrada.Text.ToString().TrimEnd();
                //MessageBox.Show(combinacion);
                string[] j = (combinacion.Split('-'));
                label6.Text = j[0];
                label7.Text = j[1];
                textEntrada.Text = "";
            }
            else
            {
                label6.Text = listEntrada.Text.ToString();
                textEntrada.Text = "";
            }
        }

        private void listSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = listSalida.Text.ToString();
            textSalida.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //Abriendo ventana para <PERSONALIZAR CONVERSION>
        private void personalizarConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaPersonalizar ventana = new VentanaPersonalizar();
            ventana.Show();
        }

        //Desplliegue del manual de usuario
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Manual.pdf");
        }

        //Abriendo ventana de Reporte
        private void verReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaReporte reporte = new VentanaReporte();
            reporte.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Funciones para separar las palabras dentro de las lineas del archivo : por TABS
        private String[] separador1(String k)
        {
            string[] j = k.Split('\t');
            return j;
        }

        //función para guardar las operaciones realizadas en un archivo de texto así como la hora de registro
        private void Escribiereporte(string valor1, string unidad1, string unidad2, string resultado) {
            StreamWriter wri = null;
            wri = File.AppendText("Reporte.txt");
            wri.WriteLine(valor1.TrimEnd()+"\t"+unidad1.TrimEnd()+"\t"+unidad2.TrimEnd()+"\t"+resultado.TrimEnd()+"\t"+DateTime.Now.ToString().TrimEnd());
            wri.Flush();//vacia el buffer
            wri.Close();
        }

        //Funcion para lectura de archivos y factores
        private string[] leerDimension(String nombreArchivo)
        {
            string[] lines = System.IO.File.ReadAllLines(nombreArchivo + ".txt");
            return lines;
        }

        //ACCION AL INGRESAR CONTENIDO AL TEXTENTRADA
        private void textEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (comboCategoria.Text.ToString().TrimEnd().CompareTo("Temperatura") == 0)//Si la categoria es temperatura
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != ',') && (e.KeyChar != '-'))//admite valores negativos, numeros y coma
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            else {//si la categoría no es temperatura

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') )//acepta solo numeros y coma , pero no negativos
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
             
            }
        }
          
         private void textEntrada_Leave(object sender, EventArgs e)
        {
            if (textEntrada.Text.Length == 0)
             {
            textEntrada.Text = "En caso de decimal, utilice ' , '";
            textEntrada.ForeColor = Color.Black;
            }
         }

        private void textEntrada_Enter(object sender, EventArgs e)
         {
          if (textEntrada.Text == "En caso de decimal utilice ' , '")
            {
            textEntrada.Text = "";
            textEntrada.ForeColor = Color.Black;
            }
         }
        private void textSalida_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textEntrada_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
