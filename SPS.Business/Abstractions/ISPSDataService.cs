using SPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS.Business.Abstractions
{
    public interface ISPSDataService
    {
        Task<List<Roles>> GetRoles();
    }
}
