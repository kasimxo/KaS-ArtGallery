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
            dataGridView1 = new DataGridView();
            btn_visualizar = new Button();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            tabPage1 = new TabPage();
            btn_insertar = new Button();
            btn_borrar = new Button();
            btn_modificar = new Button();
            lbl2 = new Label();
            lbl1 = new Label();
            txt_box2 = new TextBox();
            txt_box1 = new TextBox();
            button2 = new Button();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(637, 179);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_ActivarOpciones;
            // 
            // btn_visualizar
            // 
            btn_visualizar.Location = new Point(672, 221);
            btn_visualizar.Name = "btn_visualizar";
            btn_visualizar.Size = new Size(75, 23);
            btn_visualizar.TabIndex = 1;
            btn_visualizar.Text = "Visualizar";
            btn_visualizar.UseVisualStyleBackColor = true;
            btn_visualizar.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(9, 9);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(782, 429);
            tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(774, 401);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Visualizador";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_insertar);
            tabPage1.Controls.Add(btn_borrar);
            tabPage1.Controls.Add(btn_modificar);
            tabPage1.Controls.Add(lbl2);
            tabPage1.Controls.Add(lbl1);
            tabPage1.Controls.Add(txt_box2);
            tabPage1.Controls.Add(txt_box1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(btn_visualizar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(774, 401);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gestión inventario";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_insertar
            // 
            btn_insertar.Location = new Point(672, 308);
            btn_insertar.Name = "btn_insertar";
            btn_insertar.Size = new Size(75, 23);
            btn_insertar.TabIndex = 9;
            btn_insertar.Text = "Insertar";
            btn_insertar.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            btn_borrar.Enabled = false;
            btn_borrar.Location = new Point(672, 279);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(75, 23);
            btn_borrar.TabIndex = 8;
            btn_borrar.Text = "Borrar";
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.Enabled = false;
            btn_modificar.Location = new Point(672, 250);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(75, 23);
            btn_modificar.TabIndex = 7;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(77, 64);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(33, 15);
            lbl2.TabIndex = 6;
            lbl2.Text = "Cosa";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(77, 30);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(51, 15);
            lbl1.TabIndex = 5;
            lbl1.Text = "Nombre";
            // 
            // txt_box2
            // 
            txt_box2.Location = new Point(134, 56);
            txt_box2.Name = "txt_box2";
            txt_box2.Size = new Size(372, 23);
            txt_box2.TabIndex = 4;
            // 
            // txt_box1
            // 
            txt_box1.Location = new Point(134, 22);
            txt_box1.Name = "txt_box1";
            txt_box1.Size = new Size(372, 23);
            txt_box1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(535, 26);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Insertar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(774, 401);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Informes";
            tabPage2.UseVisualStyleBackColor = true;
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
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_visualizar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txt_box1;
        private Button button2;
        private TextBox txt_box2;
        private Label lbl1;
        private Label lbl2;
        private TabPage tabPage3;
        private Button btn_insertar;
        private Button btn_borrar;
        private Button btn_modificar;
    }
}