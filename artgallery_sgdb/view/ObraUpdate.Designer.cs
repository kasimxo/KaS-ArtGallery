namespace artgallery_sgdb.view
{
    partial class ObraUpdate
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
            label3 = new Label();
            label4 = new Label();
            txt_titulo = new TextBox();
            txt_precio = new TextBox();
            picture = new PictureBox();
            label5 = new Label();
            btn_modificar = new Button();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            cb_movimientos = new ComboBox();
            cb_artistas = new ComboBox();
            btn_nuevo_movimiento = new Button();
            btn_nuevo_autor = new Button();
            imagenChooser = new OpenFileDialog();
            fileSystemWatcher1 = new FileSystemWatcher();
            label6 = new Label();
            cb_vendida = new CheckBox();
            lbl_cliente = new Label();
            cb_clientes = new ComboBox();
            calendario = new DateTimePicker();
            lbl_calendario = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Titulo:";
            toolTip1.SetToolTip(label1, "Titulo");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 44);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Autor:";
            toolTip1.SetToolTip(label2, "Autor");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 73);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Movimiento:";
            toolTip1.SetToolTip(label3, "Movimiento");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 102);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            toolTip1.SetToolTip(label4, "Precio");
            // 
            // txt_titulo
            // 
            txt_titulo.Location = new Point(475, 12);
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(146, 23);
            txt_titulo.TabIndex = 4;
            toolTip1.SetToolTip(txt_titulo, "Titulo de la obra");
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(475, 99);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(146, 23);
            txt_precio.TabIndex = 7;
            toolTip1.SetToolTip(txt_precio, "Precio de la obra");
            // 
            // picture
            // 
            picture.Image = Properties.Resources.imgNotFound;
            picture.Location = new Point(12, 12);
            picture.Name = "picture";
            picture.Size = new Size(347, 332);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 8;
            picture.TabStop = false;
            toolTip1.SetToolTip(picture, "Imagen de la obra");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 347);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 9;
            label5.Text = "Imagen";
            toolTip1.SetToolTip(label5, "Imagen");
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(284, 350);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(75, 23);
            btn_modificar.TabIndex = 10;
            btn_modificar.Text = "Cargar";
            toolTip1.SetToolTip(btn_modificar, "Seleccionar archivo imagen");
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_cargarImagen_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(12, 415);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 11;
            btn_cancelar.Text = "Cancelar";
            toolTip1.SetToolTip(btn_cancelar, "Cancelar");
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(713, 415);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 12;
            btn_guardar.Text = "Guardar";
            toolTip1.SetToolTip(btn_guardar, "Registrar cambios");
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // cb_movimientos
            // 
            cb_movimientos.FormattingEnabled = true;
            cb_movimientos.Location = new Point(475, 70);
            cb_movimientos.Name = "cb_movimientos";
            cb_movimientos.Size = new Size(146, 23);
            cb_movimientos.TabIndex = 13;
            toolTip1.SetToolTip(cb_movimientos, "Selecciona el movimiento de la obra");
            // 
            // cb_artistas
            // 
            cb_artistas.FormattingEnabled = true;
            cb_artistas.Location = new Point(475, 41);
            cb_artistas.Name = "cb_artistas";
            cb_artistas.Size = new Size(146, 23);
            cb_artistas.TabIndex = 14;
            toolTip1.SetToolTip(cb_artistas, "Selecciona al autor de la obra");
            // 
            // btn_nuevo_movimiento
            // 
            btn_nuevo_movimiento.Location = new Point(643, 69);
            btn_nuevo_movimiento.Name = "btn_nuevo_movimiento";
            btn_nuevo_movimiento.Size = new Size(145, 23);
            btn_nuevo_movimiento.TabIndex = 18;
            btn_nuevo_movimiento.Text = "Nuevo movimiento";
            toolTip1.SetToolTip(btn_nuevo_movimiento, "Registrar nuevo movimiento");
            btn_nuevo_movimiento.UseVisualStyleBackColor = true;
            btn_nuevo_movimiento.Click += btn_nuevo_movimiento_Click;
            // 
            // btn_nuevo_autor
            // 
            btn_nuevo_autor.Location = new Point(643, 40);
            btn_nuevo_autor.Name = "btn_nuevo_autor";
            btn_nuevo_autor.Size = new Size(145, 23);
            btn_nuevo_autor.TabIndex = 17;
            btn_nuevo_autor.Text = "Nuevo autor";
            toolTip1.SetToolTip(btn_nuevo_autor, "Registrar un nuevo artista");
            btn_nuevo_autor.UseVisualStyleBackColor = true;
            btn_nuevo_autor.Click += btn_nuevo_autor_Click;
            // 
            // imagenChooser
            // 
            imagenChooser.FileName = "imagenChooser";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(378, 129);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 19;
            label6.Text = "Vendida:";
            toolTip1.SetToolTip(label6, "Vendida");
            // 
            // cb_vendida
            // 
            cb_vendida.AutoSize = true;
            cb_vendida.Location = new Point(475, 128);
            cb_vendida.Name = "cb_vendida";
            cb_vendida.Size = new Size(15, 14);
            cb_vendida.TabIndex = 20;
            toolTip1.SetToolTip(cb_vendida, "¿Está vendida la obra? Si/No");
            cb_vendida.UseVisualStyleBackColor = true;
            cb_vendida.CheckedChanged += cb_vendida_CheckedChanged;
            // 
            // lbl_cliente
            // 
            lbl_cliente.AutoSize = true;
            lbl_cliente.Location = new Point(378, 154);
            lbl_cliente.Name = "lbl_cliente";
            lbl_cliente.Size = new Size(47, 15);
            lbl_cliente.TabIndex = 21;
            lbl_cliente.Text = "Cliente:";
            toolTip1.SetToolTip(lbl_cliente, "Cliente");
            lbl_cliente.Visible = false;
            // 
            // cb_clientes
            // 
            cb_clientes.FormattingEnabled = true;
            cb_clientes.Location = new Point(475, 148);
            cb_clientes.Name = "cb_clientes";
            cb_clientes.Size = new Size(146, 23);
            cb_clientes.TabIndex = 22;
            toolTip1.SetToolTip(cb_clientes, "Comprador de la obra");
            cb_clientes.Visible = false;
            // 
            // calendario
            // 
            calendario.Location = new Point(475, 177);
            calendario.Name = "calendario";
            calendario.Size = new Size(212, 23);
            calendario.TabIndex = 23;
            toolTip1.SetToolTip(calendario, "Fecha en la que se produjo la venta");
            calendario.Visible = false;
            // 
            // lbl_calendario
            // 
            lbl_calendario.AutoSize = true;
            lbl_calendario.Location = new Point(378, 183);
            lbl_calendario.Name = "lbl_calendario";
            lbl_calendario.Size = new Size(89, 15);
            lbl_calendario.TabIndex = 24;
            lbl_calendario.Text = "Fecha de venta:";
            toolTip1.SetToolTip(lbl_calendario, "Fecha de venta");
            lbl_calendario.Visible = false;
            // 
            // ObraUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_calendario);
            Controls.Add(calendario);
            Controls.Add(cb_clientes);
            Controls.Add(lbl_cliente);
            Controls.Add(cb_vendida);
            Controls.Add(label6);
            Controls.Add(btn_nuevo_movimiento);
            Controls.Add(btn_nuevo_autor);
            Controls.Add(cb_artistas);
            Controls.Add(cb_movimientos);
            Controls.Add(btn_guardar);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_modificar);
            Controls.Add(label5);
            Controls.Add(picture);
            Controls.Add(txt_precio);
            Controls.Add(txt_titulo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ObraUpdate";
            Text = "Obra";
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_titulo;
        private TextBox txt_precio;
        private PictureBox picture;
        private Label label5;
        private Button btn_modificar;
        private Button btn_cancelar;
        private Button btn_guardar;
        private ComboBox cb_movimientos;
        private ComboBox cb_artistas;
        private Button btn_nuevo_movimiento;
        private Button btn_nuevo_autor;
        private OpenFileDialog imagenChooser;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label6;
        private CheckBox cb_vendida;
        private Label lbl_cliente;
        private ComboBox cb_clientes;
        private Label lbl_calendario;
        private DateTimePicker calendario;
        private ToolTip toolTip1;
    }
}