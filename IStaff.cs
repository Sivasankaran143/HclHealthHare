
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Construction
{
    public interface IStaff
    {
        Task<ResponseCls> GetStaffDetails();
        Task<ResponseCls> AddStaffDetails(Staff staffInfo);
    }
}
