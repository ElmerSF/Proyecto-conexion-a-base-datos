namespace Tarea2_ElmerSalazar_304260158.Ventanas_o_Formularios
{
    partial class Regis_Cajeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regis_Cajeros));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_PrimApellido = new System.Windows.Forms.TextBox();
            this.txt_SegApellido = new System.Windows.Forms.TextBox();
            this.txt_NCaja = new System.Windows.Forms.TextBox();
            this.btn_RegisCajero = new System.Windows.Forms.Button();
            this.Info_usuario = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para ingresar un nuevo registro de cajero por favor ingrese la siguiente informac" +
    "ión:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificación";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primer Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Segundo Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "N° de Caja Asignada";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(271, 98);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(350, 34);
            this.txt_Id.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(270, 152);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(351, 34);
            this.txt_Nombre.TabIndex = 7;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Nombre_TextChanged);
            // 
            // txt_PrimApellido
            // 
            this.txt_PrimApellido.Location = new System.Drawing.Point(269, 207);
            this.txt_PrimApellido.Name = "txt_PrimApellido";
            this.txt_PrimApellido.Size = new System.Drawing.Size(352, 34);
            this.txt_PrimApellido.TabIndex = 8;
            // 
            // txt_SegApellido
            // 
            this.txt_SegApellido.Location = new System.Drawing.Point(269, 263);
            this.txt_SegApellido.Name = "txt_SegApellido";
            this.txt_SegApellido.Size = new System.Drawing.Size(352, 34);
            this.txt_SegApellido.TabIndex = 9;
            // 
            // txt_NCaja
            // 
            this.txt_NCaja.Location = new System.Drawing.Point(309, 335);
            this.txt_NCaja.Name = "txt_NCaja";
            this.txt_NCaja.Size = new System.Drawing.Size(124, 34);
            this.txt_NCaja.TabIndex = 10;
            // 
            // btn_RegisCajero
            // 
            this.btn_RegisCajero.Location = new System.Drawing.Point(505, 313);
            this.btn_RegisCajero.Name = "btn_RegisCajero";
            this.btn_RegisCajero.Size = new System.Drawing.Size(199, 38);
            this.btn_RegisCajero.TabIndex = 11;
            this.btn_RegisCajero.Text = "Registrar";
            this.btn_RegisCajero.UseVisualStyleBackColor = true;
            this.btn_RegisCajero.Click += new System.EventHandler(this.btn_RegisCajero_Click);
            // 
            // Info_usuario
            // 
            this.Info_usuario.AutoSize = true;
            this.Info_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Info_usuario.Location = new System.Drawing.Point(137, 420);
            this.Info_usuario.Name = "Info_usuario";
            this.Info_usuario.Size = new System.Drawing.Size(178, 26);
            this.Info_usuario.TabIndex = 12;
            this.Info_usuario.Text = "Estado del proceso";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Location = new System.Drawing.Point(510, 372);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(194, 33);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Nuevo Registro";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(638, 51);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(118, 47);
            this.btn_Cerrar.TabIndex = 14;
            this.btn_Cerrar.Text = "&Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Regis_Cajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 455);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Info_usuario);
            this.Controls.Add(this.btn_RegisCajero);
            this.Controls.Add(this.txt_NCaja);
            this.Controls.Add(this.txt_SegApellido);
            this.Controls.Add(this.txt_PrimApellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Regis_Cajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Cajeros";
            this.Load += new System.EventHandler(this.Regis_Cajeros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_PrimApellido;
        private System.Windows.Forms.TextBox txt_SegApellido;
        private System.Windows.Forms.TextBox txt_NCaja;
        private System.Windows.Forms.Button btn_RegisCajero;
        private System.Windows.Forms.Label Info_usuario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}