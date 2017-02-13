using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FisherInsurance.Models
{
    public class Claims
    {
        
            public int Id { get; set; }
            public string PolicyType { get; set; }
            public DateTime LossDate { get; set; }
            public decimal LossAMount { get; set; }
        }
    }

