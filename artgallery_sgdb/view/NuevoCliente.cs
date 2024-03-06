using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artgallery_sgdb.view
{
    public partial class NuevoCliente : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        ObraUpdate ou;

        public NuevoCliente()
        {
            InitializeComponent();
        }

        public NuevoCliente(ObraUpdate ou)
        {
            InitializeComponent();
            this.ou = ou;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_nombre.Text) || String.IsNullOrEmpty(txt_apellido1.Text) || String.IsNullOrEmpty(txt_dni.Text) || String.IsNullOrEmpty(txt_tlf.Text) ) {
                MessageBox.Show("Los datos del cliente introducidos no son válidos. No se ha registrado el cliente.");
                return;
            } else if (fecha_nac.Value.CompareTo(DateTime.Now.AddDays(-6570)) > 0)
            {
                MessageBox.Show("La edad del cliente introducidos no es válida. No se ha registrado el cliente.");
                return;
            }
            
            string nombre = txt_nombre.Text;
            string apellido1 = txt_apellido1.Text;
            string apellido2 = txt_apellido2.Text;
            string dni = txt_dni.Text;
            string tlf = txt_tlf.Text;
            DateTime edad = fecha_nac.Value.Date;

            try
            {
                string sqlQuery = "INSERT INTO dbo.clientes (nombre, apellido1, apellido2, fecha_nac, dni, tlf) VALUES('" + nombre + 
                    "', '"+apellido1+ "', '" + apellido2+ "', '" + edad.ToString()+ "', '" + dni+ "', '" + tlf +"');";

                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand comm = new SqlCommand(sqlQuery, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                con.Open();
                comm.ExecuteNonQuery();
                comm.Dispose();
                con.Close();
                MessageBox.Show("Se ha registrado el cliente correctamente");
                if (ou != null)
                {
                    ou.recuperarClientes();//Actualizamos los clientes en la ventana original
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error registrando el cliente");

            }


            
        }
    }
}
