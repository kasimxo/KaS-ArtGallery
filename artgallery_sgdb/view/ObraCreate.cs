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
    public partial class ObraCreate : Form
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
        private Dictionary<String, Int64> listaMovimientos;
        private Dictionary<String, Int64> listaArtistas;

        public ObraCreate()
        {
            listaMovimientos = new Dictionary<string, Int64>();
            listaArtistas = new Dictionary<string, Int64>();
            InitializeComponent();
            actualizarView();
        }

        /// <summary>
        /// Inicializa y actualiza todos los componentes de la vista
        /// </summary>
        private void actualizarView()
        {
            recuperarMovimientos();
            recuperarArtistas();
            if (titulo != null) { txt_titulo.Text = titulo; }
            if (autor != null) { }
            if (movimiento != null) { }
            if (precio != null) { txt_precio.Text = precio.ToString(); }
            if (imagen != null) { }
        }

        private void recuperarArtistas()
        {
            try
            {
                string sqlQuery = "SELECT * FROM dbo.artistas;";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection con = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    listaArtistas.Add(Convert.ToString(dr[1]), Convert.ToInt64(dr[0]));
                    cb_artistas.Items.Add(Convert.ToString(dr[1]));
                }
                cb_artistas.SelectedIndex = 0;
                cb_artistas.SelectedIndex = cb_artistas.FindStringExact(autor);
            }
            catch (Exception ex) {
                MessageBox.Show("Ha surgido un error recuperando los artistas");
            }
        }

        private void recuperarMovimientos()
        {
            try
            {
                string sqlQuery = "SELECT * FROM dbo.movimientos;";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection con = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    listaMovimientos.Add(Convert.ToString(dr[1]), Convert.ToInt64(dr[0]));
                    cb_movimientos.Items.Add(Convert.ToString(dr[1]));
                }
                cb_movimientos.SelectedIndex = 0;
                cb_movimientos.SelectedIndex = cb_movimientos.FindStringExact(movimiento);
            }
            catch (Exception ex) {
                MessageBox.Show("Ha surgido un error recuperando los movimientos");
            }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarVariables()
        {
            this.titulo = txt_titulo.Text;
            this.autor = cb_artistas.Text;
            this.movimiento = cb_movimientos.Text;
            long num; //variable temporal para almacenar ids
            num = listaMovimientos[cb_movimientos.Text];
            this.id_movimiento = (int) num;

            listaArtistas.TryGetValue(autor, out num);
            this.id_autor = (int)num;
            Int32.TryParse(txt_precio.Text, out this.precio);
            
            /*
            this.imagen;

            */
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            try
            {
                actualizarVariables();
                string sqlQuery = "INSERT INTO dbo.obras (titulo, imagen, precio, id_artista, vendida, id_movimiento) VALUES('"
                    +titulo+"', '"+imagen+"', "+precio+", "+id_autor+", 0, "
                    +id_movimiento+");";
                
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand comm = new SqlCommand(sqlQuery, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                con.Open();
                comm.ExecuteNonQuery();
                comm.Dispose();
                con.Close();
                MessageBox.Show("Se han actualizado los datos correctamente");
                Program.mw.recargarObras();
            }
            catch (Exception ex) {
                MessageBox.Show("Ha surgido un error al guardar la información");
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
