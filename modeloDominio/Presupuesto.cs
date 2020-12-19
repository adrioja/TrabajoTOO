using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class Presupuesto:IEquatable<Presupuesto>
    {
        /////////////////////////// ATRIBUTOS ///////////////////////////
        private String id;
        private Cliente clienteAsociado;
        private DateTime fechaRealizacion;
        private string estado;
        private List<Vehiculo> vehiculos;
        private Vehiculo vehiculoComprado;


        /////////////////////////// CONSTRUCTOR ///////////////////////////
        public Presupuesto(String id, Cliente cliente,DateTime fechaRealizacion, string estado, List<Vehiculo> vehiculos, Vehiculo vehiculoComprado)
        {
            this.id = id;
            this.clienteAsociado=cliente;
            this.fechaRealizacion = fechaRealizacion;
            this.estado = estado;
            this.vehiculos = vehiculos;
            this.vehiculoComprado = vehiculoComprado;
        }

        public Presupuesto(String id)
        {
            this.id = id;
            //valores que inciamos por defecto
            this.clienteAsociado = null;
            this.fechaRealizacion = DateTime.Now;
            this.estado = "";
            this.vehiculos = null;
            this.vehiculoComprado = null;

        }


        /////////////////////////// PROPIEDADES ///////////////////////////

        public String Id
        {
            get 
            {
                return this.id;
            }
        }
        public Cliente ClienteAsociado
        {
            get
            {
                return this.clienteAsociado;
            }
        }
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

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
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
            return (other.id.Equals(this.id));
        }

        public override string ToString()
        {
            return "- Presupuesto: [Numero de referencia: " + this.Id +" ], [Fecha realización: " + this.FechaRealizacion.ToString() + "], [Estado: " + this.Estado + "], [Vehiculo comprado: " + this.VehiculoComprado.ToString() +"]";
        }
    }
}
