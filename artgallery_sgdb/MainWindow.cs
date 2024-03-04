using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace artgallery_sgdb {
    public partial class MainWindow : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;


        public MainWindow()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {


            string sqlQuery;

            sqlQuery = "SELECT * FROM dbo.obras;";

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
            if(dataGridView1.SelectedCells != null){
                btn_borrar.Enabled = true;
                btn_modificar.Enabled = true;
            } else
            {
                btn_borrar.Enabled = false;
                btn_modificar.Enabled = false;
            }
        }
    }
}