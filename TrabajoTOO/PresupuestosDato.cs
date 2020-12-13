using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class PresupuestosDato
    {
        String id;
        String cliente;
        DateTime fechaRealizacion;
        String estado;

        public string Id
        {
            get { return this.id; }
        }
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
            get { return this.estado; }
        }

        public PresupuestosDato(String id, String cliente, DateTime fecha, String estado)
        {
            this.id= id;
            this.cliente = cliente;
            this.fechaRealizacion = fecha;
            this.estado = estado;
        }
    }
}
