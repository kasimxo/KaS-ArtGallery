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
    public partial class Obra : Form
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

        public Obra()
        {
            InitializeComponent();
        }

        public Obra(int id_obra, String titulo, String imagen, int precio, String movimiento, String autor) {
            this.imagen = imagen;
            this.titulo = titulo;
            this.autor = autor;
            this.movimiento = movimiento;
            this.precio = precio;
            this.id_obra = id_obra;
            listaMovimientos = new Dictionary<string, Int64>();
            InitializeComponent();
            actualizarView();
        }

        /// <summary>
        /// Inicializa y actualiza todos los componentes de la vista
        /// </summary>
        private void actualizarView()
        {
            recuperarMovimientos();
            if (titulo != null) { txt_titulo.Text = titulo; }
            if (autor != null) { txt_autor.Text = autor; }
            if (movimiento != null) { txt_movimiento.Text = movimiento; }
            if (precio != null) { txt_precio.Text = precio.ToString(); }
            if (imagen != null) { }
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
                foreach (DataRow dr in dt.Rows) {
                    listaMovimientos.Add(Convert.ToString(dr[1]), Convert.ToInt64(dr[0]));
                    cb_movimientos.Items.Add(Convert.ToString(dr[1]));
                }
            }
            catch (Exception ex) { }

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
