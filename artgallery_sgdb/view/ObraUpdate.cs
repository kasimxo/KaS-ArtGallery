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
    public partial class ObraUpdate : Form
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
        private Boolean vendida;
        private Dictionary<String, Int64> listaMovimientos;
        private Dictionary<String, Int64> listaArtistas;
        private Dictionary<String, Int64> listaClientes;

        public ObraUpdate()
        {
            InitializeComponent();
        }

        public ObraUpdate(int id_obra, String titulo, String imagen, int precio, String movimiento, String autor, Boolean vendida)
        {
            this.imagen = imagen;
            this.titulo = titulo;
            this.autor = autor;
            this.movimiento = movimiento;
            this.precio = precio;
            this.id_obra = id_obra;
            this.vendida = vendida;
            listaMovimientos = new Dictionary<string, Int64>();
            listaArtistas = new Dictionary<string, Int64>();
            listaClientes = new Dictionary<string, Int64>();
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
            recuperarClientes();
            if (titulo != null) { txt_titulo.Text = titulo; }
            if (autor != null) { }
            if (movimiento != null) { }
            if (precio != null) { txt_precio.Text = precio.ToString(); }
            if (vendida)
            {
                cb_vendida.Checked = true;
            }
            else
            {
                cb_vendida.Checked = false;
            }
            if (imagen != null && !imagen.Equals(" ") && imagen.Length > 0)
            {
                picture.Image = Image.FromFile(".\\imagenes\\" + imagen);
            }
        }

        public void recuperarClientes()
        {
            try
            {
                string sqlQuery = "SELECT * FROM dbo.clientes;";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection con = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                listaClientes.Clear();
                cb_clientes.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    string nombreCompleto = Convert.ToString(dr[1]) + " " + Convert.ToString(dr[2]) + " " + Convert.ToString(dr[3]);
                    listaClientes.Add(nombreCompleto, Convert.ToInt64(dr[0]));
                    cb_clientes.Items.Add(nombreCompleto);
                }
                cb_clientes.SelectedIndex = 0;
                cb_clientes.SelectedIndex = cb_clientes.FindStringExact("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error recuperando los clientes");
            }
        }

        public void recuperarArtistas()
        {
            try
            {
                string sqlQuery = "SELECT * FROM dbo.artistas;";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection con = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                listaArtistas.Clear();
                cb_artistas.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    listaArtistas.Add(Convert.ToString(dr[1]), Convert.ToInt64(dr[0]));
                    cb_artistas.Items.Add(Convert.ToString(dr[1]));
                }
                cb_artistas.SelectedIndex = 0;
                cb_artistas.SelectedIndex = cb_artistas.FindStringExact(autor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error recuperando los artistas");
            }
        }

        public void recuperarMovimientos()
        {
            try
            {
                string sqlQuery = "SELECT * FROM dbo.movimientos;";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection con = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                listaMovimientos.Clear();
                cb_movimientos.Items.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    listaMovimientos.Add(Convert.ToString(dr[1]), Convert.ToInt64(dr[0]));
                    cb_movimientos.Items.Add(Convert.ToString(dr[1]));
                }
                cb_movimientos.SelectedIndex = 0;
                cb_movimientos.SelectedIndex = cb_movimientos.FindStringExact(movimiento);
            }
            catch (Exception ex)
            {
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
            this.id_movimiento = (int)num;

            listaArtistas.TryGetValue(autor, out num);
            this.id_autor = (int)num;
            Int32.TryParse(txt_precio.Text, out this.precio);
            this.vendida = cb_vendida.Checked;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (cb_vendida.Checked && cb_clientes.SelectedIndex == -1)
            {
                //Se ha marcado la obra como vendida pero no se ha seleccionado un 
                MessageBox.Show("Se ha producido un error al tratar de guardar una venta sin cliente");
                return;
            }

            try
            {
                actualizarVariables();
                string sqlQuery = "UPDATE dbo.obras SET"
                    + " titulo='" + titulo + "', imagen='" + imagen + "', precio="
                    + precio + ", id_artista=" + id_autor + ", id_movimiento="
                    + id_movimiento + ", vendida='" + vendida + "' WHERE id_obra=" + id_obra + ";";

                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand comm = new SqlCommand(sqlQuery, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                con.Open();
                comm.ExecuteNonQuery();
                comm.Dispose();

                if (cb_vendida.Checked) {
                    int id_cliente;
                    long temp;
                    listaClientes.TryGetValue(cb_clientes.Text, out temp);
                    id_cliente = (int)temp;
                    
                    string fecha = calendario.Value.ToLocalTime().ToString();
                    sqlQuery = "INSERT INTO dbo.ventas (id_obra, id_cliente, fecha_venta) VALUES('"
                    + id_obra + "', '" + id_cliente + "', '" + fecha + "');";

                    comm = new SqlCommand(sqlQuery, con);
                    adapter = new SqlDataAdapter(comm);
                    //con.Open();
                    comm.ExecuteNonQuery();
                    comm.Dispose();
                }

                


                con.Close();
                MessageBox.Show("Se han actualizado los datos correctamente");
                Program.mw.recargarObras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error al guardar la información");
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btn_nuevo_autor_Click(object sender, EventArgs e)
        {
            NuevoAutor nuevoAutor = new NuevoAutor(this);
            nuevoAutor.Show();
        }

        private void btn_nuevo_movimiento_Click(object sender, EventArgs e)
        {
            NuevoMovimiento nuevoMovimiento = new NuevoMovimiento(this);
            nuevoMovimiento.Show();
        }

        private void btn_cargarImagen_Click(object sender, EventArgs e)
        {
            imagenChooser.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";
            imagenChooser.ShowDialog();
            string filePath = imagenChooser.FileName;
            string filename = imagenChooser.SafeFileName;

            if (!Directory.Exists(".\\imagenes"))
            {
                Directory.CreateDirectory(".\\imagenes");
            }

            File.Copy(filePath, ".\\imagenes\\" + filename, true);
            this.imagen = filename;
            picture.Image = Image.FromFile(".\\imagenes\\" + filename);
        }

        private void cb_vendida_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_vendida.Checked)
            {
                lbl_cliente.Visible = true;
                cb_clientes.Visible = true;
                lbl_calendario.Visible = true;
                calendario.Visible = true;
            }
            else
            {
                lbl_cliente.Visible = false;
                cb_clientes.Visible = false;
                lbl_calendario.Visible = false;
                calendario.Visible = false;
            }
        }


    }
}
