namespace artgallery_sgdb.view
{
    partial class NuevoCliente
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
            toolTip1 = new ToolTip(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_nombre = new TextBox();
            txt_apellido1 = new TextBox();
            txt_apellido2 = new TextBox();
            fecha_nac = new DateTimePicker();
            txt_dni = new TextBox();
            txt_tlf = new TextBox();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 39);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            toolTip1.SetToolTip(label1, "Nombre");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 122);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Teléfono:";
            toolTip1.SetToolTip(label2, "Teléfono");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 79);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "DNI/NIE:";
            toolTip1.SetToolTip(label3, "DNI/NIE");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 39);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha de nacimiento:";
            toolTip1.SetToolTip(label4, "Fecha de nacimiento");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 122);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 4;
            label5.Text = "Segundo apellido:";
            toolTip1.SetToolTip(label5, "Segundo apellido");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 79);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 5;
            label6.Text = "Primer apellido:";
            toolTip1.SetToolTip(label6, "Primer apellido");
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(116, 36);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(130, 23);
            txt_nombre.TabIndex = 6;
            toolTip1.SetToolTip(txt_nombre, "Escribe aquí el nombre del cliente");
            // 
            // txt_apellido1
            // 
            txt_apellido1.Location = new Point(116, 76);
            txt_apellido1.Name = "txt_apellido1";
            txt_apellido1.Size = new Size(130, 23);
            txt_apellido1.TabIndex = 7;
            toolTip1.SetToolTip(txt_apellido1, "Escribe aquí el primer apellido del cliente");
            // 
            // txt_apellido2
            // 
            txt_apellido2.Location = new Point(116, 119);
            txt_apellido2.Name = "txt_apellido2";
            txt_apellido2.Size = new Size(130, 23);
            txt_apellido2.TabIndex = 8;
            toolTip1.SetToolTip(txt_apellido2, "Escribe aquí el segundo apellido del cliente");
            // 
            // fecha_nac
            // 
            fecha_nac.Location = new Point(412, 36);
            fecha_nac.Name = "fecha_nac";
            fecha_nac.Size = new Size(147, 23);
            fecha_nac.TabIndex = 9;
            toolTip1.SetToolTip(fecha_nac, "Selecciona la fecha de nacimiento del cliente");
            // 
            // txt_dni
            // 
            txt_dni.Location = new Point(412, 76);
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(130, 23);
            txt_dni.TabIndex = 10;
            toolTip1.SetToolTip(txt_dni, "Escribe aquí el documento de identidad del cliente");
            // 
            // txt_tlf
            // 
            txt_tlf.Location = new Point(412, 119);
            txt_tlf.Name = "txt_tlf";
            txt_tlf.Size = new Size(130, 23);
            txt_tlf.TabIndex = 11;
            toolTip1.SetToolTip(txt_tlf, "Escribe aquí el teléfono de contacto del cliente");
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(12, 191);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 12;
            btn_cancelar.Text = "Cancelar";
            toolTip1.SetToolTip(btn_cancelar, "Cancelar");
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(497, 191);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 13;
            btn_guardar.Text = "Guardar";
            toolTip1.SetToolTip(btn_guardar, "Registrar al nuevo cliente");
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // NuevoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 226);
            Controls.Add(btn_guardar);
            Controls.Add(btn_cancelar);
            Controls.Add(txt_tlf);
            Controls.Add(txt_dni);
            Controls.Add(fecha_nac);
            Controls.Add(txt_apellido2);
            Controls.Add(txt_apellido1);
            Controls.Add(txt_nombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NuevoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolTip toolTip1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_nombre;
        private TextBox txt_apellido1;
        private TextBox txt_apellido2;
        private DateTimePicker fecha_nac;
        private TextBox txt_dni;
        private TextBox txt_tlf;
        private Button btn_cancelar;
        private Button btn_guardar;
    }
}