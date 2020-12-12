using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class PresupuestosDato
    {
        String cliente;
        DateTime fechaRealizacion;
        String estado;
        
        public string Cliente
        {
            get { return this.cliente; }
        }

        public DateTime FechaRealizacion
        {
            get { return this.fechaRealizacion; }
        }

        public String Estado
        {
            get { return this.estado;}
        }
    }
}
