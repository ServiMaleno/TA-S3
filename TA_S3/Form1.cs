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
            muebleService.Registrar(mueble);
            bool registrado = muebleService.Registrar(mueble);

            if (registrado == false)
            {
                MessageBox.Show("Código ya registrado");
                return;
            }
            //cierre
        }
    }
}
