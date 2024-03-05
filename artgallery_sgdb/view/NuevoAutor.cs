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
using static System.Net.Mime.MediaTypeNames;

namespace artgallery_sgdb.view
{

    public partial class NuevoAutor : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        private ObraCreate oc;

        public NuevoAutor()
        {
            InitializeComponent();
        }

        public NuevoAutor(ObraCreate oc)
        {
            this.oc = oc;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String autor = txt_nombre.Text;
            if(autor == null || autor.Length<1 )
            {
                MessageBox.Show("El nombre introducido no es válido");
                return;
            }
            try {
                string sqlQuery = "INSERT INTO dbo.artistas (nombre) VALUES('" + autor + "');";

                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand comm = new SqlCommand(sqlQuery, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                con.Open();
                comm.ExecuteNonQuery();
                comm.Dispose();
                con.Close();
                MessageBox.Show("Se ha registrado el artista correctamente");
                if (oc != null) {
                    oc.recuperarArtistas();//Actualizamos los artistas en la ventana original
                }
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show("Ha surgido un error registrando el artista");

            }

        }
    }
}
