using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using artgallery_sgdb;

namespace artgallery_sgdb {
    public partial class Login : Form {
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
                        //MessageBox.Show("In");
                        Program.mw = new MainWindow();
                        Program.mw.Show();
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
