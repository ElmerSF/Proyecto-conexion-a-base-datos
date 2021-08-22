namespace Tarea2_ElmerSalazar_304260158.Ventanas_o_Formularios
{
    partial class Product_por_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_por_Categoria));
            this.label1 = new System.Windows.Forms.Label();
            this.Comb_Categoria = new System.Windows.Forms.ComboBox();
            this.Area_datos_products = new System.Windows.Forms.DataGridView();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Area_datos_products)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una Categoría para mostrar los Productos";
            // 
            // Comb_Categoria
            // 
            this.Comb_Categoria.FormattingEnabled = true;
            this.Comb_Categoria.Location = new System.Drawing.Point(443, 30);
            this.Comb_Categoria.Name = "Comb_Categoria";
            this.Comb_Categoria.Size = new System.Drawing.Size(285, 28);
            this.Comb_Categoria.TabIndex = 1;
            // 
            // Area_datos_products
            // 
            this.Area_datos_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Area_datos_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Area_datos_products.Location = new System.Drawing.Point(45, 98);
            this.Area_datos_products.Name = "Area_datos_products";
            this.Area_datos_products.Size = new System.Drawing.Size(680, 277);
            this.Area_datos_products.TabIndex = 2;
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(49, 381);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(201, 50);
            this.btn_Mostrar.TabIndex = 3;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(536, 381);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(191, 49);
            this.btn_Cerrar.TabIndex = 4;
            this.btn_Cerrar.Text = "&Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Product_por_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 441);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.Area_datos_products);
            this.Controls.Add(this.Comb_Categoria);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Product_por_Categoria";
            this.Text = "Productos por Categoria";
            this.Load += new System.EventHandler(this.Product_por_Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Area_datos_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Comb_Categoria;
        private System.Windows.Forms.DataGridView Area_datos_products;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}