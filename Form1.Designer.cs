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
            this.btnEliminarTodos = new System.Windows.Forms.Button();
            this.btnOrdenarPrecio = new System.Windows.Forms.Button();
            this.btnBuscarMuebles = new System.Windows.Forms.Button();
            this.dgMuebles = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarMueble = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMuebles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(145, 46);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(132, 22);
            this.tbCodigo.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(145, 105);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(132, 22);
            this.tbNombre.TabIndex = 5;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(145, 158);
            this.tbStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(132, 22);
            this.tbStock.TabIndex = 6;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(145, 212);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(132, 22);
            this.tbPrecio.TabIndex = 7;
            // 
            // btnRegistrarMuebles
            // 
            this.btnRegistrarMuebles.Location = new System.Drawing.Point(320, 43);
            this.btnRegistrarMuebles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarMuebles.Name = "btnRegistrarMuebles";
            this.btnRegistrarMuebles.Size = new System.Drawing.Size(149, 28);
            this.btnRegistrarMuebles.TabIndex = 8;
            this.btnRegistrarMuebles.Text = "Registrar Muebles";
            this.btnRegistrarMuebles.UseVisualStyleBackColor = true;
            this.btnRegistrarMuebles.Click += new System.EventHandler(this.btnRegistrarMuebles_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(320, 102);
            this.btnMostrarTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(149, 28);
            this.btnMostrarTodos.TabIndex = 9;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnEliminarTodos
            // 
            this.btnEliminarTodos.Location = new System.Drawing.Point(320, 209);
            this.btnEliminarTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarTodos.Name = "btnEliminarTodos";
            this.btnEliminarTodos.Size = new System.Drawing.Size(149, 28);
            this.btnEliminarTodos.TabIndex = 11;
            this.btnEliminarTodos.Text = "Eliminar Todos";
            this.btnEliminarTodos.UseVisualStyleBackColor = true;
            this.btnEliminarTodos.Click += new System.EventHandler(this.btnEliminarTodos_Click);
            // 
            // btnOrdenarPrecio
            // 
            this.btnOrdenarPrecio.Location = new System.Drawing.Point(493, 43);
            this.btnOrdenarPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdenarPrecio.Name = "btnOrdenarPrecio";
            this.btnOrdenarPrecio.Size = new System.Drawing.Size(211, 28);
            this.btnOrdenarPrecio.TabIndex = 12;
            this.btnOrdenarPrecio.Text = "Ordenar Muebles por Precio";
            this.btnOrdenarPrecio.UseVisualStyleBackColor = true;
            this.btnOrdenarPrecio.Click += new System.EventHandler(this.btnOrdenarPrecio_Click);
            // 
            // btnBuscarMuebles
            // 
            this.btnBuscarMuebles.Location = new System.Drawing.Point(493, 102);
            this.btnBuscarMuebles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarMuebles.Name = "btnBuscarMuebles";
            this.btnBuscarMuebles.Size = new System.Drawing.Size(211, 28);
            this.btnBuscarMuebles.TabIndex = 13;
            this.btnBuscarMuebles.Text = "Buscar Muebles por Nombre";
            this.btnBuscarMuebles.UseVisualStyleBackColor = true;
            this.btnBuscarMuebles.Click += new System.EventHandler(this.btnBuscarMuebles_Click_1);
            // 
            // dgMuebles
            // 
            this.dgMuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMuebles.Location = new System.Drawing.Point(45, 256);
            this.dgMuebles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgMuebles.Name = "dgMuebles";
            this.dgMuebles.RowHeadersWidth = 51;
            this.dgMuebles.Size = new System.Drawing.Size(657, 185);
            this.dgMuebles.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 464);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total de Registros:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 494);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total de Stock:";
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(232, 464);
            this.lblTotalRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(14, 16);
            this.lblTotalRegistros.TabIndex = 19;
            this.lblTotalRegistros.Text = "0";
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Location = new System.Drawing.Point(232, 494);
            this.lblTotalStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(14, 16);
            this.lblTotalStock.TabIndex = 20;
            this.lblTotalStock.Text = "0";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(729, 105);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(132, 22);
            this.tbBuscar.TabIndex = 21;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(531, 454);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(171, 28);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar DataGridView";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(763, 494);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarMueble
            // 
            this.btnEliminarMueble.Location = new System.Drawing.Point(320, 155);
            this.btnEliminarMueble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarMueble.Name = "btnEliminarMueble";
            this.btnEliminarMueble.Size = new System.Drawing.Size(149, 28);
            this.btnEliminarMueble.TabIndex = 24;
            this.btnEliminarMueble.Text = "Eliminar Mueble";
            this.btnEliminarMueble.UseVisualStyleBackColor = true;
            this.btnEliminarMueble.Click += new System.EventHandler(this.btnEliminarMueble_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 533);
            this.Controls.Add(this.btnEliminarMueble);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.lblTotalStock);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgMuebles);
            this.Controls.Add(this.btnBuscarMuebles);
            this.Controls.Add(this.btnOrdenarPrecio);
            this.Controls.Add(this.btnEliminarTodos);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnEliminarTodos;
        private System.Windows.Forms.Button btnOrdenarPrecio;
        private System.Windows.Forms.Button btnBuscarMuebles;
        private System.Windows.Forms.DataGridView dgMuebles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminarMueble;
    }
}

