using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Transfer
    {
        public int FromAccountId { get; set; }
        public int ToAccountId { get; set; }
        [Range(0.00,200.00)]
        public double Amount { get; set; }
        public string Description { get; set; }
    }
}
