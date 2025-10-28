using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ServiceStack.Text;
using SPS.DAL.Abstractions;
using SPS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPS.Utility;

namespace SPS.DAL.Implementations
{
    public class SPSDataRepository : ISPSDataRepository
    {   
        private readonly IConfiguration _config;

        public SPSDataRepository(IConfiguration config)
        { 
            _config = config;
        }


        public async Task<List<Roles>> GetRoles()
        {
            try
            {

                using (var conn = new SqlConnection(_config["DBConnectionStrings"].ToString()))
                {
                    await conn.OpenAsync();
                    var sqlcmd = new SqlCommand("Usp_GetRoles",conn);
                    sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlDataAdapter ad = new SqlDataAdapter(sqlcmd);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                  var lstRoles =  DataTransformations.ConvertDataTable<Roles>(ds.Tables[0]);
                    return lstRoles;

                }
            
            }
            catch(Exception e)
            {
                throw;
            }
           
        }
    }
}
