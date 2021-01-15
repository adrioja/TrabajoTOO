using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeloDominio
{

    /// <summary>
    /// Clase que sirve para representar un vehiculo nuevo del concesionario
    /// </summary>
    public class VehiculoNuevo: Vehiculo
    {
        /////////////////////////// ATRIBUTOS ///////////////////////////
        private List<Extra> extrasAñadidos;


        /////////////////////////// CONSTRUCTOR ///////////////////////////
        
        /// <summary>
        /// Inicializa la clase por completo y llama al constructor de la clase padre
        /// </summary>
        /// <param name="numBastidor"></param>
        /// <param name="potencia"></param>
        /// <param name="modelo"></param>
        /// <param name="marca"></param>
        /// <param name="pvRecomendado"></param>
        public VehiculoNuevo(String numBastidor, int potencia, string modelo, string marca, double pvRecomendado): base(numBastidor, potencia, modelo, marca, pvRecomendado)
        {
            this.extrasAñadidos = new List<Extra>();
        }


        /// <summary>
        /// Inicializa la clase y llama al constructor de la clase padre
        /// </summary>
        /// <param name="numBastidor"></param>
        public VehiculoNuevo(String numBastidor) : base(numBastidor)
        {
            this.extrasAñadidos = new List<Extra>();
        }


        /////////////////////////// PROPIEDADES ///////////////////////////

        /// <summary>
        /// PRE: la clase debe de estar incializada por completo(no solo el campo numero de bastidor)
        /// POST: devuelve el pvp del vehiculo
        /// </summary>
        public override double PVP
        {           
            get
            {
                double extras = 0;
                foreach(Extra e in this.extrasAñadidos)
                {
                    extras += e.PrecioFijo;
                }
                return base.PVP + extras*IVA;
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST:devuelve la lista con los extras que tiene añadido ese coche
        /// </summary>
        public List<Extra> Extras
        {
            get
            {
                return this.extrasAñadidos;
            }
        }

        /////////////////////////// METODOS ///////////////////////////
        
        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: si el vehiculo no tiene ya añadido ese extra lo añade, sino no hace nada
        /// </summary>
        /// <param name="e"></param>
        public void anadirExtra(Extra e)
        {
            if(!this.extrasAñadidos.Contains(e))
            {
                this.extrasAñadidos.Add(e);
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: comprueba que el coche contiene ese extra y si es asi lo elimina, sino no hace nada
        /// </summary>
        /// <param name="e"></param>
        public void eliminarExtra(Extra e)
        {
            if (this.extrasAñadidos.Contains(e))
            {
                this.extrasAñadidos.Remove(e);
            }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve una lista con los extras del coche
        /// </summary>
        /// <returns></returns>
        private List<String> listaExtrasAñadidos()
        {
            List<String> extras = new List<string>();
            foreach (Extra e in this.extrasAñadidos)
            {
                extras.Add(e.ToString());
            }
            return extras;
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST:devuelve una cadena con los datos del vehiculo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "- Vehiculo nuevo: [" + base.ToString() + "]";
        }
    }
}
