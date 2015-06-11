using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itbpersona))]
    public partial class tbusuario{
        void ss()
        {

        }
    }
    /*
    public Nullable<decimal> gid { get; set; }
    public string gemail { get; set; }
    public System.DateTime creado { get; set; }
    public System.DateTime fechacreacion { get; set; }
    public System.DateTime fechamodificacion { get; set; }
    public Nullable<int> estado { get; set; }*/

    public interface itbusuario
    {
        [Display(Name="Tu login")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(20, ErrorMessage="No maximo de veinte caracteres")]
        [StringLength(20)]
        object login { get; set; }

        [Display(Name="Tu passwork")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(20, ErrorMessage="No maximo de veinte caracteres")]
        [StringLength(20)]
        object pass { get; set; }

        [Display(Name="Tu id")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(6, 10, ErrorMessage = "No maximo de de 10 caracteres")]
        [StringLength(10)]
        object fid { get; set; }

        [Display(Name="Tu email")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(50, ErrorMessage="No maximo de cincuenta caracteres")]
        [StringLength(50)]
        object femail { get; set; }

        [Display(Name="Tu fullnombre")]//nombre de los labels
        [DataType(DataType.Text,ErrorMessage="Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(20, ErrorMessage="No maximo de veinte caracteres")]
        [StringLength(20)]
        object fullname { get; set; }

        [Display(Name = "Tu gid")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(6, 10, ErrorMessage = "No maximo de de 10 caracteres")]
        [StringLength(10)]
        object gid { get; set; }

        [Display(Name = "Tu gemail")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(50, ErrorMessage = "No maximo de cincuenta caracteres")]
        [StringLength(50)]
        object gemail { get; set; }

        [Display(Name = "Tu creacion")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(10, ErrorMessage = "No maximo de diez caracteres")]
        [StringLength(10)]
        object creado { get; set; }

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