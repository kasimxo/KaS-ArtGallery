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

namespace artgallery_sgdb {
    public partial class RegForm : Form {

        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public RegForm() {
            InitializeComponent();
            cb_rol.SelectedIndex = 0;
        }

        private void btn_registrar_Click(object sender, EventArgs e) {
            if (txt_username.Text.Length < 3 || txt_password.Text.Length < 5) {
                MessageBox.Show("Usuario o contraseña no válidos");
            } else if (!String.Equals(txt_password.Text, txt_password2.Text))
            {
                txt_password.Text = "";
                txt_password2.Text = "";
                MessageBox.Show("Las constraseñas introducidas no coinciden");

            } else {
                string encusr = AesCryp.Encrypt(txt_username.Text) + ".ls";
                string encpss = AesCryp.Encrypt(txt_password.Text);

                var sw = new StreamWriter("data\\" + encusr);

                sw.WriteLine(encpss);
                sw.Close();


                

                insertarNuevoUsuario(txt_username.Text.ToString(),cb_rol.Text.ToString());

                if(String.Equals(cb_rol.Text, "Administrador"))
                {
                    Program.mw = new MainWindow();
                    Program.mw.Show();

                    Program.ventana.Visible = false;
                } else if(String.Equals(cb_rol.Text, "Cliente"))
                {
                    Program.vis = new Visualizador();
                    Program.vis.Show();

                    Program.ventana.Visible = false;
                }

                

                this.Close();
            }
        }

        private void insertarNuevoUsuario(string nombre, string rol) {

            try {
                string sqlQuery = "INSERT INTO dbo.usuarios (nombre, rol) VALUES('"
            + nombre + "', '" + rol + "' );";

                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand comm = new SqlCommand(sqlQuery, con);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                con.Open();
                comm.ExecuteNonQuery();
                comm.Dispose();
                con.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error registrando el usuario");
            }

            
        }

        private void btn_limpiar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
