using Laboratorio2.Data;
using Laboratorio2.Negocio;
using Laboratorio2.Vista;
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
    public partial class FrmGuardarInformacion : Form
    {
        public FrmGuardarInformacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona person = new persona();
            person.nombrePersona = TxtNombre.Text;
            person.edadPersona = Convert.ToInt32(TxtEdad.Text);
            person.descripcionPersona = TxtDescripcion.Text;
            ClsPersona clsPersona = new ClsPersona();
            clsPersona.Crear(person);
        }

        private void FrmGuardarInformacion_Load(object sender, EventArgs e)
        {
            ClsPersona persona = new ClsPersona();
        }

        private void TxtMostrar_Click(object sender, EventArgs e)
        {
            FrmMostrarInformacion formulario = new FrmMostrarInformacion();
            formulario.Show();
        }
    }
}
