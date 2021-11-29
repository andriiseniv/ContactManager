using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSVReader.Models
{
    public class CSVModel
    {
        [Key]
        public int CSVID { get; set; }

        [Column(TypeName = "nvarchar(35)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "datetime")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "bit")]
        [Required]
        public bool Married { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0-9]{12})$", ErrorMessage = "Not a valid phone number (12 digits)")]
        public string Phone { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 100000)]
        [Required]
        public double Salary { get; set; }
    }

}
