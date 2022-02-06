using Entities.Entities.Enums;
using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("TB_USER_BUY")]
    public class UserBuy : Notifies
    {
        [Column("CUS_ID")]
        [Display(Name = "Code")]
        public int Id { get; set; }

        [Display(Name = "Product")]
        [ForeignKey("Product")]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Column("CUS_STATE")]
        [Display(Name = "State")]
        public BuyState State { get; set; }

        [Column("CUS_QUANTITY")]
        [Display(Name = "Quantity")]
        public int BuyQty { get; set; }

        [Display(Name = "User")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
