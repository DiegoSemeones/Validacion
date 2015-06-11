using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itblugares))]
    public partial class tblugares
    {
        void ss()
        {

        }
    }
    public interface itblugares
    {
        [Display(Name = "El idlugar")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(8, 12, ErrorMessage = "Intentelo de nuevo")]
        //[key]
        [ScaffoldColumn(false)]
        object idlugar { get; set; }

        [Display(Name = "El titulo")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(20, ErrorMessage = "No maximo de veinte caracteres")]
        [StringLength(20)]
        object titulo { get; set; }

        [Display(Name = "La direccion del lugar")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(100, ErrorMessage = "No maximo de cien caracteres")]
        [StringLength(100)]
        object direccion { get; set; }

        [Display(Name = "La descripcion del lugar")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(100, ErrorMessage = "No maximo de cien caracteres")]
        [StringLength(100)]
        object descripcion { get; set; }

        [Display(Name = "web")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(100, ErrorMessage = "No maximo de cien caracteres")]
        [StringLength(100)]
        object web { get; set; }

        [Display(Name = "La imagen")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(8, 12, ErrorMessage = "Intentelo de nuevo")]
        object imagen { get; set; }

        [Display(Name = "Tu email")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(100, ErrorMessage = "No maximo de cien caracteres")]
        [StringLength(100)]
        object email { get; set; }

        [Display(Name = "El Lat")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(8, 12, ErrorMessage = "Intentelo de nuevo")]
        object lat { get; set; }

        [Display(Name = "El longg")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(10, ErrorMessage = "No maximo de diez caracteres")]
        [StringLength(10)]
        object longg { get; set; }

        [Display(Name = "La fecha de creacion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(10, ErrorMessage = "No maximo de diez caracteres")]
        [StringLength(10)]
        object fechacreacion { get; set; }

        [Display(Name = "La fecha de modificacion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(10, ErrorMessage = "No maximo de diez caracteres")]
        [StringLength(10)]
        object fechamodificacion { get; set; }

        [Display(Name = "El estado")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(1, 10, ErrorMessage = "No maximo de de 10 caracteres")]
        [StringLength(10)]
        object estado { get; set; }
    }
}