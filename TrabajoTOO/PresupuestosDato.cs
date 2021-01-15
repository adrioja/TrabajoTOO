using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoTOO
{
    /// <summary>
    /// Representa la forma que tienen los datos de la tabla Presupuesto en el sistema de persistencia
    /// </summary>
    public class PresupuestosDato : Entity<String>
    {
        String id;
        String cliente;
        DateTime fechaRealizacion;
        String estado;
        String vehiculoComprado;

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve el id del presupuesto
        /// </summary>
        public string Id
        {
            get { return this.id; }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve el cliente DNI del cliente asociado a dicho presupuesto
        /// </summary>
        public string Cliente
        {
            get { return this.cliente; }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devuelve la fecha en que se realizo dicho presupuesto
        /// </summary>
        public DateTime FechaRealizacion
        {
            get { return this.fechaRealizacion; }
        }

        /// <summary>
        /// PRE: la clase debe de estar incializada
        /// POST: devulve el estado del presupuesto
        /// </summary>
        public String Estado
        {
            get { return this.estado; }
        }


        public String VehiculoComprado
        {
            get { return this.vehiculoComprado; }
        }

        /// <summary>
        /// Inicializa la clase
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cliente"></param>
        /// <param name="fecha"></param>
        /// <param name="estado"></param>
        /// <param name="vehiculoComprado"></param>
        public PresupuestosDato(String id, String cliente, DateTime fecha, String estado, String vehiculoComprado):base(id)
        {
            this.id= id;
            this.cliente = cliente;
            this.fechaRealizacion = fecha;
            this.estado = estado;
            this.vehiculoComprado = vehiculoComprado;
        }
    }
}
