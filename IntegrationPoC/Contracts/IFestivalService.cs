using IntegrationPoC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationPoC.Contracts
{
    public interface IFestivalService
    {
        IEnumerable<recordLabel> GetFestival();
    }
}
