using Dapper;
using Entity;
using Infrastructure.Construction;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    
    public class StaffRepository:IStaff
    {
        private readonly IDbConnection _dbConnection;
        public StaffRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

       

        public async Task<ResponseCls> GetStaffDetails()
        {
            ResponseCls responseCls = new ResponseCls();
            try
            {
                var Sp_Name = "Select * From [dbo].[StaffList]";
                
                responseCls.ResponseData = await _dbConnection.QueryAsync(Sp_Name, null, null, null, CommandType.Text);
                responseCls.IsSuccess = true;
            }
            catch (Exception ex)
            {
                responseCls.IsSuccess = false;
                responseCls.StatusMessage = ex.Message;
            }
            return responseCls;
        }
        public async Task<ResponseCls> AddStaffDetails(Staff userInfo)
        {
            ResponseCls responseCls = new ResponseCls();
            try
            {
                var Sp_Name = "AddStaffDetails";
                var param = new
                {
                    UserInfo = JsonConvert.SerializeObject(userInfo)
                };
                responseCls.ResponseData = await _dbConnection.QueryAsync(Sp_Name, param, null, null, CommandType.StoredProcedure);
                responseCls.IsSuccess = true;
            }
            catch (Exception ex)
            {
                responseCls.StatusMessage = ex.Message;
            }
            return responseCls;
        }
    }
}
