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
    public partial class Borrar : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        private String imagen;
        private String titulo;
        private String autor;
        private String movimiento;
        private int id_movimiento;
        private int id_autor;
        private int precio;
        private int id_obra;
        public Borrar()
        {
            InitializeComponent();
        }

        public Borrar(int id_obra, String titulo, String imagen, int precio, String movimiento, String autor)
        {
            this.imagen = imagen;
            this.titulo = titulo;
            this.autor = autor;
            this.movimiento = movimiento;
            this.precio = precio;
            this.id_obra = id_obra;
            InitializeComponent();


            lbl_confirmacion.Text = "¿Está seguro de que desea eliminar '" + titulo +
                "' creada por " + autor + " de forma permanente?";

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "DELETE FROM dbo.obras WHERE id_obra=" + id_obra + ";";

                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand comm = new SqlCommand(sqlQuery, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                con.Open();
                comm.ExecuteNonQuery();
                comm.Dispose();
                con.Close();
                MessageBox.Show("Se ha borrado la obra "+titulo +" correctamente");
                Program.mw.recargarObras();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error al borrar la obra");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
