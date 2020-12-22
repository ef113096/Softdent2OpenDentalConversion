using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Softdent2OpenDentalConversion.Models.Softdent
{
    public partial class ADACodes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal CodeNumeric { get; set; }
    }
}
