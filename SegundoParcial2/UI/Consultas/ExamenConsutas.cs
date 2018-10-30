using SegundoParcial2.BLL;
using SegundoParcial2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace SegundoParcial2.UI.Consultas
{
    public partial class ExamenConsutas : Form
    {
        RepositorioBase<Vendedor> repositorio;
            public ExamenConsutas()
            {
                InitializeComponent();
            
        }

            private void Label3_Click(object sender, EventArgs e)
            {

            }
            public void Solonumero(KeyPressEventArgs e)
            {
                try
                {
                    if (char.IsNumber(e.KeyChar))
                    {

                        e.Handled = false;
                    }
                    else if (char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }

                }
                catch (Exception)
                {
                    throw;
                }


            }

            private void Consultar_button_Click(object sender, EventArgs e)
            {


                Expression<Func<Vendedor, bool>> filtro = a => true;
                int id;
                switch (Filtro_comboBox.SelectedIndex)
                {
                    case 0: /// todos
                        break;
                    case 1:

                        id = Convert.ToInt32(Criterio_textBox.Text);
                        filtro = a => a.VendedorId == id;
                        break;
                    case 2:// por nombre

                        filtro = a => a.Nombre.Contains(Criterio_textBox.Text);
                        break;

                    ///FECHA          
                    case 3:
                        filtro = a => a.Fecha >= Desde_dateTimePicker.Value.Date && a.Fecha <= Hasta_dateTimePicker.Value.Date;

                        break;

                }
                Consulta_dataGridView.DataSource = VendedorBLL.GetList(filtro);
            }

            private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
            {

            }

            private void Criterio_textBox_TextChanged(object sender, EventArgs e)
            {
                // Solonumero(e);
            }



            private void ExamenCosultas_Load(object sender, EventArgs e)
            {

            }

       
    }
    }
