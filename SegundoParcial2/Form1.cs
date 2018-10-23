using SegundoParcial2.UI.Consultas;
using SegundoParcial2.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SegundoParcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Registro_Click_1(object sender, EventArgs e)
        {
            ExamenRegistro r = new ExamenRegistro();
            r.ShowDialog();
            // this.MdiParent.Show(r);
        }

        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExamenConsutas ec = new ExamenConsutas();
            ec.ShowDialog();
        }
    }
}
