using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public abstract class Vehiculo:IEquatable<Vehiculo> 
    {

        /////////////////////////// ATRIBUTOS ///////////////////////////
        private string numBastidor;
        private int potencia;
        private string modelo;
        private string marca;
        private double pvRecomendado;


        /////////////////////////// CONSTRUCTOR ///////////////////////////
        
        /// <summary>
        /// Inicializa la clase por completo
        /// </summary>
        /// <param name="numBastidor"></param>
        /// <param name="potencia"></param>
        /// <param name="modelo"></param>
        /// <param name="marca"></param>
        /// <param name="pvRecomendado"></param>
        public Vehiculo(String numBastidor, int potencia, string modelo, string marca, double pvRecomendado)
        {
            this.numBastidor = numBastidor;
            this.potencia = potencia;
            this.modelo = modelo;
            this.marca = marca;
            this.pvRecomendado = pvRecomendado;
        }


        /// <summary>
        /// Inicializa la clase, solo el atributo numBastidor
        /// </summary>
        /// <param name="numBastidor"></param>
        public Vehiculo(String numBastidor)
        {
            this.numBastidor = numBastidor;
            //valores que inciamos por defecto
            this.potencia = 0;
            this.modelo = "";
            this.marca = "";
            this.pvRecomendado = 0;
        }


        /////////////////////////// PROPIEDADES ///////////////////////////

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve el numero de bastidor
        /// </summary>
        public string NumBastidor
        {
            get
            {
                return this.numBastidor;
            }
        }

        /// <summary>
        /// PRE:la clase debe de estar incializada
        /// POST: devuelve o asigna la potencia
        /// </summary>
        public int Potencia
        {
            get
            {
                return this.potencia;
            }
            set
            {
                this.potencia = value;
            }
        }


        /// <summary>
        /// PRE:la clase debe de estar incializada
        /// POST: devuelve el modelo
        /// </summary>
        public string Modelo
        {
            get
            {
                return this.modelo;
            }
        }

        /// <summary>
        /// PRE:la clase debe de estar incializada
        /// POST:devuelve la marca
        /// </summary>
        public string Marca
        {
            get
            {
                return this.marca;
            }
        }


        /// <summary>
        /// PRE:la clase debe de estar incializada
        /// POST:devuleve o asigna el precio recomendado
        /// </summary>
        public double PvRecomendado
        {
            get
            {
                return this.pvRecomendado;
            }
            set
            {
                this.pvRecomendado = value;
            }
        }


        /// <summary>
        /// PRE:la clase debe de estar incializada
        /// POST: devuelve el IVA correspondiente en funcion del tipo de vehiculo
        /// </summary>
        public double IVA
        {
            get
            {
                if (this is VehiculoNuevo)
                {
                    return 0.1;
                }
                else
                {
                    return 0.21;
                }
            }
        }


        /// <summary>
        /// PRE:la clase debe de estar incializada
        /// POST: devuelve el pvp de dicho vehiculo
        /// </summary>
        public virtual double PVP
        {
            get
            {
                return (this.PvRecomendado*(1+IVA));
            }
        }


        /////////////////////////// METODOS ///////////////////////////
        
        /// <summary>
        /// PRE: la clase y el parametro deben de estar inicializadas
        /// POST: devuelve true si ambos vehiculos tienen el mismo numero de bastidor y falso en caso contrario
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Vehiculo other)
        {
            return this.NumBastidor == other.NumBastidor;
        }

        /// <summary>
        /// PRE:la clase debe de estar inicializada
        /// POST:POST: devuelve una cadena con los datos del vehiculo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[Nº Bastidor: " + this.NumBastidor + "], [Potencia: " + this.Potencia + "], [Modelo: " + this.Modelo + "], [Marca: " + this.Marca + "], [Precio de venta : "+this.PVP+"]";
        }
    }
}
