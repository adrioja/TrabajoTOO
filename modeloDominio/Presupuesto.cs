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
        private String vehiculoComprado;


        /////////////////////////// CONSTRUCTOR ///////////////////////////
        public Presupuesto(String id, Cliente cliente,DateTime fechaRealizacion, string estado, List<Vehiculo> vehiculos)
        {
            this.id = id;
            this.clienteAsociado=cliente;
            this.fechaRealizacion = fechaRealizacion;
            this.estado = estado;
            this.vehiculos = vehiculos;
            this.vehiculoComprado = " ";
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
        public String VehiculoComprado
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
