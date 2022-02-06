using Entities.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Column("USR_CPF")]
        [MaxLength(50)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }


        [Column("USR_AGE")]
        [Display(Name = "Age")]
        public int Idade { get; set; }


        [Column("USR_NAME")]
        [MaxLength(255)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        

        [Column("USR_CEP")]
        [MaxLength(15)]
        [Display(Name = "CEP")]
        public string CEP { get; set; }


        [Column("USR_ADDRESS")]
        [MaxLength(255)]
        [Display(Name = "Address")]
        public string Address { get; set; }


        [Column("USR_ADDRESS_COMPLEMENT")]
        [MaxLength(450)]
        [Display(Name = "Address Complement")]
        public string AddressComplement { get; set; }


        [Column("USR_CELL")]
        [MaxLength(20)]
        [Display(Name = "Cell")]
        public string Cell { get; set; }


        [Column("USR_PHONE")]
        [MaxLength(20)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }


        [Column("USR_STATE")]
        [MaxLength(20)]
        [Display(Name = "State")]
        public string State { get; set; }


        [Column("USR_TYPE")]
        [Display(Name = "Type")]
        public UserType Type { get; set; }
    }
}
