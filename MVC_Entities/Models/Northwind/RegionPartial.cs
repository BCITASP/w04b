using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Entities.Models.Northwind
{
    [MetadataType(typeof(RegionAttributes))]
    public partial class Region
    {

    }

    public class RegionAttributes
    {

        public int RegionID { get; set; }
        [Required]
        [Display(Name = "Rgn Desc")]
        [MaxLength(10, ErrorMessage = "Length must not exceed {1}")]
        public string RegionDescription { get; set; }
    }
}