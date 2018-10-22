using SegundoParcial2.BLL;
using SegundoParcial2.DAL;
using SegundoParcial2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcial2.UI.Registros
{
    public partial class ExamenRegistro : Form
    {
        RepositorioBase<Vendedor> repositorio;
        public ExamenRegistro()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Butones del programa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nuevo_button_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Gualdar_button_Click_1(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Vendedor>(new Contexto());
            SuperErrorProvider.Clear();
            int id = (int)vendedorIdNumericUpDown.Value;
            Vendedor vendedor = repositorio.Buscar(id);
            Vendedor vendedor_guardar = LlenaClase();

            if (vendedor == null)
            {
                if (GuardarValidar()) ///sim la funcion validar = true entonces guardaame
                {
                    if (repositorio.Guardar(vendedor_guardar))
                    {
                        MessageBox.Show(" Guardado");
                        Limpiar();

                    }
                }
            }
            else
            {
                if (GuardarValidar())
                {
                    if (repositorio.Modificar(vendedor_guardar))
                        MessageBox.Show(" Modificado");
                    else
                        MessageBox.Show(" no medificado");
                }



            }
            Nuevo_button.PerformClick();


        }
        private void Elimiinar_button_Click_1(object sender, EventArgs e)
        {
            SuperErrorProvider.Clear();
            int id;
            int.TryParse(vendedorIdNumericUpDown.Text, out id);
            // Vendedor vendedor = BLL.VendedorBLL.Buscar(id);
            if (!ExisteEnBaseDeDatos())
            {
                SuperErrorProvider.SetError(vendedorIdNumericUpDown, "no se pudo eliminar una persona que no existen");
            }
            if (repositorio.ELiminar(id))
            {
                Limpiar();
                MessageBox.Show(" Eliminado");


            }
            else
            {
                MessageBox.Show("No se puede eliminar  que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Nuevo_button.PerformClick();
            }
        }
        private void Buscar_button_Click_1(object sender, EventArgs e)
        {
            SuperErrorProvider.Clear();
            int id;
            Vendedor vendedor = new Vendedor();
            int.TryParse(vendedorIdNumericUpDown.Text, out id);
            vendedor = repositorio.Buscar(id);
            if (vendedor != null)
            {
                MessageBox.Show(" encontrado");
                LlenaCampo(vendedor);

            }
            else
            {
                MessageBox.Show("no encontrado");
                Limpiar();
            }

        }

        /// <summary>
        /// ////metodos  de implementaciones del programa
        /// </summary>
        private void Limpiar()
        {
            vendedorIdNumericUpDown.Value = 0;
            nombreTextBox.Clear();
            sueldoNumericUpDown.Value = 0;
            retencionNumericUpDown.Value = 0;
            rotacionNumericUpDown.Value = 0;
        }

        private bool GuardarValidar()
        {
            bool paso = true;


            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                SuperErrorProvider.SetError(nombreTextBox, "Debe Llenar el campo ");
                paso = false;
            }

            if (sueldoNumericUpDown.Value == 0)
            {
                SuperErrorProvider.SetError(sueldoNumericUpDown, "Falto Digitar ");
                paso = false;
            }
            if (retencionNumericUpDown.Value == 0)
            {
                SuperErrorProvider.SetError(retencionNumericUpDown, "Falto digitar laretencion");
                paso = false;
            }
            if (Fecha_dateTimePicker.Value != DateTime.Now && Fecha_dateTimePicker.Value < DateTime.Now)
            {
                SuperErrorProvider.SetError(Fecha_dateTimePicker, "Debe digitar una fecha mayor");
                paso = false;

            }
            return paso;
        }

        private bool ExisteEnBaseDeDatos()
        {
            repositorio = new RepositorioBase<Vendedor>(new Contexto());
            Vendedor _vendedor = repositorio.Buscar((int)vendedorIdNumericUpDown.Value);
            return (_vendedor != null);
        }

        private Vendedor LlenaCampo(Vendedor vendedor)
        {
            Convert.ToInt32(vendedorIdNumericUpDown.Value = vendedor.VendedorId);
            nombreTextBox.Text = vendedor.Nombre;
            Convert.ToInt32(retencionNumericUpDown.Value = vendedor.Retencion);
            Convert.ToInt32(sueldoNumericUpDown.Value = vendedor.Sueldo);
            Convert.ToInt32(rotacionNumericUpDown.Value = vendedor.Rotacion);


            return vendedor;

        }

        private Vendedor LlenaClase()
        {
            Vendedor vendedor = new Vendedor();

            vendedor.VendedorId = Convert.ToInt32(vendedorIdNumericUpDown.Value);
            vendedor.Nombre = nombreTextBox.Text;
            vendedor.Retencion = Convert.ToInt32(retencionNumericUpDown.Value);
            vendedor.Rotacion = Convert.ToInt32(rotacionNumericUpDown.Value);
            vendedor.Sueldo = Convert.ToInt32(sueldoNumericUpDown.Value);


            return vendedor;
        }

    }
}
