using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Softdent2OpenDentalConversion.Models.Softdent
{
    public partial class ExplosionCodes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int ID { get; set; }
        public decimal ExplosionCode { get; set; }
        public decimal ADACode { get; set; }
    }
}
