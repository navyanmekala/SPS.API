using SPS.Business.Abstractions;
using SPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPS.DAL.Abstractions;

namespace SPS.Business.Implementations
{
    public class SPSDataService : ISPSDataService
    {
        private readonly ISPSDataRepository _idataRepo;

        public SPSDataService (ISPSDataRepository idataRepo)
        {
            _idataRepo = idataRepo;
        }
        public async Task<List<Roles>> GetRoles()
        {
            return await _idataRepo.GetRoles();
        }
    } 
}
