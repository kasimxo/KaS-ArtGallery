using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artgallery_sgdb.UserControls {
    public partial class IconosDeVentana : UserControl {
        public IconosDeVentana() {
            InitializeComponent();
        }
        
        private void btn_exit_Click(object sender, EventArgs e) {

            //System.Windows.Forms.Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e) {
            //Program.ventana.maximizeWindow();
            btn_maximize.Click -= btn_maximize_Click;
            btn_maximize.Click += btn_resize_Click;
        }

        private void btn_minimize_Click(object sender, EventArgs e) {
            //Program.ventana.minimizeWindow();
        }

        private void btn_resize_Click(object sender, EventArgs e) {
            //Program.ventana.resizeWindow();
            btn_maximize.Click += btn_maximize_Click;
            btn_maximize.Click -= btn_resize_Click;
        }
        
    }
}
