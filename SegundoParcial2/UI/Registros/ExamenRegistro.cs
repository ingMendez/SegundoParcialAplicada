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

        public List<DetalleVendedor> Detalle { get; set; }
        public ExamenRegistro()
        {
            InitializeComponent();
            this.Detalle = new List<DetalleVendedor>();
            LlenaCombox();
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
        private void Calcular(Meta meta)
        {

        }
        private void LlenaCombox()
        {
            RepositorioBase<Meta> metarepositorio = new RepositorioBase<Meta>(new Contexto());
            CuotacomboBox.DataSource = metarepositorio.GetList(c => true);
            CuotacomboBox.ValueMember = "idMeta";
            CuotacomboBox.DisplayMember = "descripcion";

        }
        private void removerbutton_Click_1(object sender, EventArgs e)
        {
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }
        private void Gualdar_button_Click_1(object sender, EventArgs e)
        {

            //  repositorio = new RepositorioBase<Vendedor>(new Contexto());
            SuperErrorProvider.Clear();
            bool paso = false;
            int id = (int)vendedorIdNumericUpDown.Value;
            // Vendedor vendedor = repositorio.Buscar(id);
            Vendedor vendedor_guardar = LlenaClase();

            if (!GuardarValidar())
                return;

            if (vendedorIdNumericUpDown.Value == 0)
            {
                paso = VendedorBLL.Guardar(vendedor_guardar);
            }
            else
            {
                /*if (GuardarValidar()) ///sim la funcion validar = true entonces guardaame
                {
                    if (repositorio.Guardar(vendedor_guardar))
                    {
                        MessageBox.Show(" Guardado");
                        Limpiar();

                    }


                }*/
                // else
                if (!ExisteEnBaseDeDatos())
                {
                    MessageBox.Show("No Se Puedo Modificar un Vendedor Inexistente!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = VendedorBLL.Modificar(vendedor_guardar);
            }
            if (paso)
            {
                MessageBox.Show("Vendedor Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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
            if (vendedorIdNumericUpDown.Value == 0)
            {
                MessageBox.Show("no se puede eliminar Un Vendedor que no Existe");
                return;
            }
            if (VendedorBLL.Eliminar(id))
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
            vendedor = VendedorBLL.Buscar(id);
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
            //repositorio = new RepositorioBase<Vendedor>(new Contexto());
            Vendedor _vendedor = VendedorBLL.Buscar((int)vendedorIdNumericUpDown.Value);
            return (_vendedor != null);
        }

        private Vendedor LlenaCampo(Vendedor vendedor)
        {
            Convert.ToInt32(vendedorIdNumericUpDown.Value = vendedor.VendedorId);
            nombreTextBox.Text = vendedor.Nombre;
            Convert.ToInt32(retencionNumericUpDown.Value = vendedor.Retencion);
            Convert.ToInt32(sueldoNumericUpDown.Value = vendedor.Sueldo);
            Convert.ToInt32(rotacionNumericUpDown.Value = vendedor.Rotacion);
            CuotaDiaria.Value = Convert.ToDecimal(vendedor.cuotasDiarias);

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
            vendedor.cuotasDiarias = Convert.ToDouble(CuotaDiaria.Value);
            vendedor.Metas = CuotacomboBox.Text;

            return vendedor;
        }

        private void rotacionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            rotacionNumericUpDown.Value = (sueldoNumericUpDown.Value * retencionNumericUpDown.Value) / 100;
        }

        private void retencionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            rotacionNumericUpDown.Value = (sueldoNumericUpDown.Value * retencionNumericUpDown.Value) / 100;
        }

        private void sueldoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            rotacionNumericUpDown.Value = (sueldoNumericUpDown.Value * retencionNumericUpDown.Value) / 100;
        }

        private void Metabutton_Click(object sender, EventArgs e)
        {
            RMeta r = new RMeta();
            r.ShowDialog();
            LlenaCombox();
        }

        private void ExamenRegistro_Load(object sender, EventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {

            if (DetalledataGridView.DataSource != null)
            {
                this.Detalle = (List<DetalleVendedor>)DetalledataGridView.DataSource;
            }
            this.Detalle.Add(
                new DetalleVendedor(
                id: 0,
                idmetas: (int)vendedorIdNumericUpDown.Value,
                Idmeta: CuotacomboBox.SelectedIndex,
                couta: Convert.ToDouble(CuotaDiaria.Value)
                ));
            SuperErrorProvider.Clear();
            CargarGrid();
        }
        public bool agregarmeta()
        {
            bool paso = true;
            if(CuotaDiaria.Value == 0)
            {
                SuperErrorProvider.SetError(CuotaDiaria, "Debe Insertar Por lo menos una cuota");
                CuotaDiaria.Focus();
                paso = false;
            }
            if(CuotacomboBox.SelectedValue == null)
            {
                SuperErrorProvider.SetError(CuotacomboBox, "Debe Insertar Por lo menos una cuota");
                paso = false;
            }
            return paso;
        }
        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalle;

        }

        private void CuotacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenaCombox();
        }

      
    }
}
