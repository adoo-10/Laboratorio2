using Laboratorio2.Data;
using Laboratorio2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio2.Negocio
{
    class ClsPersona: ClsRPersona
    {
        public void  Crear(persona pe)
        {
            if (pe.edadPersona >= 18)
                
            {
                Guardar(pe);
            }
            else
            {
                MessageBox.Show("No se pueden guardar tus datos porque eres menor de edad");

            }
        }
        public List<persona> Listafinal()
        {
            List<persona> list = listardatos();
            return list;
        }

    }
}
