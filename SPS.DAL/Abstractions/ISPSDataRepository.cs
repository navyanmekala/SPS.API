using SPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS.DAL.Abstractions
{
    public interface ISPSDataRepository
    {
        Task<List<Roles>> GetRoles();
    }
}
