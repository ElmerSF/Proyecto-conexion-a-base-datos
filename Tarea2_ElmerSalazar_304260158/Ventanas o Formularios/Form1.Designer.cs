namespace Tarea2_ElmerSalazar_304260158
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCajerosRegistradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarCategoríasRegistradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registradosDeUnaCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registradosSinImportarCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRegistroToolStripMenuItem,
            this.mostrarInformaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoRegistroToolStripMenuItem
            // 
            this.nuevoRegistroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeCajerosToolStripMenuItem,
            this.registroDeCategoríasToolStripMenuItem,
            this.registroDeProductosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.nuevoRegistroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoRegistroToolStripMenuItem.Name = "nuevoRegistroToolStripMenuItem";
            this.nuevoRegistroToolStripMenuItem.Size = new System.Drawing.Size(130, 25);
            this.nuevoRegistroToolStripMenuItem.Text = "&Nuevo Registro";
            // 
            // registroDeCajerosToolStripMenuItem
            // 
            this.registroDeCajerosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeCajerosToolStripMenuItem.Image")));
            this.registroDeCajerosToolStripMenuItem.Name = "registroDeCajerosToolStripMenuItem";
            this.registroDeCajerosToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.registroDeCajerosToolStripMenuItem.Text = "Registro de Ca&jeros";
            this.registroDeCajerosToolStripMenuItem.Click += new System.EventHandler(this.registroDeCajerosToolStripMenuItem_Click);
            // 
            // registroDeCategoríasToolStripMenuItem
            // 
            this.registroDeCategoríasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeCategoríasToolStripMenuItem.Image")));
            this.registroDeCategoríasToolStripMenuItem.Name = "registroDeCategoríasToolStripMenuItem";
            this.registroDeCategoríasToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.registroDeCategoríasToolStripMenuItem.Text = "Registro de Ca&tegorías";
            this.registroDeCategoríasToolStripMenuItem.Click += new System.EventHandler(this.registroDeCategoríasToolStripMenuItem_Click);
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeProductosToolStripMenuItem.Image")));
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.registroDeProductosToolStripMenuItem.Text = "Registro de &Productos";
            this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.registroDeProductosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mostrarInformaciónToolStripMenuItem
            // 
            this.mostrarInformaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarCajerosRegistradosToolStripMenuItem,
            this.mostrarCategoríasRegistradasToolStripMenuItem,
            this.mostrarProductosToolStripMenuItem});
            this.mostrarInformaciónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarInformaciónToolStripMenuItem.Name = "mostrarInformaciónToolStripMenuItem";
            this.mostrarInformaciónToolStripMenuItem.Size = new System.Drawing.Size(165, 25);
            this.mostrarInformaciónToolStripMenuItem.Text = "&Mostrar Información";
            // 
            // mostrarCajerosRegistradosToolStripMenuItem
            // 
            this.mostrarCajerosRegistradosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mostrarCajerosRegistradosToolStripMenuItem.Image")));
            this.mostrarCajerosRegistradosToolStripMenuItem.Name = "mostrarCajerosRegistradosToolStripMenuItem";
            this.mostrarCajerosRegistradosToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.mostrarCajerosRegistradosToolStripMenuItem.Text = "Mostrar Ca&jeros Registrados";
            this.mostrarCajerosRegistradosToolStripMenuItem.Click += new System.EventHandler(this.mostrarCajerosRegistradosToolStripMenuItem_Click);
            // 
            // mostrarCategoríasRegistradasToolStripMenuItem
            // 
            this.mostrarCategoríasRegistradasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mostrarCategoríasRegistradasToolStripMenuItem.Image")));
            this.mostrarCategoríasRegistradasToolStripMenuItem.Name = "mostrarCategoríasRegistradasToolStripMenuItem";
            this.mostrarCategoríasRegistradasToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.mostrarCategoríasRegistradasToolStripMenuItem.Text = "Mostrar Ca&tegorías Registradas";
            this.mostrarCategoríasRegistradasToolStripMenuItem.Click += new System.EventHandler(this.mostrarCategoríasRegistradasToolStripMenuItem_Click);
            // 
            // mostrarProductosToolStripMenuItem
            // 
            this.mostrarProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registradosDeUnaCategoríaToolStripMenuItem,
            this.registradosSinImportarCategoríaToolStripMenuItem});
            this.mostrarProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mostrarProductosToolStripMenuItem.Image")));
            this.mostrarProductosToolStripMenuItem.Name = "mostrarProductosToolStripMenuItem";
            this.mostrarProductosToolStripMenuItem.Size = new System.Drawing.Size(298, 26);
            this.mostrarProductosToolStripMenuItem.Text = "Mostrar &Productos";
            this.mostrarProductosToolStripMenuItem.Click += new System.EventHandler(this.mostrarProductosToolStripMenuItem_Click);
            // 
            // registradosDeUnaCategoríaToolStripMenuItem
            // 
            this.registradosDeUnaCategoríaToolStripMenuItem.Name = "registradosDeUnaCategoríaToolStripMenuItem";
            this.registradosDeUnaCategoríaToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.registradosDeUnaCategoríaToolStripMenuItem.Text = "Registrados de &una Categoría";
            this.registradosDeUnaCategoríaToolStripMenuItem.Click += new System.EventHandler(this.registradosDeUnaCategoríaToolStripMenuItem_Click);
            // 
            // registradosSinImportarCategoríaToolStripMenuItem
            // 
            this.registradosSinImportarCategoríaToolStripMenuItem.Name = "registradosSinImportarCategoríaToolStripMenuItem";
            this.registradosSinImportarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.registradosSinImportarCategoríaToolStripMenuItem.Text = "Registrados si&n importar Categoría";
            this.registradosSinImportarCategoríaToolStripMenuItem.Click += new System.EventHandler(this.registradosSinImportarCategoríaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(40, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supermercado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(501, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "EL BUEN PRECIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "\"Donde su dinero si alcanza de verdad\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 92);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sistema Informático, desarollado por:\r\nElmer Eduardo Salazar Flores (3-0426-0158)" +
    " \r\nEstudiante de la UNED en el curso 830\r\nProgramación avanzada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermercado EL BUEN PRECIO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarInformaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCajerosRegistradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarCategoríasRegistradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registradosDeUnaCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registradosSinImportarCategoríaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

