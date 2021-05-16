using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tarea10.Clases.Archivos;
using Tarea10.Clases.Base_Datos;

namespace Tarea10
{
    public partial class frmIinicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void cargarArchivoexterno()
        {
            string fuente = @"C:\Users\HP\Desktop\tarea10\archivoCls.csv";
            ClsArchivo ar = new ClsArchivo();
            ClsConexion cn = new ClsConexion();

            //obtener tood el archivo de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencial_sql = "";
            int NumeroLinea = 0;

            //interamos sobre el arreglo, line por linea para luego convertirlo en dadots
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (NumeroLinea > 0)
                {
                    sentencial_sql += $"insert into progra1.tb_alumno values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n";
                }// end foreach

                NumeroLinea++;

            }
            NumeroLinea = 0;
            cn.EjecutaSQLDirecto(sentencial_sql);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
        


        protected void Button1_Click(object sender, EventArgs e)
        {
            cargarArchivoexterno();
        }

        public DataTable CargarDatosDB(string condicion = "1=1")
        {
            ClsConexion cn = new ClsConexion();
            DataTable dt = new DataTable();
            string sentencia = $"select * from progra1.tb_alumno where {condicion} ";
            dt = cn.consultaTablaDirecta(sentencia);
            return dt;


        }

        protected void ButtonBuscarNombre_Click(object sender, EventArgs e)
        {
            string id = TextBoxIDE.Text.Trim();
            string condicion = $"correlativo = {id}";
            DataTable dt = CargarDatosDB(condicion);
            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<string>("nombre");
                TestBoxNombre.Text = nombre;
            }
            else
            {
                TestBoxNombre.Text = "No hay informacion";
            }

        }

        protected void ButtonID_Click(object sender, EventArgs e)
        {
            string id = TextBoxIDE.Text.Trim();
            string condicion = $"correlativo = {id}";
            DataTable dt = CargarDatosDB(condicion);
            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<string>("nombre");
                TestBoxNombre.Text = nombre;
            }
            else
            {
                TestBoxNombre.Text = "No hay informacion en la numeracion";
            }

        }

        protected void TextBoxIDE_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TestBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}