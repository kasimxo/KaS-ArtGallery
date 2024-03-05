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
using artgallery_sgdb;
using Microsoft.Data.SqlClient;

namespace artgallery_sgdb {
    public partial class Login : Form {

        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public Login() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            txt_password.Text = string.Empty;
            txt_username.Text = string.Empty;
        }

        private void btn_acceder_Click(object sender, EventArgs e) {
            if (txt_username.Text.Length < 3 || txt_password.Text.Length < 5) {
                MessageBox.Show("Usuario o contraseña no válidos");
            } else {
                string file = AesCryp.Encrypt(txt_username.Text) + ".ls";
                StreamReader sr;
                try {
                    sr = new StreamReader("data\\" + file);
                    string encpss = sr.ReadLine();
                    sr.Close();

                    string decpss = AesCryp.Decrypt(encpss);

                    if (decpss == txt_password.Text) {

                        string rol = comprobarRol(txt_username.Text);
                        if(String.Equals("Administrador", rol)) { 

                            Program.mw = new MainWindow();
                            Program.mw.Show();
                        } else if(String.Equals("Cliente", rol)) {
                            Program.vis = new Visualizador();
                            Program.vis.Show();
                        }
                        //MessageBox.Show("In");
                        
                        this.Visible = false;
                    } else {
                        MessageBox.Show("Nombre de usuario o contraseña no válidos.");
                    }
                } catch (Exception ex) {
                    //no se ha encontrado el usuario
                    MessageBox.Show("Nombre de usuario o contraseña no válidos.");
 
                }
            }
        }

        private string comprobarRol(string nombre)
        {
            string sqlQuery = "SELECT rol FROM dbo.usuarios WHERE nombre ='" + nombre + "';";

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand com = new SqlCommand(sqlQuery, con);
                string rol="";
                con.Open();
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read()) { 
                    rol = reader.GetString(0); 
                }
                

                com.Dispose();
                con.Close();
                return rol;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un problema recuperando el rol del usuario");
                Debug.Write(ex.Message);
                return "";
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e) {
            RegForm rf = new RegForm();
            rf.Show();
        }


        private void txt_password_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) { 
                btn_acceder_Click(sender, e);
            }
        }
    }
}
