﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itbvotousuario))]
    public partial class tbvotousuario
    {
        void ss()
        {

        }
    }
    public interface itbvotousuario
    {
        [Display(Name = "El idvotousuario")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(8, 12, ErrorMessage = "Intentelo de nuevo")]
        //[key]
        [ScaffoldColumn(false)]
        object idvotousuario { get; set; }

        [Display(Name = "El idlugar")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [Range(8, 12, ErrorMessage = "Intentelo de nuevo")]
        //[key]
        [ScaffoldColumn(false)]
        object idlugar { get; set; }

        [Display(Name = "El iduser")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(10, ErrorMessage = "No maximo de diez caracteres")]
        [StringLength(10)]
        object iduser { get; set; }

        [Display(Name = "El scor")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Intentelo nuevamente!!!")]//tipo de
        [DisplayColumn("campo de nombre", "Nom.")]//nombre en la columna
        [Editable(false)]//no se puede editar
        [MaxLength(10, ErrorMessage = "No maximo de diez caracteres")]
        [StringLength(10)]
        object scor { get; set; }

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