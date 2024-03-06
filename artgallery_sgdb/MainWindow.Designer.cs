namespace artgallery_sgdb {
    partial class MainWindow {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void maximizeWindow() {
            this.WindowState = FormWindowState.Maximized;
        }

        public void minimizeWindow() {
            this.WindowState = FormWindowState.Minimized;
        }

        public void resizeWindow() {
            this.WindowState = FormWindowState.Normal;
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            img_obra = new PictureBox();
            lbl_precio = new Label();
            label4 = new Label();
            btn_buscar = new Button();
            lbl_movimiento = new Label();
            lbl_autor = new Label();
            lbl_titulo = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_insertar = new Button();
            btn_borrar = new Button();
            btn_modificar = new Button();
            tabPage2 = new TabPage();
            visor_informe = new Microsoft.Reporting.WinForms.ReportViewer();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_obra).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(681, 185);
            dataGridView1.TabIndex = 0;
            toolTip1.SetToolTip(dataGridView1, "Resultado de la busqueda");
            dataGridView1.CellClick += dataGridView1_ActivarOpciones;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(9, 9);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(782, 429);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(img_obra);
            tabPage1.Controls.Add(lbl_precio);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(btn_buscar);
            tabPage1.Controls.Add(lbl_movimiento);
            tabPage1.Controls.Add(lbl_autor);
            tabPage1.Controls.Add(lbl_titulo);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btn_insertar);
            tabPage1.Controls.Add(btn_borrar);
            tabPage1.Controls.Add(btn_modificar);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(774, 401);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gestión inventario";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // img_obra
            // 
            img_obra.Location = new Point(6, 3);
            img_obra.Name = "img_obra";
            img_obra.Size = new Size(240, 201);
            img_obra.SizeMode = PictureBoxSizeMode.Zoom;
            img_obra.TabIndex = 19;
            img_obra.TabStop = false;
            toolTip1.SetToolTip(img_obra, "Imagen de la obra");
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(362, 140);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(0, 15);
            lbl_precio.TabIndex = 18;
            toolTip1.SetToolTip(lbl_precio, "Precio de la obra seleccionada");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 140);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 17;
            label4.Text = "Precio:";
            toolTip1.SetToolTip(label4, "Precio");
            label4.Visible = false;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(693, 210);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 16;
            btn_buscar.Text = "Buscar";
            toolTip1.SetToolTip(btn_buscar, "Botón para buscar obras");
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_cargarObras;
            // 
            // lbl_movimiento
            // 
            lbl_movimiento.AutoSize = true;
            lbl_movimiento.Location = new Point(362, 100);
            lbl_movimiento.Name = "lbl_movimiento";
            lbl_movimiento.Size = new Size(0, 15);
            lbl_movimiento.TabIndex = 15;
            toolTip1.SetToolTip(lbl_movimiento, "Movimiento de la obra seleccionada");
            // 
            // lbl_autor
            // 
            lbl_autor.AutoSize = true;
            lbl_autor.ImageAlign = ContentAlignment.TopLeft;
            lbl_autor.Location = new Point(362, 59);
            lbl_autor.Name = "lbl_autor";
            lbl_autor.Size = new Size(0, 15);
            lbl_autor.TabIndex = 14;
            lbl_autor.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lbl_autor, "Autor de la obra seleccionada");
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Location = new Point(362, 21);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(0, 15);
            lbl_titulo.TabIndex = 13;
            toolTip1.SetToolTip(lbl_titulo, "Título de la obra seleccionada");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 100);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 12;
            label3.Text = "Movimiento:";
            toolTip1.SetToolTip(label3, "Movimiento");
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 59);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 11;
            label2.Text = "Autor:";
            toolTip1.SetToolTip(label2, "Autor");
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 21);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Título:";
            toolTip1.SetToolTip(label1, "Título");
            label1.Visible = false;
            // 
            // btn_insertar
            // 
            btn_insertar.Location = new Point(693, 326);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(75, 23);
            btn_insertar.TabIndex = 9;
            btn_insertar.Text = "Insertar";
            toolTip1.SetToolTip(btn_insertar, "Abrir formulario de registro de nueva obra");
            btn_insertar.UseVisualStyleBackColor = true;
            btn_insertar.Click += btn_insertar_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.Enabled = false;
            btn_borrar.Location = new Point(693, 297);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(75, 23);
            btn_borrar.TabIndex = 8;
            btn_borrar.Text = "Borrar";
            toolTip1.SetToolTip(btn_borrar, "Borrar obra seleccionada");
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Enabled = false;
            btn_modificar.Location = new Point(693, 268);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(75, 23);
            btn_modificar.TabIndex = 7;
            btn_modificar.Text = "Modificar";
            toolTip1.SetToolTip(btn_modificar, "Modificar obra seleccionada");
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(visor_informe);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(774, 401);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Informes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // visor_informe
            // 
            visor_informe.Dock = DockStyle.Fill;
            visor_informe.Location = new Point(3, 3);
            visor_informe.Name = "ReportViewer";
            visor_informe.ServerReport.BearerToken = null;
            visor_informe.Size = new Size(768, 395);
            visor_informe.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Art Gallery";
            FormClosing += MainWindow_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_obra).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btn_insertar;
        private Button btn_borrar;
        private Button btn_modificar;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label lbl_movimiento;
        private Label lbl_autor;
        private Label lbl_titulo;
        private Button btn_buscar;
        private Label lbl_precio;
        private Label label4;
        private PictureBox img_obra;
        private ToolTip toolTip1;
        private Microsoft.Reporting.WinForms.ReportViewer visor_informe;
    }
}