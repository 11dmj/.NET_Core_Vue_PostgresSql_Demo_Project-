using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreVuePostgreSQL.Data.Models
{
    public class EmployeeModel
    {
        [Key]
        [Required]
        public int EmployeeId { get; set; }

        [Column(TypeName = "character varying(500)")]
        [MaxLength(500)]
        public string Token { get; set; }

        [Required]
        [Column(TypeName = "character varying(20)")]
        [MaxLength(20)]
        public string FirstName { get; set; }

        
        [Column(TypeName = "character varying(20)")]
        [MaxLength(20)]
        public string MiddleName { get; set; }

        [Required]
        [Column(TypeName = "character varying(20)")]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "character varying(50)")]
        [MaxLength(50)]
        public string Password { get; set; }
    }
}
