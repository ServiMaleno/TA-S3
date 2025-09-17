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

        private void button7_Click(object sender, EventArgs e)
        {
            //Botón Mostrar Cantidad Total de Muebles Registrados
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
                Codigo = int.Parse(tbCodigo.Text),
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

        private void btnEliminarMueble_Click(object sender, EventArgs e)
        {
            // Validación de seleccion e fila
            if (dgMuebles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccionar un registro para eliminar");
                return;
            }
            //Obtener código
            String codigo = dgMuebles.SelectedRows[0].Cells[0].Value.ToString();

            //eliminar código
            muebleService.Eliminar(codigo);

            // Mostrar nuevamente
            MostrarMuebles(muebleService.ListarTodo());

        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            //mostrar lista
            MostrarMuebles(muebleService.ListarTodo());
            limpiarCampos();
            tbCodigo.Focus();
        }
    }
}
