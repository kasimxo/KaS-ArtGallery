namespace artgallery_sgdb.view
{
    partial class Obra
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_titulo = new TextBox();
            txt_precio = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            btn_modificar = new Button();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            cb_movimientos = new ComboBox();
            cb_artistas = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 44);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 73);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Movimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 102);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // txt_titulo
            // 
            txt_titulo.Location = new Point(475, 12);
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(146, 23);
            txt_titulo.TabIndex = 4;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(475, 99);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(146, 23);
            txt_precio.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imgNotFound;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 347);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 9;
            label5.Text = "Imagen";
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(284, 350);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(75, 23);
            btn_modificar.TabIndex = 10;
            btn_modificar.Text = "Cargar";
            btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(12, 415);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 11;
            btn_cancelar.Text = "Cancelar";
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
            // 
            // cb_artistas
            // 
            cb_artistas.FormattingEnabled = true;
            cb_artistas.Location = new Point(475, 41);
            cb_artistas.Name = "cb_artistas";
            cb_artistas.Size = new Size(146, 23);
            cb_artistas.TabIndex = 14;
            // 
            // Obra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_artistas);
            Controls.Add(cb_movimientos);
            Controls.Add(btn_guardar);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_modificar);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(txt_precio);
            Controls.Add(txt_titulo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Obra";
            Text = "Obra";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label5;
        private Button btn_modificar;
        private Button btn_cancelar;
        private Button btn_guardar;
        private ComboBox cb_movimientos;
        private ComboBox cb_artistas;
    }
}