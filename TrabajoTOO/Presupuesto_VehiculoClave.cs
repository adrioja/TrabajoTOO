using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    class Presupuesto_VehiculoClave
    {
        String cliente;
        DateTime fechaRealizacion;
        String vehiculo;

        public string Cliente
        {
            get { return this.cliente; }
        }

        public DateTime FechaRealizacion
        {
            get { return this.fechaRealizacion; }
        }

        public String Vehiculo
        {
            get { return this.vehiculo; }
        }
        public Presupuesto_VehiculoClave(String cliente, DateTime fecha, String vehiculo)
        {
            this.cliente = cliente;
            this.fechaRealizacion = fecha;
            this.vehiculo = vehiculo;
        }
    }
}
