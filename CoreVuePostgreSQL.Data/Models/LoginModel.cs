using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreVuePostgreSQL.Data.Models
{
    public class LoginModel
    {
        [Key]
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        [Column(TypeName = "character varying(50)")]
        [MaxLength(50)]
        public string Password { get; set; }
    }
}
