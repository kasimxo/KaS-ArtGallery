namespace artgallery_sgdb.view
{
    partial class NuevoAutor
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
            txt_nombre = new TextBox();
            button1 = new Button();
            button2 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            toolTip1.SetToolTip(label1, "Nombre");
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(72, 34);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(200, 23);
            txt_nombre.TabIndex = 1;
            toolTip1.SetToolTip(txt_nombre, "Introduce aqui el nombre del artista");
            // 
            // button1
            // 
            button1.Location = new Point(12, 101);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Cancelar";
            toolTip1.SetToolTip(button1, "Cancelar");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(197, 101);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Registrar";
            toolTip1.SetToolTip(button2, "Registrar nuevo artista");
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NuevoAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 136);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_nombre);
            Controls.Add(label1);
            Name = "NuevoAutor";
            Text = "Registrar Artista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_nombre;
        private Button button1;
        private Button button2;
        private ToolTip toolTip1;
    }
}