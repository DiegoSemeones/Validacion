using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itbgaleria))]
    public partial class tbgaleria
    {
        void ss()
        {

        }
    }
    public interface itbgaleria
    {
        [Display(Name = "El idimagen")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(8, 12, ErrorMessage = "Intentelo de nuevo")]
        //[key]
        [ScaffoldColumn(false)]
        object idimagen { get; set; }

        [Display(Name = "Nombre de la galeria")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(20, ErrorMessage = "No maximo de veinte caracteres")]
        [StringLength(20)]
        object nombre { get; set; }

        [Display(Name = "descripcion de la galeria")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(20, ErrorMessage = "No maximo de veinte caracteres")]
        [StringLength(20)]
        object descripcion { get; set; }

        [Display(Name = "El idlugares")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(8, 12, ErrorMessage = "Intentelo de nuevo")]
        [ScaffoldColumn(false)]
        object idlugares { get; set; }

        [Display(Name = "Tu fecha de creacion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(10, ErrorMessage = "No maximo de diez caracteres")]
        [StringLength(10)]
        object fechacreacion { get; set; }

        [Display(Name = "Tu fecha de modificacion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(10, ErrorMessage = "No maximo de diez caracteres")]
        [StringLength(10)]
        object fechamodificacion { get; set; }

        [Display(Name = "Tu estado")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(1, 10, ErrorMessage = "No maximo de de 10 caracteres")]
        [StringLength(10)]
        object estado { get; set; }
    }
}