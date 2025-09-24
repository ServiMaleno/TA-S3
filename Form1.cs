using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA_S3.Entities;
using TA_S3.Services;

namespace TA_S3
{
    public partial class Form1 : Form
    {
        //LLama al MuebleService.cs
        private MuebleService muebleService = new MuebleService();

        public Form1()
        {
            InitializeComponent();
        }

        private void ActualizarGrid(List<Mueble> muebles)
        {
            dgMuebles.DataSource = null;
            dgMuebles.DataSource = muebles;
        }

        private void MostrarMuebles(List<Mueble> muebles)
        {
            //limpiar DataGridView
            dgMuebles.DataSource = null;

            if (muebles.Count == 0)
            {
                lblTotalRegistros.Text = "0";
                lblTotalStock.Text = "0";
                return;
            }
            else
            {
                dgMuebles.DataSource= muebles;
                lblTotalRegistros.Text= muebles.Count.ToString();

                int stockTotal = 0;
                muebles.ForEach(mueble => stockTotal += mueble.Stock);
                lblTotalStock.Text = stockTotal.ToString();
            }
        }


        private void btnRegistrarMuebles_Click(object sender, EventArgs e)
        {
            //Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbStock.Text == "" || tbPrecio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            //Crear el objeto
            Mueble mueble = new Mueble()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
		        Stock = int.Parse(tbStock.Text),
		        Precio = double.Parse(tbPrecio.Text)
	        };

            //Registrar
          
            bool registrado = muebleService.Registrar(mueble);

            if (registrado == false)
            {
                MessageBox.Show("Código ya registrado");
                return;
            }

            // Mostrar
            MostrarMuebles(muebleService.ListarTodo());
            limpiarCampos();           
        }

        public void limpiarCampos()
        {
            tbCodigo.Clear();
            tbNombre.Clear();
            tbStock.Clear();
            tbPrecio.Clear();
            
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            //mostrar lista
            MostrarMuebles(muebleService.ListarTodo());
            limpiarCampos();
            tbCodigo.Focus();
        }

        private void btnBuscarMuebles_Click(object sender, EventArgs e)
        {
           //No disponible, evento sin funcion
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgMuebles.DataSource = null;
        }

        private void btnBuscarMuebles_Click_1(object sender, EventArgs e)
        {
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese el nombre a buscar");
                return;
            }

            String nombre = tbBuscar.Text;

            MostrarMuebles(muebleService.BuscarPorNombre(nombre));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarTodos_Click(object sender, EventArgs e)
        {
            muebleService.EliminarTodos();
            ActualizarGrid(muebleService.ListarTodo());
        }

        private void btnOrdenarPrecio_Click(object sender, EventArgs e)
        {
            List<Mueble> muebles = muebleService.ListarTodo();
            muebles = muebles.OrderByDescending(m => m.Precio).ToList();
            ActualizarGrid(muebles);
        }

        private void btnEliminarMueble_Click(object sender, EventArgs e)
        {
            // Selección de fila
            if (dgMuebles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro a eliminar");
                return;
            }

            String codigo = dgMuebles.SelectedRows[0].Cells[0].Value.ToString();

            muebleService.Eliminar(codigo);

            MostrarMuebles(muebleService.ListarTodo());
        }
    }
}
