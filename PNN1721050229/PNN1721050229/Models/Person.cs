using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PNN1721050229.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [StringLength(20)]
        public string PersonID { get; set; }
        [StringLength(50)]
        public string PersonName { get; set; }


    }
}