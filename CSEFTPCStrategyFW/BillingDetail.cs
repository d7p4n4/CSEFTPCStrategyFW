using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEFTPCStrategyFW
{
    public abstract class BillingDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillingDetailId { get; set; }
        public string Owner { get; set; }
        public string Number { get; set; }
    }
}
