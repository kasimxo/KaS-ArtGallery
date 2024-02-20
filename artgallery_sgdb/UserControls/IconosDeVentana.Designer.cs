namespace artgallery_sgdb.UserControls {
    partial class IconosDeVentana {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconosDeVentana));
            btn_exit = new Button();
            iconos = new ImageList(components);
            btn_maximize = new Button();
            btn_minimize = new Button();
            SuspendLayout();
            // 
            // btn_exit
            // 
            btn_exit.AutoSize = true;
            btn_exit.BackColor = Color.Transparent;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.ImageIndex = 0;
            btn_exit.ImageList = iconos;
            btn_exit.Location = new Point(64, 0);
            btn_exit.Margin = new Padding(0);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(32, 32);
            btn_exit.TabIndex = 0;
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // iconos
            // 
            iconos.ColorDepth = ColorDepth.Depth8Bit;
            iconos.ImageStream = (ImageListStreamer)resources.GetObject("iconos.ImageStream");
            iconos.TransparentColor = Color.Transparent;
            iconos.Images.SetKeyName(0, "exitProgram.ico");
            iconos.Images.SetKeyName(1, "maximize.ico");
            iconos.Images.SetKeyName(2, "minimize.ico");
            iconos.Images.SetKeyName(3, "resize.ico");
            // 
            // btn_maximize
            // 
            btn_maximize.AutoSize = true;
            btn_maximize.BackColor = Color.Transparent;
            btn_maximize.FlatAppearance.BorderSize = 0;
            btn_maximize.FlatStyle = FlatStyle.Flat;
            btn_maximize.ImageIndex = 1;
            btn_maximize.ImageList = iconos;
            btn_maximize.Location = new Point(32, 0);
            btn_maximize.Margin = new Padding(0);
            btn_maximize.Name = "btn_maximize";
            btn_maximize.Size = new Size(32, 32);
            btn_maximize.TabIndex = 1;
            btn_maximize.UseVisualStyleBackColor = false;
            btn_maximize.Click += btn_maximize_Click;
            // 
            // btn_minimize
            // 
            btn_minimize.AutoSize = true;
            btn_minimize.BackColor = Color.Transparent;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.ImageIndex = 2;
            btn_minimize.ImageList = iconos;
            btn_minimize.Location = new Point(0, 0);
            btn_minimize.Margin = new Padding(0);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(32, 32);
            btn_minimize.TabIndex = 2;
            btn_minimize.UseVisualStyleBackColor = false;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // IconosDeVentana
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_minimize);
            Controls.Add(btn_maximize);
            Controls.Add(btn_exit);
            Margin = new Padding(0);
            Name = "IconosDeVentana";
            Size = new Size(96, 32);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_exit;
        private ImageList iconos;
        private Button btn_maximize;
        private Button btn_minimize;
    }
}
