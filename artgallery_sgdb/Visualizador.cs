using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artgallery_sgdb
{
    public partial class Visualizador : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public Visualizador()
        {
            InitializeComponent();
            primeraCarga();
            cargarArtistas();
            cargarMovimientos();
        }

        public void cargarArtistas()
        {
            try
            {
                string sqlQuery = "SELECT * FROM dbo.artistas;";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection con = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cb_artistas.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    cb_artistas.Items.Add(Convert.ToString(dr[1]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error recuperando los artistas");
            }
        }

        public void cargarMovimientos()
        {
            try
            {
                string sqlQuery = "SELECT * FROM dbo.movimientos;";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection con = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cb_movimientos.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    cb_movimientos.Items.Add(Convert.ToString(dr[1]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error recuperando los movimientos");
            }

        }

        private void primeraCarga()
        {
            string sqlQuery = "SELECT titulo AS 'Título', autor AS 'Autor', movimiento AS 'Movimiento' FROM dbo.view_obras;";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection con = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un problema recuperando los datos");
            }
        }

        private void verObra()
        {


            string sqlQuery;
            int index = dataGridView1.CurrentCell.RowIndex;
            string titulo = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string autor = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string movimiento = dataGridView1.Rows[index].Cells[2].Value.ToString();

            sqlQuery = "SELECT * FROM dbo.view_obras WHERE autor LIKE '" + autor + "' AND titulo LIKE '"+titulo+"' AND movimiento LIKE '"+movimiento+"';";

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection con = new SqlConnection(connectionString);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                //Unicamente nos interesamos por el primer resultado
                DataRow resultado = ds.Tables[0].Rows[0];
                lbl_titulo.Text = resultado[1].ToString();
                String rutaImagen = resultado[2].ToString();

                lbl_precio.Text = resultado[3].ToString();
                lbl_movimiento.Text = resultado[4].ToString();
                lbl_autor.Text = resultado[5].ToString();

                if (rutaImagen != null && rutaImagen.Length > 1)
                {
                    img_obra.Image = Image.FromFile(".\\imagenes\\" + rutaImagen);
                }
                else
                {
                    //Si no hay ninguna imagen, colocamos un icono de sin imagen
                    img_obra.Image = artgallery_sgdb.Properties.Resources.imgNotFound;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un problema visualizando los datos");
                Debug.Write(ex.Message);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT titulo AS 'Título', autor AS 'Autor', movimiento AS 'Movimiento' FROM dbo.view_obras WHERE titulo LIKE '%" +
                txt_titulo.Text + "%' AND autor LIKE '%" + cb_artistas.Text + "%' AND movimiento LIKE '%" + cb_movimientos.Text + "%';";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection con = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                //MessageBox.Show("Se han recuperado los datos correctamente");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un problema recuperando los datos");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelautor.Visible = true;
            labelprecio.Visible = true;
            labelmovimiento.Visible = true;
            labeltitulo.Visible = true;
            verObra();
        }
    }
}
