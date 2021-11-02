using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationPoC.Model
{
    public class _band
    {
        public string name { get; set; }
        public List<_festival> festivals { get; set; }
    }
}
