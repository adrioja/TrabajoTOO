using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    class Presupuesto:IEquatable<Presupuesto>
    {
        /////////////////////////// ATRIBUTOS ///////////////////////////
        private DateTime fechaRealizacion;
        private string estado;
        private Vehiculo vehiculoComprado;


        /////////////////////////// CONSTRUCTOR ///////////////////////////
        public Presupuesto(DateTime fechaRealizacion, string estado, Vehiculo vehiculoComprado)
        {
            this.fechaRealizacion = fechaRealizacion;
            this.estado = estado;
            this.vehiculoComprado = vehiculoComprado;
        }


        /////////////////////////// PROPIEDADES ///////////////////////////
        public DateTime FechaRealizacion
        {
            get
            {
                return this.fechaRealizacion;
            }
        }

        public string Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public Vehiculo VehiculoComprado
        {
            get
            {
                return this.vehiculoComprado;
            }
            set
            {
                this.vehiculoComprado = value;
            }
        }


        /////////////////////////// METODOS ///////////////////////////
        public bool Equals(Presupuesto other)
        {
            //Terminar
        }

        public override string ToString()
        {
            return "- Presupuesto: [Fecha realización: " + this.FechaRealizacion.ToString() + "], [Estado: " + this.Estado + "], [Vehiculo comprado: " + this.VehiculoComprado.ToString() +"]";
        }
    }
}
