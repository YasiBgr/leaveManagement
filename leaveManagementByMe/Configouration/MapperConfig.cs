using AutoMapper;
using leaveManagementByMe.Data;
using leaveManagementByMe.Models;

namespace leaveManagementByMe.Configouration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType,LeaveTypeVM>().ReverseMap();
        }
    }
}
