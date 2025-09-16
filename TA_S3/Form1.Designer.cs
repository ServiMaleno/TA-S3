namespace TA_S3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.btnRegistrarMuebles = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnEliminarMueble = new System.Windows.Forms.Button();
            this.btnEliminarTodos = new System.Windows.Forms.Button();
            this.btnOrdenarPrecio = new System.Windows.Forms.Button();
            this.btnBuscarMuebles = new System.Windows.Forms.Button();
            this.btnMostrarRegistrados = new System.Windows.Forms.Button();
            this.btnMostrarStock = new System.Windows.Forms.Button();
            this.dgMuebles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgMuebles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(109, 37);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(109, 85);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(109, 128);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(100, 20);
            this.tbStock.TabIndex = 6;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(109, 172);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 7;
            // 
            // btnRegistrarMuebles
            // 
            this.btnRegistrarMuebles.Location = new System.Drawing.Point(240, 35);
            this.btnRegistrarMuebles.Name = "btnRegistrarMuebles";
            this.btnRegistrarMuebles.Size = new System.Drawing.Size(112, 23);
            this.btnRegistrarMuebles.TabIndex = 8;
            this.btnRegistrarMuebles.Text = "Registrar Muebles";
            this.btnRegistrarMuebles.UseVisualStyleBackColor = true;
            this.btnRegistrarMuebles.Click += new System.EventHandler(this.btnRegistrarMuebles_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(240, 83);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(112, 23);
            this.btnMostrarTodos.TabIndex = 9;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMueble
            // 
            this.btnEliminarMueble.Location = new System.Drawing.Point(240, 126);
            this.btnEliminarMueble.Name = "btnEliminarMueble";
            this.btnEliminarMueble.Size = new System.Drawing.Size(112, 23);
            this.btnEliminarMueble.TabIndex = 10;
            this.btnEliminarMueble.Text = "Eliminar un Mueble";
            this.btnEliminarMueble.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTodos
            // 
            this.btnEliminarTodos.Location = new System.Drawing.Point(240, 170);
            this.btnEliminarTodos.Name = "btnEliminarTodos";
            this.btnEliminarTodos.Size = new System.Drawing.Size(112, 23);
            this.btnEliminarTodos.TabIndex = 11;
            this.btnEliminarTodos.Text = "Eliminar Todos";
            this.btnEliminarTodos.UseVisualStyleBackColor = true;
            // 
            // btnOrdenarPrecio
            // 
            this.btnOrdenarPrecio.Location = new System.Drawing.Point(370, 35);
            this.btnOrdenarPrecio.Name = "btnOrdenarPrecio";
            this.btnOrdenarPrecio.Size = new System.Drawing.Size(158, 23);
            this.btnOrdenarPrecio.TabIndex = 12;
            this.btnOrdenarPrecio.Text = "Ordenar Muebles por Precio";
            this.btnOrdenarPrecio.UseVisualStyleBackColor = true;
            // 
            // btnBuscarMuebles
            // 
            this.btnBuscarMuebles.Location = new System.Drawing.Point(370, 83);
            this.btnBuscarMuebles.Name = "btnBuscarMuebles";
            this.btnBuscarMuebles.Size = new System.Drawing.Size(158, 23);
            this.btnBuscarMuebles.TabIndex = 13;
            this.btnBuscarMuebles.Text = "Buscar Muebles por Nombre";
            this.btnBuscarMuebles.UseVisualStyleBackColor = true;
            // 
            // btnMostrarRegistrados
            // 
            this.btnMostrarRegistrados.Location = new System.Drawing.Point(370, 126);
            this.btnMostrarRegistrados.Name = "btnMostrarRegistrados";
            this.btnMostrarRegistrados.Size = new System.Drawing.Size(158, 23);
            this.btnMostrarRegistrados.TabIndex = 14;
            this.btnMostrarRegistrados.Text = "Mostrar Muebles Registrados";
            this.btnMostrarRegistrados.UseVisualStyleBackColor = true;
            this.btnMostrarRegistrados.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnMostrarStock
            // 
            this.btnMostrarStock.Location = new System.Drawing.Point(370, 170);
            this.btnMostrarStock.Name = "btnMostrarStock";
            this.btnMostrarStock.Size = new System.Drawing.Size(158, 23);
            this.btnMostrarStock.TabIndex = 15;
            this.btnMostrarStock.Text = "Mostrar Muebles en Stock";
            this.btnMostrarStock.UseVisualStyleBackColor = true;
            // 
            // dgMuebles
            // 
            this.dgMuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMuebles.Location = new System.Drawing.Point(35, 219);
            this.dgMuebles.Name = "dgMuebles";
            this.dgMuebles.RowHeadersWidth = 51;
            this.dgMuebles.Size = new System.Drawing.Size(493, 150);
            this.dgMuebles.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 396);
            this.Controls.Add(this.dgMuebles);
            this.Controls.Add(this.btnMostrarStock);
            this.Controls.Add(this.btnMostrarRegistrados);
            this.Controls.Add(this.btnBuscarMuebles);
            this.Controls.Add(this.btnOrdenarPrecio);
            this.Controls.Add(this.btnEliminarTodos);
            this.Controls.Add(this.btnEliminarMueble);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnRegistrarMuebles);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Inventario de Tienda de Muebles";
            ((System.ComponentModel.ISupportInitialize)(this.dgMuebles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Button btnRegistrarMuebles;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnEliminarMueble;
        private System.Windows.Forms.Button btnEliminarTodos;
        private System.Windows.Forms.Button btnOrdenarPrecio;
        private System.Windows.Forms.Button btnBuscarMuebles;
        private System.Windows.Forms.Button btnMostrarRegistrados;
        private System.Windows.Forms.Button btnMostrarStock;
        private System.Windows.Forms.DataGridView dgMuebles;
    }
}

