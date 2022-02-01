using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("Product")]
    public class Product : Notifies
    {
        [Column("PRD_ID")]
        [Display(Name = "Code")]
        public int Id { get; set; }

        [Column("PRD_NOME")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Column("PRD_VALOR")]
        [Display(Name = "Value")]
        public decimal Value { get; set; }

        [Column("PRD_ESTADO")]
        [Display(Name = "State")]
        public bool State { get; set; }
    }
}
