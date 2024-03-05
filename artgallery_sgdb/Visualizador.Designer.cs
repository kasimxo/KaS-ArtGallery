namespace artgallery_sgdb
{
    partial class Visualizador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            cb_artistas = new ComboBox();
            cb_movimientos = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txt_titulo = new TextBox();
            toolTip1 = new ToolTip(components);
            dataGridView1 = new DataGridView();
            btn_buscar = new Button();
            img_obra = new PictureBox();
            lbl_precio = new Label();
            label5 = new Label();
            lbl_movimiento = new Label();
            lbl_autor = new Label();
            lbl_titulo = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_obra).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Filtros:";
            toolTip1.SetToolTip(label1, "Filtros");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 31);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Artista:";
            toolTip1.SetToolTip(label2, "Artista");
            // 
            // cb_artistas
            // 
            cb_artistas.FormattingEnabled = true;
            cb_artistas.Location = new Point(226, 28);
            cb_artistas.Name = "cb_artistas";
            cb_artistas.Size = new Size(121, 23);
            cb_artistas.TabIndex = 2;
            toolTip1.SetToolTip(cb_artistas, "Seleciona el artista que quieres buscar");
            // 
            // cb_movimientos
            // 
            cb_movimientos.FormattingEnabled = true;
            cb_movimientos.Location = new Point(449, 28);
            cb_movimientos.Name = "cb_movimientos";
            cb_movimientos.Size = new Size(121, 23);
            cb_movimientos.TabIndex = 3;
            toolTip1.SetToolTip(cb_movimientos, "Selecciona aquí el movimiento artistico a buscar");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 31);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 4;
            label3.Text = "Movimiento:";
            toolTip1.SetToolTip(label3, "Movimiento");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 31);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 5;
            label4.Text = "Título:";
            toolTip1.SetToolTip(label4, "Título");
            // 
            // txt_titulo
            // 
            txt_titulo.Location = new Point(59, 28);
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(100, 23);
            txt_titulo.TabIndex = 6;
            toolTip1.SetToolTip(txt_titulo, "Escribe aqui el título a buscar");
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(369, 272);
            dataGridView1.TabIndex = 7;
            toolTip1.SetToolTip(dataGridView1, "Resultado de la busqueda");
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(13, 62);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 8;
            btn_buscar.Text = "Buscar";
            toolTip1.SetToolTip(btn_buscar, "Buscar");
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // img_obra
            // 
            img_obra.Location = new Point(386, 91);
            img_obra.Name = "img_obra";
            img_obra.Size = new Size(262, 272);
            img_obra.SizeMode = PictureBoxSizeMode.Zoom;
            img_obra.TabIndex = 28;
            img_obra.TabStop = false;
            toolTip1.SetToolTip(img_obra, "Imagen de la obra");
            // 
            // lbl_precio
            // 
            lbl_precio.Location = new Point(654, 324);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(164, 26);
            lbl_precio.TabIndex = 27;
            toolTip1.SetToolTip(lbl_precio, "Precio de la obra seleccionada");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(651, 309);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 26;
            label5.Text = "Precio:";
            toolTip1.SetToolTip(label5, "Precio");
            // 
            // lbl_movimiento
            // 
            lbl_movimiento.Location = new Point(654, 246);
            lbl_movimiento.Name = "lbl_movimiento";
            lbl_movimiento.Size = new Size(164, 46);
            lbl_movimiento.TabIndex = 25;
            toolTip1.SetToolTip(lbl_movimiento, "Movimiento de la obra seleccionada");
            // 
            // lbl_autor
            // 
            lbl_autor.ImageAlign = ContentAlignment.TopLeft;
            lbl_autor.Location = new Point(654, 163);
            lbl_autor.Name = "lbl_autor";
            lbl_autor.Size = new Size(164, 49);
            lbl_autor.TabIndex = 24;
            lbl_autor.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(lbl_autor, "Autor de la obra seleccionada");
            // 
            // lbl_titulo
            // 
            lbl_titulo.Location = new Point(654, 95);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(164, 53);
            lbl_titulo.TabIndex = 23;
            toolTip1.SetToolTip(lbl_titulo, "Título de la obra seleccionada");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(654, 222);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 22;
            label6.Text = "Movimiento:";
            toolTip1.SetToolTip(label6, "Movimiento");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(654, 148);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 21;
            label7.Text = "Autor:";
            toolTip1.SetToolTip(label7, "Autor");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(654, 80);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 20;
            label8.Text = "Título:";
            toolTip1.SetToolTip(label8, "Título");
            // 
            // Visualizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(830, 375);
            Controls.Add(img_obra);
            Controls.Add(lbl_precio);
            Controls.Add(label5);
            Controls.Add(lbl_movimiento);
            Controls.Add(lbl_autor);
            Controls.Add(lbl_titulo);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btn_buscar);
            Controls.Add(dataGridView1);
            Controls.Add(txt_titulo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cb_movimientos);
            Controls.Add(cb_artistas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Visualizador";
            Text = "Explorador de obras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_obra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ToolTip toolTip1;
        private ComboBox cb_artistas;
        private ComboBox cb_movimientos;
        private Label label3;
        private Label label4;
        private TextBox txt_titulo;
        private DataGridView dataGridView1;
        private Button btn_buscar;
        private PictureBox img_obra;
        private Label lbl_precio;
        private Label label5;
        private Label lbl_movimiento;
        private Label lbl_autor;
        private Label lbl_titulo;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}