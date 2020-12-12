using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{
    class VehiculoNuevo: Vehiculo
    {
        /////////////////////////// ATRIBUTOS ///////////////////////////
        private List<Extra> extrasAñadidos;


        /////////////////////////// CONSTRUCTOR ///////////////////////////
        public VehiculoNuevo(String numBastidor, int potencia, string modelo, string marca, double pvRecomendado): base(numBastidor, potencia, modelo, marca, pvRecomendado)
        {
            this.extrasAñadidos = new List<Extra>();
        }


        /////////////////////////// PROPIEDADES ///////////////////////////
        


        /////////////////////////// METODOS ///////////////////////////
        public void anadirExtra(Extra e)
        {
            if(!this.extrasAñadidos.Contains(e))
            {
                this.extrasAñadidos.Add(e);
            }
        }
        public void eliminarExtra(Extra e)
        {
            if (this.extrasAñadidos.Contains(e))
            {
                this.extrasAñadidos.Remove(e);
            }
        }
        public List<String> listaExtrasAñadidos()
        {
            List<String> extras = new List<string>();
            foreach (Extra e in this.extrasAñadidos)
            {
                extras.Add(e.ToString());
            }
            return extras;
        }

        public override string ToString()
        {
            

            return "- Vehiculo nuevo: [Vehiculo: " + base.ToString() + "], [Lista de extras: " + this.listaExtrasAñadidos().ToString() + "]";
        }
    }
}
