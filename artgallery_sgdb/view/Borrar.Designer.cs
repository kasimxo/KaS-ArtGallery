namespace artgallery_sgdb.view
{
    partial class Borrar
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
            btn_borrar = new Button();
            btn_cancelar = new Button();
            lbl_confirmacion = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btn_borrar
            // 
            btn_borrar.Location = new Point(307, 195);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(75, 23);
            btn_borrar.TabIndex = 0;
            btn_borrar.Text = "Borrar";
            toolTip1.SetToolTip(btn_borrar, "Borrar obra");
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(12, 198);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            toolTip1.SetToolTip(btn_cancelar, "Cancelar");
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // lbl_confirmacion
            // 
            lbl_confirmacion.Location = new Point(12, 23);
            lbl_confirmacion.Name = "lbl_confirmacion";
            lbl_confirmacion.Size = new Size(377, 157);
            lbl_confirmacion.TabIndex = 2;
            lbl_confirmacion.Text = "¿Está seguro ?";
            toolTip1.SetToolTip(lbl_confirmacion, "¿Seguro que quiere borrar la obra?");
            // 
            // Borrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 230);
            Controls.Add(lbl_confirmacion);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_borrar);
            Name = "Borrar";
            Text = "Borrar";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_borrar;
        private Button btn_cancelar;
        private Label lbl_confirmacion;
        private ToolTip toolTip1;
    }
}