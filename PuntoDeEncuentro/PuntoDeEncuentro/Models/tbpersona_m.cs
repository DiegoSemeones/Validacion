using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itbpersona))]
    public partial class tbpersona
    {
        void ss() { 
        
        }
    }
    public interface itbpersona
    {
        [Display(Name = "Tu id")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(8,12, ErrorMessage="Intentelo de nuevo")]
        //[key]
        [ScaffoldColumn(false)]
        object idpersona { get; set; }

        [Display(Name="Tu nombre")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(20, ErrorMessage="No maximo de veinte caracteres")]
        [StringLength(20)]
        object nombre { get; set; }

        [Display(Name = "Tu apellido paterno")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(20, ErrorMessage = "No maximo de veinte caracteres")]
        [StringLength(20)]
        object paterno { get; set; }

        [Display(Name = "Tu apellido materno")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(20, ErrorMessage = "No maximo de veinte caracteres")]
        [StringLength(20)]
        object materno { get; set; }

        [Display(Name = "Tu celula de identidad")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(6, 7, ErrorMessage = "No maximo de de 7 caracteres")]
        [StringLength(7)]
        object ci { get; set; }

        [Display(Name = "Tu fecha de nacimiento")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(8, ErrorMessage = "No maximo de ocho caracteres")]
        [StringLength(8)]
        object fechanac { get; set; }

        [Display(Name = "La fecha de creacion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(8, ErrorMessage = "No maximo de ocho caracteres")]
        [StringLength(8)]
        object fechacreacion { get; set; }

        [Display(Name = "La fecha de modificacion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(8, ErrorMessage = "No maximo de ocho caracteres")]
        [StringLength(8)]
        object fechamodificacion { get; set; }
        
        [Display(Name = "Tu estado")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de dato
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(2, ErrorMessage = "No maximo de ocho caracteres")]
        [StringLength(2)]
        object estado { get; set; }

        /*[Display(Name = "Tu estado")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de dato
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(2, ErrorMessage = "No maximo de ocho caracteres")]
        [StringLength(2)]
        object tbusuario { get; set; }*/
    }
}