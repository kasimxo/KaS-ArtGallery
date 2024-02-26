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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            btn_registrar = new Button();
            btn_limpiar = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            lvl_password = new Label();
            lvl_username = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(195, 147);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(75, 23);
            btn_registrar.TabIndex = 12;
            btn_registrar.Text = "Registrar";
            toolTip1.SetToolTip(btn_registrar, "Botón ");
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(57, 147);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(75, 23);
            btn_limpiar.TabIndex = 11;
            btn_limpiar.Text = "Cancelar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(170, 88);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(100, 23);
            txt_password.TabIndex = 10;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(170, 32);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(100, 23);
            txt_username.TabIndex = 9;
            // 
            // lvl_password
            // 
            lvl_password.AutoSize = true;
            lvl_password.Location = new Point(55, 91);
            lvl_password.Name = "lvl_password";
            lvl_password.Size = new Size(67, 15);
            lvl_password.TabIndex = 8;
            lvl_password.Text = "Contraseña";
            // 
            // lvl_username
            // 
            lvl_username.AutoSize = true;
            lvl_username.Location = new Point(55, 40);
            lvl_username.Name = "lvl_username";
            lvl_username.Size = new Size(109, 15);
            lvl_username.TabIndex = 7;
            lvl_username.Text = "Nombre de usuario";
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 295);
            Controls.Add(btn_registrar);
            Controls.Add(btn_limpiar);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(lvl_password);
            Controls.Add(lvl_username);
            Name = "RegForm";
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
    }
}