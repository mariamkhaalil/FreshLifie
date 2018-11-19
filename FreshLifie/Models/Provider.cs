using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshLifie.Models
{
    public class Provider
    {
        public int ProviderID { get; set; }
        public string ProviderName { get; set; }
        public string ProviderURL { get; set; }
        // Foreign Key of Service Type Model
        public int ServiceID { get; set; }

    }
}
