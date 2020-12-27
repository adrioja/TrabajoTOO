using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    public class VehiculoSegundaMano: Vehiculo
    {
        /////////////////////////// ATRIBUTOS ///////////////////////////
        private string matricula;
        private DateTime fechaMatriculacion;


        /////////////////////////// CONSTRUCTOR ///////////////////////////
        
        /// <summary>
        /// Incializa la clase por completo y llama al constructor de la clase padre
        /// </summary>
        /// <param name="numBastidor"></param>
        /// <param name="potencia"></param>
        /// <param name="modelo"></param>
        /// <param name="marca"></param>
        /// <param name="pvRecomendado"></param>
        /// <param name="matricula"></param>
        /// <param name="fechaMatriculacion"></param>
        public VehiculoSegundaMano(String numBastidor, int potencia, string modelo, string marca, double pvRecomendado, string matricula, DateTime fechaMatriculacion) : base(numBastidor, potencia, modelo, marca, pvRecomendado)
        {
            this.matricula = matricula;
            this.fechaMatriculacion = fechaMatriculacion;
        }

        /// <summary>
        /// Incializa la clase (solo el atributo numero de bastidor) y llama al constructor de la clase padre
        /// </summary>
        /// <param name="numBastidor"></param>
        public VehiculoSegundaMano(String numBastidor) : base(numBastidor)
        {
            
        }


        /////////////////////////// PROPIEDADES ///////////////////////////
        
        /// <summary>
        /// PRE: la clase debe de estar inicializada
        /// POST: devuelve la matricula
        /// </summary>
        public string Matricula
        {
            get
            {
                return this.matricula;
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar inicializada
        /// POST: devuelve la fecha de matriculacion
        /// </summary>
        public DateTime FechaMatriculacion
        {
            get
            {
                return this.fechaMatriculacion;
            }
            
        }

        /// <summary>
        /// PRE: la clase debe de estar inicializada
        /// POST: devuelve el pvp
        /// </summary>
        public override double PVP
        {
            get
            {
                return base.PVP;
            }
        }


        /////////////////////////// METODOS ///////////////////////////  

        /// <summary>
        /// PRE:la clase debe de estar inicializada
        /// POST:POST: devuelve una cadena con los datos del vehiculo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "- Vehiculo de segunda mano: [" + base.ToString() + "], [Matricula: " + this.Matricula+ "], [Fecha de matriculacion: "+this.FechaMatriculacion.ToString()+"]";
        }
    }
}
