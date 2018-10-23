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
    public partial class RMeta : Form
    {
        public static int pas = 0;
        private RepositorioBase<Meta> repositorio;
        public RMeta()
        {
            InitializeComponent();
          
        }
        private void Limpiar()
        {
            errorProvider1.Clear();
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CuotanumericUpDown.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id;
            repositorio = new RepositorioBase<Meta>(new Contexto());
            int.TryParse(IdnumericUpDown.Text, out id);
            if (!ExisteEnLaBaseDeDatos())
            {
                errorProvider1.SetError(IdnumericUpDown, " esta Cuenta no Existe");
                 if (!ExisteEnLaBaseDeDatos())
            {
                errorProvider1.SetError(IdnumericUpDown, " esta Cuenta no Existe");
                    IdnumericUpDown.Focus();
                return;

            }
            if (repositorio.ELiminar(id))
            {
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                return;

            }
            if (repositorio.ELiminar(id))
            {
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Meta>(new Contexto());
            int id = (int)IdnumericUpDown.Value;
            Meta meta;
            bool paso = false;
            meta = LlenaClase();
            if (!GuardarValidar())
                return;
            if (IdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(meta);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar un Tipo de cuenta no Existente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(meta);
            }
            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se Guardo el Tipo De Cuenta!!", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    
        private Meta LlenaClase()
        {
            Meta meta = new Meta();
            meta.idMeta = Convert.ToInt32(IdnumericUpDown.Value);
            meta.descripcion = DescripciontextBox.Text;
            meta.cuota = Convert.ToDouble(CuotanumericUpDown.Value);
            return meta;
        }
        
        private void LlenaCampo(Meta meta)
        {
            IdnumericUpDown.Value = meta.idMeta;
            DescripciontextBox.Text = meta.descripcion;
            CuotanumericUpDown.Value =Convert.ToDecimal( meta.cuota);
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Meta>(new Contexto());
            Meta meta = repositorio.Buscar((int)IdnumericUpDown.Value);
            return (meta != null);
        }
    
        private bool GuardarValidar()
        {
        bool paso = true;
        if (string.IsNullOrEmpty(DescripciontextBox.Text))
        {
            errorProvider1.SetError(DescripciontextBox, "El Campo Descripcion No puede Estar Vacio!");
            DescripciontextBox.Focus();
            paso = false;
        }
        return paso;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            int id;
         
            repositorio = new RepositorioBase<Meta>(new Contexto());
            Meta meta = new Meta();
            int.TryParse(IdnumericUpDown.Text, out id);
            if (meta != null)
            {
                MessageBox.Show("Cuenta Encontrada.!!", "Exito!!!", MessageBoxButtons.OK);
                LlenaCampo(meta);
                
            }
            else
            {
                MessageBox.Show("Cuenta no Encontrada", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
 }

