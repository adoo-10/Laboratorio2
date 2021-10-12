using Laboratorio2.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2.Vista
{
    public partial class FrmMostrarInformacion : Form
    {
        public FrmMostrarInformacion()
        {
            InitializeComponent();
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            ClsPersona persona = new ClsPersona();
            var a = persona.Listafinal();

            foreach (var iterar in a)
            {
                ListPersona.Rows.Add(iterar.nombrePersona, iterar.edadPersona, iterar.descripcionPersona);
            }
        }  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
