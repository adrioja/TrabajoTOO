using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrabajoTOO
{
   public class VehiculoDatos 
    {
        private String numBastidor;
        private String marca;
        private String modelo;
        private int potencia;
        private double pvRecomendado;

        /// <summary>
        /// PRE: la clase debe de de estar incializada
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
        /// PRE: la clase debe de de estar incializada
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
        /// PRE: la clase debe de de estar incializada
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
        /// PRE: la clase debe de de estar incializada
        /// POST:devuelve la potencia
        /// </summary>
        public int Potencia 
        {
            get
            {
                return this.potencia;
            }
        }

        /// <summary>
        /// PRE: la clase debe de de estar incializada
        /// POST:devuelve el pv recomendado
        /// </summary>
        public double PvRecomendado 
        {
            get
            {
                return this.pvRecomendado;
            }
        }

        /// <summary>
        /// Incializa la clase
        /// </summary>
        /// <param name="numBastidor"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="potencia"></param>
        /// <param name="pvRecomen"></param>
        public VehiculoDatos(String numBastidor, String marca, String modelo, int potencia, double pvRecomen)
        {
            this.numBastidor = numBastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.pvRecomendado = pvRecomen;
        }
    }
}
