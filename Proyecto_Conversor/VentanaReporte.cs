using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Conversor
{
    public partial class VentanaReporte : Form
    {
       
        public VentanaReporte()
        {
            InitializeComponent();
        }

        private void VentanaReporte_Load(object sender, EventArgs e)
        {
            this.midatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            String[] entrada = leerReporte();//llamada a la función LLER ARCHIVO REPORTE
            if (entrada.Length > 0)
            {
                //ESCRIBIENDO LA CABECERA DE LAS COLUMNAS
                foreach (var columnName in entrada.FirstOrDefault().Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries))//asignacion de los valores de la primera linea 
                {
                     midatagrid.Columns.Add(columnName, columnName);
                }

                //LECTURA A PARTIR DE LA SEGUNDA LINEA DEL ARCHIVO
                foreach (var cellValues in entrada.Skip(1))
                {
                 var cellArray = cellValues.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);//Llenado de las celdas a partir de la segunda linea
                 //.columns. count es una funcion de C# perteneceinte al DATAGRID
                    if (cellArray.Length == midatagrid.Columns.Count)
                    midatagrid.Rows.Add(cellArray);
                }
            }               
        }

        //Funcion para leer REPORTE
        private string[] leerReporte()
        {
            string[] lines = System.IO.File.ReadAllLines("Reporte.txt");
            return lines;
        }        
     }
}

