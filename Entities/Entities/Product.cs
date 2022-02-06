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

        [Column("PRD_NAME")]
        [Display(Name = "Name")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Column("PRD_DESCRIPTION")]
        [Display(Name = "Description")]
        [MaxLength(150)]
        public string Description { get; set; }

        [Column("PRD_OBSERVATION")]
        [Display(Name = "Observation")]
        [MaxLength(20000)]
        public string Observation { get; set; }

        [Column("PRD_VALUE")]
        [Display(Name = "Value")]
        public decimal Value { get; set; }

        [Column("PRD_QTY_STOCK")]
        [Display(Name = "Stock Quantity")]
        public int StockQty { get; set; }

        [Display(Name = "User")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Column("PRD_STATE")]
        [Display(Name = "State")]
        public bool State { get; set; }

        [Column("PRD_SIGNUP_DATE")]
        [Display(Name = "Signup Date")]
        public DateTime SignupDate { get; set; }

        [Column("PRD_CHANGE_DATE")]
        [Display(Name = "Change Date")]
        public DateTime ChangeDate { get; set; }
    }
}
