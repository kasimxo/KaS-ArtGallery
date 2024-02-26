using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artgallery_sgdb {
    public partial class RegForm : Form {
        public RegForm() {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e) {
            if (txt_username.Text.Length < 3 || txt_password.Text.Length < 5) {
                MessageBox.Show("Usuario o contraseña no válidos");
            } else {
                string encusr = AesCryp.Encrypt(txt_username.Text) + ".ls";
                string encpss = AesCryp.Encrypt(txt_password.Text);

                var sw = new StreamWriter("data\\" + encusr);

                sw.WriteLine(encpss);
                sw.Close();


                Program.mw = new MainWindow();
                Program.mw.Show();

                Program.ventana.Visible = false;

                this.Close();
                //El nombre del archivo es el nombre del usuario encriptado
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
