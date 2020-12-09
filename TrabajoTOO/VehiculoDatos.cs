using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrabajoTOO
{
    class VehiculoDatos 
    {
        private String numBastidor;
        private String marca;
        private String modelo;
        private int potencia;
        private double pvp;
        private double pvRecomendado;
        private double iva;

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
        public double Iva 
        {
            get
            {
                return this.iva;
            }
        }
    }
}
