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

        public string NumBastidor 
        {
            get
            {
                return this.numBastidor;
            }
        }
        public string Marca
        {
            get
            {
                return this.marca;
            }
        }
        public string Modelo 
        {
            get
            {
                return this.modelo;
            }
        }
        public int Potencia 
        {
            get
            {
                return this.potencia;
            }
        }
        public double PvRecomendado 
        {
            get
            {
                return this.pvRecomendado;
            }
        }

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
