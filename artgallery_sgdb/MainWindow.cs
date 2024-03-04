using artgallery_sgdb.view;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Diagnostics;

namespace artgallery_sgdb {
    public partial class MainWindow : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;


        public MainWindow()
        {
            InitializeComponent();
        }


        private void btn_ver(object sender, EventArgs e)
        {


            string sqlQuery;
            int id_obra = obtenerIdSeleccionado();
            sqlQuery = "SELECT * FROM dbo.view_obras WHERE Id = " + id_obra.ToString() + ";";

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
                    img_obra.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    //Si no hay ninguna imagen, colocamos un icono de sin imagen
                    img_obra.Image = artgallery_sgdb.Properties.Resources.imgNotFound;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ha surgido un problema visualizando los datos");
                Debug.Write(ex.Message);
            }

        }

        private void btn_cargarObras(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * FROM dbo.view_obras;";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection con = new SqlConnection(connectionString);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show("Se han recuperado los datos correctamente");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un problema recuperando los datos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string sqlQuery = "INSERT INTO dbo.Obras (titulo, id_autor) VALUES (@titulo, @autor);";

            try
            {


                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                SqlCommand cmd = new SqlCommand("insertarObra", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                /*
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                */

                var titulo = new SqlParameter("titulo", System.Data.SqlDbType.VarChar);
                titulo.Value = txt_box1.Text;
                cmd.Parameters.Add(titulo);

                var autor = new SqlParameter("autor", System.Data.SqlDbType.Int);
                autor.Value = txt_box2.Text;
                cmd.Parameters.Add(autor);


                cmd.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("kk");

            }

        }

        private void dataGridView1_ActivarOpciones(object sender, DataGridViewCellEventArgs e)
        {
            //Comprobamos si el usuario ha seleccionado algo para habilitar los botones
            if (dataGridView1.CurrentCell != null)
            {
                btn_borrar.Enabled = true;
                btn_modificar.Enabled = true;
                btn_visualizar.Enabled = true;
            }
            else
            {
                btn_borrar.Enabled = false;
                btn_modificar.Enabled = false;
                btn_visualizar.Enabled = true;
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            int id_obra = obtenerIdSeleccionado();

            MessageBox.Show(id_obra.ToString());
            //int id_obra = dataGridView1.GetChildAtPoint(new Point(index, 0));
        }

        /// <summary>
        /// Busca el id del elemento seleccionado en la datagridview
        /// </summary>
        /// <returns></returns>
        private int obtenerIdSeleccionado()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            Int32.TryParse(dataGridView1.Rows[index].Cells[0].Value.ToString(), out int id_obra);
            return id_obra;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

             

            int index = dataGridView1.CurrentCell.RowIndex;

            int id_obra = Int32.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            String titulo = dataGridView1.Rows[index].Cells[1].Value.ToString();
            String imagen = dataGridView1.Rows[index].Cells[2].Value.ToString();
            int precio = Int32.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString());
            String movimiento = dataGridView1.Rows[index].Cells[4].Value.ToString();
            String autor = dataGridView1.Rows[index].Cells[5].Value.ToString();

            Obra obra = new Obra(id_obra, titulo, imagen, precio, movimiento, autor);
            obra.Show();
        }
    }
}