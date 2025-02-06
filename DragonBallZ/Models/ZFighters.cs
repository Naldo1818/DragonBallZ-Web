using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DragonBallZ.Models
{
    public class ZFighters
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9\\s]*$", ErrorMessage = "Please Don't Enter Any Special Character")]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9\\s]*$", ErrorMessage = "Please Don't Enter Any Special Character")]
        public string Race { get; set; }

        [Required]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Please Only Enter Numbers")]
        public int Age { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9\\s]*$", ErrorMessage = "Please Don't Enter Any Special Character")]
        public string Abilities { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z]+[a-zA-Z\\s]*$", ErrorMessage = "Please Only Enter Text")]
        public string Weakness { get; set; }


    }
}
