using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itbevento))]
    public partial class tbevento
    {
        public void prueba() {
            this.estado = 1*5;
        }
        public interface itbevento {
            [Required]//debe tener algo de informacion
            object estado { get; set; }
            [MinLength(2)]//debe tener por lo menos 2 caracteres
            object titulo { get; set; }
            [Key]//indicamos que es la llave de la tabla
            object idevento { get; set; }
        
        }
         
        /* TAREA */
        /*[MetadataType(typeof(tbpago))]
        public partial class pago
        {
            public class tbpago
            {
                [StringLength(50), Required]
                public object nombre { get; set; }
                [StringLength(15)]
                public object imagen { get; set; }
                //  public object NoSuchProperty { get; set; }
                [StringLength(50), Required]
                public object fechacreacion { get; set; }
                [StringLength(10), Required]
                public object fechamodificacion { get; set; }
            }
        }*/
    }
}