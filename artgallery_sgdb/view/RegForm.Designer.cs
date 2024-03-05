namespace artgallery_sgdb {
    partial class RegForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            btn_registrar = new Button();
            btn_limpiar = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            lvl_password = new Label();
            lvl_username = new Label();
            toolTip1 = new ToolTip(components);
            txt_password2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cb_rol = new ComboBox();
            SuspendLayout();
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(209, 214);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(75, 23);
            btn_registrar.TabIndex = 12;
            btn_registrar.Text = "Registrar";
            toolTip1.SetToolTip(btn_registrar, "Registrar nuevo usuario");
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(12, 214);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(75, 23);
            btn_limpiar.TabIndex = 11;
            btn_limpiar.Text = "Cancelar";
            toolTip1.SetToolTip(btn_limpiar, "Cancelar");
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(152, 73);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(118, 23);
            txt_password.TabIndex = 10;
            toolTip1.SetToolTip(txt_password, "Introduce aquí tu contraseña");
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(152, 29);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(118, 23);
            txt_username.TabIndex = 9;
            toolTip1.SetToolTip(txt_username, "Introduce aqui tu nombre de usuario");
            // 
            // lvl_password
            // 
            lvl_password.AutoSize = true;
            lvl_password.Location = new Point(23, 73);
            lvl_password.Name = "lvl_password";
            lvl_password.Size = new Size(70, 15);
            lvl_password.TabIndex = 8;
            lvl_password.Text = "Contraseña:";
            toolTip1.SetToolTip(lvl_password, "Contraseña");
            // 
            // lvl_username
            // 
            lvl_username.AutoSize = true;
            lvl_username.Location = new Point(23, 32);
            lvl_username.Name = "lvl_username";
            lvl_username.Size = new Size(112, 15);
            lvl_username.TabIndex = 7;
            lvl_username.Text = "Nombre de usuario:";
            toolTip1.SetToolTip(lvl_username, "Nombre de usuario");
            // 
            // txt_password2
            // 
            txt_password2.Location = new Point(152, 116);
            txt_password2.Name = "txt_password2";
            txt_password2.Size = new Size(118, 23);
            txt_password2.TabIndex = 14;
            toolTip1.SetToolTip(txt_password2, "Introduce aquí tu contraseña");
            txt_password2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 119);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 13;
            label1.Text = "Confirmar contraseña:";
            toolTip1.SetToolTip(label1, "Repetir contraseña");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 160);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 15;
            label2.Text = "Tipo de usuario:";
            toolTip1.SetToolTip(label2, "Tipo de usuario");
            // 
            // cb_rol
            // 
            cb_rol.FormattingEnabled = true;
            cb_rol.Items.AddRange(new object[] { "Cliente", "Administrador" });
            cb_rol.Location = new Point(149, 157);
            cb_rol.Name = "cb_rol";
            cb_rol.Size = new Size(121, 23);
            cb_rol.TabIndex = 16;
            toolTip1.SetToolTip(cb_rol, "Selecciona el tipo de usuario");
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 249);
            Controls.Add(cb_rol);
            Controls.Add(label2);
            Controls.Add(txt_password2);
            Controls.Add(label1);
            Controls.Add(btn_registrar);
            Controls.Add(btn_limpiar);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(lvl_password);
            Controls.Add(lvl_username);
            Name = "RegForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_registrar;
        private Button btn_limpiar;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label lvl_password;
        private Label lvl_username;
        private ToolTip toolTip1;
        private TextBox txt_password2;
        private Label label1;
        private Label label2;
        private ComboBox cb_rol;
    }
}