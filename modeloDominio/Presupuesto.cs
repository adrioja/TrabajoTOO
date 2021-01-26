using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    /// <summary>
    /// Clase que sirve para representar un presupuesto
    /// </summary>
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
        /// <summary>
        /// Inicializa la clase por completo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cliente"></param>
        /// <param name="fechaRealizacion"></param>
        /// <param name="estado"></param>
        /// <param name="vehiculos"></param>
        /// <param name="vehiculoComprado"></param>
        public Presupuesto(String id, Cliente cliente,DateTime fechaRealizacion, string estado, List<Vehiculo> vehiculos, Vehiculo vehiculoComprado)
        {
            this.id = id;
            this.clienteAsociado=cliente;
            this.fechaRealizacion = fechaRealizacion;
            this.estado = estado;
            this.vehiculos = vehiculos;
            this.vehiculoComprado = vehiculoComprado;
        }

        /// <summary>
        /// Inicializa la clase (solo el id)
        /// </summary>
        /// <param name="id"></param>
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

        /// <summary>
        /// PRE: la clase debe de estar inicializada 
        /// POST: devuelve el id
        /// </summary>
        public String Id
        {
            get 
            {
                return this.id;
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar inicializada por completo
        /// POST: devuelve el cliente asociado
        /// </summary>
        public Cliente ClienteAsociado
        {
            get
            {
                return this.clienteAsociado;
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar inicializada por completo
        /// POST: devuelve la fecha en que se realizo
        /// </summary>
        public DateTime FechaRealizacion
        {
            get
            {
                return this.fechaRealizacion;
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar inicializada por completo
        /// POST: devuelve o asigna el estado
        /// </summary>
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

        /// <summary>
        /// PRE: la clase debe de estar inicializada por completo
        /// POST: devuelve la lista de los vehiculos a los que se les ha echo el presupuesto
        /// </summary>
        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar inicializada por completo
        /// POST: devuelve o asigna el vheiculo comprado
        /// </summary>
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
        /// <summary>
        /// PRE: la clase y el parametro deben de estar inicializadas
        /// POST: devuelve true si ambos presupuestos tienen el mismo id y falso en caso contrario
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Presupuesto other)
        {
            return (other.id.Equals(this.id));
        }

        /// <summary>
        /// PRE: la clase y el parametro deben de estar inicializadas(la clase por completo)
        /// POST: devuelve una cadeena con los datos del presupuesto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "- Presupuesto: [Numero de referencia: " + this.Id +" ], [Fecha realización: " + this.FechaRealizacion.ToString() + "], [Estado: " + this.Estado + "], [Vehiculo comprado: " + this.VehiculoComprado.ToString() +"]";
        }
    }
}
