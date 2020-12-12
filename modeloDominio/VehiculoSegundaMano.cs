using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    class VehiculoSegundaMano: Vehiculo
    {
        /////////////////////////// ATRIBUTOS ///////////////////////////
        private string matricula;
        private DateTime fechaMatriculacion;


        /////////////////////////// CONSTRUCTOR ///////////////////////////
        public VehiculoSegundaMano(String numBastidor, int potencia, string modelo, string marca, double pvRecomendado, string matricula, DateTime fechaMatriculacion) : base(numBastidor, potencia, modelo, marca, pvRecomendado)
        {
            this.matricula = matricula;
            this.fechaMatriculacion = fechaMatriculacion;
        }


        /////////////////////////// PROPIEDADES ///////////////////////////
        public string Matricula
        {
            get
            {
                return this.matricula;
            }
        }

        public DateTime FechaMatriculacion
        {
            get
            {
                return this.fechaMatriculacion;
            }
            
        }


        /////////////////////////// METODOS ///////////////////////////  
        public override string ToString()
        {
            return "- Vehiculo de segunda mano: [Vehiculo: " + base.ToString() + "], [Matricula: " + this.Matricula+ "], [Fecha de matriculacion: "+this.FechaMatriculacion.ToString()+"]";
        }
    }
}
