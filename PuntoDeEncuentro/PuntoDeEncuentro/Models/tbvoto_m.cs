using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itbvoto))]
    public partial class tbvoto
    {
        void ss()
        {

        }
    }
    public interface itbvoto
    {
        [Display(Name = "El id")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(8, 12, ErrorMessage = "Intentelo de nuevo")]
        //[key]
        [ScaffoldColumn(false)]
        object id { get; set; }

        [Display(Name = "El titulo")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(10, ErrorMessage = "No maximo de diez caracteres")]
        [StringLength(10)]
        object titulo { get; set; }

        [Display(Name = "El total_votes")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(1, 1000, ErrorMessage = "Intentelo de nuevo")]
        object total_votes { get; set; }

        [Display(Name = "El total_value")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(1, 1000, ErrorMessage = "Intentelo de nuevo")]
        object total_value { get; set; }

        [Display(Name = "El used_ips")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(10, ErrorMessage = "No maximo de diez caracteres")]
        [StringLength(10)]
        object used_ips { get; set; }

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