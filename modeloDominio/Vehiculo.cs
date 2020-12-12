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
        public Vehiculo(String numBastidor, int potencia, string modelo, string marca, double pvRecomendado)
        {
            this.numBastidor = numBastidor;
            this.potencia = potencia;
            this.modelo = modelo;
            this.marca = marca;
            this.pvRecomendado = pvRecomendado;
        }


        /////////////////////////// PROPIEDADES ///////////////////////////
        public string NumBastidor
        {
            get
            {
                return this.numBastidor;
            }
        }

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

        public string Modelo
        {
            get
            {
                return this.modelo;
            }
        }

        public string Marca
        {
            get
            {
                return this.marca;
            }
        }

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

        public double IVA
        {
            get
            {
                //Terminar
            }
        }

        public double PVP
        {
            get
            {
                //Terminar
            }
        }


        /////////////////////////// METODOS ///////////////////////////
        public bool Equals(Vehiculo other)
        {
            return this.NumBastidor == other.NumBastidor;
        }

        public override string ToString()
        {
            return "- Vehiculo: [Nº Bastidor: " + this.NumBastidor + "], [Potencia: " + this.Potencia + "], [Modelo: " + this.Modelo + "], [Marca: " + this.Marca + "], [Precio de venta recomendado: "+this.PvRecomendado+"], [PVP: "+this.PVP+"], [IVA: "+this.IVA+"]";
        }
    }
}
