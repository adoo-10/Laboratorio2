using Laboratorio2.Data;
using Laboratorio2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2.Repository
{
    class ClsRPersona : IPersona
    {
        public void Guardar(persona per)
        {
            using (almacendepersonasEntities conexiónBd = new almacendepersonasEntities())
            {
                try
                {
                    persona pers = new persona();
                    pers.nombrePersona = per.nombrePersona;
                    pers.descripcionPersona = per.descripcionPersona;
                    pers.edadPersona = per.edadPersona;

                    conexiónBd.persona.Add(pers);
                    conexiónBd.SaveChanges();
                    MessageBox.Show("Save");
                    
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos" + ex);
                }


            }

       
        
            
        }
    

        public List<persona> listardatos()
        {
            using (almacendepersonasEntities conexiónBd = new almacendepersonasEntities())
            {
                List<persona> ListaDatos = conexiónBd.persona.ToList();

                return ListaDatos;

            }
        }
}   }
